namespace Infrustructure.Services.PostServices;
using Domain.Dtos.PostDtos;
public interface IPostService
{
    Task<List<GetPostDtos>> GetPosts();
    Task<GetPostDtos> GetPostById(int id);
    Task<GetPostDtos> AddPost(AddPostDtos post);
    Task<bool> DeletePost(int id);
    Task<GetPostDtos> UpdatePost(AddPostDtos post);
    int GetPostsCount();
}
