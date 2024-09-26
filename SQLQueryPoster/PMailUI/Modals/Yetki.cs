using Dapper.Contrib.Extensions;

namespace PMailUI.Modals
{
    [Table("tb_yetki")]

    public class Yetki
    {
        [Key]
        public int yetki_no { get; set; }
        public int bag_kullanici { get; set; }
        public int bag_sorgu { get; set; }
        public bool goster { get; set; }
        public bool degistir { get; set; }
        public bool sil { get; set; }
        public bool excel { get; set; }
        public bool mail { get; set; }
        [Write(false)]
        public string adi { get; set; }
    }
}
