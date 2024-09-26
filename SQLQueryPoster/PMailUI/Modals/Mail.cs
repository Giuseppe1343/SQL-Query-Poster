using Dapper.Contrib.Extensions;

namespace PMailUI.Modals
{
    [Table("tb_mail")]
    public class Mail
    {
        [Key]
        public int mail_no { get; set; }
        public string mail_adi { get; set; }
        public string mail_adres { get; set; }
    }
}

