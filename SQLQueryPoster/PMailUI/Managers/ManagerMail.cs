using Dapper;
using Dapper.Contrib.Extensions;
using PMailUI.Modals;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMailUI.Managers
{
    public class ManagerMail : BaseManager
    {
        string mail_sql = "SELECT * FROM query_poster.dbo.tb_mail WITH(nolock)";

        public ManagerMail()
        {

        }

        public List<Mail> GetList()
        {
            List<Mail> Data = new List<Mail>();
            try
            {
                Data = base.DbCon.Query<Mail>(mail_sql).ToList();
                base.IsSuccess = true;
            }
            catch (Exception ex)
            {
                base.ExMessage(ex);
            }
            return Data;
        }

        public Dictionary<int, string> GetComboSource()
        {
            Dictionary<int, string> MailSoruce = new Dictionary<int, string>();
            List<Mail> Data = base.DbCon.Query<Mail>(mail_sql).ToList();
            foreach (Mail m in Data)
            {
                MailSoruce.Add(m.mail_no, m.mail_adi + " | " + m.mail_adres);
            }
            return MailSoruce;
        }

        public List<string> GetMailList(string MailID)
        {
            List<string> MailList = new List<string>();
            if (!string.IsNullOrEmpty(MailID)) MailList = base.DbCon.Query<string>($@"SELECT mail_adres FROM query_poster.dbo.tb_mail WITH(nolock) WHERE mail_no IN ({MailID}) ").ToList();
            return MailList;
        }

        public void AddOrUpdate(Mail Data)
        {
            try
            {
                if (Data.mail_no > 0) base.DbCon.Update(Data);
                else base.DbCon.Insert(Data);
                base.IsSuccess = true;
            }
            catch (Exception ex)
            {
                base.ExMessage(ex);
            }
        }
        public void Delete(Mail Data)
        {
            try
            {
                base.DbCon.Delete(Data);
                base.IsSuccess = true;
            }
            catch (Exception ex)
            {
                base.ExMessage(ex);
            }
        }
    }
}

