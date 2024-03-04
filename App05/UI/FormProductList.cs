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
    public partial class FormProductList : Form
    {
        public FormProductList()
        {
            InitializeComponent();
        }

        private void FormProductList_Load(object sender, EventArgs e)
        {
            loadData();
            loadCategories();
        }

        private void loadCategories()
        {
            var service = new CategoryService();
            comboBoxCategories.DisplayMember = "Name";
            comboBoxCategories.ValueMember = "Id";
            comboBoxCategories.DataSource = service.Get(true)
                .Prepend(new Model.Category { Id = -1, Name = "انتخاب دسته بندی"})
                .ToList();
        }

        private void loadData()
        {
            var service = new ProductService();
            dataGridView1.DataSource = service.Get(Convert.ToInt32(comboBoxCategories.SelectedValue));
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            var form = new FormProduct();
            if (form.ShowDialog() == DialogResult.OK)
            {
                loadData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var form = new FormProduct(id);
            if (form.ShowDialog() == DialogResult.OK)
            {
                loadData();
            }
        }

        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
