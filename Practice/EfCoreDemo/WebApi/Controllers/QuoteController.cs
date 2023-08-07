using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Infrastruction.Services;
using Domain.Dtos;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class QuoteController : ControllerBase
{

    private IQuoteService _quoteService;
    public QuoteController(IQuoteService _quoteService)
    {
        this._quoteService = _quoteService;
    }
    [HttpGet("GetQuotes")]
    public async Task<List<GetQuoteDto>> GetQuotes()
    {
        return await _quoteService.GetQuotes();
    }
    [HttpGet("GetQuoteById")]
    public async Task<GetQuoteDto> GetQuoteById(int id)
    {
        return await _quoteService.GetQuoteById(id);
    }
    [HttpPost("AddQuote")]
    public async Task<GetQuoteDto> AddQuote(AddQuoteDto quoteDto)
    {
        return await _quoteService.AddQuote(quoteDto);
    }
    [HttpDelete("DeleteQuote")]
    public async Task<bool> DeleteQuote(int id)
    {
        return await _quoteService.DeleteQuote(id);
    }
    [HttpPut("UpdateQuote")]
    public async Task<GetQuoteDto> UpdateQuote(AddQuoteDto quoteDto)
    {
    return await _quoteService.UpdateQuote(quoteDto);
    }
}
