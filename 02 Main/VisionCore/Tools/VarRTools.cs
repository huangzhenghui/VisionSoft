using System;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using HalconDotNet;
using RexConst;
using RexView;
using System.Runtime.InteropServices;
using RexHelps;
using System.Reflection;
using System.Text.RegularExpressions;
using System.IO;
using System.Text;
using System.ComponentModel;
using System.Threading;
using MutualTools;

namespace VisionCore
{
    public class Var
    {
        /// <summary>
        /// 获取图像
        /// </summary>
        /// <param name="inVar">模块列表</param>
        /// <param name="Name">图像名称</param>
        /// <returns></returns>
        public static object GetImage(List<DataCell> inVar, string Name)
        {
            try
            {
                object obj = new object();
                if (Name.Contains(":"))
                {
                    switch (Name.Split(':')[0].Substring(0, 4))
                    {
                        case "图像采集":
                            obj = ((CaptureImage_Info)inVar.FirstOrDefault(c => c.mModName == Name.Split(':')[0]).mDataValue).imageObj;
                            break;
                        case "图像增强":
                            obj = ((EmphasisImage_Info)inVar.FirstOrDefault(c => c.mModName == Name.Split(':')[0]).mDataValue).imageObj;
                            break;
                        case "灰度缩放":
                            obj = ((ScaleGray_Info)inVar.FirstOrDefault(c => c.mModName == Name.Split(':')[0]).mDataValue).imageObj;
                            break;
                        case "掩膜抠图":
                            obj = ((ReduceImage_Info)inVar.FirstOrDefault(c => c.mModName == Name.Split(':')[0]).mDataValue).imageObj;
                            break;
                        case "图像裁剪":
                            obj = ((CropImage_Info)inVar.FirstOrDefault(c => c.mModName == Name.Split(':')[0]).mDataValue).imageObj;
                            break;
                        case "边缘检测":
                            obj = ((EdgeDetection_Info)inVar.FirstOrDefault(c => c.mModName == Name.Split(':')[0]).mDataValue).imageObj;
                            break;
                        default:
                            break;
                    }
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 获取模块字段的值
        /// </summary>
        /// <param name="globalVar">全局变量</param>
        /// <param name="modVar">模块变量</param>
        /// <param name="Name">名称</param>
        /// <returns></returns>
        public static object GetLinkValue(List<DataCell> globalVar, List<DataCell> modVar, string Name)
        {
            DataCell dataCell = new DataCell();
            Object outputObj = new object();

            try
            {
                if (Name.Contains(":"))
                {
                    if (Name.Contains("全局变量"))
                    {
                        dataCell = globalVar.FirstOrDefault(c => c.mDataName == Name.Split(':')[1]);
                        return dataCell.mDataValue;
                    }
                    else if (Name.Contains("变量定义"))
                    {
                        dataCell = modVar.FirstOrDefault(c => c.mDataName == Name.Split(':')[1]);
                        return dataCell.mDataValue;
                    }
                    else
                    {
                        dataCell = modVar.FirstOrDefault(c => c.mModName == Name.Split(':')[0]);
                        DataMode dataMode = dataCell.mDataMode;
                        switch (dataMode)
                        {
                            case DataMode.图像采集:
                                outputObj = (CaptureImage_Info)dataCell.mDataValue;
                                break;
                            case DataMode.图像增强:
                                outputObj = (EmphasisImage_Info)dataCell.mDataValue;
                                break;
                            case DataMode.灰度缩放:
                                outputObj = (ScaleGray_Info)dataCell.mDataValue;
                                break;
                            case DataMode.边缘检测:
                                outputObj = (EdgeDetection_Info)dataCell.mDataValue;
                                break;
                            case DataMode.创建区域:
                                outputObj = (CreateROI_Info)dataCell.mDataValue;
                                break;
                            case DataMode.找圆工具:
                                outputObj=(FindCircle_Info)dataCell.mDataValue;
                                break;
                            case DataMode.找线工具:
                                outputObj = (FindLine_Info)dataCell.mDataValue;
                                break;
                            case DataMode.轮廓提取:
                                outputObj = (ContourExt_Info)dataCell.mDataValue;
                                break;
                            case DataMode.轮廓筛选:
                                outputObj = (ContourSel_Info)dataCell.mDataValue;
                                break;
                            case DataMode.创建模板:
                                outputObj = (CreateModel_Info)dataCell.mDataValue;
                                break;
                            case DataMode.查找模板:
                                outputObj = (FindModel_Info)dataCell.mDataValue;
                                break;
                            case DataMode.仿射变换:
                                outputObj = (AffineTrans_Info)dataCell.mDataValue;
                                break;
                            case DataMode.阈值分割:
                                outputObj = (ThresholdSeg_Info)dataCell.mDataValue;
                                break;
                            case DataMode.区域连通:
                                outputObj = (ConnectReg_Info)dataCell.mDataValue;
                                break;
                            case DataMode.区域填充:
                                outputObj = (FillUpReg_Info)dataCell.mDataValue;
                                break;
                            case DataMode.区域筛选:
                                outputObj = (RegionSel_Info)dataCell.mDataValue;
                                break;
                            case DataMode.区域处理:
                                outputObj = (ProcessReg_Info)dataCell.mDataValue;
                                break;
                            case DataMode.区域运算:
                                outputObj = (OperateReg_Info)dataCell.mDataValue;
                                break;
                            case DataMode.外接区域:
                                outputObj = (ExternalReg_Info)dataCell.mDataValue;
                                break;
                            case DataMode.内接区域:
                                outputObj = (InternalReg_Info)dataCell.mDataValue;
                                break;
                            case DataMode.区域信息:
                                outputObj = (RegionInfo_Info)dataCell.mDataValue;
                                break;
                            case DataMode.区域排序:
                                outputObj = (SortReg_Info)dataCell.mDataValue;
                                break;
                            case DataMode.形状转换:
                                outputObj = (ShapeTrans_Info)dataCell.mDataValue;
                                break;
                            case DataMode.等分矩形:
                                outputObj = (PartRectangle_Info)dataCell.mDataValue;
                                break;
                            case DataMode.对象选择:
                                outputObj = (HObjectSel_Info)dataCell.mDataValue;
                                break;
                            case DataMode.点点距离:
                                outputObj = (DistancePP_Info)dataCell.mDataValue;
                                break;
                            case DataMode.点线距离:
                                outputObj = (DistancePL_Info)dataCell.mDataValue;
                                break;
                            case DataMode.线线距离:
                                outputObj = (DistanceLL_Info)dataCell.mDataValue;
                                break;
                            case DataMode.线线交点:
                                outputObj = (IntersectLL_Info)dataCell.mDataValue;
                                break;
                            case DataMode.直线构建:
                                outputObj = (CreateLine_Info)dataCell.mDataValue;
                                break;
                            case DataMode.条件判断:
                                outputObj = (Judge_Info)dataCell.mDataValue;
                                break;
                            case DataMode.读一维码:
                                outputObj = (ReadBarcode_Info)dataCell.mDataValue;
                                break;
                            case DataMode.读二维码:
                                outputObj = (ReadQRCode_Info)dataCell.mDataValue;
                                break;
                            case DataMode.OCR识别:
                                outputObj = (OCR_Info)dataCell.mDataValue;
                                break;
                            case DataMode.元组工具:
                                outputObj = (HTupleTool_Info)dataCell.mDataValue;
                                break;
                            case DataMode.文件读取:
                                outputObj = (ReadFile_Info)dataCell.mDataValue;
                                break;
                            case DataMode.拟合圆弧:
                                outputObj = (FitCircle_Info)dataCell.mDataValue;
                                break;
                        }

                        FieldInfo[] fields = outputObj.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                        if (fields.Length <= 0)
                        {
                            return "";
                        }

                        foreach (FieldInfo item in fields)
                        {
                            string name = ClassRTools.GetFieldDescription(item);//名称
                            object value = item.GetValue(outputObj);//值

                            if (name == Name.Split(':')[1])
                            {
                                return value;
                            }
                        }
                    }
                }
                else
                {
                    Log.Error(Name + ": 查找名称错误！");
                }
            }
            catch
            {
                Log.Error(Name + ": 查找字段值失败！");
            }
            return null;
        }

        /// <summary>
        /// 列表获取连接数据（一行）
        /// </summary>
        /// <param name="Name">模块名称</param>
        /// <param name="DataName">数据名称</param>
        /// <returns></returns>
        public static string GetLinkData(List<DataCell> VarList, string NameMsg)
        {
            string Name = "", DataName = "", OutData = "0";
            if (!DataName.Contains(":"))
            {
                Name = NameMsg.Split(':')[0];
                DataName = NameMsg.Split(':')[1];
                OutData = Name + "|" + DataName + "|";
            }
            try
            {
                CaptureImage_Info captureImage_Info = new CaptureImage_Info();
                EmphasisImage_Info emphasisImage_Info = new EmphasisImage_Info();
                ScaleGray_Info scaleGray_Info = new ScaleGray_Info();
                ReduceImage_Info reduceImage_Info = new ReduceImage_Info();
                CropImage_Info cropImage_Info = new CropImage_Info();
                EdgeDetection_Info edgeDetection_Info = new EdgeDetection_Info();
                ContourExt_Info contourExt_Info = new ContourExt_Info();
                ContourSel_Info contourSel_Info = new ContourSel_Info();
                ROILine mROILine = new ROILine();
                DataCell mDataCell = new DataCell();
                HHomMat2D HomMat2D = new HHomMat2D();
                CreateROI_Info createROI_Info = new CreateROI_Info();
                Char_Info mChar_Info = new Char_Info();
                FindCircle_Info findCircle_Info = new FindCircle_Info();
                FindLine_Info findLine_Info = new FindLine_Info();
                CreateModel_Info createModel_Info = new CreateModel_Info();
                FindModel_Info findModel_Info = new FindModel_Info();
                ThresholdSeg_Info thresholdSeg_Info = new ThresholdSeg_Info();
                ConnectReg_Info connectReg_Info = new ConnectReg_Info();
                RegionSel_Info regionSel_Info = new RegionSel_Info();
                SortReg_Info sortReg_Info = new SortReg_Info();
                ProcessReg_Info processReg_Info = new ProcessReg_Info();
                OperateReg_Info operateReg_Info = new OperateReg_Info();
                ExternalReg_Info externalReg_Info = new ExternalReg_Info();
                InternalReg_Info internalReg_Info = new InternalReg_Info();
                FillUpReg_Info fillUpReg_Info = new FillUpReg_Info();
                RegionInfo_Info regionInfo_Info = new RegionInfo_Info();
                HObjectSel_Info hObjectSel_Info = new HObjectSel_Info();
                DistancePP_Info distancePP_Info = new DistancePP_Info();
                DistancePL_Info distancePL_Info = new DistancePL_Info();
                DistanceLL_Info distanceLL_Info = new DistanceLL_Info();
                IntersectLL_Info intersectLL_Info = new IntersectLL_Info();
                CreateLine_Info createLine_Info = new CreateLine_Info();
                Judge_Info judge_Info = new Judge_Info();
                ShapeTrans_Info shapeTrans_Info = new ShapeTrans_Info();
                PartRectangle_Info partRectangle_Info = new PartRectangle_Info();
                ReadFile_Info readFile_Info = new ReadFile_Info();
                FitCircle_Info fitCircle_Info = new FitCircle_Info();

                if (Name.Contains("全局变量"))
                {
                    mDataCell = VarList.First(c => c.mDataName.ToString() == DataName);
                    return OutData + mDataCell.mDataValue.ToString();
                }
                else if (Name.Contains("变量定义"))
                {
                    mDataCell = VarList.First(c => c.mModName == Name & c.mDataName == DataName);
                    return OutData += mDataCell.mDataValue;
                }

                mDataCell = VarList.First(c => c.mModName == Name);
                Dictionary<string, object> fieldList = null;
                switch (Name.Substring(0, 4))
                {
                    case "图像采集":
                        captureImage_Info = (CaptureImage_Info)mDataCell.mDataValue;
                        fieldList = GetFields(captureImage_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "图像增强":
                        emphasisImage_Info = (EmphasisImage_Info)mDataCell.mDataValue;
                        fieldList = GetFields(emphasisImage_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "灰度缩放":
                        scaleGray_Info = (ScaleGray_Info)mDataCell.mDataValue;
                        fieldList = GetFields(scaleGray_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "掩膜抠图":
                        reduceImage_Info = (ReduceImage_Info)mDataCell.mDataValue;
                        fieldList = GetFields(reduceImage_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "图像裁剪":
                        cropImage_Info = (CropImage_Info)mDataCell.mDataValue;
                        fieldList = GetFields(cropImage_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "边缘检测":
                        edgeDetection_Info = (EdgeDetection_Info)mDataCell.mDataValue;
                        fieldList = GetFields(edgeDetection_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "轮廓提取":
                        contourExt_Info = (ContourExt_Info)mDataCell.mDataValue;
                        fieldList = GetFields(contourExt_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "轮廓筛选":
                        contourSel_Info = (ContourSel_Info)mDataCell.mDataValue;
                        fieldList = GetFields(contourSel_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "对象选择":
                        hObjectSel_Info = (HObjectSel_Info)mDataCell.mDataValue;
                        fieldList = GetFields(hObjectSel_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "创建区域":
                        createROI_Info =(CreateROI_Info)mDataCell.mDataValue;
                        fieldList = GetFields(createROI_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "找圆工具":
                        findCircle_Info = (FindCircle_Info)mDataCell.mDataValue;
                        fieldList = GetFields(findCircle_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "找线工具":
                        findLine_Info = (FindLine_Info)mDataCell.mDataValue;
                        fieldList = GetFields(findLine_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "创建模板":
                        createModel_Info = (CreateModel_Info)mDataCell.mDataValue;
                        fieldList = GetFields(createModel_Info);
                        if (fieldList[DataName] != null)
                        {
                            if (fieldList[DataName].GetType().ToString().Contains("[]"))
                            {

                            }
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "查找模板":
                        findModel_Info = (FindModel_Info)mDataCell.mDataValue;
                        fieldList = GetFields(findModel_Info);
                        if (fieldList[DataName] != null)
                        {
                            string valueStr = "";
                            switch (fieldList[DataName].GetType().Name)
                            {
                                case "Double[]":
                                    if (((double[])fieldList[DataName]).Length > 0)
                                    {
                                        for (int i = 0; i < ((double[])fieldList[DataName]).Length; i++)
                                        {
                                            if (i != 0)
                                            {
                                                valueStr = valueStr + "," + ((double[])fieldList[DataName])[i].ToString();
                                            }
                                            else
                                            {
                                                valueStr = ((double[])fieldList[DataName])[i].ToString();
                                            }
                                        }
                                    }
                                    else
                                    {
                                        valueStr = "null";
                                    }
                                    OutData += valueStr;
                                    break;
                                default:
                                    OutData += fieldList[DataName].ToString();
                                    break;
                            }
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "阈值分割":
                        thresholdSeg_Info = (ThresholdSeg_Info)mDataCell.mDataValue;
                        fieldList = GetFields(thresholdSeg_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "区域连通":
                        connectReg_Info = (ConnectReg_Info)mDataCell.mDataValue;
                        fieldList = GetFields(connectReg_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "区域筛选":
                        regionSel_Info = (RegionSel_Info)mDataCell.mDataValue;
                        fieldList = GetFields(regionSel_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "区域填充":
                        fillUpReg_Info = (FillUpReg_Info)mDataCell.mDataValue;
                        fieldList = GetFields(fillUpReg_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "区域处理":
                        processReg_Info = (ProcessReg_Info)mDataCell.mDataValue;
                        fieldList = GetFields(processReg_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "区域运算":
                        operateReg_Info = (OperateReg_Info)mDataCell.mDataValue;
                        fieldList = GetFields(operateReg_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "外接区域":
                        externalReg_Info = (ExternalReg_Info)mDataCell.mDataValue;
                        fieldList = GetFields(externalReg_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "内接区域":
                        internalReg_Info = (InternalReg_Info)mDataCell.mDataValue;
                        fieldList = GetFields(internalReg_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "区域信息":
                        regionInfo_Info = (RegionInfo_Info)mDataCell.mDataValue;
                        fieldList = GetFields(regionInfo_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "区域排序":
                        sortReg_Info = (SortReg_Info)mDataCell.mDataValue;
                        fieldList = GetFields(sortReg_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "形状转换":
                        shapeTrans_Info = (ShapeTrans_Info)mDataCell.mDataValue;
                        fieldList = GetFields(shapeTrans_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "等分矩形":
                        partRectangle_Info = (PartRectangle_Info)mDataCell.mDataValue;
                        fieldList = GetFields(partRectangle_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "点点距离":
                        distancePP_Info = (DistancePP_Info)mDataCell.mDataValue;
                        fieldList = GetFields(distancePP_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "点线距离":
                        distancePL_Info = (DistancePL_Info)mDataCell.mDataValue;
                        fieldList = GetFields(distancePL_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "线线距离":
                        distanceLL_Info = (DistanceLL_Info)mDataCell.mDataValue;
                        fieldList = GetFields(distanceLL_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "线线交点":
                        intersectLL_Info = (IntersectLL_Info)mDataCell.mDataValue;
                        fieldList = GetFields(intersectLL_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "直线构建":
                        createLine_Info = (CreateLine_Info)mDataCell.mDataValue;
                        fieldList = GetFields(createLine_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "条件判断":
                        judge_Info = (Judge_Info)mDataCell.mDataValue;
                        fieldList = GetFields(judge_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "文件读取":
                        readFile_Info = (ReadFile_Info)mDataCell.mDataValue;
                        fieldList = GetFields(readFile_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    case "拟合圆弧":
                        fitCircle_Info = (FitCircle_Info)mDataCell.mDataValue;
                        fieldList = GetFields(findCircle_Info);
                        if (fieldList[DataName] != null)
                        {
                            OutData += fieldList[DataName].ToString();
                        }
                        else
                        {
                            OutData += "null";
                        }
                        break;
                    default:
                        OutData += mDataCell.mDataValue;
                        break;
                }
                return OutData;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return OutData;
            }
        }

        /// <summary>
        /// 获取类中的属性
        /// </summary>
        /// <returns>所有属性名称</returns>
        public List<string> GetProperties<T>(T t)
        {
            List<string> ListStr = new List<string>();
            if (t == null)
            {
                return ListStr;
            }
            PropertyInfo[] properties = t.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            if (properties.Length <= 0)
            {
                return ListStr;
            }
            foreach (PropertyInfo item in properties)
            {
                string name = item.Name; //名称
                object value = item.GetValue(t, null);  //值

                if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
                {
                    ListStr.Add(name);
                }
                else
                {
                    GetProperties(value);
                }
            }
            return ListStr;
        }

        /// <summary>
        /// 获取类中的字段,返回名称(描述)和值
        /// </summary>
        /// <returns>字段的名称和值</returns>
        public static Dictionary<string, object> GetFields<T>(T t)
        {
            Dictionary<string, object> ListStr = new Dictionary<string, object>();
            if (t == null)
            {
                return ListStr;
            }
            FieldInfo[] fields = t.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            if (fields.Length <= 0)
            {
                return ListStr;
            }
            foreach (FieldInfo item in fields)
            {
                string name = ClassRTools.GetFieldDescription(item);//名称
                object value = item.GetValue(t);//值
                ListStr.Add(name, value);
            }
            return ListStr;
        }

        /// <summary>
        ///  获取类中的字段，返回名称和类型
        /// </summary>
        /// <returns>字段的名称和类型</returns>
        public static Dictionary<string,object> GetField<T>(T t)
        {
            Dictionary<string, object> ListStr = new Dictionary<string, object>();
            if (t == null)
            {
                return ListStr;
            }
            FieldInfo[] fields = t.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            if (fields.Length <= 0)
            {
                return ListStr;
            }
            foreach (FieldInfo item in fields)
            {
                string name = ClassRTools.GetFieldDescription(item); //名称
                string type = item.FieldType.Name.Replace("`1","<T>");//类型
                switch (type)
                {
                    case "Int":
                        type.Replace('I', 'i');
                        break;
                    case "Int[]":
                        type.Replace('I', 'i');
                        break;
                    case "Double":
                        type.Replace('D', 'd');
                        break;
                    case "Double[]":
                        type.Replace('D', 'd');
                        break;
                    case "Bool":
                        type.Replace('B', 'b');
                        break;
                    case "Bool[]":
                        type.Replace('B', 'b');
                        break;
                    case "String":
                        type.Replace('S', 's');
                        break;
                    case "String[]":
                        type.Replace('S', 's');
                        break;
                }

                ListStr.Add(name.Replace("<", "").Replace(">", "").Replace("k__BackingField", ""), type);//因为获取到属性的格式是：<变量名>k__BackingField
            }
            return ListStr;
        }

        /// <summary>
        /// 获取值(HTuple)
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public static HTuple AcqValue_HTuple(string linkStr, List<DataCell> sysVar, List<DataCell> solVar)
        {
            HTuple outputObj = new HTuple();

            try
            {
                if (linkStr == null) return outputObj;

                if (linkStr.Contains(":"))
                {

                    object obj = GetLinkValue(sysVar, solVar, linkStr);
                    if (obj != null) outputObj = ((HTuple)(obj)).TupleNumber();
                }
                else
                {
                    if (TypeConvert.StringToHTuple(linkStr).TupleIsNumber() == 0) throw new Exception("异常");
                    outputObj = TypeConvert.StringToHTuple(linkStr);
                }
            }
            catch { }

            return outputObj;
        }

        /// <summary>
        /// 获取值(HObject)
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public static HObject AcqValue_HObject(string linkStr, List<DataCell> sysVar, List<DataCell> solVar)
        {
            HObject outputObj = new HObject();
            if (linkStr.Contains(":"))
            {
                object obj = GetLinkValue(sysVar, solVar, linkStr);
                if (obj != null) outputObj = (HObject)obj;
            }

            return outputObj;
        }
    }
}
