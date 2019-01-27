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
    public partial class PasswordManagerDashboard : Form
    {
        PasswordManagerOperation passwordManagerOperation;
        public PasswordManagerDashboard()
        {
            passwordManagerOperation = new PasswordManagerOperation();
            InitializeComponent();
            GridReflesh();
        }

        private void AddPasswordBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SiteNameTbx.Text) && !string.IsNullOrEmpty(userNameTbx.Text) && !string.IsNullOrEmpty(passwordTbx.Text))
            {
                passwordManagerOperation.InsertData(SiteNameTbx.Text, userNameTbx.Text, passwordTbx.Text, UserHelper.UserId);
                MessageBox.Show("Başarı İle Kaydedildi");
                GridReflesh();
                SiteNameTbx.Text = string.Empty;
                userNameTbx.Text = string.Empty;
                passwordTbx.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Boş Alanları Doldurunuz");
            }
        }

        public void GridReflesh()
        {
            DataDg.DataSource = passwordManagerOperation.GetAllPasswordList(UserHelper.UserId);
            DataDg.Columns[1].HeaderText = "Site Adı";
            DataDg.Columns[3].HeaderText = "Kullanıcı Adı";
            DataDg.Columns[4].HeaderText = "Şifre";
            DataDg.Columns[0].Visible = false;
            DataDg.Columns[2].Visible = false;
            DataDg.Columns[5].Visible = false;
            DataDg.Columns[6].Visible = false;
            DataDg.Columns[7].Visible = false;

        }

        private void RemoveGridBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in DataDg.SelectedRows)  //Seçili Satırları Silme
            {
                int dataId = Convert.ToInt32(drow.Cells[0].Value);
                passwordManagerOperation.DeletePassword(dataId);
            }
            MessageBox.Show("Seçili Alanlar Silindi");
            GridReflesh();
            UpdatePasswordTbx.Text = string.Empty;
            UpdateUserNameTbx.Text = string.Empty;
            UpdateSiteNameTbx.Text = string.Empty;
        }

        private void UpdateDataBtn_Click(object sender, EventArgs e)
        {
            int dataId = 0;
            foreach (DataGridViewRow drow in DataDg.SelectedRows)  //Seçili Satırları Silme
            {
              dataId = Convert.ToInt32(drow.Cells[0].Value);
            }
            if (dataId > 0)
            {
                passwordManagerOperation.UpdateData(UpdateSiteNameTbx.Text, UpdateUserNameTbx.Text, UpdatePasswordTbx.Text, UserHelper.UserId, dataId);
                MessageBox.Show("Data Güncellendi");
            }
            else
            {
                MessageBox.Show("Satır Seçilmemiş");
            }
            GridReflesh();
        }

        private void DataDg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
         }

        private void DataDg_DoubleClick(object sender, EventArgs e)
        {
            int gridValue = 0;
            if (DataDg.SelectedRows.Count > 0)
            {
                gridValue = (int)DataDg.SelectedRows[0].Cells[0].Value;
            }
            Data.PasswordManager pwManager = passwordManagerOperation.GetPasswordManagerSelectedById(gridValue, UserHelper.UserId);
            if (pwManager != null)
            {
                UpdateUserNameTbx.Text = pwManager.UserName;
                UpdatePasswordTbx.Text = pwManager.Password;
                UpdateSiteNameTbx.Text = pwManager.SiteName;
            }
    }
    }
}
