using System;
using NoteBoard.BLL;
using NoteBoard.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBoard.UI
{
    public partial class ResetPassword : Form
    {
        PasswordController _passwordController;
        Password _pass;
        public ResetPassword(Password pass)
        {
            InitializeComponent();
            _passwordController = new PasswordController();
            _pass = pass;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtOldPass.Text != _pass.PasswordText)
            {
                MessageBox.Show("Sifreniz yalnış!");
                return;
            }
            else if (txtNewPass.Text != txtNewPassA.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor!");
                return;
            }
            Password newPassword = new Password();
            newPassword.PasswordText = txtNewPass.Text;
            newPassword.UserID = _pass.UserID;

            try
            {
                bool result = _passwordController.Add(newPassword);
                if (result)
                {
                    MessageBox.Show("Şifre güncellendi");
                }
                else
                {
                    MessageBox.Show("Şifre güncellenmedi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void ResetPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
