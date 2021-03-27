using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
	

namespace kütüphane
{
    public partial class Error_msg : MaterialForm
    {
        public Error_msg()
        {
            InitializeComponent();
        }

        private void Error_msg_Load(object sender, EventArgs e)
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

        }
       

        public string Message
        {
            get { return lbl_message.Text; }
            set { lbl_message.Text = value; }
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
