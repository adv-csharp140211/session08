using app07.Model;
using app07.Service;
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
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            CategoryService service = new CategoryService();
            service.Add(new Category
            {
                Name = textBoxName.Text,
                Description = textBoxDescription.Text,
                IsActive = checkBoxIsActive.Checked,
            });
            MessageBox.Show("Done");
            Close();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            //if(FormLogin.CurrentUser.Role != "admin")
            //{
            //    MessageBox.Show("Access Denied");
            //    Close();
            //}
        }
    }
}
