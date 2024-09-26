using Dapper;
using Dapper.Contrib.Extensions;
using PMailCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMailCore.Managers
{
    public class ManagerPlan : BaseManager
    {
        public ManagerPlan()
        {

        }

        public List<Plan> GetList()
        {
            List<Plan> Data = new List<Plan>();
            try
            {
                Data = base.DbCon.Query<Plan>($@"SELECT tp.*,ts.sorgu_icerik,ts.sorgu_adi, ts.parametre AS sorgu_parametre,ts.tablo_tipi FROM query_poster.dbo.tb_plan AS tp INNER JOIN tb_sorgu AS ts ON tp.bag_sorgu=ts.sorgu_no WHERE tp.durum = 1").ToList();

                base.IsSuccess = true;
            }
            catch (Exception ex)
            {
                base.ExMessage(ex);
            }
            return Data;
        }

        public List<dynamic> GetQueryResult(string dynamicQuery)
        {

            List<dynamic> dynamicQueryResult = new List<dynamic>();
            try
            {
                dynamicQueryResult = base.DbCon.Query<dynamic>(dynamicQuery).ToList();
                base.IsSuccess = true;
            }
            catch (Exception ex)
            {
                base.ExMessage(ex);
            }
            return dynamicQueryResult;
        }

        public List<string> GetMailAdresList(string MailID)
        {
            List<string> MailList = new List<string>();
            try
            {
                if (!string.IsNullOrEmpty(MailID)) MailList = base.DbCon.Query<string>($@"SELECT mail_adres FROM query_poster.dbo.tb_mail WITH(nolock) WHERE mail_no IN ({MailID}) ").ToList();
                base.IsSuccess = true;
            }
            catch (Exception ex)
            {
                base.ExMessage(ex);
            }
            return MailList;
        }

        public void Update(Plan Data)
        {
            try
            {
                base.DbCon.Update(Data);
                base.IsSuccess = true;
            }
            catch (Exception ex)
            {
                base.ExMessage(ex);
            }
        }
    }
}
