using MaterialSkin;
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
using System.Data.SqlClient;
using Dapper;
namespace kütüphane
{
    class Data_Base_Prosess
    {
        
        public SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-58TIN5I;Initial Catalog=library;Integrated Security=True");
        public SqlCommand sqlCommand;




        public bool Entery_Personel(string id,string pw) {
            
            
            SqlDataReader dataReader;           
            try
            {
                
                 sqlConnection.Open();                 
                 sqlCommand = new SqlCommand("select * from personel where id=@q1 and pw=@q2 ",sqlConnection);
                 sqlCommand.Parameters.AddWithValue("@q1", id);
                 sqlCommand.Parameters.AddWithValue("@q2", pw);
                 dataReader = sqlCommand.ExecuteReader();              
                if (dataReader.HasRows){                   
                    Personel_info.id = id;
                    Personel_info.pw = pw;
                 }
                sqlConnection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;  
            }
                  
           
        }


        public MaterialListView GetNotice(MaterialListView mlist) {
            
            sqlConnection.Open();
            try
            {
                var data = sqlConnection.Query<Notices>("select * from notices", sqlConnection);
                foreach (var item in data)
                {
                    ListViewItem listView = new ListViewItem(item.Notice_no.ToString());
                    listView.SubItems.Add(item.Id.ToString());
                    listView.SubItems.Add(item.Notice.ToString());
                    mlist.Items.Add(listView);
                }
                sqlConnection.Close();
                return mlist;
            }
            catch (Exception)
            {
                sqlConnection.Close();
                return mlist;
            }               
            
            
        }

        public bool SetNotice(string notice) {            
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-58TIN5I;Initial Catalog=library;Integrated Security=True");
            sqlConnection.Open();
            try
            {
                
                sqlCommand = new SqlCommand("insert into notices (id,notice) values(@q1,@q2)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@q1", Personel_info.id);
                sqlCommand.Parameters.AddWithValue("@q2", notice);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                       
                return true;                
            }
            catch (Exception)
            {
                sqlConnection.Close();
                return false;
            }          
        }
        public ComboBox comboBoxadd_book_category_name(ComboBox comboBox)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = @"Data Source=DESKTOP-58TIN5I;Initial Catalog=library;Integrated Security=True";
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT category_name as xpr from category";
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                SqlDataReader dr;
                sqlConnection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    comboBox.Items.Add(dr["xpr"]);
                }
                sqlConnection.Close();
                return comboBox;
            }
            catch (Exception)
            {
                sqlConnection.Close();
                return null;
            }
           
        }

        public ComboBox comboBoxadd_library_no(ComboBox comboBox)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = @"Data Source=DESKTOP-58TIN5I;Initial Catalog=library;Integrated Security=True";
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT distinct(library_no) as xpr FROM book_library";
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;

                SqlDataReader dr;
                sqlConnection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    comboBox.Items.Add(dr["xpr"]);
                }
                sqlConnection.Close();


                return comboBox;
            }
            catch (Exception)
            {
                sqlConnection.Close();
                return null;             
            }
                      
        }

        public bool book_add(string isbn, string book_name, 
                             string release_date, string s_number,
                             string book_category,
                             string author_Name,string author_Surname,
                             string amount,string library_no)
        {           
            try
            {
                sqlConnection.Open();
                
                int library_no_int = Convert.ToInt32(library_no);                
                /// isbn
                /// library_no
                sqlCommand = new SqlCommand("SELECT category_no from category where category_name=@q1", sqlConnection);                
                sqlCommand.Parameters.AddWithValue("@q1", book_category);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                dr.Read();
                int category_no = Convert.ToInt32(dr["category_no"].ToString());
                ///category_no
                ///
                dr.Close();              
                sqlCommand.Parameters.Clear();   
                
                sqlCommand.CommandText = "SELECT author_no from authors where author_name=@q1 and author_surname=@q2";
                sqlCommand.Parameters.AddWithValue("@q1", author_Name);
                sqlCommand.Parameters.AddWithValue("@q2", author_Surname);
                dr = sqlCommand.ExecuteReader();              
                int author_no;
                sqlCommand.Parameters.Clear();                
                if (dr.HasRows)
                {
                    dr.Read();
                    author_no =Convert.ToInt32(dr["author_no"]);
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    sqlCommand.CommandText = "insert into authors (author_name,author_surname) values(@q1,@q2)";
                    sqlCommand.Parameters.AddWithValue("@q1", author_Name);
                    sqlCommand.Parameters.AddWithValue("@q2", author_Surname);
                    sqlCommand.ExecuteNonQuery();
                    sqlCommand.Parameters.Clear();
                    sqlCommand.CommandText = "SELECT author_no from authors where author_name=@q1 and author_surname=@q2";
                    sqlCommand.Parameters.AddWithValue("@q1", author_Name);
                    sqlCommand.Parameters.AddWithValue("@q2", author_Surname);
                    dr = sqlCommand.ExecuteReader();
                    author_no = Convert.ToInt32(dr.Read());
                    sqlCommand.Parameters.Clear();
                    dr.Close();
                }
                //
                sqlCommand.CommandText = "insert into book values(@q1,@q2,@q3,@q4)";
                sqlCommand.Parameters.AddWithValue("@q1", isbn);
                sqlCommand.Parameters.AddWithValue("@q2", book_name);
                sqlCommand.Parameters.AddWithValue("@q3", release_date);
                sqlCommand.Parameters.AddWithValue("@q4", s_number);
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Parameters.Clear();
                //                           
                sqlCommand.CommandText = "insert into book_authors values(@q1,@q2)";
                sqlCommand.Parameters.AddWithValue("@q1", isbn);
                sqlCommand.Parameters.AddWithValue("@q2", author_no);
                sqlCommand.ExecuteNonQuery();               
                sqlCommand.Parameters.Clear();
                //
                sqlCommand.CommandText = "insert into book_category values(@q1,@q2)";
                sqlCommand.Parameters.AddWithValue("@q1", isbn);
                sqlCommand.Parameters.AddWithValue("@q2", category_no);
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Parameters.Clear();
                //               
                sqlCommand.CommandText = "insert into book_library values(@q1,@q2,@q3)";
                sqlCommand.Parameters.AddWithValue("@q1",library_no_int);
                sqlCommand.Parameters.AddWithValue("@q2",isbn);
                sqlCommand.Parameters.AddWithValue("@q3",amount);
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Parameters.Clear();
                //

                sqlConnection.Close();
                return true;
            }
            catch (Exception)
            {
                sqlConnection.Close();
                return false;
            }
        }
        public MaterialListView book_search(string text, MaterialListView mlist)
        {
            
            try
            {
                sqlConnection.Open();
                
                text = "select book.isbn, book.book_name, book.release_date, book.s_number, category.category_name , book_library.library_no , authors.author_name from " +
                    " ((((( " +
                    "  book  inner join book_category on book.isbn=book_category.isbn) " +
                    "  inner join category on book_category.category_no=category.category_no) " +
                    "  inner join book_authors on book_authors.isbn=book.isbn) " +
                    "  inner join authors on book_authors.authors_no= authors.author_no)" +
                    "  inner join book_library on book_library.isbn= book.isbn) " +
                    "  where " + text;

               
                 
                var data = sqlConnection.Query<Book_src_information>(text, sqlConnection);
                foreach (var item in data)
                {
                    ListViewItem listView = new ListViewItem(item.isbn.ToString());
                    listView.SubItems.Add(item.book_name.ToString());
                    listView.SubItems.Add(item.release_date.ToString());
                    listView.SubItems.Add(item.s_number.ToString());
                    listView.SubItems.Add(item.category_name.ToString());
                    listView.SubItems.Add(item.library_no.ToString());
                    listView.SubItems.Add(item.author_name.ToString());                               
                    
                    mlist.Items.Add(listView);
                }
                sqlConnection.Close();
                return mlist;
            }
            catch (Exception)
            {
                sqlConnection.Close();
                return mlist;
            }
        }
        public string book_count(string isbn, string library_no)
        {
            int library_no_int = Convert.ToInt32(library_no);
            string value="";

            sqlCommand = new SqlCommand("select book_library.amount from book_library where book_library.isbn=@q1 and book_library.library_no=@q2", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@q1", isbn);
            sqlCommand.Parameters.AddWithValue("@q2", library_no_int);
            
            sqlConnection.Open();
            SqlDataReader dr = sqlCommand.ExecuteReader();
           
            if (dr.HasRows)
            {
                dr.Read();
                value = dr["amount"].ToString();
                sqlConnection.Close();
                return value;
                
            }
            sqlConnection.Close();
            return value;
        }
        public string diff(string isbn,string library_no)
        {
            int library_no_int = Convert.ToInt32(library_no);
            string value = "";
            try
            {
               
                sqlCommand = new SqlCommand("SELECT COUNT(*) as amount from loan where loan.receive_date is null and loan.library_no=" + library_no_int, sqlConnection);
                sqlConnection.Open();
                
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    value = dr["amount"].ToString();
                    sqlConnection.Close();
                    return value;

                }
                return value;
            }
            catch (Exception)
            {
                sqlConnection.Close();
                return value;
            }          

            
        }
        
        public bool loan_book(string isbn, string member_no,string library_no,bool choose)
        {
            Loan_book loan = new Loan_book();
            loan.Isbn_no = isbn;
            loan.Memeber_no = Convert.ToInt32(member_no);
            loan.Library_no = Convert.ToInt32(library_no);
            loan.Date = DateTime.Now;
            
            try
            {
                sqlConnection.Open();
                if (choose==true)
                {
                    sqlCommand = new SqlCommand("insert into loan (isbn_no,member_no,library_no,rent_date) values(@q1,@q2,@q3,@q4)", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@q1", loan.Isbn_no);
                    sqlCommand.Parameters.AddWithValue("@q2", loan.Memeber_no);
                    sqlCommand.Parameters.AddWithValue("@q3", loan.Library_no);
                    sqlCommand.Parameters.AddWithValue("@q4", loan.Date);                    
                    sqlCommand.ExecuteNonQuery();                   

                }
                else
                {
                   
                        sqlCommand = new SqlCommand("update loan set receive_date=@q1 where isbn_no=@q2 and member_no=@q3 and library_no=@q4 ", sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@q1", loan.Date);
                        sqlCommand.Parameters.AddWithValue("@q2", loan.Isbn_no);
                        sqlCommand.Parameters.AddWithValue("@q3", loan.Memeber_no);
                        sqlCommand.Parameters.AddWithValue("@q4", loan.Library_no);

                        sqlCommand.ExecuteNonQuery();
                  
           
                   
                }
                sqlConnection.Close();
                return true;


            }
            catch (Exception)
            {
                return false;
               
            }

        }
        public bool member_add(Members members)
        {
            try
            {
                               
                sqlCommand = new SqlCommand("insert into adress (street,apartment_number,zip_code,city,country) values (@q1,@q2,@q3,@q4,@q5)", sqlConnection);
                sqlConnection.Open();


                sqlCommand.Parameters.AddWithValue("@q1",members.Street);
                sqlCommand.Parameters.AddWithValue("@q2",members.Apartment_number);
                sqlCommand.Parameters.AddWithValue("@q3",members.Zip_code);
                sqlCommand.Parameters.AddWithValue("@q4",members.City);
                sqlCommand.Parameters.AddWithValue("@q5",members.Country);                
                sqlCommand.ExecuteNonQuery();                
                ///
                sqlCommand.CommandText = "select adress_no from adress where street=@q1 and apartment_number=@q2 and zip_code=@q3 and city=@q4 and country=@q5";
                SqlDataReader dr = sqlCommand.ExecuteReader();
                dr.Read();
                members.Adress_no =Convert.ToInt32(dr["adress_no"]);
                dr.Close();
                ///
                sqlCommand.Parameters.Clear();
                sqlCommand.CommandText = "insert into members values(@q1,@q2,@q3,@q4,@q5,@q6)";
                sqlCommand.Parameters.AddWithValue("@q1",members.Member_Name);
                sqlCommand.Parameters.AddWithValue("@q2",members.Member_Surname);
                sqlCommand.Parameters.AddWithValue("@q3",members.Gender);
                sqlCommand.Parameters.AddWithValue("@q4",members.Phone);
                sqlCommand.Parameters.AddWithValue("@q5",members.Email);
                sqlCommand.Parameters.AddWithValue("@q6",members.Adress_no);
                sqlCommand.ExecuteNonQuery();
                ///
                sqlCommand.CommandText = "select member_no from members where member_name=@q1 and member_surname=@q2 and gender=@q3 and phone=@q4 and email=@q5 and adress_no=@q6";
                dr = sqlCommand.ExecuteReader();
                dr.Read();
                members.Member_no = Convert.ToInt32(dr["member_no"]);
                dr.Close();
                ///
                sqlConnection.Close();
                return true; 
            }
            catch (Exception)
            {
                sqlConnection.Close();
                return false;
            }
            
        }
        public MaterialListView member_search(MaterialListView materialListView,Members members)
        {
            bool control = false;
            string txt="";
            string and = " and ";
            if (members.Member_no != 0)
            {
                if (control == true)
                {
                    txt = txt + and;
                }
                txt = txt + " member_no='" + members.Member_no + "'";
                control = true;
            }
            if (members.Member_Name!="")
            {
                if (control == true)
                {
                    txt = txt + and;
                }
                txt = txt + "member_name='" + members.Member_Name + "'";
                control = true;
            }
            if (members.Member_Surname != "")
            {
                if (control == true)
                {
                    txt = txt + and;
                }
                txt = txt + "member_surname='" + members.Member_Surname + "'";
                control = true;
            }
            if (members.Phone != "")
            {
                if (control == true)
                {
                    txt = txt + and;
                }
                txt = txt + "phone='" + members.Phone + "'";
                control = true;
            }
            if (members.Email != "")
            {
                if (control == true)
                {
                    txt = txt + and;
                }
                txt = txt + "email='" + members.Email + "'";
                control = true;
            }
            if (members.Adress_no != 0)
            {
                if (control == true)
                {
                    txt = txt + and;
                }
                txt = txt + "adress_no'" + members.Adress_no + "'";
                control = true;
            }
            txt = " select *  from members inner join adress on members.adress_no = adress.adress_no where " + txt;

            try
            {
                var data = sqlConnection.Query<Members>(txt, sqlConnection);
                foreach (var item in data)
                {
                    ListViewItem listView = new ListViewItem(item.Member_no.ToString());                    
                    listView.SubItems.Add(item.Phone);
                    listView.SubItems.Add(item.Email);                    
                    listView.SubItems.Add(item.Street);
                    listView.SubItems.Add(item.Apartment_number);
                    listView.SubItems.Add(item.Zip_code.ToString());
                    listView.SubItems.Add(item.City);
                    listView.SubItems.Add(item.Country);
                    listView.SubItems.Add(item.Adress_no.ToString());
                    materialListView.Items.Add(listView);
                }

                return materialListView;
            }
            catch (Exception)
            {

                return materialListView;
            }
        
        }
        public bool delete_member(int no)
        {

            try
            {
                sqlCommand = new SqlCommand("delete from members where member_no=@q1",sqlConnection);
                sqlCommand.Parameters.AddWithValue("@q1",no);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;            
            }

            

        }





    }
}

