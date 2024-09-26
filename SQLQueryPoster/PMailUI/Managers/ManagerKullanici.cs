using Dapper;
using Dapper.Contrib.Extensions;
using PMailUI.Modals;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMailUI.Managers
{
    public class ManagerKullanici : BaseManager
    {
        string kullanici_sql = "SELECT * FROM query_poster.dbo.tb_kullanici WITH(nolock) ";
        public ManagerKullanici()
        {

        }
        public List<Kullanici> GetList()
        {
            List<Kullanici> Data = new List<Kullanici>();
            try
            {
                Data = base.DbCon.Query<Kullanici>(kullanici_sql + " WHERE kullanici_no != 1").ToList();
                base.IsSuccess = true;
            }
            catch (Exception ex)
            {
                base.ExMessage(ex);
            }
            return Data;
        }
        public Kullanici GetSatir(string kullanici, string sifre)
        {
            Kullanici Data = null;
            try
            {
                Data = new Kullanici();
                //Data = base.DbCon.QueryFirstOrDefault<Kullanici>("SELECT * FROM query_poster.dbo.tb_kullanici WITH(nolock) WHERE adi= @kullanici AND sifre= @sifre", new { kullanici = kullanici, sifre= sifre });
                Data = base.DbCon.QueryFirstOrDefault<Kullanici>($@"{kullanici_sql} WHERE adi= '{kullanici}' AND sifre= '{sifre}'");
                base.IsSuccess = true;
            }
            catch (Exception ex)
            {
                base.ExMessage(ex);
            }
            return Data;
        }
        public void AddOrUpdate(Kullanici Data)
        {
            try
            {
                if (Data.kullanici_no > 0) base.DbCon.Update(Data);
                else base.DbCon.Insert(Data);
                base.IsSuccess = true;
            }
            catch (Exception ex)
            {
                base.ExMessage(ex);
            }
        }
        public void Delete(Kullanici Data)
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
