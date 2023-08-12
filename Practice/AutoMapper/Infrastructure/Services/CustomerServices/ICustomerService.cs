using Domain.Dtos.Customer;

namespace Infrastructure.Services.CustomerServices;

public interface ICustomerService
{
    public Task<List<GetCustomerDto>> GetCustomers(); 
    public Task<GetCustomerDto> AddCustomer(AddCustomerDto customer); 
    public Task<bool> DeleteCustomer(int id); 
    public Task<GetCustomerDto> UpdateCustomer(AddCustomerDto customerDto); 
    public Task<GetCustomerDto> GetCustomerById(int id); 
}
