using Izenda.BI.Framework.Models.UserManagement;
using Izenda.BI.Logic.CustomConfiguration;

namespace WebFormsStarterKit
{
    public static class IzendaConfig
    {
        public static void RegisterLoginLogic()
        {
            UserIntegrationConfig.GetAccessToken = (args) =>
            {
                return IzendaBoundary.IzendaTokenAuthorization.GetToken(new Models.UserInfo()
                {
                    UserName = args.UserName,
                    TenantUniqueName = args.TenantId
                });
            };

            UserIntegrationConfig.ValidateToken = (ValidateTokenArgs args) =>
            {
                var token = args.AccessToken;
                var user = IzendaBoundary.IzendaTokenAuthorization.GetUserInfo(token);
                return new ValidateTokenResult { UserName = user.UserName, TenantUniqueName = user.TenantUniqueName };
            };
        }
    }
}