using System.ComponentModel.DataAnnotations;

namespace Games_Pro.Models
{
    public class baseEntity
    {
        public int Id { get; set; }
        [MaxLength(500)]
        public string Name { get; set; }
        
    }
}
