using GameZone.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Games_Pro.ViewModel
{
    public class CreateGameFormViewModel: GameFormViewModel
    {
        
        [AllowedExtensions(FileSettings.AllowwdExtensions),
        MaxFileSize(FileSettings.MaxFileSizeInBytes)]
        public IFormFile Cover { get; set; } = default!;
        
    }
}
