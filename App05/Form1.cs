using App05.UI;

namespace App05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {

        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            var form = new FormCategoryList();
            form.ShowDialog();  
        }
    }
}
