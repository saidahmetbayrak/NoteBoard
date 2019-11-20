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
    public partial class Main : Form
    {
        PasswordController _passwordController;
        NoteController _noteController;
        User _user;
        public Main(User user)
        {
            InitializeComponent();
            _user = user;
            _noteController = new NoteController();
            _passwordController = new PasswordController();
        }

        private void lnkPassChange_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Password password = _passwordController.GetActivePassword(_user.UserID);
            ResetPassword frm = new ResetPassword(password);
            frm.Owner = this.Owner;
            frm.Show();
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FillNotes();
        }

        private void FillNotes()
        {
            List<Note> notes = _noteController.GetNotesByUser(_user.UserID);
            lstNotes.DisplayMember = "Title";
            lstNotes.ValueMember = "NoteID";
            lstNotes.DataSource = notes;
            lstNotes.SelectedIndex = -1;
        }

        private void AddNote()
        {
            Note note = new Note();
            note.Title = txtTitle.Text;
            note.Content = txtContent.Text;
            note.UserID = _user.UserID;

            bool result = _noteController.Add(note);
            if (result)
            {
                MessageBox.Show("Notunuz başarıyla eklendi!");
                txtTitle.Clear();
                txtContent.Clear();
                FillNotes();
            }
            else
            {
                MessageBox.Show("Notunuz kayıt edilmedi.");
            }
        }

        private void UpdateNote()
        {
            int noteID = (int)lstNotes.SelectedValue;
            Note selected = _noteController.GetById(noteID);

            selected.Title = txtTitle.Text;
            selected.Content = txtContent.Text;

            bool result = _noteController.Update(selected);
            if (result)
            {
                MessageBox.Show("Güncellendi");
                txtTitle.Clear();
                txtContent.Clear();
                FillNotes();
            }
            else
            {
                MessageBox.Show("Güncellenmedi!");
            }

        }

        private void btnSavve_Click(object sender, EventArgs e)
        {
            if (lstNotes.SelectedIndex < 0)
            {
                AddNote();
            }
            else
            {
                UpdateNote();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstNotes.SelectedIndex < 0)
            {
                MessageBox.Show("Note şeçimi yapınız!!");
                return;
            }

            int noteID = (int)lstNotes.SelectedValue;
            Note selected = _noteController.GetById(noteID);
            bool result = _noteController.Delete(selected);
            if (result)
            {
                MessageBox.Show("Not başarıyla silindi");
                FillNotes();
            }
            else
            {
                MessageBox.Show("Not silme işlemi gerçekleşmedi");
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
