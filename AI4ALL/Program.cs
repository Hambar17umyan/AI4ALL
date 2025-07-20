using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddRazorPages()
    .AddDataAnnotationsLocalization();
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllers();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
app.Use(async (context, next) =>
{
    // 1. Try to read incoming header
    var lang = context.Request.Headers["PageLanguage"].FirstOrDefault();

    // 2. If none, fall-back to the cookie (or default to "EN")
    if (string.IsNullOrEmpty(lang))
    {
        if (!context.Request.Cookies.TryGetValue("PageLanguage", out lang))
            lang = "EN";
        // inject a header for all downstream code
        context.Request.Headers["PageLanguage"] = lang;
    }

    await next();
});
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();
app.MapControllers();
app.Run();
