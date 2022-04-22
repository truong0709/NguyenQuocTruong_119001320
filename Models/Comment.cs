using System.ComponentModel.DataAnnotations;
namespace NguyenQuocTruong.Models
{
    public class Comment
    {
        public int Id { get; set; }
        
        [Required]
        public string Author { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime CreateAt { get; set; }




    }
}
