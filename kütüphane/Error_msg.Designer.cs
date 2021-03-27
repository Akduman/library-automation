namespace kütüphane
{
    partial class Error_msg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_message = new MaterialSkin.Controls.MaterialLabel();
            this.btn_yes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_no = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lbl_message
            // 
            this.lbl_message.Depth = 0;
            this.lbl_message.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_message.Location = new System.Drawing.Point(12, 77);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbl_message.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(318, 68);
            this.lbl_message.TabIndex = 0;
            this.lbl_message.Text = "Message";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_message.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // btn_yes
            // 
            this.btn_yes.Depth = 0;
            this.btn_yes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_yes.Location = new System.Drawing.Point(34, 161);
            this.btn_yes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Primary = true;
            this.btn_yes.Size = new System.Drawing.Size(123, 39);
            this.btn_yes.TabIndex = 1;
            this.btn_yes.Text = "Yes";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btn_no
            // 
            this.btn_no.Depth = 0;
            this.btn_no.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_no.Location = new System.Drawing.Point(184, 161);
            this.btn_no.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_no.Name = "btn_no";
            this.btn_no.Primary = true;
            this.btn_no.Size = new System.Drawing.Size(125, 39);
            this.btn_no.TabIndex = 2;
            this.btn_no.Text = "No";
            this.btn_no.UseVisualStyleBackColor = true;
            // 
            // Error_msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 250);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.lbl_message);
            this.Name = "Error_msg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error_msg";
            this.Load += new System.EventHandler(this.Error_msg_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_message;
        private MaterialSkin.Controls.MaterialRaisedButton btn_yes;
        private MaterialSkin.Controls.MaterialRaisedButton btn_no;
    }
}