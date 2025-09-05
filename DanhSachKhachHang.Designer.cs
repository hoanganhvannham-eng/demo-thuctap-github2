namespace ThuongMaiDienTu
{
    partial class DanhSachKhachHang
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
            this.dgvDSKH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbid = new System.Windows.Forms.TextBox();
            this.tbhoten = new System.Windows.Forms.TextBox();
            this.tbsodienthoai = new System.Windows.Forms.TextBox();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.dpkngaysinh = new System.Windows.Forms.DateTimePicker();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.cbloaikhachhang = new System.Windows.Forms.ComboBox();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSKH
            // 
            this.dgvDSKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKH.Location = new System.Drawing.Point(12, 297);
            this.dgvDSKH.Name = "dgvDSKH";
            this.dgvDSKH.RowHeadersWidth = 51;
            this.dgvDSKH.RowTemplate.Height = 24;
            this.dgvDSKH.Size = new System.Drawing.Size(776, 165);
            this.dgvDSKH.TabIndex = 1;
            this.dgvDSKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKH_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ho Ten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "So Dien Thoai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dia Chi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngay Sinh";
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(142, 46);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(200, 22);
            this.tbid.TabIndex = 8;
            // 
            // tbhoten
            // 
            this.tbhoten.Location = new System.Drawing.Point(142, 84);
            this.tbhoten.Name = "tbhoten";
            this.tbhoten.Size = new System.Drawing.Size(200, 22);
            this.tbhoten.TabIndex = 9;
            // 
            // tbsodienthoai
            // 
            this.tbsodienthoai.Location = new System.Drawing.Point(142, 120);
            this.tbsodienthoai.Name = "tbsodienthoai";
            this.tbsodienthoai.Size = new System.Drawing.Size(200, 22);
            this.tbsodienthoai.TabIndex = 10;
            // 
            // tbdiachi
            // 
            this.tbdiachi.Location = new System.Drawing.Point(142, 158);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(200, 22);
            this.tbdiachi.TabIndex = 11;
            // 
            // dpkngaysinh
            // 
            this.dpkngaysinh.Location = new System.Drawing.Point(142, 198);
            this.dpkngaysinh.Name = "dpkngaysinh";
            this.dpkngaysinh.Size = new System.Drawing.Size(200, 22);
            this.dpkngaysinh.TabIndex = 12;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(142, 245);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 13;
            this.btnthem.Text = "Them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(255, 245);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 14;
            this.btnsua.Text = "Sua";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(364, 245);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 15;
            this.btnxoa.Text = "Xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // cbloaikhachhang
            // 
            this.cbloaikhachhang.FormattingEnabled = true;
            this.cbloaikhachhang.Items.AddRange(new object[] {
            "1 – Khách vàng",
            "2 – Khách bạc",
            "3 – Khách đồng"});
            this.cbloaikhachhang.Location = new System.Drawing.Point(407, 46);
            this.cbloaikhachhang.Name = "cbloaikhachhang";
            this.cbloaikhachhang.Size = new System.Drawing.Size(201, 24);
            this.cbloaikhachhang.TabIndex = 16;
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(503, 245);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(75, 23);
            this.btnhienthi.TabIndex = 17;
            this.btnhienthi.Text = "Hiển Thị";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Location = new System.Drawing.Point(407, 152);
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(201, 22);
            this.tbtimkiem.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tim kiem theo ten";
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(407, 195);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(91, 23);
            this.btntimkiem.TabIndex = 20;
            this.btntimkiem.Text = "Tim Kiem";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // DanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbtimkiem);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.cbloaikhachhang);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dpkngaysinh);
            this.Controls.Add(this.tbdiachi);
            this.Controls.Add(this.tbsodienthoai);
            this.Controls.Add(this.tbhoten);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSKH);
            this.Name = "DanhSachKhachHang";
            this.Text = "DanhSachKhachHang";
            this.Load += new System.EventHandler(this.DanhSachKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbhoten;
        private System.Windows.Forms.TextBox tbsodienthoai;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.DateTimePicker dpkngaysinh;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.ComboBox cbloaikhachhang;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btntimkiem;
    }
}