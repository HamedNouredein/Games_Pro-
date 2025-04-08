namespace Games_Pro.Models
{
    public class Category: baseEntity
    {
        public ICollection<Game> Games { get; set; }=new List<Game>();
    }
}
