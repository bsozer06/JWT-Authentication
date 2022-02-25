using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    class Kullanici: Base
    {
        [Required]
        [StringLength(50, ErrorMessage = "Kullanıcı adı 50 karakterden fazla olamaz.")]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Ad 50 karakterden fazla olamaz.")]
        public string Adi { get; set; }
        public string Soyadi { get; set; }

        //[Required]
        [StringLength(150, ErrorMessage = "Şifre 150 karakterden fazla olamaz.")]
        public string Sifre { get; set; }

        public bool Aktif { get; set; }

        public byte? Tip { get; set; }
    }
}
