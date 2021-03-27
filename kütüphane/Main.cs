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
using MaterialSkin.Animations;

namespace kütüphane
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
           
        }
        Data_Base_Prosess data_base = new Data_Base_Prosess();
        private void Main_Load(object sender, EventArgs e)
        {
            materialListView1 = data_base.GetNotice(materialListView1);
            comboBox1 = data_base.comboBoxadd_library_no(comboBox1);
            comboBox2 = data_base.comboBoxadd_book_category_name(comboBox2);
            comboBox3 = data_base.comboBoxadd_library_no(comboBox3);
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
          
            if (data_base.SetNotice(materialSingleLineTextField1.Text)==true)
            {
                MaterialMessageBox.Show("Succesfull","Notice",MessageBoxButtons.OK);
            }
            else
            {
                MaterialMessageBox.Show("Unsuccesfull", "Notice", MessageBoxButtons.OK);
            }
            materialListView1 = data_base.GetNotice(materialListView1);
            materialSingleLineTextField1.Clear();

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
         
        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_2(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
           bool result=data_base.book_add(
                materialSingleLineTextField2.Text,materialSingleLineTextField3.Text,
                materialSingleLineTextField4.Text,materialSingleLineTextField5.Text, 
                comboBox2.SelectedItem.ToString(),materialSingleLineTextField7.Text,
                materialSingleLineTextField8.Text,materialSingleLineTextField6.Text,
                comboBox1.SelectedItem.ToString());
            if (result==true)
            {
                MaterialMessageBox.Show("basarılı","basarılı",MessageBoxButtons.OK);
            }
            else
            {
                MaterialMessageBox.Show("basarısız", "basarısız", MessageBoxButtons.OK);
            }




        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            
            string isbn = src_isbn.Text.Trim();
            string book_name = Search.Text.Trim();
            string release_date = src_date.Text.Trim();
            string s_number = src_s.Text.Trim();
            bool control = false;
            string text="";
            string or = " or ";
           
            if (isbn != "")
            {
                if (control == true)
                {
                    text =   text + or ;                                      
                }              
                text = text + " book.isbn='" + isbn + "'";
                control = true;
            }         

            if (book_name != "")
            {
                if (control == true)
                {
                    text = text + or ;
                    control = true;
                }
                 text = text + "  book.book_name like '%" + book_name + "%'";                                                  
            }            

            if (release_date != "")
            {
                if (control == true)
                {
                    text = text + or;
                    control = true;
                }
                text = text + "  book.release_date='" + release_date + "'";
            }       


            if (s_number != "")
            {
                if (control==true)
                {
                    text = text + or;
                    control = true;
                }
                text = text + "  s_number='" + s_number + "'";

            }
            materialListView2.Items.Clear();
            materialListView2 =data_base.book_search(text,materialListView2);
          
        }
        

        private void materialSingleLineTextField9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {            
                      
        }

        private void materialLabel10_Click(object sender, EventArgs e)
        {

        }

        private void Isbn_txt_TextChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                label_ba.Text = data_base.book_count(Isbn_txt.Text, comboBox3.SelectedItem.ToString());
              //  int result = Convert.ToInt32(data_base.diff(Isbn_txt.Text));
              //  materialLabel12.Text = ((Convert.ToInt32(materialLabel9.Text) - result)).ToString();
            }
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Isbn_txt.Text != "")
            {
                label_ba.Text = data_base.book_count(Isbn_txt.Text, comboBox3.SelectedItem.ToString());
                
            }
          // materialLabel9.Text = data_base.book_count(Isbn_txt.Text, comboBox3.SelectedItem.ToString());
        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {
            label_ba.Text = data_base.book_count(Isbn_txt.Text,comboBox3.SelectedItem.ToString());
        }

        private void materialLabel9_TextChanged(object sender, EventArgs e)
        {

            //resultlabel.Text = ((Convert.ToInt64(label_ba.Text)) - (Convert.ToInt64(materialLabel12))).ToString();


            

        }

        private void materialLabel12_Click(object sender, EventArgs e)
        {

        }

        private void ba(object sender, EventArgs e)
        {

        }

        private void label_ba_TextChanged(object sender, EventArgs e)
        {           
            try
            {
                materialLabel12.Text = (data_base.diff(Isbn_txt.Text,comboBox3.SelectedItem.ToString()));
            }
            catch (Exception)
            {

                materialLabel12.Text = "";
            }
              
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
           
           bool result=data_base.loan_book(Isbn_txt.Text,member_txt.Text,comboBox3.SelectedItem.ToString(),true);
            if (result==true)
            {
                MaterialMessageBox.Show("başarlı","başarılı",MessageBoxButtons.OK);
            }
            else
            {
                MaterialMessageBox.Show("başarısız", "başarısız", MessageBoxButtons.OK);
            }
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            bool result = data_base.loan_book(Isbn_txt.Text, member_txt.Text, comboBox3.SelectedItem.ToString(), false);
            if (result == true)
            {
                
                MaterialMessageBox.Show("başarlı", "başarılı", MessageBoxButtons.OK);
            }
            else
            {
                MaterialMessageBox.Show("başarısız", "başarısız", MessageBoxButtons.OK);
            }

        }

        private void Member_add_Click(object sender, EventArgs e)
        {
            Members members = new Members();
            if (materialRadioButton1.Checked)
            {
                members.Gender = "1";
            }
            else
            {
                members.Gender = "0";
            }
            
            members.Member_Name = m_n.Text;
            members.Member_Surname = m_s.Text;             
            members.Phone = m_p.Text;
            members.Email = m_e.Text;
            members.Street = a_s.Text;
            members.Apartment_number = a_ano.Text;
            members.Zip_code = Convert.ToInt32(a_z.Text);
            members.City = a_c.Text;
            members.Country = a_contry.Text;
            bool result = data_base.member_add(members);

            if (result == true)
            {
                MaterialMessageBox.Show("başarlı", "başarılı", MessageBoxButtons.OK);
             
            }
            else
            {
                MaterialMessageBox.Show("başarısız", "başarısız", MessageBoxButtons.OK);
            }          
        }

        private void materialRaisedButton4_Click_1(object sender, EventArgs e)
        {
            if ((data_base.delete_member(Convert.ToInt32(member_no.Text.ToString()))==true))
            {
                MaterialMessageBox.Show("başarılı", "başarılı", MessageBoxButtons.OK);
            }
            else
            {
                MaterialMessageBox.Show("başarısız", "başarısız", MessageBoxButtons.OK);
            }


        }

        private void materialRaisedButton8_Click_1(object sender, EventArgs e)
        {
            Members members = new Members();
            if (materialRadioButton1.Checked)
            {
                members.Gender = "1";
            }
            else
            {
                members.Gender = "0";
            }
            if (member_no.Text!="")
            {
                members.Member_no = Convert.ToInt32(member_no.Text.ToString());
            }            
            members.Member_Name = m_n.Text;
            members.Member_Surname = m_s.Text;
            members.Phone = m_p.Text;
            members.Email = m_e.Text;
            members.Street = a_s.Text;
            members.Apartment_number = a_ano.Text;
            if (a_z.Text!= "")
            {
                members.Zip_code = Convert.ToInt32(a_z.Text);
            }            
            members.City = a_c.Text;
            members.Country = a_contry.Text;
            materialListView4 = data_base.member_search(materialListView4, members);


        }

        private void materialListView4_MouseClick(object sender, MouseEventArgs e)
        {
            member_no.Text = materialListView4.SelectedItems[0].Text.ToString();

            /*  m_p.Text = m
             string a = materialListView4.SelectedItems[1].Text.ToString(); ;
             m_p.Text = a;
            // m_e.Text = materialListView4.SelectedItems[0].Text.ToString();
            a_s.Text = materialListView4.SelectedItems[3].Text.ToString();
             a_ano.Text = materialListView4.SelectedItems[4].Text.ToString();
             a_z.Text= materialListView4.SelectedItems[5].Text.ToString();
             a_c.Text= materialListView4.SelectedItems[6].Text.ToString();
             a_contry.Text = materialListView4.SelectedItems[7].Text.ToString();*/
        }

        private void materialListView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //delete
            //create view and trigger
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
           //update
           //create view and trigger

        }
    }
}
