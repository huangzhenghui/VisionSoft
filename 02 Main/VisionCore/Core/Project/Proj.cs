using System;
using System.Linq;
using RexConst;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using HalconDotNet;

namespace VisionCore
{
    /// <summary>
    /// 流程类
    /// </summary>
    [Serializable]
    public class Proj
    {
        #region 字段、属性

        /// <summary>
        /// 通信列表
        /// </summary>
        public List<ECom> mECom;

        /// <summary>
        /// 相机列表
        /// </summary>
        public List<CamerasBase> mCamera;

        /// <summary>
        /// 数据全局变量列表
        /// </summary>
        public List<DataCell> mSysVar;

        /// <summary>
        /// 控件全局变量
        /// </summary>
        public List<CtrlVar> ctrlVarColl = new List<CtrlVar>();

        /// <summary>
        /// 标定变量 
        /// </summary>
        public List<DataCell> mCalVar;

        /// <summary>
        /// 模块列表
        /// </summary>
        public List<DataCell> mSloVar = new List<DataCell>();

        /// <summary>
        /// 模块基类列表
        /// </summary>
        public List<ObjBase> mObjBase = new List<ObjBase>();

        /// <summary>
        /// 模块信息列表
        /// </summary>
        public List<ModInfo> mModInfo { get; private set; } = new List<ModInfo>();

        /// <summary>
        /// 流程信息
        /// </summary>
        public ProjInfo mProjInfo { set; get; } = new ProjInfo();

        /// <summary>
        /// 运行模式 
        /// </summary>
        public RunMode mRunMode { set; get; } = RunMode.停止执行;

        /// <summary>
        /// 运行方式 
        /// </summary>
        public RunType mRunType { set; get; } = RunType.主动执行;

        /// <summary>
        /// 显示启用 
        /// </summary>
        public bool mIsShow { set; get; } = true;

        /// <summary>
        /// 运行标志位
        /// </summary>
        bool IsRun = true;

        /// <summary>
        /// 判断结构完成标志位
        /// </summary>
        bool IsEnd = false;

        /// <summary>
        /// 循环标志位
        /// </summary>
        bool IsFor = true; 
        
        /// <summary>
        /// 添加标志位
        /// </summary>
        bool IsAdd = false;

        /// <summary>
        /// For循环内模块列表
        /// </summary>
        List<ObjBase> ForObj = new List<ObjBase>();

        /// <summary>
        /// Bool字典
        /// </summary>
        Dictionary<string, bool> ForBoolDic = new Dictionary<string, bool>();

        /// <summary>
        /// ObjBase字典
        /// </summary>
        Dictionary<string, List<ObjBase>> ForBaseDic = new Dictionary<string, List<ObjBase>>();

        /// <summary>
        /// For循环层数
        /// </summary>
        Dictionary<string, int> ForSite = new Dictionary<string, int>();

        /// <summary>
        /// 循环开始索引集合
        /// </summary>
        List<int> StartList = new List<int>();

        /// <summary>
        /// 循环结束索引集合
        /// </summary>
        List<int> EndList = new List<int>();

        /// <summary>
        /// ObjBase字典
        /// </summary>
        Dictionary<string, List<ObjBase>> ForObjDic = new Dictionary<string, List<ObjBase>>();

        /// <summary>
        /// 线程控制
        /// </summary>
        [NonSerialized]
        public Thread mThread;

        /// <summary>
        /// 线程运行条件 
        /// </summary>
        [NonSerialized]
        public bool mThreadStatus = false;

        /// <summary>
        /// 流程控制
        /// </summary>
        [NonSerialized]
        public AutoResetEvent mAutoResetEvent = new AutoResetEvent(false);

        #endregion

        #region 方法-流程相关

        /// <summary>
        /// 构造函数-创建流程
        /// </summary>
        public Proj()
        {
            mThread = new Thread(Process);
            mThread.IsBackground = true;
            mThread.Start();
        }

        /// <summary>
        /// 开始流程
        /// </summary>
        public void Start()
        {
            mThreadStatus = true;
            mAutoResetEvent.Set();
        }

        /// <summary>
        /// 停止流程
        /// </summary>
        public void Stop()
        {
            mThreadStatus = false;
            Thread.Sleep(10);
        }

        /// <summary>
        /// 获取线程状态
        /// </summary>
        public bool GetThreadStatus()
        {
            return mThreadStatus;
        }

        /// <summary>
        /// 更新流程名
        /// </summary>
        public void ShowName()
        {
            foreach (ObjBase item in mObjBase)
            {
                item.ProjName = mProjInfo.Name;
            }
        }

        /// <summary>
        /// 信息赋值
        /// </summary>
        public void SetInfo()
        {
            try
            {
                mAutoResetEvent = new AutoResetEvent(false);
                mThread = new Thread(Process);
                mThread.IsBackground = true;
                mThread.Start();
                foreach (ObjBase Mod in mObjBase)
                {
                    Mod.SetInfo();
                    Mod.mHTimer = new HTimer();
                    Mod.ModInfo.CostTime = 0;
                    Mod.mCamera = mCamera;
                    Mod.mECom = mECom;
                    Mod.mObjBase = mObjBase;
                    Mod.mSysVar = mSysVar;
                    Mod.ctrlVarColl = ctrlVarColl;
                    Mod.mSloVar = mSloVar;
                }
                GerInfoList();
            }catch{ }

        }

        /// <summary>
        /// 流程运行
        /// </summary>
        public void Process()
        {
            mThreadStatus = false;
            while (true)
            {
                if (mThreadStatus == false)
                {
                    mAutoResetEvent.WaitOne();//阻塞等待
                }
                else
                {
                    Log.Info(mProjInfo.Name + ": 流程运行开始*:↓");
                    HTimer mHTimer = new HTimer(true);// 启动计时器 
                    IsRun = true;
                    IsEnd = false;
                    IsFor = true;
                    IsAdd = false;

                    if (ForBaseDic != null)
                    {
                        ForBaseDic.Clear();
                    }
                    if (ForBoolDic != null)
                    {
                        ForBoolDic.Clear();
                    }

                    foreach (ObjBase item in mObjBase)
                    {
                        if (item.ModInfo.Name.StartsWith("循环开始"))
                        {
                            IsAdd = true;
                            ForObj = new List<ObjBase>();
                            ForBoolDic.Add(item.ModInfo.Name, false);
                        }

                        if (IsAdd)
                        {
                            ForObj.Add(item);
                        }

                        if (item.ModInfo.Name.StartsWith("循环结束"))
                        {
                            IsAdd = false;
                            ForBaseDic.Add(item.ModInfo.Name, ForObj);
                        }
                    }

                    for (int i = 0; i < mObjBase.Count; ++i)
                    {
                        ObjBase obj = mObjBase[i];
                        obj.ModInfo.Result = obj.Enable;
                        obj.ModInfo.State = ModState.None;
                        if (obj.Enable &!Sol.IsStop)
                        {
                            obj.mHTimer.Start(); // 启动计时器
                            obj.ModInfo.State = ModState.None;

                            if (obj.ModInfo.Name.StartsWith("循环开始"))
                            {
                                if ((ForBoolDic.ContainsKey(obj.ModInfo.Name)))
                                {
                                    ForRun(obj.ModInfo.Name);
                                    i = mObjBase.FindIndex(c => c.ModInfo.Name == obj.ModInfo.Name.Replace("开始", "结束"));
                                }
                            }
                            else if (IsRun && obj.ModInfo.Name.StartsWith("如果"))
                            {
                                obj.ModInfo.State = ModState.Start;
                                obj.RunObj();
                                IsRun = obj.ModInfo.Result;
                                IsEnd = IsRun;
                            }
                            else if (!IsEnd && obj.ModInfo.Name.StartsWith("否则"))
                            {
                                obj.ModInfo.State = ModState.Start;
                                obj.RunObj();
                                IsRun = obj.ModInfo.Result;
                                IsEnd = IsRun;
                            }
                            else if (!IsEnd && obj.ModInfo.Name.StartsWith("否则"))
                            {
                                obj.ModInfo.State = ModState.Start;
                                obj.RunObj();
                                IsRun = obj.ModInfo.Result;
                                IsEnd = IsRun;
                            }
                            else if (IsRun & (!obj.ModInfo.Name.StartsWith("如果") && !obj.ModInfo.Name.StartsWith("否则")))
                            {
                                obj.ModInfo.State = ModState.Start;
                                obj.RunObj();
                            }
                            else
                            {
                                IsRun = obj.ModInfo.Name.StartsWith("结束") ? true : false;
                                if (obj.ModInfo.Name.StartsWith("结束")) IsEnd = false;
                            }

                            obj.mHTimer.Stop();  // 停止计时器
                            obj.ModInfo.CostTime = obj.mHTimer.GetMilliSecond;
                        }
                    }

                    //主界面显示图像
                    List<DataCell> DispalyImage = mSloVar.FindAll(e => e.mDataMode == DataMode.图像采集);
                    List<DataCell> dataCells1 = mSloVar.FindAll(e => e.mDataMode == DataMode.仿射变换);
                    List<DataCell> dataCells2 = mSloVar.FindAll(e => e.mDataMode == DataMode.图像增强);
                    List<DataCell> dataCells3 = mSloVar.FindAll(e => e.mDataMode == DataMode.灰度缩放);
                    List<DataCell> dataCells4 = mSloVar.FindAll(e => e.mDataMode == DataMode.掩膜抠图);
                    List<DataCell> dataCells5 = mSloVar.FindAll(e => e.mDataMode == DataMode.图像剪切);
                    DispalyImage.AddRange(dataCells1);
                    DispalyImage.AddRange(dataCells2);
                    DispalyImage.AddRange(dataCells3);
                    DispalyImage.AddRange(dataCells4);
                    DispalyImage.AddRange(dataCells5);

                    if (DispalyImage.Count >= 0)
                    {
                        foreach (DataCell cell in DispalyImage)
                        {
                            if (cell.mDataValue != null)
                            {
                                if (cell.mDataMode == DataMode.图像采集)
                                {
                                    ShowMsg.SendImage(mProjInfo.Name, (((CaptureImage_Info)cell.mDataValue).imageObj));
                                }
                                else if (cell.mDataMode == DataMode.仿射变换)
                                {
                                    ShowMsg.SendImage(mProjInfo.Name, (((AffineTrans_Info)cell.mDataValue).resultImg));
                                }
                                else if (cell.mDataMode == DataMode.图像增强)
                                {
                                    ShowMsg.SendImage(mProjInfo.Name, (((EmphasisImage_Info)cell.mDataValue).imageObj));
                                }
                                else if (cell.mDataMode == DataMode.灰度缩放)
                                {
                                    ShowMsg.SendImage(mProjInfo.Name, (((ScaleGray_Info)cell.mDataValue).imageObj));
                                }
                                else if (cell.mDataMode == DataMode.掩膜抠图)
                                {
                                    ShowMsg.SendImage(mProjInfo.Name, ((ReduceImage_Info)cell.mDataValue).imageObj);
                                }
                                else if (cell.mDataMode == DataMode.图像剪切)
                                {
                                    ShowMsg.SendImage(mProjInfo.Name, (((CropImage_Info)cell.mDataValue).imageObj));
                                }
                            }
                        }
                    }
                    else
                    {
                        Log.Info(mProjInfo.Name + ":获取图像*:失败! " + mProjInfo.CostTime.ToString("F0") + "ms");
                    }

                    ShowMsg.SendCrtlInfo();

                    mHTimer.Stop();  // 停止计时器
                    mIsShow = false;
                    Thread.Sleep(10);
                    ChangeEvent();
                    Application.DoEvents();
                    if (mRunMode == RunMode.单次执行) { Stop(); }
                    Log.Info(mProjInfo.Name + ": 流程运行结束*:" + mHTimer.GetMilliSecond.ToString("F0") + "ms");
                }
            }
        }

        /// <summary>
        /// 函数运行
        /// </summary>
        public void FuncExe()
        {
            Log.Info(mProjInfo.Name + ": 函数运行开始*:↓");
            HTimer mHTimer = new HTimer(true);// 启动计时器 
            IsRun = true;
            IsEnd = false;
            IsFor = true;
            IsAdd = false;

            if (ForBaseDic != null)
            {
                ForBaseDic.Clear();
            }
            if (ForBoolDic != null)
            {
                ForBoolDic.Clear();
            }

            foreach (ObjBase item in mObjBase)
            {
                if (item.ModInfo.Name.StartsWith("循环开始"))
                {
                    IsAdd = true;
                    ForObj = new List<ObjBase>();
                    ForBoolDic.Add(item.ModInfo.Name, false);
                }

                if (IsAdd)
                {
                    ForObj.Add(item);
                }

                if (item.ModInfo.Name.StartsWith("循环结束"))
                {
                    IsAdd = false;
                    ForBaseDic.Add(item.ModInfo.Name, ForObj);
                }
            }

            for (int i = 0; i < mObjBase.Count; ++i)
            {
                ObjBase obj = mObjBase[i];
                obj.ModInfo.Result = obj.Enable;
                obj.ModInfo.State = ModState.None;
                if (obj.Enable & !Sol.IsStop)
                {
                    obj.mHTimer.Start(); // 启动计时器
                    obj.ModInfo.State = ModState.None;

                    if (obj.ModInfo.Name.StartsWith("循环开始"))
                    {
                        if ((ForBoolDic.ContainsKey(obj.ModInfo.Name)))
                        {
                            ForRun(obj.ModInfo.Name);
                            i = mObjBase.FindIndex(c => c.ModInfo.Name == obj.ModInfo.Name.Replace("开始", "结束"));
                        }
                    }
                    else if (IsRun && obj.ModInfo.Name.StartsWith("如果"))
                    {
                        obj.ModInfo.State = ModState.Start;
                        obj.RunObj();
                        IsRun = obj.ModInfo.Result;
                        IsEnd = IsRun;
                    }
                    else if (!IsEnd && obj.ModInfo.Name.StartsWith("否则"))
                    {
                        obj.ModInfo.State = ModState.Start;
                        obj.RunObj();
                        IsRun = obj.ModInfo.Result;
                        IsEnd = IsRun;
                    }
                    else if (!IsEnd && obj.ModInfo.Name.StartsWith("否则"))
                    {
                        obj.ModInfo.State = ModState.Start;
                        obj.RunObj();
                        IsRun = obj.ModInfo.Result;
                        IsEnd = IsRun;
                    }
                    else if (IsRun & (!obj.ModInfo.Name.StartsWith("如果") && !obj.ModInfo.Name.StartsWith("否则")))
                    {
                        obj.ModInfo.State = ModState.Start;
                        obj.RunObj();
                    }
                    else
                    {
                        IsRun = obj.ModInfo.Name.StartsWith("结束") ? true : false;
                        if (obj.ModInfo.Name.StartsWith("结束")) IsEnd = false;
                    }

                    obj.mHTimer.Stop();  // 停止计时器
                    obj.ModInfo.CostTime = obj.mHTimer.GetMilliSecond;
                }
            }

            //主界面显示图像
            List<DataCell> DispalyImage = mSloVar.FindAll(e => e.mDataMode == DataMode.图像采集);
            List<DataCell> dataCells1 = mSloVar.FindAll(e => e.mDataMode == DataMode.仿射变换);
            List<DataCell> dataCells2 = mSloVar.FindAll(e => e.mDataMode == DataMode.图像增强);
            List<DataCell> dataCells3 = mSloVar.FindAll(e => e.mDataMode == DataMode.灰度缩放);
            List<DataCell> dataCells4 = mSloVar.FindAll(e => e.mDataMode == DataMode.掩膜抠图);
            List<DataCell> dataCells5 = mSloVar.FindAll(e => e.mDataMode == DataMode.图像剪切);
            DispalyImage.AddRange(dataCells1);
            DispalyImage.AddRange(dataCells2);
            DispalyImage.AddRange(dataCells3);
            DispalyImage.AddRange(dataCells4);
            DispalyImage.AddRange(dataCells5);

            if (DispalyImage.Count >= 0)
            {
                foreach (DataCell cell in DispalyImage)
                {
                    if (cell.mDataValue != null)
                    {
                        if (cell.mDataMode == DataMode.图像采集)
                        {
                            ShowMsg.SendImage(mProjInfo.Name, (((CaptureImage_Info)cell.mDataValue).imageObj));
                        }
                        else if (cell.mDataMode == DataMode.仿射变换)
                        {
                            ShowMsg.SendImage(mProjInfo.Name, (((AffineTrans_Info)cell.mDataValue).resultImg));
                        }
                        else if (cell.mDataMode == DataMode.图像增强)
                        {
                            ShowMsg.SendImage(mProjInfo.Name, (((EmphasisImage_Info)cell.mDataValue).imageObj));
                        }
                        else if (cell.mDataMode == DataMode.灰度缩放)
                        {
                            ShowMsg.SendImage(mProjInfo.Name, (((ScaleGray_Info)cell.mDataValue).imageObj));
                        }
                        else if (cell.mDataMode == DataMode.掩膜抠图)
                        {
                            ShowMsg.SendImage(mProjInfo.Name, new RImage(((ReduceImage_Info)cell.mDataValue).imageObj));
                        }
                        else if (cell.mDataMode == DataMode.图像剪切)
                        {
                            ShowMsg.SendImage(mProjInfo.Name, (((CropImage_Info)cell.mDataValue).imageObj));
                        }
                    }
                }
            }
            else
            {
                Log.Info(mProjInfo.Name + ":获取图像*:失败! " + mProjInfo.CostTime.ToString("F0") + "ms");
            }

            ShowMsg.SendCrtlInfo();

            mHTimer.Stop();  // 停止计时器
            mIsShow = false;
            Thread.Sleep(10);
            ChangeEvent();
            Application.DoEvents();
            if (mRunMode == RunMode.单次执行) { Stop(); }
            Log.Info(mProjInfo.Name + ": 函数运行结束*:" + mHTimer.GetMilliSecond.ToString("F0") + "ms");
        }

        /// <summary>
        /// 循环执行
        /// </summary>
        /// <param name="objName"></param>
        private void ForRun(string objName)
        {
            IsFor = true;
            List<ObjBase> mForObjBase = ForBaseDic.First(c => c.Key == objName.Replace("开始", "结束")).Value;
            while (IsFor)
            {
                IsRun = true;
                for (int i = 0; i < mForObjBase.Count; ++i)
                {
                    ObjBase obj = mForObjBase[i];

                    if (obj.Enable && !Sol.IsStop)
                    {
                        obj.mHTimer.Start(); // 启动计时器
                        obj.ModInfo.State = ModState.None;

                        if (IsRun && obj.ModInfo.Name.StartsWith("退出循环"))
                        {
                            obj.ModInfo.State = ModState.Start;
                            obj.RunObj();
                            IsRun = obj.ModInfo.Result;
                            if (!IsRun) IsFor = false;
                        }
                        else if(IsRun && obj.ModInfo.Name.StartsWith("如果"))
                        {
                            obj.ModInfo.State = ModState.Start;
                            obj.RunObj();
                            IsRun = obj.ModInfo.Result;
                            IsEnd = IsRun;
                        }
                        else if (!IsEnd && obj.ModInfo.Name.StartsWith("否则"))
                        {
                            obj.ModInfo.State = ModState.Start;
                            obj.RunObj();
                            IsRun = obj.ModInfo.Result;
                            IsEnd = IsRun;
                        }
                        else if (IsRun && (!obj.ModInfo.Name.StartsWith("如果") && !obj.ModInfo.Name.StartsWith("否则") && !obj.ModInfo.Name.StartsWith("结束")))
                        {
                            obj.ModInfo.State = ModState.Start;
                            obj.RunObj();
                        }
                        else
                        {
                            if (obj.ModInfo.Name.StartsWith("结束"))
                            {
                                obj.ModInfo.State = ModState.Start;
                                obj.RunObj();
                                IsRun = true;
                                IsEnd = false;
                            }
                            else
                            {
                                IsRun = false;
                            }
                        }

                        if (IsRun)
                        {
                            switch (obj.ModInfo.State)
                            {
                                case ModState.OK:
                                    break;
                                case ModState.NG:
                                    Log.Info(mProjInfo.Name + ":" + obj.ModInfo.Name + ":运行失败! " + obj.ModInfo.CostTime.ToString("F0") + "ms");
                                    break;
                            }
                        }

                        if (obj.ModInfo.Name.StartsWith("循环开始"))
                        {
                            if (obj.ModInfo.Result)
                            {
                                IsFor = !obj.ModInfo.Result;
                            }
                        }

                        obj.mHTimer.Stop();  // 停止计时器
                        obj.ModInfo.CostTime = obj.mHTimer.GetMilliSecond;
                    }
                }
            }
        }

        /// <summary>
        /// 析构函数-析构流程
        /// </summary>
        ~Proj()
        {
            if (mAutoResetEvent == null) return;
            mAutoResetEvent.Dispose();
            mThread.Abort();
        }

        #endregion

        #region 方法-模块相关

        /// <summary>
        /// 增加新的模块到流程列表
        /// </summary>
        public void AddModObj(ObjBase objBase, int index)
        {
            int EncodeMax = 0;
            List<string> nameList = mObjBase.Select(c => c.ModInfo.Name).ToList();

            //确定新模块的不重名名称
            while (true)
            {
                //没有重名就跳出循环
                if (!nameList.Contains(objBase.ModInfo.Plugin + EncodeMax))
                {
                    break;
                }
                EncodeMax++;
            }
            objBase.ModInfo.Encode = EncodeMax;
            objBase.ModInfo.Name = objBase.ModInfo.Plugin + objBase.ModInfo.Encode;
            objBase.ModInfo.Index = mProjInfo.Index;
            objBase.mECom = mECom;
            objBase.mSysVar = mSysVar;
            objBase.ctrlVarColl = ctrlVarColl;
            objBase.mObjBase = mObjBase;
            objBase.mSloVar = mSloVar;
            objBase.mCamera = mCamera;
            objBase.ProjName = mProjInfo.Name;
            objBase.ModInfo.State = ModState.None;
            if (index > -1)
            {
                mObjBase.Insert(index, objBase);
            }
            GerInfoList();
        }

        /// <summary>
        /// 添加一个模块
        /// </summary>
        /// <param name="ChangName">要追加的模块目标位置模块名称</param>
        /// <param name="mModParam">模块信息</param>
        /// <param name="isNext">是否在后方追加</param>
        public void AddModObj(string ChangName, ModInfo mModParam, bool isNext)
        {
            try
            {
                Sol.mProjSave = false;//解决方案未保存
                PluginsInfo mPluginsInfo = PluginToolService.mPluginDic[mModParam.Plugin];
                ObjBase NewObjBase = (ObjBase)mPluginsInfo.ModObjType.Assembly.CreateInstance(mPluginsInfo.ModObjType.FullName);
                NewObjBase.ModInfo.Plugin = mPluginsInfo.Name;
                int index = mObjBase.FindIndex(x => x.ModInfo.Name == ChangName) + 1;
                if (index >= 0 & isNext)
                {
                    AddModObj(NewObjBase, index);
                }
                else if (index >= 0 & !isNext)
                {
                    AddModObj(NewObjBase, index - 1);
                }
                else
                {
                    AddModObj(NewObjBase, -1);
                }

                if (mModParam.Plugin == "循环开始")
                {
                    mPluginsInfo = PluginToolService.mPluginDic["循环结束"];
                    NewObjBase = (ObjBase)mPluginsInfo.ModObjType.Assembly.CreateInstance(mPluginsInfo.ModObjType.FullName);
                    NewObjBase.ModInfo.Plugin = mPluginsInfo.Name;
                    AddModObj(NewObjBase, index + 1);
                }
                else if (mModParam.Plugin == "如果")
                {
                    mPluginsInfo = PluginToolService.mPluginDic["结束"];
                    NewObjBase = (ObjBase)mPluginsInfo.ModObjType.Assembly.CreateInstance(mPluginsInfo.ModObjType.FullName);
                    NewObjBase.ModInfo.Plugin = mPluginsInfo.Name;
                    NewObjBase.ModInfo.Remarks = "双击添加条件";
                    AddModObj(NewObjBase, index + 1);
                }
                ChangeEvent();
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            GerInfoList();
        }

        /// <summary>
        /// 删除模块-模块名称
        /// </summary>
        public void RemovMod(string RemovName)
        {
            try
            {
                bool falg = true;
                Sol.mProjSave = false;//解决方案未保存
                ObjBase ObjBaseInfo = null;
                if (RemovName.Contains("循环开始"))
                {
                    ObjBaseInfo = mObjBase.First(x => x.ModInfo.Name == RemovName);
                    mObjBase.Remove(ObjBaseInfo);
                    ObjBaseInfo = mObjBase.First(x => x.ModInfo.Name == "循环结束" + RemovName.Replace("循环开始", ""));
                    mObjBase.Remove(ObjBaseInfo);
                }
                else if (RemovName.Contains("如果"))
                {
                    int index = mObjBase.FindIndex(x => x.ModInfo.Name == RemovName);
                    ObjBaseInfo = mObjBase.First(x => x.ModInfo.Name == RemovName);
                    mObjBase.Remove(ObjBaseInfo);
                    while (falg)
                    {
                        ObjBase RemovObj = mObjBase[index];
                        if (RemovObj.ModInfo.Name.Contains("否则"))
                        {
                            mObjBase.Remove(RemovObj);
                        }
                        else if (RemovObj.ModInfo.Name.Contains("结束"))
                        {
                            mObjBase.Remove(RemovObj);
                            falg = false;
                        }
                        else
                        {
                            RemovObj = mObjBase[++index];
                        }
                    }
                }
                else
                {
                    mObjBase.Remove(mObjBase.FirstOrDefault(x => x.ModInfo.Name == RemovName));
                    mSloVar.Remove(mSloVar.FirstOrDefault(x => x.mModName == RemovName));
                }
                GerInfoList();
                ChangeEvent();
            }
            catch (Exception ex) { Log.Debug(ex.Message); }
        }

        /// <summary>
        /// 更新模块
        /// </summary>
        public void ChangeMod(ModInfo mModParam)
        {
            Sol.mProjSave = false;//解决方案未保存
            ObjBase data = mObjBase.FirstOrDefault(c => (c.ModInfo.Name == mModParam.Name));
            data.Enable = mModParam.Enable;
            GerInfoList();
            ChangeEvent();
        }

        /// <summary>
        /// 修改位置
        /// </summary>
        /// <param name="ChangName">模块名称</param>
        /// <param name="GoalName">目标位置的模块名称</param>
        /// <param name="isNext">是否在目标下方追加</param>
        public void ChangePos(string ChangName, string GoalName, bool isNext, ModFlowItem itemA, ModFlowItem itemB)
        {
            try
            {
                Sol.mProjSave = false;//解决方案未保存
                ObjBase ModInfo = mObjBase.First(x => x.ModInfo.Name == ChangName);
                if (ModInfo.ModInfo.Plugin == "条件分支" && !ModInfo.ModInfo.Name.StartsWith("如果"))// 
                {
                    Log.Warn("条件分支工具若要改动位置,请拖动对应的 <如果> 模块");
                    return;
                }
                if (ModInfo.ModInfo.Name.StartsWith("结束"))
                {
                    Log.Warn("条件结束不允许改变位置,若要改动位置,请拖动对应的 <否则>模块");
                    return;
                }
                if (ModInfo.ModInfo.Name.StartsWith("文件夹结束"))
                {
                    Log.Warn("文件夹结束不允许改变位置,若要改动位置,请拖动对应的 <文件夹>模块");
                    return;
                }

                List<string> nameMod = new List<string>();
                List<int> dataIndex = new List<int>();
                for (int i = 0; i < mObjBase.Count; i++)
                {
                    nameMod.Add(mObjBase[i].ModInfo.Name);
                }

                for (int i = 0; i < ModInfo.mSloVar.Count; i++)
                {
                    int idx = nameMod.FindIndex(x => x == mSloVar[i].mModName);
                    dataIndex.Add(idx);
                }

                int NewPos = mObjBase.FindIndex(x => x.ModInfo.Name == GoalName);
                int OldPos = mObjBase.FindIndex(x => x.ModInfo.Name == ChangName);
                int OrgPos = mObjBase.FindIndex(x => x.ModInfo.Name == "文件夹结束" + ChangName.Replace("文件夹", ""));
                if (ChangName.Contains("文件夹"))
                {
                    if (NewPos >= OrgPos)
                    {
                        Log.Warn("文件夹只能在文件夹结束前面,请拖动至对应位置 <文件夹>模块");
                        return;
                    }
                }

                NewPos = NewPos < OldPos ? ++NewPos : NewPos;
                mObjBase.Remove(ModInfo); //ToDo:模块位置变更-原位删除
                mObjBase.Insert(NewPos, ModInfo);//ToDo:模块位置变更-新位插入

                //更新数据信息
                DataCell dataCell = ModInfo.mSloVar.Find(x => x.mModName == ChangName);
                int oldIndex = ModInfo.mSloVar.FindIndex(x => x.mModName == ChangName);
                int aimIndex = ModInfo.mSloVar.FindIndex(x => x.mModName == GoalName);

                if (oldIndex != -1)
                {
                    if (aimIndex != -1)
                    {
                        aimIndex = aimIndex < oldIndex ? ++aimIndex : aimIndex;
                        ModInfo.mSloVar.RemoveAt(oldIndex);
                        ModInfo.mSloVar.Insert(aimIndex, dataCell);
                    }
                    else
                    {
                        List<int> assem = dataIndex.FindAll(x => x < NewPos);
                        ModInfo.mSloVar.RemoveAt(oldIndex);
                        ModInfo.mSloVar.Insert(assem.Max(), dataCell);
                    }
                }

                GerInfoList();
                ChangeEvent();
            }
            catch { }
        }

        /// <summary>
        /// 获取所有模块名称
        /// </summary>
        public List<string> GetObjBaseList()
        {
            return mObjBase.Select(c => c.ModInfo.Name).ToList();
        }

        /// <summary>
        /// 根据名称获取模块
        /// </summary>
        public ObjBase GetObjBase(string Name)
        {
            return mObjBase.FirstOrDefault(c => c.ModInfo.Name == Name);
        }

        /// <summary>
        /// 根据索引获取模块
        /// </summary>
        public ObjBase GetObjBase(int index)
        {
            return mObjBase.FirstOrDefault(c => c.ModInfo.Encode == index);
        }

        /// <summary>
        /// 还原模块数据
        /// </summary>
        public void RecoverObjBase(ObjBase backModObjBase)
        {
            if (mObjBase.Count > 0)
            {
                int index = mObjBase.FindIndex(c => c.ModInfo.Encode == backModObjBase.ModInfo.Encode);
                mObjBase[index] = backModObjBase;
            }
        }

        /// <summary>
        /// 模块修改事件
        /// </summary>
        [field: NonSerialized]
        public event EventHandler<EventArgs> mChangeEvent;

        /// <summary>
        /// 触发模块事件 
        /// </summary>
        public void ChangeEvent()
        {
            mChangeEvent?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// 获取模块信息列表
        /// </summary>
        public void GerInfoList()
        {
            if (mModInfo == null)
            {
                mModInfo = new List<ModInfo>();
            }
            mModInfo.Clear();
            foreach (ObjBase mbase in mObjBase)
            {
                mModInfo.Add(mbase.ModInfo);
            }
        }

        #endregion
    }
}
