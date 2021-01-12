using System.Collections.Generic;
using System.Threading.Tasks;

public interface ICommentRepository
{
    Task<List<Comment>> GetAll();

    Task<Comment> GetById(int id);
}