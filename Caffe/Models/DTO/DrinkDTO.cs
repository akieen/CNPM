using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Caffe.Models.DTO
{
    public class DrinkDTO
    {
        public int id;
      [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public IFormFile ImageFile { get; set; }

    }
}
