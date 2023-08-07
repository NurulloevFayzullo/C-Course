using Microsoft.AspNetCore.Mvc;
using Infrastructure.Service;
namespace WebApi.Controllers;
using Domain.Classes;
public class CategoryControllers : ControllerBase
{
    private CategoryService connect;
    public CategoryControllers(CategoryService connect)
    {
        this.connect = connect;
    }

    [HttpGet("GetCategories")]
    public async Task<List<Category>> GetCategories()
    {
        return await connect.GetCategories();
    }
    [HttpGet("GetCategoriesById")]
    public async Task<Category> GetCategoriesById(int id)
    {
        return await connect.GetCategoriesById(id);
    }
    
    [HttpPost("AddCategories")]
    public async Task<Category> AddCategories(Category category)
    {
        return await connect.AddCategories(category);
    }
    [HttpDelete("DeleteCategories")]
    public async Task<int> DeleteCategories(int id)
    {
        return await connect.DeleteCategories(id);
    }
    [HttpPut("UpdateCategories")]
    public async Task<Category> UpdateCategories(Category category)
    {
        return await connect.UpdateCategories(category);
    }
}
