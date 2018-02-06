using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace WebFormsStarterKit.ApiControllers
{
    [Authorize]
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        [Authorize]
        [HttpGet]
        [Route("GenerateToken")]
        public string GenerateToken()
        {
            var username = User.Identity.GetUserName();
            var tenantName = ((System.Security.Claims.ClaimsIdentity)User.Identity).FindFirstValue("tenantName");

            var user = new Models.UserInfo { UserName = username, TenantUniqueName = tenantName };
            var token = IzendaBoundary.IzendaTokenAuthorization.GetToken(user);
            return token;
        }
    }
}
