using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Kamp
    {
        public int Id { get; set; }
        public string KampAdi { get; set; }
        public bool IptalMi { get; set; }
        public string Aciklama { get; set; }
        public Nullable<DateTime> AcilisTarihi { get; set; }
        public int ToplamPoliklinikSayisi { get; set; }
        public int ToplamHastaneSevkSayisi { get; set; }

        public virtual ICollection<KampVeriGirisGunluk> KampGunlukVeriGiris { get; set; }

        public virtual Il Il { get; set; }

    }
}