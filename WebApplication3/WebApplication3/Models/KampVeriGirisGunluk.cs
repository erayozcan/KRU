using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class KampVeriGirisGunluk
    {
        public int Id { get; set; }
        public int PoliklinikSayisi { get; set; }
        public int HastaneSevkSayisi { get; set; }
        public Nullable<DateTime> VeriGirisTarihi { get; set; }
        public User VeriGirisiYapanKullanici { get; set; }
        public virtual Kamp Kamp { get; set; }


    }
}