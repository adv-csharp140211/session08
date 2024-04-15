using app07.Model;
using app07.Repository;
using app07.Utils;
using BC = BCrypt.Net.BCrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app07.UI
{
    public partial class FormLogin : Form
    {
        public static User CurrentUser;
        public FormLogin()
        {
            InitializeComponent();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBoxUsername.Text) || String.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Username/Password is required");
                return;
            }
            var repo = new GenericRepositoryNew();
            var user = repo.Get<User>().FirstOrDefault(x => x.Username == textBoxUsername.Text);
            if (user == null)
            {
                MessageBox.Show("Username/Password is incorect");
                return;
            }
            var hash = (textBoxPassword.Text + user.Salt).ToHashSha512();
            ;
            if (!BC.Verify(textBoxPassword.Text, user.Password))
            {
                MessageBox.Show("Username/Password is incorect");
                return;
            }
            CurrentUser = user;
            //
            Hide();
            var frm = new Form1();
            frm.ShowDialog();
            Close();
        }
    }
}
