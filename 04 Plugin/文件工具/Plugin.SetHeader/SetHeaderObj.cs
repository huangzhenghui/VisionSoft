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

namespace Plugin.SetHeader
{
    [Category("文件工具")]
    [DisplayName("表头设置")]
    [Serializable]
    public class SetHeaderObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 信息输出
        /// </summary>
        public SetHeader_Info setHeader_Info = new SetHeader_Info();

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
                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.表头设置, ConstVar.SetHeader, ModInfo.Plugin, "0", 1, setHeader_Info, DataAtrr.全局变量));

                //更新界面
                deliveryHeader(setHeader_Info);

                Log.Info(ModInfo.Name + ":" + "表头设置成功");
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
            new SetHeaderForm((SetHeaderObj)baseMod).ShowDialog();
        }

        #endregion
    }
}
