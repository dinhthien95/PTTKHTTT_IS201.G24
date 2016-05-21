using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DTO;
namespace DAO
{
    public class HocVienDAO : DBConnection
    {
        public HocVienDAO() : base() { }

        DataTable dt = new DataTable();
        //public DataTable DanhSachMaHocVien()
        //{

        //    try
        //    {
        //        if (conn.State != ConnectionState.Open)
        //            conn.Open();

        //        SqlCommand cmd = conn.CreateCommand();
        //        cmd.CommandText = string.Format("SELECT * FORM HocVien", conn);
        //        try
        //        {
        //            SqlDataReader rd = cmd.ExecuteReader();
        //            dt.Load(rd);
        //            return dt;
        //        }
        //        catch
        //        {
        //            conn.Close();
        //            throw;
        //        }
        //    }
        //}

    }
}
