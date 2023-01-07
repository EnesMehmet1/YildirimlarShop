using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace YildirimlarE.Models
{
    public class Context:DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Magza> Magzas { get; set; }
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<MagzaYorum> MagzaYorums { get; set; }
        public DbSet<UrunYorum> UrunYorums { get; set; }
    }
}