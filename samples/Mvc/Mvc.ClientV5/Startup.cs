using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using Owin;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(Mvc.ClientV5.Startup))]

namespace Mvc.ClientV5
{
    public class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "Cookies"
            });

            app.UseOpenIdConnectAuthentication(new OpenIdConnectAuthenticationOptions
            {
                ClientId = "myClientMvc5",
                ClientSecret = "secret_secret_secret2",
                RedirectUri = "http://localhost:9664/oidc",
                PostLogoutRedirectUri = "http://localhost:9664/",
                SignInAsAuthenticationType = "Cookies",
                Authority = "http://localhost:54540/",
                Resource = "http://localhost:54540/",

                Notifications = new OpenIdConnectAuthenticationNotifications()
                {

                    MessageReceived = async n =>
                    {
                        await Task.FromResult(0);

                    },

                    SecurityTokenValidated = async n =>
                    {
                        await Task.FromResult(0);

                    },


                }



            });


        }

    }
}
