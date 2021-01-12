using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Route("Photos")]
public class PhotoController : Controller
{
    private IPhotoRepository _photoRepo;

    public PhotoController(IPhotoRepository photoRepo)
    {
        _photoRepo = photoRepo;
    }

    [HttpGet("")]
    public async Task<IActionResult> IndexAsync()
    {
        var allPhotos = await _photoRepo.GetAll();

        return View(allPhotos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIDAsync(int id)
    {
        var photo = await _photoRepo.GetByID(id);

        return View(photo);
    }
}