using Domain.Dtos.PostDtos;
using Infrustructure.Services.PostServices;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class PostController : ControllerBase
{
    private IPostService _connection;

    public PostController(IPostService _connection)
    {
        this._connection = _connection;
    }

    [HttpGet("GetPosts")]
    public async Task<List<GetPostDtos>> GetPosts()
    {
        return await _connection.GetPosts();
    }
    [HttpGet("GetPostById")]
    public async Task<GetPostDtos> GetPostById(int id)
    {
        return await _connection.GetPostById(id);
    }
    [HttpGet("GetPostCount")]
    public int GetPostCount()
    {
        return _connection.GetPostsCount();
    }
    [HttpPost("AddPost")]
    public async Task<GetPostDtos> AddTeacher(AddPostDtos post)
    {
        return await _connection.AddPost(post);
    }
    [HttpDelete("DeletePost")]
    public async Task<bool> DeletePost(int id)
    {
        return await _connection.DeletePost(id);
    }
    [HttpPut("UpdatePost")]
    public async Task<GetPostDtos> UpdatePost(AddPostDtos post)
    {
        return await _connection.UpdatePost(post);
    }

}
