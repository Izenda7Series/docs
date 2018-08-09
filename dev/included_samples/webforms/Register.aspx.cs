using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Izenda.BI.Framework.Models;
using Izenda.BI.Framework.Models.DBStructure;
using Izenda.BI.Framework.Models.Permissions;
using Izenda.BI.Logic.CustomConfiguration;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using WebFormsStarterKit.Models;

namespace WebFormsStarterKit.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();

            var tenant = new Tenant() { Name = Tenant.Text };
            var tenantManager = new Managers.TenantManager();
            var exstingTenant = tenantManager.GetTenantByName(tenant.Name);
            if (exstingTenant != null)
                tenant = exstingTenant;
            else
                tenant = tenantManager.SaveTenant(tenant);

            var user = new ApplicationUser() { UserName = Email.Text, Email = Email.Text, Tenant_Id = tenant.Id };
            IdentityResult result = manager.Create(user, Password.Text);
            //This line below will hard code users who register to a role of Manager and can be changed by altering the role below
            manager.AddToRole(user.Id, "Manager");
            if (result.Succeeded)
            {
                //izenda

                //determine tenant
                var izendaTenant = new Tenants();
                izendaTenant.Active = true;
                izendaTenant.Deleted = false;

                //var currentUserTenant = ParseTenantFromEmail(izendaTenant.Name);
                izendaTenant.Name = tenant.Name;
                izendaTenant.TenantID = tenant.Name;

                //determine roles
                var roleDetail = new RoleDetail()
                {
                    Name = "Administrator",
                    TenantUniqueName = tenant.Name,
                    Active = true,
                    Permission = new Permission(),
                };

                var izendaUser = new UserDetail()
                {
                    UserName = user.Email,
                    EmailAddress = user.Email,
                    FirstName = "John", //todo fix this
                    LastName = "Doe",
                    TenantDisplayId = tenant.Name,
                    Deleted = false,
                    Active = true,
                    SystemAdmin = false,
                    Roles = new List<Role>()
                };

                izendaUser.Roles.Add(new Role()
                {
                    Name = roleDetail.Name
                });

                TenantIntegrationConfig.AddOrUpdateTenant(izendaTenant);
                RoleIntegrationConfig.AddOrUpdateRole(roleDetail);
                UserIntegrationConfig.AddOrUpdateUser(izendaUser);

                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                //string code = manager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

                signInManager.SignIn(user, isPersistent: false, rememberBrowser: false);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}