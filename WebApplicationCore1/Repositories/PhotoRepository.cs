using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

public class PhotoRepository : IPhotoRepository
{
    private const string GET_ALL_PHOTOS_URL = "https://jsonplaceholder.typicode.com/photos/";
    private const string GET_BY_ID_URL = "https://jsonplaceholder.typicode.com/photos/";

    public async Task<List<Photo>> GetAll()
    {
        using (var client = new HttpClient())
        {
            var photo = await client.GetStringAsync(GET_ALL_PHOTOS_URL);

            return JsonConvert.DeserializeObject<List<Photo>>(photo);
        }
    }

    public async Task<Photo> GetByID(int id)
    {
        using (var client = new HttpClient())
        {
            var photoJson = await client.GetStringAsync( $"{GET_BY_ID_URL}{id.ToString()}");
           
            return JsonConvert.DeserializeObject<Photo>(photoJson);
        }
    }
}