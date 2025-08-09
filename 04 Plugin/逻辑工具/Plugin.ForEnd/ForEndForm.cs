using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisionCore;

namespace Plugin.ForEnd
{
    public partial class ForEndForm: FormBase
    {

        private ForEndObj mObj ;


        public ForEndForm(ForEndObj Obj) : base(Obj)
        {
            mObj = Obj;
            InitializeComponent();
        }


        private void DelayModForm_Load(object sender, EventArgs e)
        {
            mObj = (ForEndObj)ObjBase;
        }

        public override void  FormToObj()
        {
        }
        public override void ObjToForm()
        {
        }
        public override void btn_Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void btn_Run_Click(object sender, EventArgs e)
        {
            mObj.RunObj();
        }
        public override void btn_Cancel_Click(object sender, EventArgs e)
        {
        }
    }
}
