using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Il
    {
        public int Id { get; set; }
        public string IlAdi { get; set; }
        public int ToplamPoliklinik { get; set; }
        public int ToplamHastaneSevkSayisi { get; set; }
        public virtual ICollection<Kamp> Kamplar { get; set; }
        public virtual ICollection<IlVeriGirisGunluk> GunlukRapor { get; set; }
        public bool IptalMi { get; set; }


    }
}