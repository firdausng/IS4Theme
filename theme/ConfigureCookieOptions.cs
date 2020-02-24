using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace theme
{
    internal class ConfigureCookieOptions : IConfigureNamedOptions<CookieAuthenticationOptions>
    {
        public ConfigureCookieOptions() { }
        public void Configure(CookieAuthenticationOptions options) { }
        public void Configure(string name, CookieAuthenticationOptions options)
        {
            options.AccessDeniedPath = "/Identity/Account/AccessDenied";
            //options.LoginPath = "/Identity/Account/login";
            //Any other options you want to set/override
        }
    }
}
