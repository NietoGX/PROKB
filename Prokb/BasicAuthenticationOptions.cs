using Microsoft.AspNetCore.Authentication;

namespace Prokb
{
    public class BasicAuthenticationOptions : AuthenticationSchemeOptions
    {
        public string Realm { get; set; }
    }
}