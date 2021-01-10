//using System;
//using System.Net;
//using System.Net.Http;
//using System.Security.Principal;
//using System.Text;
//using System.Threading;
//using System.Web.Http.Controllers;
//using System.Web.Http.Filters;
//using WebAPI.Controllers;

//namespace WebAPI.Handlers

//{
//    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
//    {
//        public override void OnAuthorization(HttpActionContext actionContext)
//        {
//            if (actionContext.Request.Headers.Authorization == null)
//            {
//                actionContext.Response = actionContext.Request
//                    .CreateResponse(HttpStatusCode.Unauthorized);
//            }
//            else
//            {
//                string authenticationToken = actionContext.Request.Headers
//                                            .Authorization.Parameter;
//                string decodedAuthenticationToken = Encoding.UTF8.GetString(
//                    Convert.FromBase64String(authenticationToken));
//                string[] usernamePasswordArray = decodedAuthenticationToken.Split(':');
//                string username = usernamePasswordArray[0];
//                string password = usernamePasswordArray[1];

//                if (UsersController.Login(username, password))
//                {
//                    Thread.CurrentPrincipal = new GenericPrincipal(
//                        new GenericIdentity(username), null);
//                }
//                else
//                {
//                    actionContext.Response = actionContext.Request
//                        .CreateResponse(HttpStatusCode.Unauthorized);
//                }
//            }
//        }
//    }
//} 





using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;

using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Handlers
{

    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        //private readonly authenticateDBContext _context;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock
           // ,
            //authenticateDBContext context
            )
            : base(options, logger, encoder, clock)
        {
            //_context = context;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("header was not found.");

            try
            {

                var authenticationHeaderValue = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);

                var bytes = Convert.FromBase64String(authenticationHeaderValue.Parameter);

                string[] credentials = Encoding.UTF8.GetString(bytes).Split(":");
                string emailAdress = credentials[0];
                string password = credentials[1];

                  ;// _context.Users.Where(user => user.Email == emailAdress && user.Password == password).FirstOrDefault();
                int check = 0;

                

                string Emailcheck = "admin";
                string Passwordcheck = "admin";

                if (Emailcheck == emailAdress && Passwordcheck == password) { check = 1 ; }

                if (check == 0)
                    return AuthenticateResult.Fail("error");
                else
                {
                    var claims = new[] { new Claim(ClaimTypes.Name, "admin") };
                    var identity = new ClaimsIdentity(claims, Scheme.Name);
                    var principal = new ClaimsPrincipal(identity);
                    var ticket = new AuthenticationTicket(principal, Scheme.Name);

                    return AuthenticateResult.Success(ticket);
                }

            }
            catch (Exception)
            {
                return AuthenticateResult.Fail("error");
            }




            return AuthenticateResult.Fail("");
        }
    }
}
