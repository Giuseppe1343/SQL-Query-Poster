using Dapper;
using Dapper.Contrib.Extensions;
using PMailUI.Modals;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMailUI.Managers
{
    public class ManagerPlan : BaseManager
    {
        string plan_sql = "SELECT * FROM query_poster.dbo.tb_plan WITH(nolock)";

        public ManagerPlan()
        {

        }

        public List<Plan> GetList()
        {
            List<Plan> Data = new List<Plan>();
            try
            {
                Data = base.DbCon.Query<Plan>(@"SELECT tp.*,ts.sorgu_adi FROM query_poster.dbo.tb_plan AS tp WITH(nolock) LEFT JOIN tb_sorgu AS ts ON tp.bag_sorgu=ts.sorgu_no").ToList();
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
            Dictionary<int, string> SorguSource = new Dictionary<int, string>();
            List<Sorgu> Data = base.DbCon.Query<Sorgu>("SELECT sorgu_no,sorgu_adi FROM query_poster.dbo.tb_sorgu WITH(nolock)").ToList();
            foreach (Sorgu s in Data)
            {
                SorguSource.Add(s.sorgu_no, s.sorgu_adi);
            }
            return SorguSource;

        }

        public void AddOrUpdate(Plan Data)
        {
            try
            {
                if (Data.plan_no > 0) base.DbCon.Update(Data);
                else base.DbCon.Insert(Data);
                base.IsSuccess = true;
            }
            catch (Exception ex)
            {
                base.ExMessage(ex);
            }
        }
        public void Delete(Plan Data)
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
