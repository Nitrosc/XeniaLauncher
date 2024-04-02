using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.IO;
using System.Collections;

namespace XeniaLauncher
{
    public partial class Opciones : Form
    {
        public String uuidL = "";
        String XeniaExedir = "";
        String XeniaLast = "";
        String XeniaCExedir = "";
        String XeniaCLast = "";
        String XeniaDir = "";
        String XeniaCdir = "";
        public Opciones()
        {
            InitializeComponent();
            fillData();
            try
            {
                fillpaths();
            }
            catch { }
        }
        public void fillData() { 
            Utilz ut = new Utilz();
            SQLiteConnection conn = ut.getConn();
            conn.Open();
            String sql = "SELECT* FROM  Files";
            SQLiteCommand command = new SQLiteCommand(sql,conn);
            SQLiteDataReader reader =command.ExecuteReader();
            while (reader.Read())
            {
                XeniaLast = reader["XeniaVer"].ToString();
                XeniaCLast = reader["XeniaC"].ToString();
                String uuidL = reader["UUID"].ToString();
                XeniaExedir = reader["XenieExe"].ToString();
                if (XeniaExedir.Equals("")) {
                    stxt_xeniaexe.Text = "-No file selected-";
                }
                if (!XeniaExedir.Equals("")) {
                    stxt_xeniaexe.Text = XeniaExedir+" "+XeniaLast;
                }


               XeniaCExedir = reader["XeniaCExe"].ToString();
                if (XeniaCExedir.Equals(""))
                {
                    stxt_XeniaCexe.Text = "-No file selected-";
                }
                if (!XeniaCExedir.Equals(""))
                {
                    stxt_XeniaCexe.Text = XeniaCExedir+" "+XeniaCLast;
                }
                XeniaDir = reader["XeniaDir"].ToString();
                XeniaCdir = reader["XeniaCDir"].ToString();


              
            }
            reader.Close();
            conn.Close();
        }
        private void btn_xenia_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Xenia.exe";
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //String dire = openFileDialog1.;
                //Console.WriteLine(dire);
                //String filelocation = openFileDialog1.
                string fileName = openFileDialog1.FileName;
                FileInfo fi = new FileInfo(fileName);
                XeniaDir = fi.Directory.ToString();
                //Console.WriteLine("Directorio "+dire);
                var lastmodified = fi.LastWriteTime;
                DateTime lastm = fi.LastWriteTime;
                String fecha = lastm.ToString("yyyy-MM-dd");
                XeniaExedir = fileName;
                XeniaLast = fecha;
                stxt_xeniaexe.Text = XeniaExedir+" "+XeniaLast;
            }
        }

        private void btn_xeniaC_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "XeniaCanary.exe";
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                //String filelocation = openFileDialog1.
                string fileName = openFileDialog1.FileName;
                
                FileInfo fi = new FileInfo(fileName);
                XeniaCdir = fi.Directory.ToString();
                var lastmodified = fi.LastWriteTime;
                DateTime lastm = fi.LastWriteTime;
                String fecha = lastm.ToString("yyyy-MM-dd");
                XeniaCExedir = fileName;
                XeniaCLast = fecha;
                stxt_XeniaCexe.Text = fileName+" "+XeniaCLast;
            }
        }

       

        

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (uuidL.Equals(""))
            {
                uuidL = Guid.NewGuid().ToString();
            }
            Utilz ut  =new Utilz();
            SQLiteConnection conn = ut.getConn();
            conn.Open();

            string sql = "REPLACE INTO Files  (UUID, XenieExe, XeniaCExe, XeniaVer, XeniaC,XeniaDir, XeniaCDir)VALUES('" + uuidL + "','" + XeniaExedir + "','" + XeniaCExedir + "','"+XeniaLast+"','"+XeniaCLast+"','"+XeniaDir+"','"+XeniaCdir+"')";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();


            ArrayList paths = new ArrayList();
            paths = getList();
            if (paths.Count>0) {
                sql = "DELETE FROM Rompath";
                command = new SQLiteCommand(sql, conn);
                command.ExecuteNonQuery();
                sql = "VACUUM;";
                command = new SQLiteCommand(sql, conn);
                command.ExecuteNonQuery();
                String toin = "";
                for (int x =0;x<paths.Count;x++) {
                    if (!toin.Equals("")) {
                        toin = toin+ ",('"+Guid.NewGuid().ToString()+"','" + @paths[x].ToString()+"')";
                    }
                    if (toin.Equals(""))
                    {
                        toin = "('"+Guid.NewGuid().ToString()+"','"+@paths[x].ToString()+"')";
                    }

                }
                sql = "REPLACE INTO Rompath (UUID,Directory)VALUES" + toin;
                command = new SQLiteCommand(sql, conn);
                command.ExecuteNonQuery();
            }
  
            conn.Close();
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int getcheck(String tocheck) {
            int checker = 0;
            foreach (ListViewItem eachItem in listView1.Items)
            {
                
                string Selected = eachItem.SubItems[0].Text; //directly access "eachItem"
                if (Selected.Equals(tocheck)) {
                    checker = 1;
                    break;
                }
              
            }
            return checker;
        }
        public ArrayList getList()
        {
            ArrayList List = new ArrayList();
            foreach (ListViewItem eachItem in listView1.Items)
            {

               
                List.Add(eachItem.SubItems[0].Text);

            }
            return List;
        }
        public void fillpaths() {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            
            listView1.Columns.Add("Path", 600);

            Utilz ut = new Utilz();
            SQLiteConnection conn = ut.getConn();
            conn.Open();
            String sql = "SELECT* FROM Rompath";
            SQLiteCommand command = new SQLiteCommand(sql,conn);
            SQLiteDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    string[] array = new string[1];
                    array[0] = reader[1].ToString();
                    ListViewItem value = new ListViewItem(array);
                    listView1.Items.Add(value);
                }
                reader.Close();
            }
            catch { }
            conn.Close();

        }
        public void addpaths(String path) {
            int check=getcheck(path);
            if (check==0) {
                string[] array = new string[1];
                array[0] = path;

                ListViewItem value = new ListViewItem(array);
                listView1.Items.Add(value);
            }

        }
        private void btn_rom_Click(object sender, EventArgs e)
        {
           
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    //    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    //Console.WriteLine(""+fbd.SelectedPath);
                    addpaths("" + fbd.SelectedPath);                 
                }
            }
        }
    }
}
