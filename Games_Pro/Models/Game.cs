using System.ComponentModel.DataAnnotations;

namespace Games_Pro.Models
{
    public class Game:baseEntity
    { 
      
        [MaxLength(2500)]
        public string Description { get; set; }
        [MaxLength(500)]
        public string Cover { get; set; }
        public int CategoryId { get; set; }// هنا الفورنكي
        public Category Category { get; set; } = default!;//ربط جدول الكاتوجري
        public ICollection<GameDevice> Devices { get; set; }= new List<GameDevice>();// هنا العلاقة مني تو مني 
    }
}
