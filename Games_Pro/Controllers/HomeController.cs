using System.Diagnostics;

namespace GameZone.Controllers;
public class HomeController : Controller
{
    private readonly IGameService _gamesService;

    public HomeController(IGameService gamesService)
    {
        _gamesService = gamesService;
    }

    public IActionResult Index()
    {
        var games = _gamesService.GetAll();
        return View(games);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}