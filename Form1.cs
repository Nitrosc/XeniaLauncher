using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections;
using System.IO;
using SQLitePCL;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading;


namespace XeniaLauncher
{

    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
           
            // downloader();
            start();
           // Console.WriteLine();
            listView1.DoubleClick += listView1_DoubleClick;
            //testupdateAsync();
        }
        public void start() {
            Utilz ut = new Utilz();
            ut.createdb();
            ut.setfiles();
            setList();
            fillList();
            int millisecondsDelay = 2000;

            var t = Task.Run(async delegate
            {
                checkupdates();
                await Task.Delay(1000);
            });
            //checkupdates();
        }

       
        public void checkupdates() { 
        Utilz ut = new Utilz();
        int xenia = ut.checkUpdateXenia();
        int xeniaC = ut.checkUpdateXeniaCanary();
            if (xenia==1) {
                Global.wichXenia = 0;
                //  Console.WriteLine("Update xenia plis");
                Update_available av = new Update_available();
                av.ShowDialog();
                
                if (Global.updateend==1) {
                    ut.updatedone();
                    UpdateDone upd = new UpdateDone();
                    upd.ShowDialog();
                    this.Close();
                    start();
                }
               
                
            }
            if (xeniaC == 1)
            {
                // Console.WriteLine("Update xenia canary plis");
                Global.wichXenia = 1;
                Update_available av = new Update_available();
                av.ShowDialog();
               
                if (Global.updateend == 1)
                {
                    ut.updatedone();
                    UpdateDone upd = new UpdateDone();
                    upd.ShowDialog();
                    this.Close();
                    start();
                }
                


            }

        }
        public void setList() {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Name", 300);
            listView1.Columns.Add("Path", 600);

        }

       
        public void fillList() {
            ArrayList directorys= new ArrayList();
            ArrayList listxex = new ArrayList();
            ArrayList fullxex = new ArrayList();
            Utilz ut = new Utilz();
            SQLiteConnection conn = ut.getConn();
            conn.Open();
            String sql = "SELECT* FROM Rompath";
            SQLiteCommand command = new SQLiteCommand(sql,conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                directorys.Add(reader[1].ToString());
            }
            reader.Close();
            conn.Close();
            if (directorys.Count>0) {
                for (int x=0;x<directorys.Count;x++) {
                    String Folder = directorys[x].ToString();

                    string[] allfiles = Directory.GetFiles(Folder, "Default.xex", SearchOption.AllDirectories);
                    foreach (String file in allfiles) {
                        // Console.WriteLine("File "+file);
                        String name = ut.getBetween(file,@Folder+@"\",@"\Default.xex");
                        if (name.Equals("")) {
                            name = ut.getBetween(file, @Folder + @"\", @"\default.xex");
                        }
                        if (name.Equals(""))
                        {
                            name = ut.getBetween(file, @Folder + @"\", @"\DEFAULT.xex");
                        }
                        if (name.Equals(""))
                        {
                            name = ut.getBetween(file, @Folder + @"\", @"\DEFAULT.XEX");
                        }
                        if (name.Equals(""))
                        {
                            name = ut.getBetween(file, @Folder + @"\", @"\default.XEX");
                        }
                        string[] array = new string[2];
                        array[0] = name;
                        array[1] = file;
                        ListViewItem value = new ListViewItem(array);
                        listView1.Items.Add(value);
                        //Console.WriteLine(name);
                    }
                    allfiles = Directory.GetFiles(Folder, "*.iso", SearchOption.AllDirectories);
                    foreach (String file in allfiles)
                    {
                        // Console.WriteLine("File "+file);
                        String name = ut.getBetween(file, @Folder + @"\", ".iso");
                        if (name.Equals(""))
                        {
                            name = ut.getBetween(file, @Folder + @"\", ".ISO");
                        }
                       
                        string[] array = new string[2];
                        array[0] = name;
                        array[1] = file;
                        ListViewItem value = new ListViewItem(array);
                        listView1.Items.Add(value);
                        //Console.WriteLine(name);
                    }
                    //Console.WriteLine("Archivo 1 " + allfiles.Length);





                }

            }

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opciones op = new Opciones();
            op.ShowDialog();
            start();
        }

        public void downloader() {
            string htmlCode = "";
            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString("https://github.com/xenia-project/release-builds-windows/releases");
            }
            Utilz ut =new Utilz();
            String fecha = ut.getBetween(htmlCode, "datetime=\"", "\">");
            fecha = ut.getBetween(fecha, "", "T");
            Console.WriteLine(fecha);
            // datetime = "2023-09-14T10:00:57Z" >
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
           
                if (listView1.SelectedItems.Count == 1)
                {
                Utilz ut = new Utilz();
                
                String game = listView1.SelectedItems[0].SubItems[1].Text.ToString();
                String gameName = listView1.SelectedItems[0].SubItems[0].Text.ToString();
                //Console.WriteLine("name " + gameName);
               // Console.WriteLine("name dir " + game);
               
                Global.gameName= gameName;
                Global.GameDir = game;
               
                GameSettings gs = new GameSettings();
                gs.ShowDialog();
                if (!Global.RunGame.Equals("")) {
                    runGame(Global.RunGame);
                
                }

                }
            
        }

        public void runGame(String ruta) {
            Utilz ut = new Utilz();
            String pathemu = ut.getXenia(1);




            string strCmdText;
            //strCmdText = pathemu + " " + "\"" + ruta + "\"";

            strCmdText =ruta;
            Console.WriteLine(strCmdText);




            ProcessStartInfo ProcessInfo;
            Process Process;

            ProcessInfo = new ProcessStartInfo("cmd.exe", "/K " + strCmdText);

            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = false;

            Process = Process.Start(ProcessInfo);
        }
    }
}
