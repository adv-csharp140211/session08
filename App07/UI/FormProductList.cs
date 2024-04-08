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
    public partial class FormProductList : Form
    {
        double PerPage = 3;
        int page = 1;
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
                .Prepend(new Model.Category { Id = -1, Name = "انتخاب دسته بندی" })
                .ToList();
        }

        private void loadData()
        {
            var service = new ProductService();
            (List<ProductService.ProductVM>, int) value = service.Get(
                            Convert.ToInt32(comboBoxCategories.SelectedValue),
                            textBoxFrom.Text,
                            textBoxTo.Text,
                            page, Convert.ToInt32(PerPage)
                            );
            dataGridView1.DataSource = value.Item1;

            panel1.Controls.Clear();

            for (int i = 0; i < Math.Ceiling(value.Item2 / PerPage); i++)
            {
                var button = new Button();
                button.Text = (i + 1).ToString();
                button.Location = new Point((i* button.Width) + 5 , 10);
                button.Click += Button_Click;                
                panel1.Controls.Add(button);
            }
          
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            page = Convert.ToInt32(((Button)sender).Text);
            loadData();
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

        private void textBoxFrom_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void textBoxTo_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
