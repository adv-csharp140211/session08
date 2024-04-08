using app07.Model;
using app07.Repository;
using app07.UI;

namespace app07
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

        private void buttonProductList_Click(object sender, EventArgs e)
        {
            var frm = new FormProductList();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var stack = new StackInt();
            stack.Push(1);
            stack.Push(10);
            stack.Push(15);

            MessageBox.Show(stack.Pop().ToString());
            MessageBox.Show(stack.Pop().ToString());
        }

        private void buttonStackGeneric_Click(object sender, EventArgs e)
        {
            var stack = new StackGenric<int>();
            stack.Push(1);
            stack.Push(10);
            stack.Push(15);


            var stack2 = new StackGenric<string>();
            stack2.Push("xyz");
            stack2.Push("abc");
            stack2.Push("xml");

            MessageBox.Show(stack.Pop().ToString());
            MessageBox.Show(stack.Pop().ToString());
        }

        private void buttonGenericRepo_Click(object sender, EventArgs e)
        {
            var categoryRepo = new GenericRepository<Category>();
            var productRepo = new GenericRepository<Product>();
            //Unit Of Work

            var category = new Category { Name = "Test", Description = "Test", IsActive = true };
            categoryRepo.Add(category);

            var product = new Product { Name = "Test", Description = "Test", Category = category, Price = 500 };
            productRepo.Add(product);


        }

        private void buttonGenericRepositoryNew_Click(object sender, EventArgs e)
        {
            var repo = new GenericRepositoryNew();

            var category = new Category { Name = "Test", Description = "Test", IsActive = true };
            repo.Add(category);

            var product = new Product { Name = "TestPPP", Description = "Test", CategoryId = category.Id, Price = 500 };
            repo.Add(product);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HibernatingRhinos.Profiler.Appender.EntityFramework.EntityFrameworkProfiler.Initialize();
        }
    }

}
