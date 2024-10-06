using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Restuarent_Backend.Models.MenuEntity
{
    public class MenuTable
    {
        [Key]
        [Required]
        public string MenuItemId { get; set;}

        [Required]
        public string Title { get; set;}
        [Required]
        public string Description { get; set;}
        [Required]
        public decimal Price { get; set;}
        [Required]
        public string Category { get; set;}
        [Required]
        public string ImageUrl { get; set;}
        
        public bool? IsAvailable { get; set;}

        public DateTime DateTime { get; set;} = DateTime.Now;


    }
}
