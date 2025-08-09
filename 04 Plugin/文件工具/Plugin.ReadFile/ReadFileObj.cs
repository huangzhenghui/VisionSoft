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

namespace Plugin.ReadFile
{
    [Category("文件工具")]
    [DisplayName("文件读取")]
    [Serializable]
    public class ReadFileObj : ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 信息输出
        /// </summary>
        public ReadFile_Info readFile_Info = new ReadFile_Info();

        /// <summary>
        /// 文件类型
        /// </summary>
        public FileType fileType = FileType.T_HTuple;

        /// <summary>
        /// 文件路径
        /// </summary>
        public string filePath = "";

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
                //声明变量
                object data = new object();

                //初始化输出变量
                InitOutputInfo();

                //获取数据
                GetData();

                //执行算法
                ReadFile(fileType, filePath, out data);

                //状态更新
                exeResult = "执行成功";

                //更新数据
                readFile_Info.data_HTuple = (HTuple)data;

                //保存对象
                SetVarList(ref mSloVar, new DataCell(ModInfo.Name, ModInfo.Encode, DataType.单量, DataMode.文件读取, ConstVar.ContourSel, ModInfo.Plugin, "0", 1, readFile_Info, DataAtrr.全局变量));

                Log.Info(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行成功");
                ModInfo.State = ModState.OK;
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(Sol.mSol.mProjList[ModInfo.Index].mProjInfo.Name + ": " + ModInfo.Name + ":" + "执行失败(" + "原因：" + ex.Message + ")");
                ModInfo.State = ModState.NG;
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
            new ReadFileForm((ReadFileObj)baseMod).ShowDialog();
        }

        #endregion

        #region 方法-数据相关

        /// <summary>
        /// 初始化输出变量
        /// </summary>
        public override void InitOutputInfo()
        {
            readFile_Info.data_HTuple = new HTuple();
        }

        /// <summary>
        /// 如果数据内容是链接，则由GetLinkValue得到链接的值
        /// </summary>
        public void GetData() { }

        #endregion

        #region

        /// <summary>
        /// 数据读取
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        public void ReadFile(FileType fileType, string filePath, out object data)
        {
            data = new object();

            switch (fileType)
            {
                case FileType.T_HTuple:
                    HTuple data_HTuple = new HTuple();
                    HOperatorSet.ReadTuple(filePath, out data_HTuple);
                    data = data_HTuple;
                    break;
            }
        }

        #endregion
    }
}
