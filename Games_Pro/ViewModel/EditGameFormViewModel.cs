using GameZone.Attributes;

namespace Games_Pro.ViewModel
{
    public class EditGameFormViewModel: GameFormViewModel
    {
        public int Id { get; set; }

        public string? CurrentCover { get; set; }

        [AllowedExtensions(FileSettings.AllowwdExtensions),
            MaxFileSize(FileSettings.MaxFileSizeInBytes)]
        public IFormFile? Cover { get; set; } = default!;
    }
}
