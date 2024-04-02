using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XeniaLauncher
{
	public class Update : Form
	{
		private IContainer components;

		private Label label1;

		private ProgressBar progressBar1;

		private Label stxt_progreso;

		public Update()
		{
			InitializeComponent();
			if (Global.wichXenia==0) {
                startDownload(Global.XeniaDir, "https://github.com/xenia-project/release-builds-windows/releases/latest/download/xenia_master.zip");
            }
            if (Global.wichXenia == 1)
            {
                startDownload(Global.XeniaCDir, "https://github.com/xenia-canary/xenia-canary/releases/download/experimental/xenia_canary.zip");
            }
        }

		private void startDownload(String path, String urlx)
		{
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += client_DownloadProgressChanged;
			webClient.DownloadFileCompleted += client_DownloadFileCompleted;
			
            string myLocalFilePath = path + "\\update.zip"; ;
            webClient.Credentials = new NetworkCredential("", "");
			
            webClient.DownloadFileAsync(new Uri(urlx), myLocalFilePath);
        }

		private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			double num = double.Parse(e.BytesReceived.ToString());
			double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
			double percentage = num / totalBytes * 100.0;
			stxt_progreso.Text = "Downloading " + e.BytesReceived + " of " + e.TotalBytesToReceive;
			progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
		}

		private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			stxt_progreso.Text = "Done";
			extrackandRun();
		}

		public void extrackandRun()
		{
			String path = "";
			if (Global.wichXenia==1) {
				path = Global.XeniaCDir;
			}
            if (Global.wichXenia == 0)
            {
				path = Global.XeniaDir;
            }
            string startPath = path;
			string obj =path + "\\update.zip";
			//Console.WriteLine(obj);
			_ = path;
			new ZipArchive(File.OpenRead(obj)).ExtractToDirectory(startPath, overwrite: true);
			/*Process.Start(new ProcessStartInfo
			{
				FileName = "Sam.C.exe",
				WorkingDirectory = Environment.CurrentDirectory
			})*/;
			//Environment.Exit(1);
			Global.updateend = 1;
                this.Close();
            
            
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.stxt_progreso = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(122, 53);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Updating...";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(8, 101);
			this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(293, 15);
			this.progressBar1.TabIndex = 1;
			// 
			// stxt_progreso
			// 
			this.stxt_progreso.AutoSize = true;
			this.stxt_progreso.Location = new System.Drawing.Point(8, 127);
			this.stxt_progreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.stxt_progreso.Name = "stxt_progreso";
			this.stxt_progreso.Size = new System.Drawing.Size(0, 13);
			this.stxt_progreso.TabIndex = 2;
			// 
			// Update
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(321, 177);
			this.ControlBox = false;
			this.Controls.Add(this.stxt_progreso);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Update";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Update";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
