namespace kütüphane
{
    partial class enter
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.id_box = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pw_box = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // id_box
            // 
            this.id_box.Depth = 0;
            this.id_box.Hint = "Enter Your ID";
            this.id_box.Location = new System.Drawing.Point(32, 199);
            this.id_box.MaxLength = 32767;
            this.id_box.MouseState = MaterialSkin.MouseState.HOVER;
            this.id_box.Name = "id_box";
            this.id_box.PasswordChar = '\0';
            this.id_box.SelectedText = "";
            this.id_box.SelectionLength = 0;
            this.id_box.SelectionStart = 0;
            this.id_box.Size = new System.Drawing.Size(279, 28);
            this.id_box.TabIndex = 0;
            this.id_box.TabStop = false;
            this.id_box.UseSystemPasswordChar = false;
            // 
            // pw_box
            // 
            this.pw_box.Depth = 0;
            this.pw_box.Hint = "Enter Your Pw";
            this.pw_box.Location = new System.Drawing.Point(30, 262);
            this.pw_box.MaxLength = 32767;
            this.pw_box.MouseState = MaterialSkin.MouseState.HOVER;
            this.pw_box.Name = "pw_box";
            this.pw_box.PasswordChar = '\0';
            this.pw_box.SelectedText = "";
            this.pw_box.SelectionLength = 0;
            this.pw_box.SelectionStart = 0;
            this.pw_box.Size = new System.Drawing.Size(281, 28);
            this.pw_box.TabIndex = 1;
            this.pw_box.TabStop = false;
            this.pw_box.UseSystemPasswordChar = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(241, 93);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(236, 63);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Welcome";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(30, 353);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 36);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "Enter";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(33, 306);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(0, 24);
            this.materialLabel2.TabIndex = 4;
            // 
            // enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 472);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pw_box);
            this.Controls.Add(this.id_box);
            this.Name = "enter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Automation";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField id_box;
        private MaterialSkin.Controls.MaterialSingleLineTextField pw_box;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}

