using Microsoft.AspNetCore.Mvc;
using Domain.Classes;
namespace WebApi.Controllers;
using Infrastructure.Service;
public class QuoteControllers : ControllerBase
{
    private QuoteService connect;
    public QuoteControllers(QuoteService connect)
    {
        this.connect = connect;
    }
    [HttpGet("GetCategoryId")]
    public async Task<List<Quotes>> GetCategoryId(int id)
    {
    return await connect.GetCategoryId(id);
    }

    [HttpGet("GetQuotes")]
    public async Task<List<Quotes>> GetQuotes()
    {
        return await connect.GetQuotes();
    }
    [HttpGet("GetRandomQuotes")]
    public async Task<Quotes> GetRandomQuotes()
    {
        return await connect.GetRandomQuotes();
    }
    [HttpGet("GetQuotesById")]
    public async Task<Quotes> GetQuotesById(int id)
    {
        return await connect.GetQuotesById(id);
    }
    [HttpPost("AddQuotes")]
    public async Task<GetQuoteDto> AddQuotes(AddQuoteDto quotes)
    {
        return await connect.AddQuotes(quotes);
    }
    [HttpDelete("DeleteQuotes")]
    public async Task<int> DeleteQuotes(int id)
    {
        return await connect.DeleteQuotes(id);
    }
    [HttpPut("UpdateQuotes")]
    public async Task<Quotes> UpdateQuotes(Quotes quotes)
    {
        return await connect.UpdateQuotes(quotes);
    }
}
