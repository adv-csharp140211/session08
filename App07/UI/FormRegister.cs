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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var salt = Guid.NewGuid().ToString();
            var password = (textBoxPassword.Text + salt).ToHashSha512();
            var user = new User { IsActive = true,  Username= textBoxUsername.Text, Password = password, Salt=salt };
            var repo = new GenericRepositoryNew();
            repo.Add(user);
            MessageBox.Show("Done");
        }
    }
}
