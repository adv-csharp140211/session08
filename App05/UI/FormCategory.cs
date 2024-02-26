using App05.Model;
using App05.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App05.UI
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
            service.Add(new Category { Name = textBoxName.Text, Description = textBoxDescription.Text });
            MessageBox.Show("Done");
        }
    }
}
