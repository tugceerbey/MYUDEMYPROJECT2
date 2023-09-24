using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.DtoLayer1.Dtos.RoomDto
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Lütfen oda numarasını yazınız")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen oda görseli yazınız")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz")]
        [StringLength(100, ErrorMessage = "Lütfen en fazla 100 karakter veri girişi yapınız")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen oda Başlığını giriniz")]
        
        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısını giriniz")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo sayısını giriniz")]
        public string BathCount { get; set; }

        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen açıklamayı yazınız")]
        public string Description { get; set; }
    }
}
