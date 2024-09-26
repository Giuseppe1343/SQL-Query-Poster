using Dapper.Contrib.Extensions;
using System;

namespace PMailUI.Modals
{
    [Table("tb_plan")]
    public class Plan
    {
        [Key]
        public int plan_no { get; set; }
        public string plan_adi { get; set; }
        public int bag_sorgu { get; set; }
        public string bag_mail { get; set; }
        public DateTime ilk_tarih { get; set; }
        public DateTime son_tarih { get; set; }
        public byte bas_saat { get; set; }
        public byte bit_saat { get; set; }
        public byte dakika { get; set; }
        public byte saat { get; set; }
        public byte gun { get; set; }
        public byte hafta { get; set; }
        public byte ay { get; set; }
        public bool durum { get; set; }
        public bool mail_html { get; set; }
        [Write(false)]
        public string sorgu_adi { get; set; }

    }
}
