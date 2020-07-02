using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebReport1.Models
{

    public class TienDoMLNS
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
    class QLtableListMLNS
    {

        DBConnectionTienDoMLNS DB;
        public QLtableListMLNS()
        {
            DB = new DBConnectionTienDoMLNS();

        }
        public List<TienDoMLNS> getTienDoMLNS()
        {
            string sql = "";
            sql = "SELECT * FROM TienDoMLNS";



            List<TienDoMLNS> strTable = new List<TienDoMLNS>();
            SqlConnection con = DB.getConnection();
            SqlDataAdapter cmd = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();

            con.Open();
            cmd.Fill(dt);
            cmd.Dispose();
            con.Close();
            TienDoMLNS strH;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strH = new TienDoMLNS();

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