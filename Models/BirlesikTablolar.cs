using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YildirimlarE.Models
{
    public class BirlesikTablolar
    {

        public IEnumerable<Magza> m { get; set; }
        public IEnumerable<MagzaYorum> y { get; set; }
        public IEnumerable<Magza> m2 { get; set; }
        public IEnumerable<Urun> u { get; set; }
        public IEnumerable<Urun> u2 { get; set; }
        public IEnumerable<Urun> u3 { get; set; }
        public IEnumerable<UrunYorum> uy { get; set; }
    }
}