using app07.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app08.Utils;
static public class AuthUtils
{
    public static void ApplyAuthorization(this Form form)
    {

        foreach (var ctrl in form.Controls)
        {
            if (ctrl is Button btn)
            {
                btn.Enabled = false;
                var permission = FormLogin.Permissions
                    .FirstOrDefault(x => x.ButtonName == btn.Name && x.FormName == form.GetType().FullName);
                if (permission != null && FormLogin.CurrentUser.Role.PermissionRoles.Any(x => x.PermissionId == permission.Id))
                {
                    btn.Enabled = true;
                }
            }
        }
    }
}
