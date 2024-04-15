using app07.Model;
using app07.Repository;
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
        GenericRepositoryNew repository = new GenericRepositoryNew();
        List<string> checkedButtons = new List<string>();

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

            comboBoxRoles.DisplayMember = "Name";
            comboBoxRoles.ValueMember = "Id";
            comboBoxRoles.DataSource = repository.Get<Role>().ToList();
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
                if (ctrl is Button btn)
                {
                    //var btn = (Button)ctrl;
                    string key = $"{formName}|{btn.Name}";
                    checkedListBoxButtons.Items.Add(key, checkedButtons.Contains(key));
                }
            }

        }

        private void checkedListBoxButtons_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string buttoName = checkedListBoxButtons.SelectedItem as string;
            if (string.IsNullOrEmpty(buttoName))
            {
                return;
            }
            if(e.NewValue == CheckState.Checked && !checkedButtons.Contains(buttoName))
            {
                checkedButtons.Add(buttoName);
            }
            if (e.NewValue == CheckState.Unchecked && checkedButtons.Contains(buttoName))
            {
                checkedButtons.Remove(buttoName);
            }
        }
    }
}
