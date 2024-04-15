using app07.Model;
using app07.Repository;
using Microsoft.EntityFrameworkCore;
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
                    string key = $"{formName}|{btn.Name}|{btn.Text}";
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
            if (e.NewValue == CheckState.Checked && !checkedButtons.Contains(buttoName))
            {
                checkedButtons.Add(buttoName);
            }
            if (e.NewValue == CheckState.Unchecked && checkedButtons.Contains(buttoName))
            {
                checkedButtons.Remove(buttoName);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var permissions = repository.Get<Permission>().ToList();
            var roleId = (int)comboBoxRoles.SelectedValue;

            //EF OLD for delete
            //var permissionRoles = repository.Get<Role>()
            //    .Include(x => x.PermissionRoles)
            //    .FirstOrDefault(x => x.Id == roleId)
            //    .PermissionRoles
            //    ;
            //foreach ( var permission in permissions)
            //{
            //    repository.Delete(permission);
            //}

            //EF New 
            repository.Get<PermissionRole>().Where(x => x.RoleId == roleId).ExecuteDelete();

            //Trade Off
            //Intercepor
            //Audit log / Soft Delete


            foreach (var checkedButton in checkedButtons) { 
                var parts  = checkedButton.Split('|');
                var formName = parts[0];
                var buttonName = parts[1];
                var buttonTitle = parts[2];

                var permission = permissions.FirstOrDefault(x => x.FormName == formName && x.ButtonName == buttonName);
                if (permission == null)
                {
                    permission = new Permission { ButtonName = buttonName, FormName = formName, ButtonTitle = buttonTitle };
                    repository.Add(permission);
                }

                repository.Add(new PermissionRole { RoleId = roleId, PermissionId = permission.Id });
            }

            MessageBox.Show("Done");
        }
    }
}
