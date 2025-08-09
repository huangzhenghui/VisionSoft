using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VisionCore;
using VisionCore.Properties;

namespace VisionCore
{
    /// <summary>
    /// 单元类型
    /// </summary>
    public enum UnitType
    {
        /// <summary>
        ///模块
        /// </summary>
        Mod,
        /// <summary>
        /// 模块文件夹
        /// </summary>
        Folder,
        /// <summary>
        /// 空白模块,占位用
        /// </summary>
        Empty

    }
    /// <summary>
    /// 鼠标当前区域
    /// </summary>
    public enum CheckArea
    {
        /// <summary>
        /// 空白区域
        /// </summary>
        Space,
        /// <summary>
        /// 模块图标
        /// </summary>
        Icon,
        /// <summary>
        /// 多选框
        /// </summary>
        MultiSelect,
        /// <summary>
        /// 注释
        /// </summary>
        Remarks
    }

    /// <summary>
    /// 流程的一个单元数据
    /// </summary>
    public class ModFlowItem : TreeNode
    {
        public int last_unitno;
        public Sol mSol;
        public ModInfo mModInfo { get; }
        private static Bitmap mFolderIconOpen;
        private static Bitmap mFolderIconClose;
        private static Dictionary<string, Icon> mImageIconDic;
        internal bool Click;
        internal bool mChecked;
        internal static bool dragList = false;
        internal static bool dragInNew = false;
        /// <summary>
        /// 是否模块可选择
        /// </summary>
        internal static bool mCheckLable = false;
        internal static int ControlWidth = 120;
        /// <summary>
        /// 拖拽目标位置的UnitNo
        /// </summary>
        internal static int mDragToUnitNo = -1;
        /// <summary>
        /// 拖拽目标位置的UnitNo
        /// </summary>
        internal static int mDragFromUnitNo = -1;
        internal static int FlowHeight = 0;
        /// <summary>
        /// 模块运行的时候 显示的点数
        /// </summary>
        private static int loadPointNum = 1;
        /// <summary>
        /// 注释的左上点
        /// </summary>
        public Point RemarksPoint { get; private set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Disabled
        {
            get
            {
                return !mModInfo.Enable;
            }
        }
        /// <summary>
        /// 获取模块图标
        /// </summary>
        /// <param name="ident"></param>
        public void GetModelIcon(string ident)
        {
            if (PluginToolService.mPluginDic.ContainsKey(ident))
            {
                Icon icon = PluginToolService.mPluginDic[ident].IconImage;
                if (icon != null)
                {
                    mImageIconDic.Add(ident, icon);
                }
            }
        }
        public ModFlowItem(ModInfo info, int index) : base(info.Name)
        {
            Top = -1;
            Left = -1;
            ModNo = index;
            mModInfo = info;
            if (Regex.IsMatch(info.Name, "文件夹[0-9]*$") || info.Name.StartsWith("如果") || info.Name.StartsWith("否则") || info.Name.StartsWith("循环开始"))
            {
                UnitType = UnitType.Folder;
            }
            else if (info.Plugin == "FolderEnd")
            {
                UnitType = UnitType.Empty;
            }
            else
            {
                UnitType = UnitType.Mod;
            }
            if (mImageIconDic == null)
            {
                /*MakeProcUnitList();*///这一句必须放在前面 不然会出现折叠的时候只显示 -  ,具体原因不明 magical 20181018 
                mImageIconDic = new Dictionary<string, Icon>();
            }
            if (!mImageIconDic.ContainsKey(mModInfo.Plugin))
            {
                GetModelIcon(mModInfo.Plugin);
            }

        }
        public new void Expand()
        {
            base.Expand();
        }
        /// <summary>
        /// 检查鼠标的位置,并返回状态
        /// </summary>
        /// <param name="e">鼠标信息</param>
        /// <returns>位置枚举</returns>
        internal CheckArea HitCheck(MouseEventArgs e)
        {
            if (mCheckLable && (e.X > (ControlWidth - Height * 2)) && (e.X < (ControlWidth - Height * 2 + Height / 2.0)))
            {
                return CheckArea.MultiSelect;
            }
            if ((e.X > Left) && (e.X < (Left + Height)))
            {
                return CheckArea.Icon;
            }
            if (RemarksPoint.X < e.X && e.X < RemarksPoint.X + 90 && RemarksPoint.Y - 5 < e.Y && e.Y < RemarksPoint.Y + 9 + 5)
            {
                return CheckArea.Remarks;
            }
            return CheckArea.Space;
        }

        /// <summary>
        /// 绘制逻辑模块展开折叠样式
        /// </summary>
        private void MakeProcUnitList()
        {
            int width = 32;
            int coldif = 1;
            int tempWidth = (width / 5);
            mFolderIconOpen = new Bitmap(26, 26);
            mFolderIconClose = new Bitmap(26, 26);
            
            //绘制逻辑模块展开折叠样式
            using (Graphics g = Graphics.FromImage(mFolderIconOpen))
            {
                using (Pen pen = new Pen(Color.Navy, 1f))
                {
                    //绘制折叠框白色填充
                    Icon icon = Resources.展开;
                    g.FillRectangle(new SolidBrush(Color.White), new Rectangle(coldif - 6, width / 6 - 2, 14, 15));
                    g.DrawIcon(icon, new Rectangle(coldif - 6, width / 6 - 3, 18, 18));
                }
            }
            using (Graphics g = Graphics.FromImage(mFolderIconClose))
            {
                using (Pen pen = new Pen(Color.Navy, 1f))
                {
                    //绘制折叠框白色填充
                    Icon icon = Resources.折叠;
                    g.FillRectangle(new SolidBrush(Color.White), new Rectangle(coldif - 6, width / 6 - 2, 14, 15));
                    g.DrawIcon(icon, new Rectangle(coldif - 6, width / 6 - 3, 18, 18));
                }
            }
        }

        /// <summary>
        /// 画出判断结果符号
        /// </summary>
        /// <param name="g"></param>
        /// <param name="top"></param>
        /// <param name="pen"></param>
        /// <param name="brush"></param>
        private void DrawJudge(Graphics g, int top, Pen pen, SolidBrush brush)
        {
            if (mModInfo.Name != "")
            {
                brush.Color = Color.White;
                int x = ControlWidth - Height - Height/2;
                int y = top - (Height / 12);
                pen.Width = 3f;
                if (Disabled == false)
                {
                    switch (mModInfo.State)
                    {
                        case ModState.None:
                            g.DrawImage(Resources.unknown, new Rectangle(x + 17, y + 11, 16, 16), new Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel);
                            break;
                        case ModState.OK:
                            g.DrawImage(Resources.ok, new Rectangle(x + 17, y + 11, 16, 16), new Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel);
                            break;
                        case ModState.NG:
                            g.DrawImage(Resources.ng, new Rectangle(x + 17, y+ 11, 16, 16), new Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel);
                            break;
                        case ModState.Start:
                            Brush bg = new SolidBrush(Color.DarkOrange);//声明的画刷
                            for (int i = 0; i < loadPointNum; ++i)
                            {
                                g.FillEllipse(bg, x + 15 + i * 5, y + Height / 3 + 3, 5, 5);
                            }
                            loadPointNum = loadPointNum > 3 ? 1 : ++loadPointNum;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    g.DrawImage(Resources.unuse, new Rectangle(x + 15, y + 11, 16, 16), new Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel);

                }
                //还原
                pen.Color = Color.Black;
                pen.Width = 1f;
            }
        }

        /// <summary>
        /// 绘制CheckBox
        /// </summary>
        /// <param name="g"></param>
        /// <param name="top"></param>
        /// <param name="pen"></param>
        /// <param name="brush"></param>
        private void DrawCheckBox(Graphics g, int top, Pen pen, SolidBrush brush)
        {
            if (mModInfo.Name != "")
            {
                brush.Color = Color.Black;
                int x = ControlWidth - Height * 2;
                int y = top + (Height / 4);
                g.FillRectangle(brush, x, y, Height / 2, Height / 2);
                brush.Color = Color.White;
                g.FillRectangle(brush, (x + 2), (y + 2), ((Height / 2) - 4), ((Height / 2) - 4));
                if (mChecked)
                {
                    pen.Color = Color.Red;
                    pen.Width = 2f;
                    g.DrawLine(pen, (x + (Height / 8)), ((y + (Height / 4)) + (Height / 8)), (x + (Height / 8)), (y + (Height / 4)));
                    g.DrawLine(pen, (x + (Height / 8)), ((y + (Height / 4)) + (Height / 8)), ((x + (Height / 4)) + (Height / 8)), (y + (Height / 8)));
                }
                pen.Color = Color.Black;
                pen.Width = 1f;
            }
        }

        /// <summary>
        /// 绘制流程中的模块
        /// </summary>
        /// <param name="g"></param>
        /// <param name="left"></param>
        /// <param name="top"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        /// <param name="nest"></param>
        /// <param name="parent_top"></param>
        internal void PaintItem(ModFlowItem modFlow, Graphics g, ref int left, ref int top, int w, int h, int nest, string mSpaceKey, ref int parent_top, bool selected)
        {
            mSpaceKey = "";
            int num = 17;
            int num2 = (int)(h * 0.1);
            Top = top;
            Left = (nest * num) + left;
            Width = w;
            Height = h;
            selected |= IsSelected;
            int num8 = Click ? 10 : 10;//偏移量x改为一样,就没有动画效果
            if ((top > FlowHeight) || (top < -Height))//滚动情况
            {
                top += h;
                if (UnitType == UnitType.Folder)
                {
                    int num3 = parent_top;
                    parent_top = top;
                    if (IsExpanded)
                    {
                        foreach (ModFlowItem item in base.Nodes)
                        {
                            item.PaintItem(item, g, ref left, ref top, Width - num, h, nest + 1, mSpaceKey,ref parent_top, selected);
                        }
                    }
                    parent_top = num3;
                }
            }
            else
            {
                Font font = new Font("隶书", 11.5F, FontStyle.Regular);
                using (SolidBrush brush = new SolidBrush(Color.White))
                {
                    using (Pen pen2 = new Pen(Color.Navy,1.5f))
                    {
                        //绘制模块边缘
                        g.DrawLine(pen2, left + (nest * num) + 26, top, ControlWidth - 2, top);//上边缘
                        g.DrawLine(pen2, left + (nest * num) + 9, top + Height, ControlWidth - 2, top + Height);//下边缘
                        g.DrawLine(pen2, ControlWidth - 2, top, ControlWidth - 2, (top + Height));//右边缘

                        //选中模块的背景
                        if (IsSelected && !Sol.GetStates())
                        {
                            brush.Color = Color.Lavender;
                            g.FillRectangle(brush, Left + 9, top + 1, Width - 11, h - 1);
                        }
                        if (!Disabled && Sol.GetStates())
                        {
                            brush.Color = Color.Lavender;//留运行时的背景色运行的时候显示
                        }
                        else if (Disabled)
                        {
                            brush.Color = ColorTranslator.FromHtml("#f6f5ec");
                        }

                        //绘制模块上的显示文本(包括模块名称和运行时间)
                        brush.Color = Color.Navy;
                        if (mModInfo.Name.Length<5)
                        {
                            mSpaceKey = mSpaceKey + "    ";
                        }
                        if (mModInfo.Plugin.StartsWith("文件夹")||mModInfo.Plugin.StartsWith("结束"))
                        {
                            g.DrawString(ModNo.ToString() + "." + mModInfo.Name, font, brush, (Left + Height) + 10, (float)(top + (h / 4)) - 3);
                        }
                        else
                        {
                            if (nest > 0)//层级大于0 说明在文件夹内
                            {
                                mSpaceKey = mSpaceKey.Length > 8 ? mSpaceKey.Remove(0, 8) : mSpaceKey.PadLeft(11, ' ');
                            }
                            else
                            {
                                mSpaceKey = mSpaceKey + "  ";
                            }
                            //绘制模块名称
                            g.DrawString(ModNo.ToString() + "." + mModInfo.Name ,font, brush, Left + Height + 10, (float)(top + (h / 6)));

                            //绘制运行时间
                            brush.Color = Color.Gray;
                            Font fontRunTime = new Font("隶书", 9F, FontStyle.Regular);

                            int gapVal;
                            int multNum = 0;
                            switch (mModInfo.CostTime.ToString("F2").Split('.')[0].Length)
                            {
                                case 1:
                                    multNum = 0;
                                    break;
                                case 2:
                                    multNum = 1;
                                    break;
                                case 3:
                                    multNum = 2;
                                    break;
                                case 4:
                                    multNum = 3;
                                    break;
                                case 5:
                                    multNum = 4;
                                    break;
                                case 6:
                                    multNum = 5;
                                    break;
                            }

                            gapVal = 5 * multNum;
                            g.DrawString(mModInfo.CostTime.ToString("F2") + "ms", fontRunTime, brush, ControlWidth - Height - 15- gapVal, top + Height / 2 + 5);
                        }

                        //绘制注释区域
                        using (Font font2 = new Font(font.Name, 9.5F, FontStyle.Regular))
                        {
                            brush.Color = Color.Gray;
                            RemarksPoint = new Point(((Left + Height) + 4) + 7, (top + (h / 2) + (h / 9)));
                            if (mModInfo.Remarks != "")
                            {
                                g.DrawString(mModInfo.Remarks, font2, brush, RemarksPoint.X, RemarksPoint.Y);
                            }
                            else
                            {
                                g.DrawString("注释", font2, brush, RemarksPoint.X, RemarksPoint.Y);
                            }
                        }

                        //在逻辑工具中的模块左侧的竖线绘制
                        int num4 = Top + (Height / 2);
                        pen2.Color = Color.Navy;
                        if (nest > 0)//层级大于0 说明在文件夹内
                        {
                            if (modFlow.Text.Contains("循环开始")|| modFlow.Text.Contains("如果") || modFlow.Text.Contains("否则"))
                            {
                                if (IsExpanded)
                                {
                                    int start = modFlow.ModNo;
                                    int end = ((ModFlowItem)modFlow.NextNode).ModNo;
                                    int gap = end - start;
                                    g.DrawLine(pen2, Left - num + (Height / 4) + 16, Top, Left - num + (Height / 4) + 16, Top + Height * gap);
                                }
                            }

                            g.DrawLine(pen2, Left - num + (Height / 4) + 16, Top, Left - num + (Height / 4) + 16, Top + Height);
                        }

                        //最左侧树列表的竖线 8为固定左边距离
                        g.DrawLine(pen2, 8, top, 8, (top + Height));

                        //拖拽插入的效果-分隔线
                        if ((dragList || dragInNew) && (ModNo == mDragToUnitNo) && mDragToUnitNo != mDragFromUnitNo)
                        {
                            brush.Color = Color.Navy;
                            g.FillRectangle(brush, left + (nest * num) + 9, top + Height, ControlWidth - (nest * num) - 10, 2);
                        }

                        DrawJudge(g, top, pen2, brush);

                        switch (UnitType)
                        {
                            case UnitType.Mod:
                                //绘制图标
                                if (mModInfo.Name.Length > 0)
                                {
                                    if (mImageIconDic.ContainsKey(mModInfo.Plugin))
                                    {
                                        Icon image2 = mImageIconDic[mModInfo.Plugin];
                                        if (mModInfo.Name.StartsWith("结束")) { image2 = Resources.end; }
                                        else if (mModInfo.Name.StartsWith("循环结束")) { image2 = Resources.endfor; }
                                        g.DrawIcon(image2, new Rectangle(Left + num2 + num8, (top + num2) + 4, 26, 26));
                                    }
                                    else
                                    {
                                        //没有图标就用框代替
                                        g.FillRectangle(brush, Left + num2 + num8, top + num2, 26, 26);
                                    }
                                    if (mCheckLable)
                                    {
                                        //绘制多选框
                                        DrawCheckBox(g, top, pen2, brush);
                                    }
                                }
                                top += h;
                                break;
                            case UnitType.Folder:
                                MakeProcUnitList();
                                int width = Height - (num2 * 2);
                                int num7 = Click ? 2 : 0;//偏移量y
                                int x = Left + num2 + num8;
                                int y = Top + num2 + num7 + 4;
                                pen2.Color = Color.Transparent;
                                brush.Color = Color.Transparent;//填充  画背景图

                                if (IsExpanded || Nodes.Count == 0)//当文件夹内没有子类的时候 画一个 一
                                {
                                    if (mImageIconDic.ContainsKey(mModInfo.Plugin))//画文件打开图标
                                    {
                                        Icon image2 = mImageIconDic[mModInfo.Plugin];
                                        if (mModInfo.Name.StartsWith("如果")) { image2 = Resources._if; }
                                        else if (mModInfo.Name.StartsWith("否则")) { image2 = Resources._else; }
                                        else if (mModInfo.Name.StartsWith("循环开始")) { image2 = Resources._for; }
                                        g.DrawIcon(image2, new Rectangle(x, y, 26, 26));
                                    }
                                    g.DrawImage(mFolderIconOpen, new Rectangle(x - 10, y, width, width), new Rectangle(0, 0, 26, 26), GraphicsUnit.Pixel);
                                    pen2.Color = Color.Navy;

                                    if (mCheckLable)   
                                    {
                                        DrawCheckBox(g, top, pen2, brush);
                                    }
                                    int parent_topTmp = parent_top;
                                    parent_top = top;
                                    top += h;
                                    foreach (ModFlowItem item2 in Nodes)//画子对象
                                    {
                                        item2.PaintItem(item2, g, ref left, ref top, Width - num, h, nest + 1, mSpaceKey, ref parent_top, selected);
                                    }
                                    parent_top = parent_topTmp;
                                }
                                else
                                {
                                    if (mImageIconDic.ContainsKey(mModInfo.Plugin))//画文件夹关闭按钮
                                    {
                                        //依据判定结果获取图标,图标绘制只有一个 已经添加了结果显示图标 √ × 
                                        Icon image2 = mImageIconDic[mModInfo.Plugin];
                                        if (mModInfo.Name.StartsWith("如果")){ image2 = Resources._if; }
                                        else if (mModInfo.Name.StartsWith("否则")){ image2 = Resources._else; }
                                        else if (mModInfo.Name.StartsWith("循环结束")) { image2 = Resources.endfor; }
                                        g.DrawIcon(image2, new Rectangle(x, y, 26, 26));
                                    }
                                    g.DrawImage(mFolderIconClose, new Rectangle(x - 10, y, width, width), new Rectangle(0, 0, 26, 26), GraphicsUnit.Pixel);
                                    if (mCheckLable) { DrawCheckBox(g, top, pen2, brush); }
                                    top += h;
                                }
                                break;
                            case UnitType.Empty:
                                top += h;
                                break;
                            default:
                                break;
                        }
                    }
                }
                if (base.TreeView == null)
                {
                    font.Dispose();
                    font = null;
                }
            }
        }

        public override string ToString()
        {
            return ModNo.ToString() + "." + mModInfo.Name;
        }
        public new bool Checked
        {
            get
            {
                return mChecked;
            }
            set
            {
                if ((mModInfo.Name != "") && (!mModInfo.Name.Contains("文件夹结束")))
                {
                    mChecked = value;
                }
            }
        }
        public new bool IsSelected { get; internal set; }
        public UnitType UnitType { get; }
        public new ModFlowItem Parent
        {
            get
            {
                return (ModFlowItem)base.Parent;
            }
        }
        public int Level_Under
        {
            get
            {
                int num = 0;
                if (base.Nodes.Count > 0)
                {
                    num = 1;
                }
                int num2 = 0;
                foreach (ModFlowItem item in base.Nodes)
                {
                    int num3 = item.Level_Under;
                    if (num2 < num3)
                    {
                        num2 = num3;
                    }
                }
                return (num + num2);
            }
        }

        /// <summary>
        /// 模块位置索引
        /// </summary>
        public int ModNo { get; set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Left { get; private set; }
        public int Top { get; private set; }
    }
}
