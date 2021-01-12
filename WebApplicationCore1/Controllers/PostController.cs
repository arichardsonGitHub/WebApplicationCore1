using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Route("Posts")]
public class PostController : Controller
{
    private  IPostRepository _postRepo;

    public PostController(IPostRepository postRepo)
    {
        _postRepo = postRepo;
    }

    [HttpGet("")]
    public async Task<IActionResult> Index()
    {
        return View(await _postRepo.GetAll());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByID(int id)
    {
        return View(await _postRepo.GetByID(id));
    }
}