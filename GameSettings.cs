using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XeniaLauncher
{
    public partial class GameSettings : Form
    {
        String gameUUID = "";
        private string Frames = "";

        public GameSettings()
        {
            InitializeComponent();
            etxt_FrameLimit.TextChanged += etxt_FrameChanged;
            Global.RunGame = "";
            Utilz ut = new Utilz();
            stxt_title.Text = Global.gameName;
            setDafault();
            try {
                filldata();
            }
            catch { }
           // Console.WriteLine("testeando "+Global.gameName);
        }
        public void setDafault()
        {

            cb_internal.SelectedIndex = 7;
            cb_postanti.SelectedItem = "none";
            cb_resolutionx.SelectedItem = "1";
            cb_drawresolitony.SelectedItem = "1";
            cb_lang.SelectedIndex = 0;
            cb_renderer.SelectedItem = "any";
            etxt_FrameLimit.Text = "60";
        }
        public void saveGameSettings() {
            //Games (UUID VARCHAR(64) PRIMARY KEY, Directory VARCHAR(600),GameName VARCHAR(600), WichXenia VARCHAR(10), CustomName VARCHAR(600), FullScreen VARCHAR(10),InternalR VARCHAR(10), PostAnti VARCHAR(10),Rx VARCHAR(10),Ry VARCHAR(10),GpuInvalid VARCHAR(10), Vsync VARCHAR(10), NativeMS VARCHAR(10), UserLang VARCHAR(30))";
            Utilz ut = new Utilz();
            SQLiteConnection conn = ut.getConn();
            conn.Open();
            if (gameUUID.Equals("")) {
                gameUUID = Guid.NewGuid().ToString();
            }
            String WichXenia = "1";
            if (cb_master.Checked) {
                WichXenia = "0";
            }
            String FullScreen = "0";
            if (cb_fscreen.Checked) {
                FullScreen = "1";
            }
            int indexInterR = cb_internal.SelectedIndex;
           
            String InternalR = ""+indexInterR;
            String PostAnti = cb_postanti.Text.ToString();
            String Rx = cb_resolutionx.Text.ToString();
            String Ry = cb_drawresolitony.Text.ToString();
            String GpuInvalid = "0";
            if (cb_allowinvalid.Checked) { 
                GpuInvalid = "1";
            }
            String Vsync = "1";
            if (!cb_vsync.Checked) {
                Vsync = "0";
            }
            String NativeMS = "1";
            if (!cb_msaa.Checked) {
                NativeMS = "0";
            }
            int indexlang= cb_lang.SelectedIndex;
            String UserLang = ""+indexlang;
            String Renderer = "\"" + cb_renderer.Text.ToString()+"\"";
            String Framelimit = "" + etxt_FrameLimit.Text.ToString();
            
            String sql = "REPLACE INTO Games (UUID,Directory,GameName,WichXenia,FullScreen,InternalR,PostAnti,Rx,Ry,GpuInvalid,Vsync,NativeMS,UserLang,Renderer,Framelimit)" +
                "VALUES ('"+gameUUID+"','"+Global.GameDir+"','"+Global.gameName+"','"+WichXenia+"','"+FullScreen+"','"+InternalR+"','"+PostAnti+"','"+Rx+"','"+Ry+"','"+GpuInvalid+"','"+Vsync+"','"+NativeMS+"','"+UserLang+"','"+ Renderer + "','"+ Framelimit + "')";
            SQLiteCommand command = new SQLiteCommand(sql,conn);
            command.ExecuteNonQuery();

            conn.Close();

        }
        private void etxt_FrameChanged(object sender, EventArgs e)
        {
          
            if (etxt_FrameLimit.Text.ToString().Equals(""))
            {
                Frames = "";
            }
            if (IsN(etxt_FrameLimit.Text.ToString()))
            {
                Frames = etxt_FrameLimit.Text.ToString();
                return;
            }
            etxt_FrameLimit.Text = Frames;
            etxt_FrameLimit.Focus();
            etxt_FrameLimit.Select(etxt_FrameLimit.Text.Length, 0);
        }

        public static bool IsN(object Expression)
        {
            double result;
            return double.TryParse(Convert.ToString(Expression), NumberStyles.Any, NumberFormatInfo.InvariantInfo, out result);
        }
        public void filldata() {
            // string sql2 = "CREATE TABLE IF NOT EXISTS Games (UUID VARCHAR(64) PRIMARY KEY, Directory VARCHAR(600),GameName VARCHAR(600), WichXenia VARCHAR(10), CustomName VARCHAR(600), FullScreen VARCHAR(10),InternalR VARCHAR(10), PostAnti VARCHAR(10),Rx VARCHAR(10),Ry VARCHAR(10),GpuInvalid VARCHAR(10), Vsync VARCHAR(10), NativeMS VARCHAR(10), UserLang VARCHAR(30))";
            Utilz ut = new Utilz();
            SQLiteConnection conn = ut.getConn();
            conn.Open();
            String sql = "SELECT* FROM Games WHERE Directory='"+Global.GameDir+"'";
            SQLiteCommand command = new SQLiteCommand(sql,conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                
                if (reader["WichXenia"].ToString().Equals("0")) {
                    cb_master.Checked = true;
                }
                if (reader["FullScreen"].ToString().Equals("1")) { 
                    cb_fscreen.Checked = true;
                }
                int indexInternalResolution = Convert.ToInt32(reader["InternalR"].ToString());
                cb_internal.SelectedIndex = indexInternalResolution;
                cb_postanti.SelectedItem = reader["PostAnti"].ToString();
                cb_resolutionx.SelectedItem = reader["Rx"].ToString();
                cb_drawresolitony.SelectedItem = reader["Ry"].ToString();
                if (reader["GpuInvalid"].ToString().Equals("1")) {
                    cb_allowinvalid.Checked = true;
                }
                if (reader["Vsync"].ToString().Equals("0")) { 
                    cb_vsync.Checked = false;
                }
                if (reader["NativeMS"].ToString().Equals("0")) {
                    cb_msaa.Checked= false;
                }
                int indexLang = Convert.ToInt32(reader["UserLang"].ToString());
                cb_lang.SelectedIndex = indexLang;
                gameUUID = reader["UUID"].ToString();
                cb_renderer.SelectedItem = reader["Renderer"].ToString();
                etxt_FrameLimit.Text = reader["Framelimit"].ToString();
            }
            reader.Close();
            conn.Close();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_master_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_master.Checked==true) {
                
                cb_canary.Checked = false;
            }
            if (cb_master.Checked == false)
            {

                cb_canary.Checked = true;
            }

        }

        private void cb_canary_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_canary.Checked == true)
            {

                cb_master.Checked = false;
            }
            if (cb_canary.Checked == false)
            {

                cb_master.Checked = true;
            }
        }
        public void ConstructRun() {
            // --vsync = false

            String toRun = "";
            if (cb_fscreen.Checked) {
                toRun = toRun + " --fullscreen=true";            
            }
            if (!cb_fscreen.Checked)
            {
                toRun = toRun + " --fullscreen=false";
            }
            int indexInternalResolution = cb_internal.SelectedIndex;
            indexInternalResolution=indexInternalResolution + 1;
            if(cb_canary.Checked)
            {

                toRun = toRun + " --internal_display_resolution=" + indexInternalResolution;
            }
                String postAnti = cb_postanti.Text.ToString();
            if (postAnti.Equals("none")) {
                postAnti = "";
            }
            if (cb_canary.Checked) {
                toRun = toRun + " --postprocess_antialiasing=\"" + postAnti + "\"";
            }

            toRun = toRun + " --draw_resolution_scale_x=" + cb_resolutionx.Text.ToString();
            toRun = toRun + " --draw_resolution_scale_y=" + cb_drawresolitony.Text.ToString();
            if (cb_allowinvalid.Checked) {
                toRun = toRun + " --gpu_allow_invalid_fetch_constants=true"; 
            }
            if (!cb_allowinvalid.Checked)
            {
                toRun = toRun + " --gpu_allow_invalid_fetch_constants=false";
            }
            if (cb_vsync.Checked) {
                toRun = toRun + " --vsync=true";
            }
            if (!cb_vsync.Checked)
            {
                toRun = toRun + " --vsync=false";
            }
            if (cb_msaa.Checked) {
                toRun = toRun + " --native_2x_msaa=true";
            }
            if (!cb_msaa.Checked)
            {
                toRun = toRun + " --native_2x_msaa=false";
            }
            int indexLang= cb_lang.SelectedIndex;
            indexLang = indexLang + 1;
            if (indexLang>=10) {
                indexLang = indexLang + 1;
            }
            toRun = toRun + " --gpu=\""+cb_renderer.Text.ToString()+"\"";
            if (cb_canary.Checked) {
                String frames = etxt_FrameLimit.Text.ToString();
                if(frames.Equals("")){
                    frames = "60";
                }
                toRun = toRun + " --framerate_limit="+frames;
            }

            toRun = toRun + " --user_language="+indexLang;
            if (cb_master.Checked) {
                Global.RunGame = Global.XeniaExe+" \""+Global.GameDir+"\""+" "+toRun;
            }
            if (cb_canary.Checked)
            {
                Global.RunGame = Global.XeniaCExe + " \"" + Global.GameDir + "\"" + " " + toRun;
            }
            // Console.WriteLine("run line "+toRun);
        }
        private void btn_run_Click(object sender, EventArgs e)
        {
            saveGameSettings();
            ConstructRun();
            this.Close();
        }

       
    }
}
