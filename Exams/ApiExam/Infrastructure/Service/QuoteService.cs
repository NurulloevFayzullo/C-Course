namespace Infrastructure.Service;
using Domain.Classes;
using Dapper;
public class QuoteService
{
    private DapperContext _connection;
    public QuoteService(DapperContext connection)
    {
        _connection = connection;
    }

    public List<Quotes> GetQuotes()
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"Select * from quotes order by id";
            return connection.Query<Quotes>(sql).ToList();
        }
    }
    public List<Quotes> GetCategoryId(int id)
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"select q.id,q.author,q.quotetext,q.categoryid
from quotes as q
join categories as c
on c.id=q.categoryid
where q.categoryid=@id;";
            var e = connection.Query<Quotes>(sql, new { id }).ToList();
            return e;

        }
    }
    public Quotes GetRandomQuotes()
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"SELECT id,author,quoteText,categoryid 
                FROM quotes
                ORDER BY RANDOM()
                LIMIT 1";
            return connection.QuerySingleOrDefault<Quotes>(sql);
        }
    }
    public Quotes AddQuotes(Quotes quotes)
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"insert into quotes(id,author,quoteText,categoryid) values(@id,@author,@quoteText,@categoryid) returning @id";
            var ct = connection.ExecuteScalar<int>(sql, quotes);
            quotes.Id = ct;
            return quotes;
        }
    }
    public int DeleteQuotes(int id)
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"Delete from quotes where id=@id";
            return connection.Execute(sql, new { id });
        }
    }
    public Quotes UpdateQuotes(Quotes quotes)
    {
        using (var connection = _connection.CreateConnection())
        {
            var sql = @"Update quotes 
                set author=@author,quoteText=@quoteText,categoryid=@categoryid
                where id=@id";
            var ct = connection.Execute(sql, quotes);
            return quotes;
        }
    }
    public Quotes GetQuotesById(int id)
    {
        using (var connection = _connection.CreateConnection())
        {
            string sql = $"select * from quotes where id = @id;";
            var response = connection.QuerySingleOrDefault<Quotes>(sql, new { id });
            return response;
        }
    }
}
