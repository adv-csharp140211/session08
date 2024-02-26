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

namespace App05.UI;

public partial class FormProduct : Form
{
    public FormProduct()
    {
        InitializeComponent();
    }

    private void FormProduct_Load(object sender, EventArgs e)
    {
        var service = new CategoryService();
        comboBoxCategory.DisplayMember = "Name";
        comboBoxCategory.DataSource = service.Get(true);
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        var service = new ProductService();
        service.Add(new Product {
            Name = textBoxName.Text,
            Description = textBoxDescription.Text,
            Price = Convert.ToInt32(textBoxPrice.Text),
            CategoryId = ((Category)comboBoxCategory.SelectedItem).Id,
        });
        MessageBox.Show("Done");
        Close();
    }
}
