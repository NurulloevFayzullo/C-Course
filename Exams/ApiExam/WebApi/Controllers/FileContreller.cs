using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class FileContreller : ControllerBase
{
    private readonly IWebHostEnvironment _host;
    public FileContreller(IWebHostEnvironment host)
    {
        _host = host;
    }

    
}
