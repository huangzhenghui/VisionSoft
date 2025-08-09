using HalconDotNet;
using Plugin.CreateROI;
using Rex.UI;
using RexConst;
using RexView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;
using VisionCore.Core.Project;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static VisionCore.Core.Project.ProjDelegate;

namespace Plugin.ShowData
{
    [Category("文件工具")]
    [DisplayName("数据显示")]
    [Serializable]
    public class ShowDataObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 信息输出
        /// </summary>
        public ShowData_Info showData_Info = new ShowData_Info();

        /// <summary>
        /// 链接名称
        /// </summary>
        public string[] linkName = new string[100];

        #endregion

        #region 方法-模块相关

        /// <summary>
        /// 运行模块
        /// </summary>
        /// <returns></returns>
        public override bool RunObj()
{
            try
            {
                //获取数据
                GetData();

                //更新界面
                deliveryData(showData_Info);

                Log.Info(ModInfo.Name + ":" + "数据显示成功");
                ModInfo.State = ModState.OK;
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ModInfo.Name + ":" + ex.Message);
                ModInfo.State = ModState.NG;
                mRImageResult = null;
                return false;
            }
        }

        #endregion

        #region 方法-窗体相关

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <param name="baseMod"></param>
        public override void RunForm(ObjBase baseMod)
        {
            new ShowDataForm((ShowDataObj)baseMod).ShowDialog();
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData()
        {
            string[] str = new string[100];
            int j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                j = i + 1;
                str[i] = "Data" + j;
            }

            for (int i = 0; i < linkName.Length; i++)
            {
                if (linkName[i].Contains(":"))
                {
                    double linValue = Convert.ToDouble(Var.GetLinkValue(mSysVar, mSloVar, linkName[i]));
                    showData_Info.GetType().GetProperty(str[i]).SetValue(showData_Info, linValue.ToString("F4"));
                }
            }
        }

        #endregion
    }
}
