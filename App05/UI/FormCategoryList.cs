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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            loadData();
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            HibernatingRhinos.Profiler.Appender.EntityFramework.EntityFrameworkProfiler.Initialize();
            comboBox1.SelectedIndex = 0;            
        }

        private void loadData()
        {
            var service = new CategoryService();
            var data = service.Get();
            if (comboBox1.SelectedIndex > 0)
            {
                dataGridView1.DataSource = service.Get(comboBox1.SelectedIndex == 1);
            }
            else
            {
                dataGridView1.DataSource = service.Get();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
