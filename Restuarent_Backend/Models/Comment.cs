namespace Restuarent_Backend.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string MenuItemId { get; set; }
        public string Comments { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
