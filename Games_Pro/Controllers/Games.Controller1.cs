using Games_Pro.Models;
using Games_Pro.Service;

namespace Games_Pro.Controllers;

public class Games : Controller
{
private readonly ApplicationDbContext _context;
private readonly ICategoryService _categoryService;
private readonly IDeviceService _devicesService;
private readonly IGameService _gameService;
public Games(ApplicationDbContext context, ICategoryService categoryService, IDeviceService device, IGameService gameService)
{
    _context = context;
    _categoryService = categoryService;
        _devicesService = device;
    _gameService = gameService;
}
public IActionResult Index()
{
        var games = _gameService.GetAll();
        return View(games); ;
}
    public IActionResult Details(int id)
    {
        var game = _gameService.GetById(id);

        if (game is null)
            return NotFound();

        return View(game);
    }
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var game = _gameService.GetById(id);

        if (game is null)
            return NotFound();

        EditGameFormViewModel viewModel = new()
        {
            Id = id,
            Name = game.Name,
            Description = game.Description,
            CategoryId = game.CategoryId,
            SelectedDevices = game.Devices.Select(d => d.DeviceId).ToList(),
            Categories = _categoryService.GetSelectList(),
            Devices = _categoryService.GetSelectList(),
            CurrentCover = game.Cover
        };

        return View(viewModel);
    }
    [HttpGet]
public IActionResult Create()

    {
    CreateGameFormViewModel viewModel = new()
    {
        Categories = _categoryService.GetSelectList(),
        Devices = _devicesService.GetDeviceList() 
    };
        return View(viewModel);
    }
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Create(CreateGameFormViewModel model)
    {
    if (!ModelState.IsValid)
    {
        model.Categories = _categoryService.GetSelectList();
        model.Devices = _devicesService.GetDeviceList();
        return View(model);
    }
    await _gameService.Create(model); 

    return RedirectToAction(nameof(Index));
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(EditGameFormViewModel model)
    {
        if (!ModelState.IsValid)
        {
            model.Categories = _categoryService.GetSelectList();
            model.Devices = _devicesService.GetDeviceList();
            return View(model);
        }

        var game = await _gameService.Update(model);

        if (game is null)
            return BadRequest();

        return RedirectToAction(nameof(Index));
    }
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        var isDeleted = _gameService.Delete(id);

        return isDeleted ? Ok() : BadRequest();
    }

}
