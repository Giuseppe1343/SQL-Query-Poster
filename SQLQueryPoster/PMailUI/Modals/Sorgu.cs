using Dapper.Contrib.Extensions;
using System;

namespace PMailUI.Modals
{
    [Table("tb_sorgu")]
    public class Sorgu
    {
        [Key]
        public int sorgu_no { get; set; }
        public bool durum { get; set; }
        public string sorgu_adi { get; set; }
        public string sorgu_icerik { get; set; }
        public int tablo_tipi { get; set; }
        public int duzelten { get; set; }
        public DateTime duzeltme_tarih { get; set; }
        public string parametre { get; set; }
        [Write(false)]
        public bool degistir { get; set; }
        [Write(false)]
        public bool sil { get; set; }
        [Write(false)]
        public bool excel { get; set; }
        [Write(false)]
        public bool mail { get; set; }
    }
}
