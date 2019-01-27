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
    public partial class RegisterForm : Form
    {
        AppUserOperation appuserOperation;
        public RegisterForm()
        {
            appuserOperation = new AppUserOperation();
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userNameTbx.Text) && string.IsNullOrEmpty(passwordTbx.Text)&&string.IsNullOrEmpty(emailTbx.Text))
            {
                MessageBox.Show("Boş Alanları Doldurun");
            }
            else
            {
             if (!appuserOperation.GetAnyUser(userNameTbx.Text))
                {
                    appuserOperation.InsertAppUser(emailTbx.Text, userNameTbx.Text, passwordTbx.Text);
                    MessageBox.Show("Başarı İle Kayıt Oldunuz Lütfen Giriş Yapınız");

                    HomeForm form = new HomeForm();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Böyle Bir Kullanıcı Bulunmakta Başka Bir Kullanıcı Adı Deneyiniz");
                }
            }
        }
    }
}
