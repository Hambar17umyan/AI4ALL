using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace AI4ALL.Controllers;

public class LocalizationController : Controller
{
    [HttpPost]
    public IActionResult ChangeLanguage(string language, string returnUrl)
    {
        if (!string.IsNullOrEmpty(language))
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(
                    new RequestCulture(language)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });

            Response.Headers["PageLanguage"] = language;
        }
        return LocalRedirect(returnUrl ?? "/");
    }
}