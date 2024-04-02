using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XeniaLauncher
{
    public partial class Update_available : Form
    {
        public Update_available()
        {
            InitializeComponent();
            if (Global.wichXenia==1) {
                //xenia canary
                stxt_wichxenia.Text = "There is an update to xenia Canary available";
            }
            if (Global.wichXenia == 0)
            {
                //xenia canary
                stxt_wichxenia.Text = "There is an update to xenia Master available";
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            up.ShowDialog();
            this.Close();
        }
    }
}
