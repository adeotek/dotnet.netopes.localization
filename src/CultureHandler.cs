using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;

namespace Netopes.Localization
{
    public class CultureHandler
    {
        public void Set(HttpContext httpContext, string culture)
        {
            httpContext.Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)));
        }

        public async Task SetAsync(HttpContext httpContext, string culture)
        {
            await Task.Run(() => Set(httpContext, culture));
        }
    }
}