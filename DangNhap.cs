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
    public partial class DangNhap: Form
    {
        string constr = "Data Source=DESKTOP-10V42VO\\SQLEXPRESS;Initial Catalog=ThuongMaiDienTu;Integrated Security=True";

        public DangNhap()
        {
            InitializeComponent();
        }

        public static string name = "";
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            string username = tbusename.Text.Trim();
            string password = tbpassword.Text.Trim();

            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM DangNhap WHERE TenDangNhap = @username AND MatKhau = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = (int)cmd.ExecuteScalar();
                conn.Close();

                if (count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    name = tbusename.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("ban co muon thoat khong??////////////????????????.", "tieu de thoat",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
