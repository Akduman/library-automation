using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kütüphane
{

    public partial class Ok_msg : MaterialForm
    {
        public Ok_msg()
        {
            InitializeComponent();
        }
        public string Message
        {
            get { return lbl_message.Text; }
            set { lbl_message.Text = value; }
        }
        private void Ok_msg_Load(object sender, EventArgs e)
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }
    }
}
