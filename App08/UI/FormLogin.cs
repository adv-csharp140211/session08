using app07.Model;
using app07.Repository;
using app07.Utils;
using BC = BCrypt.Net.BCrypt;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace app07.UI
{
    public partial class FormLogin : Form
    {
        public static User CurrentUser;
        public static List<Permission> Permissions = new List<Permission>();
        public FormLogin()
        {
            InitializeComponent();
        }

        string connectionStr = "data source=.;initial catalog=cs140211-codefirst2;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=AppDBFirst";

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUsername.Text) || String.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Username/Password is required");
                return;
            }

            var connection = new SqlConnection(connectionStr);
            //var count = connection.Execute(@"insert into [forosh].[Dastebandi] (Name, Description, IsActive) values (@Name, @Description, @IsActive)", new Category { Name = "test", Description = "test cat", IsActive = true});
            var users = connection.Query<User>("select * from users");



            MessageBox.Show("Done " + users.Count());


            var repo = new GenericRepositoryNew();
            var user = repo.Get<User>()
                .Include(x => x.Role)
                .Include(x => x.Role.PermissionRoles)
                .FirstOrDefault(x => x.Username == textBoxUsername.Text);
            if (user == null)
            {
                MessageBox.Show("Username/Password is incorect");
                return;
            }
            var hash = (textBoxPassword.Text + user.Salt).ToHashSha512();
            ;
            if (!BC.Verify(textBoxPassword.Text, user.Password))
            {
                MessageBox.Show("Username/Password is incorect");
                return;
            }
            CurrentUser = user;
            Permissions = repo.Get<Permission>().ToList();
            //
            Hide();
            var frm = new Form1();
            frm.ShowDialog();
            Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
