using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManager.Bus;
using PasswordManager.Data;
namespace PasswordManager.WinForm
{
    public partial class HomeForm : Form
    {
        AppUserOperation appUserOperation;

        public HomeForm()
        {
            appUserOperation = new AppUserOperation();
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userNameTbx.Text)&&!(string.IsNullOrEmpty(passwordTbx.Text))){
               int userId= appUserOperation.GetLoginUser(userNameTbx.Text, passwordTbx.Text);
                if (userId == 0)
                {
                    MessageBox.Show("Şifreniz Yanlış Olabilir  Yada Hesabınız Pasif Listesinde Olabilir");
                }
                else
                {
                    UserHelper.UserId = userId;
                    PasswordManagerDashboard form = new PasswordManagerDashboard();
                    form.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("Girilmemiş Alanlar Bulunmakta");
            }
        }
    }
}
