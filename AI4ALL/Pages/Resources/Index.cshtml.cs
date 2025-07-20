using AI4ALL.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AI4ALL.Pages.Resources;
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