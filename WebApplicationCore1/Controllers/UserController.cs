using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Route("Users")]
public class UserController : Controller
{
    private IUserRepository _userRepo;
    private IAlbumRepository _albumRepo;
    private IPostRepository _postRepo;

    public UserController(IUserRepository userRepo, IAlbumRepository albumRepo, IPostRepository postRepo)
    {
        _userRepo = userRepo;
        _albumRepo = albumRepo;
        _postRepo = postRepo;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var users = await _userRepo.GetAll();
        return View(users);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByID(int id)
    {
        var user = await _userRepo.GetByID(id);
        user.Albums = await _albumRepo.GetForUser(user.ID);
        user.Posts = await _postRepo.GetForUser(user.ID);

        return View(user);
    }
}