using Npgsql;
using Dapper;
public class ContactService
{
    string _connectionString = "Server=localhost;Port=5432;Database=contactdb;User Id=postgres;Password=Aylin1212;";
    public List<Contact> GetContacts()
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            string sql = "Select * from contacts";
            var contacts = connection.Query<Contact>(sql).ToList();
            return contacts;
        }
    }
    public Contact AddContact(Contact contact)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            var add = $"insert into contacts(id,name,phone) values (@id,@name,@phone) returning id;";
            var res = connection.ExecuteScalar<int>(add, contact);
            contact.Id=res;
            return contact;
        }
    }
    public int UpdateContact(Contact contact)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            return connection.Execute($"update contacts set id=@id,name=@name,phone=@phone where id=@id", new { contact.Name, contact.Phone, contact.Id });
        }
    }
    public int DeleteContact(int id)
    {
        using (var connection = new NpgsqlConnection(_connectionString))
        {
            return connection.Execute($"delete from contacts where id=@id", new { id });
        }
    }

    public Contact GetContactById(int id)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
        {
            string sql = $"select * from contacts where id = @id";
            var response = connection.QuerySingleOrDefault<Contact>(sql, new { id });
            return response;
        }
    }
    


}