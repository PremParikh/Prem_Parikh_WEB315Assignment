using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesbooks.Pages;

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
[IgnoreAntiforgeryToken]
public class ErrorModel : PageModel
{
    public object GetRequestId()
    {
        return requestId;
    }

    public void SetRequestId(object value)
    {
        requestId = value;
    }

    public bool ShowRequestId => !string.IsNullOrEmpty((string)GetRequestId());

    private readonly ILogger<ErrorModel> _logger;
    private object requestId;

    public ErrorModel(ILogger<ErrorModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        SetRequestId(Activity.Current?.Id ?? HttpContext.TraceIdentifier);
    }
}

