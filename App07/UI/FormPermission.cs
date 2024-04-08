using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app07.UI
{
    public partial class FormPermission : Form
    {
        public FormPermission()
        {
            InitializeComponent();
        }

        private void FormPermission_Load(object sender, EventArgs e)
        {
            var asembly = Assembly.GetExecutingAssembly();
            var forms = asembly.GetTypes().Where(x => x.BaseType == typeof(Form));
            foreach (var form in forms)
            {
                listBoxForms.Items.Add(form.FullName);
            }
        }

        private void listBoxForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxButtons.Items.Clear();
            var formName = listBoxForms.SelectedItem as string;
            //reflection
            var formType = Type.GetType(formName);
            var frm = Activator.CreateInstance(formType) as Form;

            //var buttons = formType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance).Where(t => t == typeof(Button));
            //foreach (var button in buttons)
            //{
            //}

            foreach (var ctrl in frm.Controls)
            {
                if(ctrl is Button btn)
                {
                    checkedListBoxButtons.Items.Add(btn.Name);
                }
            }
            
        }
    }
}
