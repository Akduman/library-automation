using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Data.SqlClient;
using System.Timers;



namespace kütüphane
{
    public partial class enter : MaterialForm
    {
        public enter()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

        }

        private void Form1_Load(object sender, EventArgs e)
        {                      
            
        }
        
        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Data_Base_Prosess data_base = new Data_Base_Prosess();         
         
            if (data_base.Entery_Personel(id_box.Text.ToString(), pw_box.Text.ToString())==true)
            {
              //  MaterialMessageBox.Show("Succesfull","Entry",MessageBoxButtons.OK);                
                Main main = new Main();
                this.Hide();
                main.Show();                              
            }
            else
            {
                materialLabel2.Text = "Your id or pw wrong";
            }          
        }
    }

}
