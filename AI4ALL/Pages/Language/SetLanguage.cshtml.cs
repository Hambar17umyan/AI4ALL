using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AI4ALL.Pages.Language;

public class SetLanguageModel : PageModel
{
    public IActionResult OnGet(string lang, string returnUrl = "/")
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
