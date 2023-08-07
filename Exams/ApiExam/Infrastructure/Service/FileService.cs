using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Service;

public class FileService : IFileService
{
    private readonly IWebHostEnvironment hostEnvironment;

    public FileService(IWebHostEnvironment hostEnvironment)
    {
        this.hostEnvironment = hostEnvironment;
    }
    
    public string Upload(string folder, IFormFile file)
    {
        string fullPath = Path.Combine(hostEnvironment.WebRootPath,folder,file.FileName);
        using (var stream = new FileStream(fullPath,FileMode.Create))
        {
         file.CopyTo(stream);   
        }
        return file.FileName;
    }
    public bool DeleteFile(string folder, string filename)
    {
        string fullPath = Path.Combine(hostEnvironment.WebRootPath,folder,filename);
        System.IO.File.Delete(fullPath);
        return true;
    }
}
