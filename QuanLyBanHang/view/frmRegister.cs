using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            this.accounts = accounts;
        }
        private List<UserData> accounts;
        private string registerUsername;
        private string registerPassword;
        private bool isPasswordVisible = false;
        private void lbSignup_Click(object sender, EventArgs e)
        {
            frmLogin frmlogin = new frmLogin();
            this.Hide();
            frmlogin.Show();
        }

        private void closeFrm_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi ứng dụng?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaShowpass_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtNewPassword.PasswordChar = isPasswordVisible ? '*' : ' ';
            picEyeclose.Image = isPasswordVisible ? Properties.Resources.closed_eye : Properties.Resources.eye_open;


            if (!(txtNewPassword.UseSystemPasswordChar))
            {
                txtNewPassword.PasswordChar = '*';
                picEyeclose.Image = Properties.Resources.eye_open;
                txtNewPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtNewPassword.PasswordChar = '\0';
                picEyeclose.Image = Properties.Resources.closed_eye;
                txtNewPassword.UseSystemPasswordChar = false;
            }

        }
        private void PictureBoxPassword_Load(object sender, EventArgs e)
        {
            picEyeclose.Cursor = Cursors.Hand;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            UserData newcUser = new UserData();
            newcUser.Email = txtEmail.Text;
            newcUser.Username = txtNewUsername.Text;
            newcUser.Password = txtNewPassword.Text;
            var user = UserData.getAllUser();
            if (user.Find(u => string.Compare(u.Username, newcUser.Username) == 0) == null)
            {
                if (txtNewPassword.Text == txtPassagn.Text)
                {
                    user.Add(newcUser);
                    frmLogin lg = new frmLogin(user);
                    lg.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("password mismatch");
                }

                //string newUsername = "";
                //string newPassword = "";


                //if (txtNewUsername.Text != "")
                //{
                //    newUsername = txtNewUsername.Text;
                //}


                //if (txtNewPassword.Text != "")
                //{
                //    newPassword = txtNewPassword.Text;
                //}

                //accounts.Add(new UserData(newUsername, newPassword));
                //MessageBox.Show("Resgister success");
                //this.Close(); 
                //if(accounts != null && txtNewUsername != null && txtNewPassword != null)
                //if (txtNewUsername != null && txtNewPassword != null)
                //{
                //    string newUsername = txtNewUsername.Text.Trim();
                //    string newPassword = txtNewPassword.Text.Trim();

                //    if (!accounts.Any(u => u.Username == newUsername))
                //    {
                //        accounts.Add(new UserData(newUsername, newPassword));
                //        MessageBox.Show("Tạo tài khoản thành công!");
                //        this.Close();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
                //    }
                //}
            }

        }

    }

    
}
    

