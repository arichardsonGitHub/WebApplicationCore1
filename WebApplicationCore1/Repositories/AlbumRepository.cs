using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

public class AlbumRepository : IAlbumRepository
{
    public async Task<List<Album>> GetAll()
    {
        using (HttpClient client = new HttpClient())
        {
            var album = await client.GetStringAsync("https://jsonplaceholder.typicode.com/albums");
            return JsonConvert.DeserializeObject<List<Album>>(album);
        }
    }

    public async Task<Album> GetByID(int id)
    {
        using (HttpClient client = new HttpClient())
        {
            var albumJson = await client.GetAsync("https://jsonplaceholder.typicode.com/albums/" + id.ToString()).Result.Content.ReadAsStringAsync();
            var album = JsonConvert.DeserializeObject<Album>(albumJson);

            var photosJson = await client.GetAsync("https://jsonplaceholder.typicode.com/photos?albumId=" + id.ToString()).Result.Content.ReadAsStringAsync();
            album.Photos = JsonConvert.DeserializeObject<List<Photo>>(photosJson);

            return album;
        }
    }

    public async Task<List<Album>> GetForUser(int userID)
    {
        using (HttpClient client = new HttpClient())
        {
            var album = await client.GetStringAsync("https://jsonplaceholder.typicode.com/albums?userId=" + userID.ToString());
            return JsonConvert.DeserializeObject<List<Album>>(album);
        }
    }
}