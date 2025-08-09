using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisionCore.SolForm.FormR
{
    public delegate void DeliveryVal(string info);

    public partial class FrmModify : FormBase
    {
        #region 字段、属性

        /// <summary>
        /// 计时器
        /// </summary>
        public HTimer timerObj = new HTimer();

        /// <summary>
        /// 耗时
        /// </summary>
        public double costTime = 0;

        /// <summary>
        /// 传值委托字段
        /// </summary>
        public DeliveryVal deliveryVal;

        /// <summary>
        /// 类型
        /// </summary>
        public string type;

        #endregion

        #region 初始化

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="name"></param>
        /// <param name="deliveryVal"></param>
        public FrmModify(string name, DeliveryVal deliveryVal, string type)
        {
            InitializeComponent();
            lblModName.Text = name;
            this.deliveryVal = deliveryVal;
            this.type = type;
        }

        #endregion

        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btn_Run_Click(object sender, EventArgs e)
        {
            timerObj.Start(); // 启动计时器

            if (type=="名称")
            {
                if (tbxInfo.Text.Trim() == "")
                {
                    MessageBox.Show("模块名称不能为空！");
                }
                else
                {
                    deliveryVal.Invoke(tbxInfo.Text.Trim());
                }
            }
            else
            {
                deliveryVal.Invoke(tbxInfo.Text.Trim());
            }
           
            timerObj.Stop();  // 停止计时器 

            costTime = timerObj.GetMilliSecond;
            lblTime.Text = "耗时:" + costTime.ToString("F2") + "ms";
        }
    }
}
