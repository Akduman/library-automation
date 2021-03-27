namespace kütüphane
{
    partial class Ok_msg
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
            this.btn_yes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_message = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btn_yes
            // 
            this.btn_yes.Depth = 0;
            this.btn_yes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_yes.Location = new System.Drawing.Point(111, 168);
            this.btn_yes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Primary = true;
            this.btn_yes.Size = new System.Drawing.Size(123, 39);
            this.btn_yes.TabIndex = 4;
            this.btn_yes.Text = "Ok";
            this.btn_yes.UseVisualStyleBackColor = true;
            // 
            // lbl_message
            // 
            this.lbl_message.Depth = 0;
            this.lbl_message.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_message.Location = new System.Drawing.Point(12, 83);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbl_message.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(318, 68);
            this.lbl_message.TabIndex = 3;
            this.lbl_message.Text = "Message";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ok_msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 250);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.lbl_message);
            this.Name = "Ok_msg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ok_msg";
            this.Load += new System.EventHandler(this.Ok_msg_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btn_yes;
        private MaterialSkin.Controls.MaterialLabel lbl_message;
    }
}