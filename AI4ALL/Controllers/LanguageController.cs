using Microsoft.AspNetCore.Mvc;

namespace AI4ALL.Controllers
{
    [Route("Language")]
    public class LanguageController : Controller
    {
        [Route("change")]
        public IActionResult Change(string lang, string returnUrl = "/")
        {
            // 1 year expiration
            Response.Cookies.Append(
                "PageLanguage",
                lang,
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1), HttpOnly = true, Secure = true }
            );

            // Redirect back to where we came from
            return LocalRedirect(returnUrl);
        }
    }
}
