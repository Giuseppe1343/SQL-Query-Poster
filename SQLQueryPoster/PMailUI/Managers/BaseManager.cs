using System;
using System.Configuration;
using System.Data.SqlClient;

namespace PMailUI.Managers
{
    public class BaseManager
    {
        public SqlConnection DbCon { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public BaseManager()
        {
            DbCon = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
        }
        public void ExMessage(Exception ex)
        {
            this.IsSuccess = false;
            this.Message = ex.Message;
        }
    }
}
