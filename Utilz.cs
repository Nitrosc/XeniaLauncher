using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Net;
using static System.Data.Entity.Infrastructure.Design.Executor;
using System.Collections;

namespace XeniaLauncher
{
    internal class Utilz
    {

        public SQLiteConnection getConn()
        {
            return new SQLiteConnection("Data Source=XenLaucher.sqlite;Version=3;");
        }
        public string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int num = strSource.IndexOf(strStart, 0) + strStart.Length;
                int num2 = strSource.IndexOf(strEnd, num);
                return strSource.Substring(num, num2 - num);
            }
            return "";
        }
        public String getXenia(int decider) {
            String dirXenia = "";
            String dirXeniaC = "";
            SQLiteConnection conn = getConn();
            conn.Open();
            String sql = "SELECT* FROM Files";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                dirXenia = reader["XenieExe"].ToString();
                dirXeniaC = reader["XeniaCExe"].ToString();

            }
            reader.Close();
            conn.Close();
            String whichXenia = "";
            if (decider == 0)
            {
                whichXenia = dirXenia;
            }
            if (decider == 1) {
                whichXenia = dirXeniaC;
            }

            return whichXenia;
        }
        public void updatedone() {
            if (Global.updateend == 1) {

                SQLiteConnection conn = getConn();
                conn.Open();
                String sql = "UPDATE Files SET XenieExe='"+Global.XeniaDir+ "\\xenia.exe', XeniaVer='"+Global.XeniawebDate+"', XeniaDir='" + Global.XeniaDir+"'";
                if (Global.wichXenia==1) {
                    sql = "UPDATE Files SET XeniaCExe='"+Global.XeniaCDir+ "\\xenia_canary.exe', XeniaC='"+Global.XeniaCwebDate+"', XeniaCDir='" + Global.XeniaCDir+"'";
                }
                SQLiteCommand command = new SQLiteCommand(sql,conn);
                command.ExecuteNonQuery();



                conn.Close();



            }
        
        }
        public void createdb()
        {
            SQLiteConnection conn = getConn();
            conn.Open();
            try
            {
                string sql2 = "CREATE TABLE IF NOT EXISTS Files (UUID VARCHAR(64) PRIMARY KEY, XenieExe VARCHAR(600), XeniaCExe VARCHAR(600), XeniaVer VARCHAR(100), XeniaC VARCHAR(100), XeniaDir VARCHAR(600), XeniaCDir VARCHAR(600))";
                SQLiteCommand command2 = new SQLiteCommand(sql2, conn);
                command2.ExecuteNonQuery();
            }
            catch
            {
            }
            try
            {
                string sql2 = "CREATE TABLE IF NOT EXISTS Rompath (UUID VARCHAR(64) PRIMARY KEY, Directory VARCHAR(600))";
                SQLiteCommand command2 = new SQLiteCommand(sql2, conn);
                command2.ExecuteNonQuery();
            }
            catch
            {
            }
            try
            {
                string sql2 = "CREATE TABLE IF NOT EXISTS Games (UUID VARCHAR(64) PRIMARY KEY, Directory VARCHAR(600),GameName VARCHAR(600), WichXenia VARCHAR(10), FullScreen VARCHAR(10),InternalR VARCHAR(10), PostAnti VARCHAR(10),Rx VARCHAR(10),Ry VARCHAR(10),GpuInvalid VARCHAR(10), Vsync VARCHAR(10), NativeMS VARCHAR(10),UserLang VARCHAR(30),Renderer VARCHAR(30),Framelimit VARCHAR(30))";
                SQLiteCommand command2 = new SQLiteCommand(sql2, conn);
                command2.ExecuteNonQuery();
            }
            catch
            {
            }
            conn.Close();
        }
        public void setfiles() {
            SQLiteConnection conn = getConn();
            conn.Open();
            string sql = "SELECT* FROM Files";
            SQLiteCommand command = new SQLiteCommand(sql,conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Global.XeniaExe = reader["XenieExe"].ToString();
                Global.XeniaLast= reader["XeniaVer"].ToString();
                Global.XeniaCExe = reader["XeniaCExe"].ToString();
                Global.XeniaCLast= reader["XeniaC"].ToString();
                Global.XeniaDir = reader["XeniaDir"].ToString();
                Global.XeniaCDir = reader["XeniaCDir"].ToString();


            }
            reader.Close();
            conn.Close();

        }
        public int checkUpdateXenia()
        {
            int update = 0;
            if (!Global.XeniaLast.Equals("")) {
                string htmlCode = "";
                using (WebClient client = new WebClient())
                {
                    htmlCode = client.DownloadString("https://github.com/xenia-project/release-builds-windows/releases");
                }
                Utilz ut = new Utilz();
                String fecha = ut.getBetween(htmlCode, "datetime=\"", "\">");
                fecha = ut.getBetween(fecha, "", "T");
                DateTime LatestDate = DateTime.ParseExact(fecha, "yyyy-MM-dd",
                                           System.Globalization.CultureInfo.InvariantCulture);
                Global.XeniawebDate = LatestDate.ToString("yyyy-MM-dd");
                DateTime sysDate = DateTime.ParseExact(Global.XeniaLast, "yyyy-MM-dd",
                                           System.Globalization.CultureInfo.InvariantCulture);
                if (LatestDate > sysDate) {
                    update = 1;
                }
            }
            // Console.WriteLine(fecha);



            
            return update;
        }
      
           
        public int checkUpdateXeniaCanary() {

            int update = 0;
            if (!Global.XeniaCLast.Equals("")) {
                string htmlCode = "";
                using (WebClient client = new WebClient())
                {
                    htmlCode = client.DownloadString("https://github.com/xenia-canary/xenia-canary/releases/tag/experimental");
                }
                Utilz ut = new Utilz();
                String fecha = ut.getBetween(htmlCode, "datetime=\"", "\">");
                fecha = ut.getBetween(fecha, "", "T");
                
                DateTime LatestDate = DateTime.ParseExact(fecha, "yyyy-MM-dd",
                                           System.Globalization.CultureInfo.InvariantCulture);
                DateTime sysDate = DateTime.ParseExact(Global.XeniaCLast, "yyyy-MM-dd",
                                           System.Globalization.CultureInfo.InvariantCulture);
                Global.XeniaCwebDate = LatestDate.ToString("yyyy-MM-dd");
                
                if (LatestDate > sysDate)
                {
                    update = 1;
                }
            }
            // Console.WriteLine(fecha);




            return update;
        }
    }
}
