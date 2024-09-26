using Dapper.Contrib.Extensions;
using System;

namespace PMailUI.Modals
{
    [Table("tb_kullanici")]
    public class Kullanici
    {
        [Key]
        public int kullanici_no { get; set; }
        public bool durum { get; set; }
        public string adi { get; set; }
        public string sifre { get; set; }
        public DateTime? son_giris { get; set; }
    }
}
