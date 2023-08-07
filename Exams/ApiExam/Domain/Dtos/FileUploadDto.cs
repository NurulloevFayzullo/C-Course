using Microsoft.AspNetCore.Http;

namespace Domain.Dtos;

public class FileUploadDto
{
    public List<IFormFile> File { get; set; }
}
