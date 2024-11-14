using QuanLyKhoHang.BLL.Auth;
using QuanLyKhoHang.DAL;
using QuanLyKhoHang.DAL.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang.Auth
{
    public partial class RegisterForm : Form
    {
        private readonly AuthService _authService;
        public RegisterForm()
        {
            InitializeComponent();
            _authService = new AuthService(new GenericRepository<User>(new QuanLyKhoHangContext()));

        }


        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;
            string confirmPassword = txtNhapLaiMatKhau.Text;

            // Kiểm tra các trường nhập liệu
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không khớp. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_authService.Register(username, password))
            {
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close(); // Đóng form đăng ký sau khi hoàn tất
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void ckbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            // Đổi chế độ hiển thị mật khẩu
            txtMatKhau.UseSystemPasswordChar = !ckbHienThiMatKhau.Checked;
            txtNhapLaiMatKhau.UseSystemPasswordChar = !ckbHienThiMatKhau.Checked;
        }

        private void btnDangNhapForm_Click(object sender, EventArgs e)
        {
            // Tạo một instance của form đăng nhập
            LoginForm loginForm = new LoginForm();

            // Hiển thị form đăng nhập
            loginForm.Show();
            this.Close();
        }
    }
}
