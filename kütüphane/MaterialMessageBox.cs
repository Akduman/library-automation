using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace kütüphane
{
    class MaterialMessageBox
    {
        public static DialogResult Show(string message, string title, MessageBoxButtons button) {

            DialogResult result = DialogResult.None;
            switch (button)
            {
                case MessageBoxButtons.OK:
                    using (Ok_msg ok_Msg = new Ok_msg())
                    {
                        ok_Msg.Text = title;
                        ok_Msg.Message = message;
                        result = ok_Msg.ShowDialog();

                    }
                    break; 
                    
                case MessageBoxButtons.YesNo:
                    using (Error_msg error_Msg = new Error_msg())
                    {
                        error_Msg.Text = title;
                        error_Msg.Message = message;
                        result = error_Msg.ShowDialog();
                    }
                    break;                
                default:
                    break;
            }

           

            return result;



        }

    }
}
