﻿using NoteBoard.BLL;
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
    public partial class Register : Form
    {
        UserController _userController;
        public Register()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordA.Text)
            {
                MessageBox.Show("Sifreler eşleşmiyor!");
                return;
            }

            User newUser = new User();
            newUser.FirstName = txtName.Text;
            newUser.LastName = txtSurname.Text;
            newUser.UserName = txtUsername.Text;
            newUser.UserRole = UserRole.Standart;
            newUser.Passwords.Add(new Password()
            {
              PasswordText = txtPassword.Text
            });

            try
            {
              bool result = _userController.Add(newUser);
              if (result)
              {
                 MessageBox.Show("Kayıt başarılı.Kullanıcı onay süreciniz başladı.");
                 this.Close();
                 this.Owner.Show();
              }
            }
            catch (Exception)
            {
              throw;
            }
            
        }
    }
}
