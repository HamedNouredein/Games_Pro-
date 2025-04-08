using System.ComponentModel.DataAnnotations;

namespace Games_Pro.Models
{
    public class Device:baseEntity
    {
        [MaxLength(50)]
        public string Icon { get; set; }=string.Empty;
    }
}
