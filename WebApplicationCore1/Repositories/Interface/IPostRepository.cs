using System.Collections.Generic;
using System.Threading.Tasks;

public interface IPostRepository
{
    Task<List<Post>> GetAll();

    Task<Post> GetByID(int id);

    Task<List<Post>> GetForUser(int userID);
}