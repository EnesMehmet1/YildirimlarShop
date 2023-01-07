using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YildirimlarE.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        public string FotoUrl1 { get; set; }
        public string Aciklama { get; set; }
    }
}