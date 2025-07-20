namespace AI4ALL.Pages.Contact;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

public class IndexModel : PageModel
{
    [BindProperty]
    public ContactFormModel Contact { get; set; }
    public bool Success { get; set; }
    public PageLanguageType CurrentLanguage { get; set; } = PageLanguageType.EN;

    public void OnGet()
    {
        // Safe parse with default
        var raw = Request.Headers["PageLanguage"].FirstOrDefault() ?? "EN";
        CurrentLanguage = Enum.TryParse<PageLanguageType>(raw, true, out var l) ? l : PageLanguageType.EN;

    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        // TODO: Send email or store message
        Success = true;
        return Page();
    }
}
