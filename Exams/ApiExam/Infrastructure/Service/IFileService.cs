using Microsoft.AspNetCore.Http;

namespace Infrastructure.Service;

public interface IFileService
{
    string Upload(string folder,IFormFile file);
    bool DeleteFile(string folder, string filename);
}
