using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    class KyThiDAO : DBConnection
    {
        public bool AddKyThi(KyThi kt)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("InsKyThi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKyThi", SqlDbType.NVarChar).Value = kt._makythi;
                cmd.Parameters.Add("@NgayThi", SqlDbType.DateTime).Value = kt._ngaythi ;
                cmd.Parameters.Add("@GioThi", SqlDbType.Float).Value = kt._giothi;
                cmd.Parameters.Add("@MaPhongThi", SqlDbType.NVarChar).Value = kt._maphongthi;
                cmd.Parameters.Add("@MaDeThi", SqlDbType.NVarChar).Value = kt._madethi;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                conn.Close();
                Console.WriteLine(e);
                return false;
            }
        }
        public bool EditKyThi(KyThi kt)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("EditKyThi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKyThi", SqlDbType.NVarChar).Value = kt._makythi;
                cmd.Parameters.Add("@NgayThi", SqlDbType.DateTime).Value = kt._ngaythi;
                cmd.Parameters.Add("@GioThi", SqlDbType.Float).Value = kt._giothi;
                cmd.Parameters.Add("@MaPhongThi", SqlDbType.NVarChar).Value = kt._maphongthi;
                cmd.Parameters.Add("@MaDeThi", SqlDbType.NVarChar).Value = kt._madethi;
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }
        public bool DeleteKyThi(string makythi)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("DelKyThi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKyThi", SqlDbType.Int).Value = makythi;
                cmd.ExecuteNonQuery();

                conn.Close();
                return true;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }
    }
   
}
