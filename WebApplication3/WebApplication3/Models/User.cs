using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public Il KullaniciIli { get; set; }
        public KullaniciRol Rol { get; set; }
    }

    public enum KullaniciRol
    {
        Admin=1,
        Kullanici=2
    }
}