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
    public List<Quotes> GetCategoryId(int id)
    {
    return connect.GetCategoryId(id);
    }

    [HttpGet("GetQuotes")]
    public List<Quotes> GetQuotes()
    {
        return connect.GetQuotes();
    }
    [HttpGet("GetRandomQuotes")]
    public Quotes GetRandomQuotes()
    {
        return connect.GetRandomQuotes();
    }
    [HttpGet("GetQuotesById")]
    public Quotes GetQuotesById(int id)
    {
        return connect.GetQuotesById(id);
    }
    [HttpPost("AddQuotes")]
    public Quotes AddQuotes(Quotes quotes)
    {
        return connect.AddQuotes(quotes);
    }
    [HttpDelete("DeleteQuotes")]
    public int DeleteQuotes(int id)
    {
        return connect.DeleteQuotes(id);
    }
    [HttpPut("UpdateQuotes")]
    public Quotes UpdateQuotes(Quotes quotes)
    {
        return connect.UpdateQuotes(quotes);
    }
}
