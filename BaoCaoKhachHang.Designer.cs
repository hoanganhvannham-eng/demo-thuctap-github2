namespace ThuongMaiDienTu
{
    partial class BaoCaoKhachHang
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
            this.dgvbaocaokhachhang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbaocaokhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbaocaokhachhang
            // 
            this.dgvbaocaokhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbaocaokhachhang.Location = new System.Drawing.Point(12, 144);
            this.dgvbaocaokhachhang.Name = "dgvbaocaokhachhang";
            this.dgvbaocaokhachhang.RowHeadersWidth = 51;
            this.dgvbaocaokhachhang.RowTemplate.Height = 24;
            this.dgvbaocaokhachhang.Size = new System.Drawing.Size(777, 295);
            this.dgvbaocaokhachhang.TabIndex = 0;
            // 
            // BaoCaoKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvbaocaokhachhang);
            this.Name = "BaoCaoKhachHang";
            this.Text = "BaoCaoKhachHang";
            this.Load += new System.EventHandler(this.BaoCaoKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbaocaokhachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbaocaokhachhang;
    }
}