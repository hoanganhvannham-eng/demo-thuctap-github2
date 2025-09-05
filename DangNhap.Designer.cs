namespace ThuongMaiDienTu
{
    partial class DangNhap
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
            this.tbusename = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbusename
            // 
            this.tbusename.Location = new System.Drawing.Point(296, 119);
            this.tbusename.Name = "tbusename";
            this.tbusename.Size = new System.Drawing.Size(154, 22);
            this.tbusename.TabIndex = 0;
            // 
            // tbpassword
            // 
            this.tbpassword.AccessibleName = "*";
            this.tbpassword.Location = new System.Drawing.Point(296, 166);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.Size = new System.Drawing.Size(154, 22);
            this.tbpassword.TabIndex = 1;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(233, 298);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(92, 23);
            this.btndangnhap.TabIndex = 2;
            this.btndangnhap.Text = "dang nhap";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(414, 298);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(85, 23);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoat";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbusename);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbusename;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button btnthoat;
    }
}