using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YildirimlarE.Models
{
    public class Urun
    {   
        [Key]
        public int UrunId { get; set; }
        public string Ad { get; set; }
        public string FotoUrl { get; set; }
        public int Stok { get; set; }
        public string UrunAciklama { get; set; }
        public virtual Kategori  kategori { get; set; }
        public ICollection<UrunYorum> UrunYorums { get; set; }
    }
}   