using Domain.Dtos.PostDtos;
using Domain.Entities;
using Infrustructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrustructure.Services.PostServices;

public class PostService : IPostService
{
    private DataContext _context;
     public PostService(DataContext _context)
    {
        this._context = _context;
    }



    public async Task<GetPostDtos> AddPost(AddPostDtos post)
    {
         var pos = new Post()
        {
            Id = post.Id,
            Description = post.Description,
            Vote=post.Vote,
            CreateAt=post.CreateAt,
            Title = post.Title
        };
       await _context.Posts.AddAsync(pos);
        await _context.SaveChangesAsync();
        return new GetPostDtos()
        {
            Id = post.Id,
            Description = post.Description,
            Vote=post.Vote,
            CreateAt=post.CreateAt,
            Title = post.Title
        };
    }

    public async Task<bool> DeletePost(int id)
    {
            var post = await _context.Posts.FindAsync(id);
        if (post != null)
        {
          _context.Posts.Remove(post);
            await _context.SaveChangesAsync();
            return true;
        }
        else
        {
            return false;
        }

    }

    public async Task<GetPostDtos> GetPostById(int id)
    {
        var post = await _context.Posts.Select(c => new GetPostDtos()
        {
            Id = c.Id,
            Title = c.Title,
            Description = c.Description,
            Vote=c.Vote,
            CreateAt=c.CreateAt
        }).FirstOrDefaultAsync(c => c.Id == id);
        return post;
    }

    public async Task<List<GetPostDtos>> GetPosts()
    {
            var post = await _context.Posts.Select(p => new GetPostDtos()
        {
            Id = p.Id,
            Title = p.Title,
            Description = p.Description,
           Vote=p.Vote,
           CreateAt=p.CreateAt
        }).ToListAsync();
        return post;
    }

    public int GetPostsCount()
    {
     return _context.Posts.Count();
    }

    public async Task<GetPostDtos> UpdatePost(AddPostDtos post)
    {
         var pos = new Post()
        {
          Id = post.Id,
            Description = post.Description,
            Title = post.Title,
         Vote=post.Vote,
         CreateAt=post.CreateAt
        };
     _context.Posts.Update(pos);
     await _context.SaveChangesAsync();
     return new GetPostDtos()
        {
            Id = post.Id,
            Description = post.Description,
            Title = post.Title,
            Vote=post.Vote,
            CreateAt=post.CreateAt
        };
    }

}
