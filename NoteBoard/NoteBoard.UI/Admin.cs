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
    public partial class Admin : Form
    {
        UserController _userController;
        UserRole _user;
        public Admin()
        {
            InitializeComponent();
            _userController = new UserController();
            _user = new UserRole();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            FillUser();
        }

        private void FillUser()
        {
            lstUsers.Items.Clear();
            List<User> allUser = _userController.GetAll();
            ListViewItem lvi;
            foreach (var item in allUser)
            {
                lvi = new ListViewItem(item.FirstName);
                lvi.SubItems.Add(item.LastName);
                lvi.SubItems.Add(item.UserName);
                lvi.SubItems.Add(item.IsActive ? "Aktif":"Pasif");
                lvi.Tag = item;
                lstUsers.Items.Add(lvi);
            }

        }

        private void lstUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstUsers.SelectedItems.Count>0)
            {
                ListViewItem selected = lstUsers.SelectedItems[0];
                User selectedUser = selected.Tag as User;
                if (selectedUser.UserRole != UserRole.Admin)
                {
                    if (selectedUser.IsActive==false)
                    {
                   
                        DialogResult result = MessageBox.Show("Bu kullanıcıyı onaylıyor musunuz ?", "Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            selectedUser.IsActive = true;
                            _userController.Update(selectedUser);
                            FillUser();
                        }
                    }
                    
                else
                {
                    DialogResult result = MessageBox.Show("Bu kullanıcıyı kara listeye almak istiyor musunuz ?", "Onay", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        selectedUser.IsActive = false;
                        _userController.Update(selectedUser);
                        FillUser();
                    }
                }
                }
                else
                {
                    MessageBox.Show("Admin üzerine islem yapılamaz!!");
                }
            }
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
