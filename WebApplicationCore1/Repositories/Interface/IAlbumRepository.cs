using System.Collections.Generic;
using System.Threading.Tasks;

public interface IAlbumRepository
{
    Task<Album> GetByID(int id);

    Task<List<Album>> GetForUser(int userID);

    Task<List<Album>> GetAll();
}