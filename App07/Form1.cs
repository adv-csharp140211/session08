using app07.Model;
using app07.Repository;
using app07.UI;
using System.Text;

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

        private void buttonReflection_Click(object sender, EventArgs e)
        {
            var product = new Product { Name = "TestPPP", Description = "Test", CategoryId = 20, Price = 500 };
            var category = new Category { Name = "Test", Description = "Test", IsActive = true };
            //Reflection

            //JSON - JavaScript Object Notation
            //{ "Name" : "TestPPP", "Description" : "Test", "CategoryId" : 20, "Price" : 500 }
            var productJson = toJosnSpecific(product);
            //var categoryJson = toJosn(category);

            var json1 = toJosnReflection(product);
            var json2 = toJosnReflection(category);
            MessageBox.Show(json2);


        }

        private string toJosnSpecific(Product p)
        {

            return $"{{ \"Name\" : \"{p.Name}\", \"Description\" : \"{p.Description}\", \"CategoryId\" : {p.CategoryId}, \"Price\" : {p.Price} }}";
        }

        private string toJosnReflection(object p)
        {
            var sb = new StringBuilder();
            sb.Append("{");
            Type type = p.GetType();
            var props = type.GetProperties();
            foreach (var prop in props)
            {
                var x = prop.PropertyType;
                sb.Append("\"");
                sb.Append(prop.Name);
                sb.Append("\": \"");
                sb.Append(prop.GetValue(p));
                sb.Append("\",");
            }
            sb.Append("}");
            return sb.ToString();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var form = new FormRegister();
            form.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var form = new FormLogin();
            form.ShowDialog();
        }
    }

}
