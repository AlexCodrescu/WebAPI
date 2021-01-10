//using Microsoft.AspNetCore.Authentication;
//using Microsoft.Extensions.Logging;
//using Microsoft.Extensions.Options;
//using System;
//using System.Net.Http.Headers;
//using System.Text;
//using System.Text.Encodings.Web;
//using System.Threading.Tasks;

//namespace WebAPI.Handlers
//{
//    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
//    {

//        public BasicAuthenticationHandler(
//            IOptionsMonitor<AuthenticationSchemeOptions> options,
//            ILoggerFactory logger,
//            UrlEncoder encoder,
//            ISystemClock clock)
//            : base(options, logger, encoder, clock)
//        {

//        }

//        protected override async  Task<AuthenticateResult> HandleAuthenticateAsync()
//        {
//            if (!Request.Headers.ContainsKey("Authorization"))
//                return AuthenticateResult.Fail("header was not found.") ;

//           var authenticationHeaderValue = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);

//           var bytes = Convert.FromBase64String(authenticationHeaderValue.Parameter);

//           string[] credentials = Encoding.UTF8.GetString(bytes).Split(":");
//            string emailAdress = credentials[0];
//            string password = credentials[1];


//            return AuthenticateResult.Fail("TBD");
//        }
//    }
//}
