using Domain.Dtos;

namespace Infrastruction.Services;

public interface IQuoteService
{
    Task<List<GetQuoteDto>> GetQuotes();
    Task<GetQuoteDto>GetQuoteById(int id);
    Task<GetQuoteDto> AddQuote(AddQuoteDto quoteDto);
    Task<GetQuoteDto> UpdateQuote(AddQuoteDto quoteDto);
    Task<bool> DeleteQuote(int id);

}
