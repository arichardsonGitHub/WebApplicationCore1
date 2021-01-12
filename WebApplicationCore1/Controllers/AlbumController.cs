using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Route("Albums")]
public class AlbumController : Controller
{
    private IAlbumRepository _albumRepo;

    public AlbumController(IAlbumRepository albumRepo)
    {
        _albumRepo = albumRepo;
    }

    [HttpGet("")]
    public async Task<IActionResult> Index()
    {
        var albums = await _albumRepo.GetAll();

        return View(albums);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByID(int id)
    {
        var album = await _albumRepo.GetByID(id);
        
        return View(album);
    }
}
