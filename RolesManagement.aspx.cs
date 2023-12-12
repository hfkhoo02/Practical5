using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Practical5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lstRoles.DataSource = Roles.GetAllRoles();
                lstRoles.DataBind();

                lstUsers.DataSource = Membership.GetAllUsers();
                lstUsers.DataBind();

                ddlRole.DataSource = Roles.GetAllRoles();
                ddlRole.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string roleName = txtRole.Text.Trim();
            try
            {
                if (Roles.RoleExists(roleName))
                {
                    
                }
                else
                {
                    Roles.CreateRole(roleName);
                    lstRoles.DataSource = Roles.GetAllRoles();
                    lstRoles.DataBind();
                    ddlRole.DataSource = Roles.GetAllRoles();
                    ddlRole.DataBind();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Roles.AddUserToRole(lstUsers.SelectedItem.Text, lstRoles.SelectedItem.Text);

                lstUsersRoles.DataSource =
                    Roles.GetRolesForUser(lstUsers.SelectedItem.Text);
                lstUsersRoles.DataBind();
            } catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }

        protected void btnGetRoleUsers_Click(object sender, EventArgs e)
        {
            lstUsersRoles.DataSource = Roles.GetUsersInRole(ddlRole.SelectedItem.Text);
            lstUsersRoles.DataBind();   
        }
    }
}