using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebReport1.Models
{

    public class TienDo
    {

       
        public string TT { set; get; }
        public string MA { set; get; }
        public string CHITIEU { set; get; }
        public string THANG { set; get; }
        public string QUY { set; get; }
        public string NAM { set; get; }
        public string KHQUY { set; get; }
        public string KHNAM { set; get; }

    }
    class QLtableList
    {

        DBConnection DB;
        public QLtableList()
        {
            DB = new DBConnection();

        }
        public List<TienDo> getTienDo()
        {
            string sql = "";
                sql = "SELECT * FROM TienDoCBQL";
           
            

            List<TienDo> strTable = new List<TienDo>();
            SqlConnection con = DB.getConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();

            con.Open();
            cmd.Fill(dt);
            cmd.Dispose();
            con.Close();
            TienDo strH;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strH = new TienDo();
       
                strH.TT = dt.Rows[i]["TT"].ToString();
                strH.MA = dt.Rows[i]["MA"].ToString();
                strH.CHITIEU = dt.Rows[i]["CHITIEU"].ToString();
                strH.THANG = dt.Rows[i]["THANG"].ToString();
                strH.QUY = dt.Rows[i]["QUY"].ToString();
                strH.NAM = dt.Rows[i]["NAM"].ToString();
                strH.KHQUY = dt.Rows[i]["KHQUY"].ToString();
                strH.KHNAM = dt.Rows[i]["KHNAM"].ToString();
                strTable.Add(strH);
            }
            return strTable;
        }
    }
}