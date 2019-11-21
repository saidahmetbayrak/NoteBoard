using NoteBoard.BLL;
using NoteBoard.Model;
using System;
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
    public partial class Login : Form
    {
        UserController _userController;
        public Login()
        {
            InitializeComponent();
           
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register frm = new Register();
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                User currentUser = _userController.GetByLogin(txtUserName.Text, txtPassword.Text);
                if (currentUser != null)
                {
                    if (currentUser.UserRole == UserRole.Standart)
                    {
                        Main frm = new Main(currentUser);
                        //Main ctor'undan user gönderecez
                        frm.Owner = this;
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        Admin frm = new Admin();
                        frm.Owner = this;
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı sisteme kayıtlı degil!");
            }   
          
        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            _userController = new UserController();
        }
    }
}
