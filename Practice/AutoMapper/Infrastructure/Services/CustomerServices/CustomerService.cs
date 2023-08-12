using AutoMapper;
using Domain.Dtos.Customer;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Domain.Entity;
namespace Infrastructure.Services.CustomerServices;

public class CustomerService : ICustomerService
{
    protected readonly DataContext _context;
    protected readonly IMapper _mapper;
    public CustomerService(DataContext _context,IMapper _mapper)
    {
        this._context = _context;
        this._mapper=_mapper;
    }



    public async Task<GetCustomerDto> AddCustomer(AddCustomerDto customer)
    {
        var conn = _mapper.Map<Customer>(customer);
        await _context.AddAsync(conn);
        await _context.SaveChangesAsync();
        return _mapper.Map<GetCustomerDto>(conn);
    }

    public Task<bool> DeleteCustomer(int id)
    {
        throw new NotImplementedException();
    }

    public Task<GetCustomerDto> GetCustomerById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<GetCustomerDto>> GetCustomers()
    {
        var customer = await _context.Customers.ToListAsync();
        return _mapper.Map<List<GetCustomerDto>>(customer);
    }

    public Task<GetCustomerDto> UpdateCustomer(AddCustomerDto customerDto)
    {
        throw new NotImplementedException();
    }

}
