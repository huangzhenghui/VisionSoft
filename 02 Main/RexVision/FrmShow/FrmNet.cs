using Rex.UI;
using TSIVision.FrmConfigR;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using VisionCore;
using WeifenLuo.WinFormsUI.Docking;

namespace TSIVision
{
    [Serializable]
    public partial class FrmNet : DockContent
    {
        #region 字段、属性

        public List<UISymbolButton> mBtnList = new List<UISymbolButton>();

        #endregion

        #region 初始化

        public FrmNet()
        {
            InitializeComponent();
            FrmConfigComm.SetEComEvent += EComEvent;
            FormMain.SetEComEvent += EComEvent;
            EComManageer.SetEComEvent += EComEvent;
            FrmConfigCam.SetCamearEvent += CamearEvent;
            Sol.SetCameraEvent += CamearEvent;
        }

        #endregion

        #region 方法-添加按钮控件

        /// <summary>
        /// 通讯添加按钮
        /// </summary>
        /// <param name="mECom"></param>
        /// <param name="type"></param>
        public void AddButton(ECom mECom, EComOperate type)
        {
            foreach (Control btn in uipl_EComEvent.Controls)
            {
                if (btn.Text == mECom.Key)
                {
                    return;
                }
            }

            UISymbolButton aButton = new UISymbolButton();
            aButton.Text = mECom.DeviceName;
            aButton.Symbol = 57567;
            aButton.FillColor = Color.Thistle;
            aButton.FillDisableColor = aButton.FillColor;
            aButton.FillPressColor = aButton.FillColor;
            aButton.FillHoverColor = aButton.FillColor;
            aButton.RectColor = aButton.FillColor;
            aButton.RectDisableColor = aButton.FillColor;
            aButton.RectHoverColor = aButton.FillColor;
            aButton.RectPressColor = aButton.FillColor;
            aButton.UseDoubleClick = true;
            aButton.BringToFront();
            aButton.Size = new Size(110, 24);
            aButton.Font = new Font("华文新魏", 12F);
            mBtnList.Add(aButton);
            uipl_EComEvent.Controls.Add(aButton);
            ArrangeButtons();
        }

        /// <summary>
        /// 相机添加按钮
        /// </summary>
        /// <param name="mCamerasBase"></param>
        public void AddButton(CamerasBase mCamerasBase)
        {
            foreach (Control btn in uipl_EComEvent.Controls)
            {
                if (btn.Text == mCamerasBase.mCamName)
                {
                    return;
                }
            }
            UISymbolButton aButton = new UISymbolButton();
            aButton.Text = mCamerasBase.mCamName;
            aButton.Symbol = 61488;
            aButton.FillColor = Color.Thistle;
            aButton.FillDisableColor = aButton.FillColor;
            aButton.FillPressColor = aButton.FillColor;
            aButton.FillHoverColor = aButton.FillColor;
            aButton.RectColor = aButton.FillColor;
            aButton.RectDisableColor = aButton.FillColor;
            aButton.RectHoverColor = aButton.FillColor;
            aButton.RectPressColor = aButton.FillColor;
            aButton.UseDoubleClick = true;
            aButton.BringToFront();
            aButton.Size = new Size(110, 24);
            aButton.Font = new Font("华文新魏", 12F);
            mBtnList.Add(aButton);
            uipl_EComEvent.Controls.Add(aButton);
            ArrangeButtons();
        }

        #endregion

        #region 方法-panel中控件自动排序

        /// <summary>
        /// 设置Panel容器中的Button自动排序
        /// </summary>
        /// <param name="panel">Panel控件</param>
        public void ArrangeButtons()
        {
            int x = 0, y = 2;
            Control.ControlCollection ct = uipl_EComEvent.Controls;
            for (int i = ct.Count - 1; i >= 0; i--)
            {
                ct[i].Location = new Point(x + 9, y);
                x = x + ct[i].Width + 9;
                if (x + ct[i].Width > uipl_EComEvent.Width)
                {
                    x = 0;
                    y = y + ct[i].Height + 3;
                }
            }
        }

        #endregion

        #region 事件-控件操作

        /// <summary>
        /// 通讯控件操作事件，包含增加、移除、清除
        /// </summary>
        /// <param name="mECom"></param>
        /// <param name="type"></param>
        public void EComEvent(ECom mECom, EComOperate type)
        {
            switch (type)
            {
                case EComOperate.Add:
                    AddButton(mECom, type);
                    break;
                case EComOperate.Remove:
                    foreach (Control mBtn in uipl_EComEvent.Controls)
                    {
                        if (mBtn.Text == mECom.DeviceName)
                        {
                            uipl_EComEvent.Controls.Remove(mBtn);
                        }
                    }
                    break;
                case EComOperate.Clear:
                    uipl_EComEvent.Controls.Clear();
                    break;
            }
        }

        /// <summary>
        /// 相机控件操作事件，包含增加、移除、清除
        /// </summary>
        /// <param name="mCamear"></param>
        /// <param name="type"></param>
        public void CamearEvent(CamerasBase mCamear, EComOperate type)
        {
            switch (type)
            {
                case EComOperate.Add:
                    AddButton(mCamear);
                    break;
                case EComOperate.Remove:
                    foreach (Control mBtn in uipl_EComEvent.Controls)
                    {
                        if (mCamear != null)
                        {
                            if (mBtn.Text == mCamear.mCamName)
                            {
                                uipl_EComEvent.Controls.Remove(mBtn);
                            }
                        }
                    }
                    break;
                case EComOperate.Clear:
                    break;
            }
        }

        #endregion

        #region 事件-窗体控件

        /// <summary>
        /// 窗体尺寸变化时，重新排列panel中Button控件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNet_SizeChanged(object sender, EventArgs e)
        {
            ArrangeButtons();
        }

        #endregion

        #region 事件-Timer控件

        /// <summary>
        /// 根据通讯连接情况刷新控件状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (uipl_EComEvent.Controls.Count > 0)
            {
                foreach (UISymbolButton mBtn in uipl_EComEvent.Controls)
                {
                    if (mBtn.Symbol == 61488)
                    {
                        CamerasBase mCamerasBase = Sol.mSol.mCamerasList.Find(c => c.mCamName == mBtn.Text);
                        if (mCamerasBase != null)
                        {
                            if (mCamerasBase.mConnected)
                            {
                                mBtn.FillColor = Color.SkyBlue;
                                mBtn.FillDisableColor = mBtn.FillColor;
                                mBtn.FillPressColor = mBtn.FillColor;
                                mBtn.FillHoverColor = mBtn.FillColor;
                                mBtn.RectColor = mBtn.FillColor;
                                mBtn.RectDisableColor = mBtn.FillColor;
                                mBtn.RectHoverColor = mBtn.FillColor;
                                mBtn.RectPressColor = mBtn.FillColor;
                            }
                            else
                            {
                                mBtn.FillColor = Color.Thistle;
                                mBtn.FillDisableColor = mBtn.FillColor;
                                mBtn.FillPressColor = mBtn.FillColor;
                                mBtn.FillHoverColor = mBtn.FillColor;
                                mBtn.RectColor = mBtn.FillColor;
                                mBtn.RectDisableColor = mBtn.FillColor;
                                mBtn.RectHoverColor = mBtn.FillColor;
                                mBtn.RectPressColor = mBtn.FillColor;
                            }
                        }
                    }
                    else
                    {
                        ECom mECom = Sol.mSol.mEComList.Find(c => c.DeviceName == mBtn.Text);
                        if (mECom != null)
                        {
                            if (mECom.IsConnected)
                            {
                                mBtn.FillColor = Color.SkyBlue;
                                mBtn.FillDisableColor = mBtn.FillColor;
                                mBtn.FillPressColor = mBtn.FillColor;
                                mBtn.FillHoverColor = mBtn.FillColor;
                                mBtn.RectColor = mBtn.FillColor;
                                mBtn.RectDisableColor = mBtn.FillColor;
                                mBtn.RectHoverColor = mBtn.FillColor;
                                mBtn.RectPressColor = mBtn.FillColor;
                            }
                            else
                            {
                                mBtn.FillColor = Color.Thistle;
                                mBtn.FillDisableColor = mBtn.FillColor;
                                mBtn.FillPressColor = mBtn.FillColor;
                                mBtn.FillHoverColor = mBtn.FillColor;
                                mBtn.RectColor = mBtn.FillColor;
                                mBtn.RectDisableColor = mBtn.FillColor;
                                mBtn.RectHoverColor = mBtn.FillColor;
                                mBtn.RectPressColor = mBtn.FillColor;
                            }
                        }
                        else
                        {
                            uipl_EComEvent.Controls.Remove(mBtn);
                        }
                    }
                }
            }
        }

        #endregion
    }
}

