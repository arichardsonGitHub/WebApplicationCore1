using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

public class CommentRepository : ICommentRepository
{
    public async Task<List<Comment>> GetAll()
    {
        using (HttpClient client = new HttpClient())
        {
            var comment = await client.GetStringAsync("https://jsonplaceholder.typicode.com/comments");

            return JsonConvert.DeserializeObject<List<Comment>>(comment);
        }
    }

    public async Task<Comment> GetById(int id)
    {
        using (HttpClient client = new HttpClient())
        {
            var comment = await client.GetStringAsync("https://jsonplaceholder.typicode.com/comments/" + id.ToString());
          
            return JsonConvert.DeserializeObject<Comment>(comment);
        }
    }

}