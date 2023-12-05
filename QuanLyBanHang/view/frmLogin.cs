using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using QuanLyBanHang.view;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace QuanLyBanHang
{
    public partial class frmLogin : Form
    {

        private bool isPasswordVisible = false;
        private bool isImageVisible = false;
        private List<UserData> account = new List<UserData>();

        public frmLogin()
        {
            InitializeComponent();
            account.Add(new UserData("admin", "123"));
        }

        public frmLogin(List<UserData> listUser) {
            InitializeComponent();
            this.account = listUser;
            account.Add(new UserData("admin", "123"));

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
          
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            UserData user = account.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
             
            {
                frmProduct frmProduct = new frmProduct(account);
                frmProduct.Show();
                this.Hide();
               MessageBox.Show("Đăng nhập thành công!");
       
                            
                
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra tên đăng nhập và mật khẩu.");
            }
        }
    
        private void lbCreate_Click(object sender, EventArgs e)
        {
            frmRegister frmreister = new frmRegister();
            //this.Hide();
            frmreister.Show();
           

        }

        private void picbClose_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void picEyeclose_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.PasswordChar = isPasswordVisible ? '*' : ' ';
            picEyeclose.Image = isPasswordVisible ? Properties.Resources.closed_eye : Properties.Resources.eye_open;
          
        
            if (!(txtPassword.UseSystemPasswordChar))
            {
                txtPassword.PasswordChar = '*';
                picEyeclose.Image = Properties.Resources.eye_open;
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                picEyeclose.Image = Properties.Resources.closed_eye;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_Forgort_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}
