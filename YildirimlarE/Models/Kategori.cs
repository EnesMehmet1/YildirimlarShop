using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YildirimlarE.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriAd { get; set; }
        public string KategoriFoto { get; set; }
        public ICollection<Urun> Uruns { get; set; }
    }
}