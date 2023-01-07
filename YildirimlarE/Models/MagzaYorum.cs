﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YildirimlarE.Models
{
    public class MagzaYorum
    {
        [Key]
        public int id { get; set; }
        public string  Yorum { get; set; }
        public string  KullaniciAdi { get; set; }
        public string  EMail { get; set; }
        public int MagzaId { get; set; }
        public virtual Magza  Magza { get; set; }
    }
}