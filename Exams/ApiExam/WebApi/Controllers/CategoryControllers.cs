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
    public List<Category> GetCategories()
    {
        return connect.GetCategories();
    }
    [HttpGet("GetCategoriesById")]
    public Category GetCategoriesById(int id)
    {
        return connect.GetCategoriesById(id);
    }
    
    [HttpPost("AddCategories")]
    public Category AddCategories(Category category)
    {
        return connect.AddCategories(category);
    }
    [HttpDelete("DeleteCategories")]
    public int DeleteCategories(int id)
    {
        return connect.DeleteCategories(id);
    }
    [HttpPut("UpdateCategories")]
    public Category UpdateCategories(Category category)
    {
        return connect.UpdateCategories(category);
    }
}
