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

namespace app07.UI;

public partial class FormProduct : Form
{
    int? Id;
    public FormProduct()
    {
        InitializeComponent();
    }

    public FormProduct(int id) : this()
    {
        Id = id;        
    }


    private void FormProduct_Load(object sender, EventArgs e)
    {
        var service = new CategoryService();
        comboBoxCategory.DisplayMember = "Name";
        List<Category> categories = service.Get(true);
        comboBoxCategory.DataSource = categories;

        if (Id.HasValue)
        {
            var productService = new ProductService();
            var product = productService.ById(Id.Value);

            textBoxName.Text = product.Name;
            textBoxDescription.Text = product.Description;
            textBoxPrice.Text = product.Price.ToString();
            comboBoxCategory.SelectedItem = categories.FirstOrDefault(x => x.Id == product.CategoryId);
        }

        
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        var service = new ProductService();
        Product model = new Product
        {
            Name = textBoxName.Text,
            Description = textBoxDescription.Text,
            Price = Convert.ToDecimal(textBoxPrice.Text),
            CategoryId = ((Category)comboBoxCategory.SelectedItem).Id,
        };

        //logical error
        if (Id.HasValue)
        {
            model.Id = Id.Value;
            service.Update(model); 
        }
        else
        {
            service.Add(model);
        }
            
        MessageBox.Show("Done");
        DialogResult = DialogResult.OK;
        Close();
    }
}
