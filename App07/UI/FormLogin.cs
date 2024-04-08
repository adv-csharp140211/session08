using app07.Model;
using app07.Repository;
using app07.Utils;
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
        public FormLogin()
        {
            InitializeComponent();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var repo = new GenericRepositoryNew();
            var user = repo.Get<User>().FirstOrDefault(x => x.Username == textBoxUsername.Text);
            if (user == null)
            {
                MessageBox.Show("Username not found");
                return;
            }
            var hash = (textBoxPassword.Text + user.Salt).ToHashSha512();
            if (hash != user.Password)
            {
                MessageBox.Show("Password is incorect");
                return;
            }

            //
            Close();
        }
    }
}
