using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Caffe.Models
{
    public class ChiTietHoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHoaDonChiTiet { get; set; }
        public int MaHoaDon { get; set; }
        public int DrinkId { get; set; }
        public int price { get; set; }
        public int SoLuong { get; set; }
        [ForeignKey("MaHoaDon")]
        public HoaDon HoaDon { get; set; }

    }
}
