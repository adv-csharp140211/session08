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
using Microsoft.EntityFrameworkCore;

namespace app07.UI
{
    public partial class FormLogin : Form
    {
        public static User CurrentUser;
        public static List<Permission> Permissions = new List<Permission>();
        public FormLogin()
        {
            InitializeComponent();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUsername.Text) || String.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Username/Password is required");
                return;
            }
            var repo = new GenericRepositoryNew();
            var user = repo.Get<User>()
                .Include(x => x.Role)
                .Include(x => x.Role.PermissionRoles)
                .FirstOrDefault(x => x.Username == textBoxUsername.Text);
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
            Permissions = repo.Get<Permission>().ToList();
            //
            Hide();
            var frm = new Form1();
            frm.ShowDialog();
            Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
