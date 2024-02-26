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
        }

        private void loadData()
        {
            var service = new ProductService();
            dataGridView1.DataSource = service.Get();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            var form = new FormProduct();
            form.ShowDialog();
            loadData();
        }
    }
}
