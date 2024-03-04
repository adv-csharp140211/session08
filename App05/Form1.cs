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
    }

}
