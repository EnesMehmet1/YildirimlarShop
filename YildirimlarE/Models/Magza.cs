using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YildirimlarE.Models
{
    public class Magza
    {
        [Key]
        public int MagzaId { get; set; }
        public string MagzaAdi { get; set; }
        public string Aciklama { get; set; }
        public string FotoUrl { get; set; }
        public DateTime AcilisTarih { get; set; }
        public string Sehir { get; set; }
        public ICollection<MagzaYorum> MagzaYorums { get; set; }
    }
}