namespace AI4ALL.Pages.About;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

public class IndexModel : PageModel
{
    public PageLanguageType CurrentLanguage { get; set; } = PageLanguageType.EN;

    public void OnGet()
    {
        // Safe parse with default
        var raw = Request.Headers["PageLanguage"].FirstOrDefault() ?? "EN";
        CurrentLanguage = Enum.TryParse<PageLanguageType>(raw, true, out var l) ? l : PageLanguageType.EN;

    }
}
