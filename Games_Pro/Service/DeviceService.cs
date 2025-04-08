
namespace Games_Pro.Service
{
    public class DeviceService : IDeviceService
    {
        private readonly ApplicationDbContext _context;

        public DeviceService(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<SelectListItem> GetDeviceList()
        {
            return _context.Devices
            .Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.Name }).AsNoTracking().ToList();
        }
    }
}
