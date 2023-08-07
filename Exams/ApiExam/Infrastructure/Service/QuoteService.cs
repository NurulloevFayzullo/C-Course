using System.Net.Mime;
namespace Infrastructure.Service;
using Domain.Classes;
using Dapper;
public class QuoteService
{
    
    private FileService _fileService;
    private DapperContext _connection;
    
    public QuoteService(DapperContext connection,FileService fileService)
    {
        _connection = connection;
        _fileService=fileService;
    }

    public async Task<List<Quotes>> GetQuotes()
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"Select * from quotes order by id";
            return (await connection.QueryAsync<Quotes>(sql)).ToList();
        }
    }
    public async Task<List<Quotes>> GetCategoryId(int id)
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"select q.id,q.author,q.quotetext,q.categoryid
from quotes as q
join categories as c
on c.id=q.categoryid
where q.categoryid=@id;";
            var e = (await connection.QueryAsync<Quotes>(sql, new { id })).ToList();
            return e;

        }
    }
    public async Task<Quotes> GetRandomQuotes()
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"SELECT id,author,quoteText,categoryid 
                FROM quotes
                ORDER BY RANDOM()
                LIMIT 1";
            return await connection.QuerySingleOrDefaultAsync<Quotes>(sql);
        }
    }
    public async Task<GetQuoteDto> AddQuotes(AddQuoteDto quotes)
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"insert into quotes(id,author,quoteText,categoryid) values(@id,@author,@quoteText,@categoryid)";
            var ct = await connection.ExecuteAsync(sql, quotes);
            var command = @"insert into image_quotes(imagename,qouteid)
              values(@imagename,@quoteid)";
              foreach (var file in quotes.Files)
              {
               await connection.ExecuteAsync(command,new {imagename=file.FileName,quoteid=quotes.Id});
             _fileService.Upload(quotes.Folder,file);            
              }
            return new GetQuoteDto{
                Id=quotes.Id,
                Author=quotes.Author,
                QuoteText=quotes.QuoteText,
                categoryid=quotes.categoryid
            };    
        }
    }

    public async Task<int> DeleteQuotes(int id)
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"Delete from quotes where id=@id";
            return await connection.ExecuteAsync(sql, new { id });
        }
    }
    public async Task<Quotes> UpdateQuotes(Quotes quotes)
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"Update quotes 
                set author=@author,quoteText=@quoteText,categoryid=@categoryid
                where id=@id";
            var ct = await connection.ExecuteAsync(sql, quotes);
            return quotes;
        }
    }
    
    public async Task<GetQuoteDto> GetQuotesById(int id)
    {
        using (var connection = _connection.CreateConnection())
        {
            string sql = $"select * from quotes where id = @id;";
            var response = await connection.QuerySingleOrDefaultAsync<GetQuoteDto>(sql, new { id });
            return response;
        }
    }
}
