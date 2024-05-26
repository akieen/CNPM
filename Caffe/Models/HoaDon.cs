using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Caffe.Models
{
    public class HoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHoaDon { get; set; }
        [Required]

        public DateTime NgayTao { get; set; } = DateTime.Now;

        public int? KhachHangId { get; set; }
        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

    }
}
