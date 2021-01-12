using System.Collections.Generic;
using System.Threading.Tasks;

public interface IPhotoRepository
{
    Task<Photo> GetByID(int id);

    Task<List<Photo>> GetAll();
}