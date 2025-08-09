using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using HalconDotNet;
using RexConst;
namespace VisionCore
{
    /// <summary>
    /// 模块抽象类(模块总类)
    /// </summary>
    [Serializable]
    public abstract class ObjBase
    {
        #region 字段、属性

        /// <summary>
        /// 模块图标 
        /// </summary>
        public Image Icon;

        /// <summary>
        /// 流程名称 
        /// </summary>
        public string ProjName = "";

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Enable = true;

        /// <summary>
        /// 是否启用像素当量
        /// </summary>
        public bool isUsePixelPrec = false;

        /// <summary>
        /// 是否显示区域
        /// </summary>
        public bool isShowReg = true;

        /// <summary>
        /// 是否显示数据
        /// </summary>
        public bool isShowData = true;

        /// <summary>
        /// 信息显示X坐标
        /// </summary>
        public double X = 10;

        /// <summary>
        /// 信息显示Y坐标
        /// </summary>
        public double Y = 10;

        /// <summary>
        /// 字体大小
        /// </summary>
        public int fontSize = 10;

        /// <summary>
        /// 字体样式
        /// </summary>
        public string fontType = "隶书";

        /// <summary>
        /// 字体颜色
        /// </summary>
        public string fontColor = "#00FF00";

        /// <summary>
        /// 信息前缀
        /// </summary>
        public string prefix = "";

        /// <summary>
        /// 结果颜色
        /// </summary>
        public string resultColor = "#00FF00";

        /// <summary>
        /// 执行结果
        /// </summary>
        [NonSerialized]
        public string exeResult = "模块未执行";

        /// <summary>
        /// 模块基类列表
        /// </summary>
        public List<ObjBase> mObjBase;

        /// <summary>
        /// 模块单元输出数据列表
        /// </summary>
        public List<DataCell> mSloVar;

        /// <summary>
        /// 当前图片
        /// </summary>
        [NonSerialized]
        public RImage mRImage;

        /// <summary>
        /// 处理后图片
        /// </summary>
        [NonSerialized]
        public RImage mRImageResult;

        /// <summary>
        /// 数据全局变量
        /// </summary>
        [NonSerialized]
        public List<DataCell> mSysVar;

        /// <summary>
        /// 控件全局变量
        /// </summary>
        [NonSerialized]
        public List<CtrlVar> ctrlVarColl;

        /// <summary> 
        /// 通信列表
        /// </summary>
        [NonSerialized]
        public List<ECom> mECom;

        /// <summary>
        /// 相机列表
        /// </summary>
        [NonSerialized]
        public List<CamerasBase> mCamera;

        /// <summary>
        /// 模块耗时
        /// </summary>
        [NonSerialized]
        public HTimer mHTimer = new HTimer();

        /// <summary> 
        /// 模块信息 
        /// </summary>
        private ModInfo mModInfo = new ModInfo();

        /// <summary>
        /// 模块信息
        /// </summary>
        public ModInfo ModInfo
        {
            get
            {
                if (mModInfo == null)
                {
                    mModInfo = new ModInfo();
                }
                return mModInfo;
            }
            set
            {
                mModInfo = value;
                AfterSetModParam();
            }
        }

        /// <summary>
        /// 限定访问-模块设置后执行,子类可用可不用
        /// </summary>
        virtual protected void AfterSetModParam() { }

        #endregion

        #region 方法-模块相关

        /// <summary> 
        /// 抽象执行模块接口 
        /// </summary>
        abstract public bool RunObj();

        /// <summary> 
        /// 模块设置界面
        /// </summary>
        virtual public void RunForm(ObjBase baseMod) { }

        /// <summary>
        /// 验证输入字符串为数字-返回一个bool类型的值
        /// </summary>
        /// <param name="strln">输入字符</param>
        public bool IsNumber(string strln)
        {
            Regex regex = new Regex("[^0-9.-]");
            Regex regex2 = new Regex("[0-9]*[.][0-9]*[.][0-9]*");
            Regex regex3 = new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            string str = "^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$";
            string str2 = "^([-]|[0-9])[0-9]*$";
            Regex regex4 = new Regex("(" + str + ")|(" + str2 + ")");
            return !regex.IsMatch(strln) && !regex2.IsMatch(strln) && !regex3.IsMatch(strln) && regex4.IsMatch(strln);
        }

        #endregion

        #region  方法-变量相关

        /// <summary>
        /// 更新模块列表中的对象
        /// </summary>
        /// <param name="imCalVar">列表</param>
        /// <param name="data">值</param>
        public void SetVarList(ref List<DataCell> var, DataCell data)
        {
            //如果存在则更新，不存在则添加
            int index = var.FindIndex(e => e.mModName == data.mModName && e.mDataName == data.mDataName);
            if (index > -1)
            {
                var[index] = data;
            }
            else
            {
                var.Add(data);
            }
        }

        /// <summary>
        /// 信息赋值
        /// </summary>
        public virtual void SetInfo() { }

        /// <summary>
        /// 初始化输出变量
        /// </summary>
        public virtual void InitOutputInfo() { }

        #endregion
    }
}
