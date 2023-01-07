using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YildirimlarE.Models
{
    public class UrunYorum
    {
        [Key]
        public int Id { get; set; }
        public string Yorum { get; set; }
        public string KullaniciAdi { get; set; }
        public string EMail { get; set; }
        public int UrunId { get; set; }
        public virtual Urun Urun { get; set; }
    }
}