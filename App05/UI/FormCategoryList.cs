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
    public partial class FormCategoryList : Form
    {
        public FormCategoryList()
        {
            InitializeComponent();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            var form = new FormCategory();
            form.ShowDialog();
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            var service = new CategoryService();
            dataGridView1.DataSource = service.Get();
        }
    }
}
