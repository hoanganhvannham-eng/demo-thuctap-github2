using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms
namespace ThuongMaiDienTu
{
    public partial class BaoCaoKhachHang: Form
    {
        string constr = "Data Source=DESKTOP-10V42VO\\SQLEXPRESS;Initial Catalog=ThuongMaiDienTu;Integrated Security=True";

        public BaoCaoKhachHang()
        {
            InitializeComponent();
        }

        private void BaoCaoKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }
        void LoadKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();
                string query = @"SELECT 
                                        Id,
                                        HoTen,
                                        SoDienThoai,
                                        DiaChi,
                                        NgaySinh,
                                        DATEDIFF(YEAR, NgaySinh, GETDATE()) AS Tuoi
                                    FROM 
                                        KhachHang
                                    ORDER BY 
                                        Tuoi ASC;
                                    ";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvbaocaokhachhang.DataSource = dt;
            }
        }
    }
}
