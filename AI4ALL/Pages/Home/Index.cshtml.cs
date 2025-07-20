using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using AI4ALL.Models;

namespace AI4ALL.Pages.Home;

public class IndexModel : PageModel
{
    public PageLanguageType CurrentLanguage { get; private set; }

    public void OnGet()
    {
        // Safe parse with default
        var raw = Request.Headers["PageLanguage"].FirstOrDefault() ?? "EN";
        CurrentLanguage = Enum.TryParse<PageLanguageType>(raw, true, out var l) ? l : PageLanguageType.EN;
    }
}