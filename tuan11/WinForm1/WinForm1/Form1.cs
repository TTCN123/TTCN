namespace WinForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Kiểm tra thông tin đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Text;

            // Kiểm tra tên đăng nhập và mật khẩu
            if (username == "admin" && password == "123456")
            {
                MessageBox.Show("Đăng nhập thành công!");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        // Kiểm tra thông tin đăng kí
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsernameRegister.Text;
            string password = txtPasswordRegister.Text;
            string confirmPassword = txtConfirmPasswordRegister.Text;

            // Kiểm tra mật khẩu xác nhận
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không khớp!");
            }
            else
            {
                // Lưu thông tin đăng kí
                // ...
                MessageBox.Show("Đăng kí thành công!");
            }
        }
// Kiểm tra thông tin đăng nhập
private void btnLogin_Click(object sender, EventArgs e)
{
    string username = txtUsernameLogin.Text;
    string password = txtPasswordLogin.Text;

    // Kiểm tra tên đăng nhập và mật khẩu
    if (username == "admin" && password == "123456")
    {
        MessageBox.Show("Đăng nhập thành công!");
    }
    else
    {
        MessageBox.Show("Đăng nhập thất bại!");
    }
}

// Kiểm tra thông tin đăng kí

