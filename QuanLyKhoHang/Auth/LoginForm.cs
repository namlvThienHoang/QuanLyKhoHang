using QuanLyKhoHang.Auth;
using QuanLyKhoHang.BLL.Auth;
using QuanLyKhoHang.DAL;
using QuanLyKhoHang.DAL.Base;
using System;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService;
        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService(new GenericRepository<User>(new QuanLyKhoHangContext()));

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;
            var user = _authService.Login(username, password);
            // Kiểm tra username và password (giả sử một cơ chế xác thực đơn giản)
            if (user != null)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Close();
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sai tên người dùng hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Mở form đăng ký
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Close();
        }

        private void ckbHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            // Đổi chế độ hiển thị mật khẩu
            txtMatKhau.UseSystemPasswordChar = !ckbHienThiMatKhau.Checked;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
