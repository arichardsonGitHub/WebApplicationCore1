using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

[Route("Comments")]
public class CommentController : Controller
{
    private ICommentRepository _commentRepo;

    public CommentController(ICommentRepository commentRepo)
    {
        _commentRepo = commentRepo;
    }

    [HttpGet("")]
    public async Task<IActionResult> Index()
    {
        var comments = await _commentRepo.GetAll();

        return View(comments);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var comment = await _commentRepo.GetById(id);

        return View(comment);
    }

}