namespace PasswordManager.WinForm
{
    partial class PasswordManagerDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.SiteNameTbx = new System.Windows.Forms.TextBox();
            this.AddPasswordBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTbx = new System.Windows.Forms.TextBox();
            this.userNameTbx = new System.Windows.Forms.TextBox();
            this.DataDg = new System.Windows.Forms.DataGridView();
            this.RemoveGridBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateSiteNameTbx = new System.Windows.Forms.TextBox();
            this.UpdateDataBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UpdatePasswordTbx = new System.Windows.Forms.TextBox();
            this.UpdateUserNameTbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataDg)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Site Adı";
            // 
            // SiteNameTbx
            // 
            this.SiteNameTbx.Location = new System.Drawing.Point(151, 95);
            this.SiteNameTbx.Name = "SiteNameTbx";
            this.SiteNameTbx.Size = new System.Drawing.Size(100, 20);
            this.SiteNameTbx.TabIndex = 19;
            // 
            // AddPasswordBtn
            // 
            this.AddPasswordBtn.Location = new System.Drawing.Point(166, 186);
            this.AddPasswordBtn.Name = "AddPasswordBtn";
            this.AddPasswordBtn.Size = new System.Drawing.Size(75, 23);
            this.AddPasswordBtn.TabIndex = 18;
            this.AddPasswordBtn.Text = "Ekle";
            this.AddPasswordBtn.UseVisualStyleBackColor = true;
            this.AddPasswordBtn.Click += new System.EventHandler(this.AddPasswordBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // passwordTbx
            // 
            this.passwordTbx.Location = new System.Drawing.Point(151, 147);
            this.passwordTbx.Name = "passwordTbx";
            this.passwordTbx.Size = new System.Drawing.Size(100, 20);
            this.passwordTbx.TabIndex = 15;
            this.passwordTbx.UseSystemPasswordChar = true;
            // 
            // userNameTbx
            // 
            this.userNameTbx.Location = new System.Drawing.Point(151, 121);
            this.userNameTbx.Name = "userNameTbx";
            this.userNameTbx.Size = new System.Drawing.Size(100, 20);
            this.userNameTbx.TabIndex = 14;
            // 
            // DataDg
            // 
            this.DataDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDg.Location = new System.Drawing.Point(412, 36);
            this.DataDg.Name = "DataDg";
            this.DataDg.Size = new System.Drawing.Size(667, 330);
            this.DataDg.TabIndex = 21;
            this.DataDg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataDg_CellClick);
            this.DataDg.DoubleClick += new System.EventHandler(this.DataDg_DoubleClick);
            // 
            // RemoveGridBtn
            // 
            this.RemoveGridBtn.Location = new System.Drawing.Point(412, 399);
            this.RemoveGridBtn.Name = "RemoveGridBtn";
            this.RemoveGridBtn.Size = new System.Drawing.Size(139, 23);
            this.RemoveGridBtn.TabIndex = 22;
            this.RemoveGridBtn.Text = "Seçili Alanı Sil";
            this.RemoveGridBtn.UseVisualStyleBackColor = true;
            this.RemoveGridBtn.Click += new System.EventHandler(this.RemoveGridBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Listeden Seçtiğiniz Satırları  Silebilirsiniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Site Adı";
            // 
            // UpdateSiteNameTbx
            // 
            this.UpdateSiteNameTbx.Location = new System.Drawing.Point(96, 392);
            this.UpdateSiteNameTbx.Name = "UpdateSiteNameTbx";
            this.UpdateSiteNameTbx.Size = new System.Drawing.Size(100, 20);
            this.UpdateSiteNameTbx.TabIndex = 29;
            // 
            // UpdateDataBtn
            // 
            this.UpdateDataBtn.Location = new System.Drawing.Point(108, 484);
            this.UpdateDataBtn.Name = "UpdateDataBtn";
            this.UpdateDataBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateDataBtn.TabIndex = 28;
            this.UpdateDataBtn.Text = "Düzenle";
            this.UpdateDataBtn.UseVisualStyleBackColor = true;
            this.UpdateDataBtn.Click += new System.EventHandler(this.UpdateDataBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Şifre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Kullanıcı Adı:";
            // 
            // UpdatePasswordTbx
            // 
            this.UpdatePasswordTbx.Location = new System.Drawing.Point(96, 444);
            this.UpdatePasswordTbx.Name = "UpdatePasswordTbx";
            this.UpdatePasswordTbx.Size = new System.Drawing.Size(100, 20);
            this.UpdatePasswordTbx.TabIndex = 25;
            this.UpdatePasswordTbx.UseSystemPasswordChar = true;
            // 
            // UpdateUserNameTbx
            // 
            this.UpdateUserNameTbx.Location = new System.Drawing.Point(96, 418);
            this.UpdateUserNameTbx.Name = "UpdateUserNameTbx";
            this.UpdateUserNameTbx.Size = new System.Drawing.Size(100, 20);
            this.UpdateUserNameTbx.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Listeden  Çift Click İle  Satır  Seçiniz ";
            // 
            // PasswordManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 535);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpdateSiteNameTbx);
            this.Controls.Add(this.UpdateDataBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UpdatePasswordTbx);
            this.Controls.Add(this.UpdateUserNameTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RemoveGridBtn);
            this.Controls.Add(this.DataDg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SiteNameTbx);
            this.Controls.Add(this.AddPasswordBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTbx);
            this.Controls.Add(this.userNameTbx);
            this.Name = "PasswordManagerDashboard";
            this.Text = "PasswordManagerDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.DataDg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SiteNameTbx;
        private System.Windows.Forms.Button AddPasswordBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTbx;
        private System.Windows.Forms.TextBox userNameTbx;
        private System.Windows.Forms.DataGridView DataDg;
        private System.Windows.Forms.Button RemoveGridBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UpdateSiteNameTbx;
        private System.Windows.Forms.Button UpdateDataBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UpdatePasswordTbx;
        private System.Windows.Forms.TextBox UpdateUserNameTbx;
        private System.Windows.Forms.Label label8;
    }
}