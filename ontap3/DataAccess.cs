using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ontap3
{
    public class DataAccess
    {
        private SqlConnection con;
        //Thằng em dưới đây sẽ tạo kết nối đến CSDL
        public void MoMotKetNoi()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Andy\source\repos\ontap3\ontap3\App_Data\data.mdf;Integrated Security=True";
            con.Open();
            //xong 
        }
        public DataTable LayBangDuLieu(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, this.con);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
            //xong
        }
        public void DongKetNoiCSDL()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            //xong
        }
    }
}