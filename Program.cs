using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuongMaiDienTu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            DangNhap loginForm = new DangNhap();
            if (loginForm.ShowDialog() == DialogResult.OK) // Nếu đăng nhập thành công
            {
                Application.Run(new Form1());
            }
        }
    }
}
