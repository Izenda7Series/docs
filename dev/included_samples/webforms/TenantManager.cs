using System;
using System.Linq;
using System.Threading.Tasks;
using WebFormsStarterKit.Models;

namespace WebFormsStarterKit.Managers
{
    public class TenantManager
    {
        public Tenant GetTenantByName(string name)
        {
            using (var context = ApplicationDbContext.Create())
            {
                var tenant = context.Tenants.SingleOrDefault(x => x.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
                return tenant;
            }
        }

        public Tenant SaveTenant(Tenant tenant)
        {
            using (var context = ApplicationDbContext.Create())
            {
                context.Tenants.Add(tenant);
                context.SaveChanges();

                return tenant;
            }
        }
    }
}