using Dapper;
using Dapper.Contrib.Extensions;
using PMailUI.Modals;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PMailUI.Managers
{
    public class ManagerSorgu : BaseManager
    {
        string sorgu_sql = "SELECT * FROM query_poster.dbo.tb_sorgu WITH(nolock)";

        public ManagerSorgu()
        {

        }
        public Sorgu GetSorgu(int sorguno)
        {
            var Data = new Sorgu();
            try
            {
                Data = base.DbCon.Query<Sorgu>(@"SELECT * FROM query_poster.dbo.tb_sorgu AS ts WITH(nolock) WHERE sorgu_no=@sorguno", new { sorguno }).FirstOrDefault();

                base.IsSuccess = true;
            }
            catch (Exception ex)
            {
                base.ExMessage(ex);
            }
            return Data;
        }
        public List<Sorgu> GetList()
        {
            List<Sorgu> Data = new List<Sorgu>();
            try
            {

                if (S.AktifKullanici.kullanici_no == 1) Data = base.DbCon.Query<Sorgu>(sorgu_sql).ToList();
                else
                {
                    Data = base.DbCon.Query<Sorgu>(@"SELECT ts.*, ty.degistir, ty.sil, ty.excel, ty.mail FROM query_poster.dbo.tb_sorgu AS ts WITH(nolock) LEFT JOIN tb_yetki AS ty ON ts.sorgu_no=ty.bag_sorgu WHERE ty.bag_kullanici=@kullanici_no AND ty.goster=1 AND ts.durum = 1", S.AktifKullanici).ToList();
                }
                base.IsSuccess = true;
            }
            catch (Exception ex)
            {
                base.ExMessage(ex);
            }
            return Data;
        }
        public List<Yetki> GetSorguKullanici(int sorguno)
        {
            List<Yetki> Data = new List<Yetki>();
            try
            {
                Data = base.DbCon.Query<Yetki>(@"SELECT tk.adi, COALESCE(ty.bag_kullanici,tk.kullanici_no) AS bag_kullanici, ty.* FROM tb_kullanici AS tk WITH(nolock) LEFT JOIN tb_yetki AS ty ON tk.kullanici_no = ty.bag_kullanici AND ty.bag_sorgu = @sorguno WHERE tk.kullanici_no!=1", new { sorguno }).ToList();
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
        public void AddOrUpdate(Sorgu Data)
        {
            try
            {
                if (Data.sorgu_no == 0 && S.AktifKullanici.kullanici_no == 1) base.DbCon.Insert(Data);
                else base.DbCon.Update(Data);
                base.IsSuccess = true;
            }
            catch (Exception ex)
            {
                base.ExMessage(ex);
            }
        }
        public void Delete(Sorgu Data)
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

        public void AddOrUpdate(Yetki Data)
        {
            try
            {
                if (Data.yetki_no > 0) base.DbCon.Update(Data);
                else base.DbCon.Insert(Data);
                base.IsSuccess = true;
            }
            catch (Exception ex)
            {
                base.ExMessage(ex);
            }
        }
        public void AddOrUpdate(List<Yetki> Data)
        {
            try
            {
                foreach (var item in Data)
                {
                    if (item.yetki_no > 0) base.DbCon.Update(item);
                    else base.DbCon.Insert(item);
                }

                base.IsSuccess = true;
            }
            catch (Exception ex)
            {
                base.ExMessage(ex);
            }
        }
        public void Delete(Yetki Data)
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
        public DataTable ConvertCSVtoDataTable(string strCSV)
        {
            if (string.IsNullOrEmpty(strCSV)) strCSV = "Param;Value";
            string[] Lines = strCSV.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            string[] Fields;
            Fields = Lines[0].Split(new char[] { ';' });
            int Cols = Fields.GetLength(0);
            DataTable dt = new DataTable();
            //1st row must be column names; force lower case to ensure matching later on.
            for (int i = 0; i < Cols; i++)
                dt.Columns.Add(Fields[i].ToLower(), typeof(string));
            DataRow Row;
            for (int i = 1; i < Lines.GetLength(0); i++)
            {
                Fields = Lines[i].Split(new char[] { ';' });
                bool noEmpty = true;
                foreach (string field in Fields)
                {
                    if (string.IsNullOrEmpty(field)) noEmpty = false;
                }
                if (noEmpty && Fields.Length > 0)
                {
                    Row = dt.NewRow();
                    for (int f = 0; f < Cols; f++)
                        Row[f] = Fields[f];
                    dt.Rows.Add(Row);
                }
            }
            return dt;
        }
    }
}
