namespace Domain.Classes;
using Microsoft.AspNetCore.Http;
public class AddQuoteDto : Quotes
{
    public string Folder { get; set; }
    public List<IFormFile> Files { get; set; }
}
