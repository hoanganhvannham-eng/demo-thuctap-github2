using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuongMaiDienTu
{
    public partial class DanhSachKhachHang: Form
    {
        string constr = "Data Source=DESKTOP-10V42VO\\SQLEXPRESS;Initial Catalog=ThuongMaiDienTu;Integrated Security=True";
        public DanhSachKhachHang()
        {
            InitializeComponent();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (tbhoten.Text == "" || tbsodienthoai.Text == "" || cbloaikhachhang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO KhachHang (HoTen, SoDienThoai, DiaChi, NgaySinh, LoaiKH) VALUES (@ht, @sdt, @dc, @ns, @lkh)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ht", tbhoten.Text);
                    cmd.Parameters.AddWithValue("@sdt", tbsodienthoai.Text);
                    cmd.Parameters.AddWithValue("@dc", tbdiachi.Text);
                    cmd.Parameters.AddWithValue("@ns", dpkngaysinh.Value);
                    cmd.Parameters.AddWithValue("@lkh", cbloaikhachhang.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới thành công!");
                    LoadKhachHang();

                    //SqlParameter[] p = new SqlParameter[]
                    //{
                    //    new SqlParameter ("@ht", tbhoten.Text),
                    //    new SqlParameter ("@sdt", tbsodienthoai.Text),
                    //    new SqlParameter ("@dc", tbdiachi.Text),
                    //    new SqlParameter ("@ns", dpkngaysinh.Value),
                    //    new SqlParameter ("@lkh", cbloaikhachhang.SelectedValue)
                    //}
                    //cmd.Parameters.AddRange(p); 
                    //cmd.ExecuteNonQuery();
                    //MessageBox.Show("Thêm mới thành công!");
                    //LoadKhachHang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("loi " + ex.Message);
                }
                /*
                 SqlParameter[] p = new SqlParameter[]
                 {
                     new SqlParameter ("@ht", tbhoten.Text),
                     new SqlParameter ("@sdt", tbsodienthoai.Text),
                     new SqlParameter ("@dc", tbdiachi.Text),
                     new SqlParameter ("@ns", dpkngaysinh.Value),
                     new SqlParameter ("@lkh", cbloaikhachhang.SelectedValue)
                 };
                 cmd.Parameters.AddRange(p);
                 cmd.ExecuteNonQuery();
                 conn.Close();
                 MessageBox.Show("them thanh cong");
                 LoadData()*/
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra có chọn khách hàng chưa
                if (string.IsNullOrEmpty(tbid.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận trước khi cập nhật
                if (MessageBox.Show("Bạn có muốn cập nhật dữ liệu?", "Cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        string query = "UPDATE KhachHang SET HoTen=@ht, SoDienThoai=@sdt, DiaChi=@dc, NgaySinh=@ns, LoaiKH=@lkh WHERE Id=@id";
                        SqlCommand cmd = new SqlCommand(query, conn);

                        // Gán giá trị vào các tham số
                        cmd.Parameters.AddWithValue("@ht", tbhoten.Text);
                        cmd.Parameters.AddWithValue("@sdt", tbsodienthoai.Text);
                        cmd.Parameters.AddWithValue("@dc", tbdiachi.Text);
                        cmd.Parameters.AddWithValue("@ns", dpkngaysinh.Value);
                        cmd.Parameters.AddWithValue("@lkh", cbloaikhachhang.SelectedValue);
                        cmd.Parameters.AddWithValue("@id", tbid.Text);

                        // Thực thi lệnh cập nhật
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Cập nhật thành công!");
                        else
                            MessageBox.Show("Cập nhật thất bại, vui lòng kiểm tra lại!");

                        LoadKhachHang(); // load lại dữ liệu lên DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đã chọn khách hàng chưa
                if (string.IsNullOrEmpty(tbid.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xác nhận trước khi xóa
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(constr))
                    {
                        conn.Open();
                        string query = "DELETE FROM KhachHang WHERE Id=@id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", tbid.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Không tìm thấy khách hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        LoadKhachHang(); // Load lại danh sách
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void DanhSachKhachHang_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(constr);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LoaiKhachHang", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            cbloaikhachhang.DataSource = ds.Tables[0];
            cbloaikhachhang.DisplayMember = "TenLoaiKH";//Xác định cột nào của bảng dữ liệu sẽ được hiển thị lên ComboBox
            cbloaikhachhang.ValueMember = "Id";// Xác định cột nào là giá trị thực sự của từng item trong ComboBox
                                               //Khi bạn chọn "Khách bạc", comboBoxLoaiKhachHang.SelectedValue sẽ trả về 2
                                               //Khi bạn lấy comboBoxLoaiKhachHang.SelectedValue, nó sẽ trả về giá trị của cột Id ứng với mục bạn đang chọn
        }
        void LoadKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string query = @"SELECT KH.Id, KH.HoTen, KH.SoDienThoai, KH.DiaChi, KH.NgaySinh, LKH.TenLoaiKH 
                         FROM KhachHang KH 
                         LEFT JOIN LoaiKhachHang LKH ON KH.LoaiKH = LKH.Id";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDSKH.DataSource = dt;
            }
        }

        private void dgvDSKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                tbid.Text = dgvDSKH.Rows[i].Cells[0].Value.ToString();
                tbhoten.Text = dgvDSKH.Rows[i].Cells[1].Value.ToString();
                tbsodienthoai.Text = dgvDSKH.Rows[i].Cells[2].Value.ToString();
                tbdiachi.Text = dgvDSKH.Rows[i].Cells[3].Value.ToString();
                dpkngaysinh.Value = Convert.ToDateTime(dgvDSKH.Rows[i].Cells[4].Value);
                cbloaikhachhang.Text = dgvDSKH.Rows[i].Cells[5].Value.ToString();
            }
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = tbtimkiem.Text.Trim();  // Lấy nội dung ô tìm kiếm

                using (SqlConnection conn = new SqlConnection(constr))
                {
                    conn.Open();
                    string query;

                    // Nếu TextBox rỗng -> hiển thị toàn bộ khách hàng
                    if (string.IsNullOrEmpty(keyword))
                    {
                        query = "SELECT KhachHang.Id, HoTen, SoDienThoai, DiaChi, NgaySinh, LoaiKH, LoaiKhachHang.TenLoaiKH " +
                                "FROM KhachHang INNER JOIN LoaiKhachHang ON KhachHang.LoaiKH = LoaiKhachHang.Id";
                    }
                    else
                    {
                        query = "SELECT KhachHang.Id, HoTen, SoDienThoai, DiaChi, NgaySinh, LoaiKH, LoaiKhachHang.TenLoaiKH " +
                                "FROM KhachHang INNER JOIN LoaiKhachHang ON KhachHang.LoaiKH = LoaiKhachHang.Id " +
                                "WHERE HoTen LIKE @keyword";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvDSKH.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
