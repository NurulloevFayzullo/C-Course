using System.Net.Mime;
using Domain.Dtos;
using Domain.Entities;
using Infrastruction.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastruction.Services;

public class QuoteService : IQuoteService
{
    private readonly DataContext _context;
    public QuoteService(DataContext _context)
    {
        this._context = _context;
    }


    public async Task<List<GetQuoteDto>> GetQuotes()
    {
        return await _context.Quotes.Select(q =>
        new GetQuoteDto()
        {
            Id = q.Id,
            Author = q.Author,
            QuoteText = q.QuoteText,
            ImageName = q.ImageName

        }).ToListAsync();
    }
    public async Task<GetQuoteDto> AddQuote(AddQuoteDto quoteDto)
    {
        var quote = new Quote()
        {
            Id = quoteDto.Id,
            Author = quoteDto.Author,
            QuoteText = quoteDto.QuoteText,
            ImageName = quoteDto.ImageName,
            CreateAt=DateTime.Now
        };
       await _context.Quotes.AddAsync(quote);
        await _context.SaveChangesAsync();
        return new GetQuoteDto()
        {
            Id = quoteDto.Id,
            Author = quoteDto.Author,
            QuoteText = quoteDto.QuoteText,
            ImageName = quoteDto.ImageName
      
        };
    }
    public async Task<GetQuoteDto> GetQuoteById(int id)
    {
        var quote = await _context.Quotes.Select(q =>
           new GetQuoteDto()
           {
               Id = q.Id,
               Author = q.Author,
               QuoteText = q.QuoteText,
               ImageName = q.ImageName
           }).FirstOrDefaultAsync(q => q.Id == id);
        return quote;
    }

    public async Task<bool> DeleteQuote(int id)
    {
        var exist = await _context.Quotes.FindAsync(id);
        if (exist != null)
        {
            _context.Quotes.Remove(exist);
            await _context.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }
    }

    public async Task<GetQuoteDto> UpdateQuote(AddQuoteDto quoteDto)
    {
        var quote = new Quote()
        {
            Id = quoteDto.Id,
            Author = quoteDto.Author,
            QuoteText = quoteDto.QuoteText,
            ImageName = quoteDto.ImageName
        };
        _context.Quotes.Update(quote);
        await _context.SaveChangesAsync();
        return new GetQuoteDto()
        {
            Id = quoteDto.Id,
            Author = quoteDto.Author,
            QuoteText = quoteDto.QuoteText,
            ImageName = quoteDto.ImageName
      
        };
    }

}
