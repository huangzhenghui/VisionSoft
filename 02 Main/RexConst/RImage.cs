using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Diagnostics;
using HalconDotNet;
using System.ComponentModel;
using System.Windows.Forms;
/// <summary>
/// 公有类型定义
/// </summary>
namespace RexConst
{
    [Serializable]
    public class RImage : HImage, ISerializable
    {
        #region 字段、属性

        /// <summary>
        /// 状态
        /// </summary>
        [Description("状态")]
        public bool Status = true;

        /// <summary> 
        /// 名称 
        /// </summary>
        [Description("名称")]
        public string Name = string.Empty;

        /// <summary>
        /// 窗体索引
        /// </summary>
        [Description("窗体索引")]
        public int Screen = 0;

        /// <summary>
        /// 图像宽度
        /// </summary>
        [Description("图像宽度")]
        public int Width = 1000;

        /// <summary>
        /// 图像高度
        /// </summary>
        [Description("图像高度")]
        public int Height = 1000;

        /// <summary> 
        /// X方向像素当量
        /// </summary>
        [Description("像素当量")]
        public double PixelPrec = 0.01;

        /// <summary>
        /// 显示的ROI
        /// </summary>
        [Description("ROI")]
        public List<HRoi> mHRoi = new List<HRoi>();

        /// <summary>
        /// 显示的信息
        /// </summary>
        [Description("显示信息")]
        public List<HText> mHText = new List<HText>();

        /// <summary> 
        /// 掩膜区域
        /// </summary>
        [Description("掩膜区域")]
        public HObject maskReg = new HObject();

        #endregion

        #region 构造函数

        public RImage() : base() { }
        public RImage(HObject obj) : base(obj){ }
        public RImage(string fileName) : base(fileName) { }
        public RImage(IntPtr key, bool copy) : base(key, copy) { }
        public RImage(string type, int width, int height, IntPtr pixelPointer) : base(type, width, height, pixelPointer) { }
        public RImage(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }
            this.PixelPrec = info.GetDouble("PixelPrec");
            this.Status = info.GetBoolean("Status");
            try
            {
                this.mHRoi = (List<HRoi>)info.GetValue("mHRoi", typeof(List<HRoi>));
                this.mHText = (List<HText>)info.GetValue("mHText", typeof(List<HText>));
            }
            catch{ }
        }

        #endregion

        #region 方法-图像相关

        ///<summary>序列化</summary>
        ///<param name="info"></param>
        ///<param name="context"></param>
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                if (info == null)
                {
                    throw new System.ArgumentNullException("info");
                }
                info.AddValue("ScaleY", PixelPrec);
                info.AddValue("Status", Status);
                info.AddValue("mHRoi", mHRoi);
                info.AddValue("mHText", mHText);
                HSerializedItem item = SerializeImage();//Himage 内部函数 反编译得到的
                byte[] buffer = item;
                item.Dispose();
                info.AddValue("data", buffer, typeof(byte[]));
            }
            catch{ }
        }

        /// <summary>
        /// 保存RImage
        /// </summary>
        public void SaveRImage(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            if (ext == ".he")
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    BinaryFormatter binaryFmt = new BinaryFormatter();
                    fs.Seek(0, SeekOrigin.Begin);
                    binaryFmt.Serialize(fs, this);
                }
            }
            else if (ext == "") //当没有传入有后缀的fileName,默认保存png magical 20170822
            {
                if (GetImageType().ToString().Contains("real"))
                {
                    this.WriteImage("tiff", 0, fileName);
                }
                else
                {
                    this.WriteImage("png best", 0, fileName);
                }
            }
            else
            {
                this.WriteImage(ext.Substring(1), 0, fileName);
            }
        }

        /// <summary>
        /// HImageToRImage
        /// </summary>
        public static RImage ToRImage(HObject image)
        {
            return new RImage(image);
        }

        /// <summary>
        /// 将图像由HObject格式转化为RImage
        /// </summary>
        /// <param name="hobject"></param>
        /// <param name="image"></param>
        public static void HObjToRImage(HObject hobject, ref RImage image)
        {
            HTuple pointer, type, width, height;
            HOperatorSet.GetImagePointer1(hobject, out pointer, out type, out width, out height);
            image.GenImage1(type, width, height, pointer);
        }

        /// <summary> 
        /// 从文件中获取RImage对象
        /// </summary>
        public static RImage ReadRImage(string fileName)
        {
            RImage ImgExt = null;
            try
            {
                if (Path.GetExtension(fileName).ToLower() == ".he")
                {
                    using (FileStream fs = new FileStream(fileName, FileMode.Open))//作为语句：用于定义一个范围，在此范围的末尾将释放对象。 请参阅 using 语句。 by:longteng
                    {
                        fs.Seek(0, SeekOrigin.Begin);
                        BinaryFormatter binaryFmt = new BinaryFormatter();
                        ImgExt = (RImage)binaryFmt.Deserialize(fs);
                    }
                }
                else
                {
                    ImgExt = ToRImage(new HImage(fileName));
                    ImgExt.Name = Path.GetFileName(fileName);
                }
                GC.Collect();
                return ImgExt;
            }
            catch (Exception ex)
            {
                return ImgExt;
            }
        }

        #endregion

        #region 方法-信息显示相关

        /// <summary>
        /// 在主界面图像窗口中显示ROI区域
        /// </summary>
        public void ShowHRoi(HRoi ROI)
        {
            try
            {
                int index = mHRoi.FindIndex(e => e.CellID == ROI.CellID && e.roiType == ROI.roiType && e.CellType == ROI.CellType);
                if (ROI.fors == true)
                {
                    mHRoi.Add(ROI);
                    return;
                }
                if (index > -1)
                    mHRoi[index] = ROI;
                else
                    mHRoi.Add(ROI);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 在主界面图像窗口中显示文本 
        /// </summary>
        public void ShowHText(HText text)
        {
            try
            {
                int index = mHText.FindIndex(e => e.CellType == text.CellType && e.roiType == text.roiType && e.CellType == text.CellType);
                if (text.fors == true)
                {
                    mHText.Add(text);
                    return;
                }
                if (index > -1)
                    mHText[index] = text;
                else
                    mHText.Add(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region 方法-深拷贝

        /// <summary>
        /// 深拷贝
        /// </summary>
        public new RImage Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                mHRoi = mHRoi.Where(c => c != null && (c.hobject == null || c.hobject.IsInitialized())).ToList();
                mHText = mHText.Where(c => c != null && (c.hobject == null || c.hobject.IsInitialized())).ToList();
                formatter.Serialize(stream, this);
                stream.Position = 0;
                return formatter.Deserialize(stream) as RImage;
            }
        }

        #endregion
    }
}
