
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class IlVeriGirisGunluk
    {
        public int Id { get; set; }
        public int PoliklinikSayisi { get; set; }
        public int HastaneSevkSayisi { get; set; }
        public int SinirdanGirisYapanSayisi { get; set; }
        public int HastanePoliklinikSayisi { get; set; }
        public int HastanedeYatanHastaSayisi { get; set; }
        public int DogumSayisi { get; set; }
        public int AmeliyatSayisi { get; set; }
        public Nullable<DateTime> VeriGirisTarihi { get; set; }
        public User VeriGirisiYapanKullanici { get; set; }

        public virtual Il Il { get; set; }


    }
}