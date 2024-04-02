namespace XeniaLauncher
{
    partial class Opciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_xenia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stxt_xeniaexe = new System.Windows.Forms.Label();
            this.stxt_XeniaCexe = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_xeniaC = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_rom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_xenia
            // 
            this.btn_xenia.Location = new System.Drawing.Point(12, 25);
            this.btn_xenia.Name = "btn_xenia";
            this.btn_xenia.Size = new System.Drawing.Size(87, 30);
            this.btn_xenia.TabIndex = 0;
            this.btn_xenia.Text = "Search";
            this.btn_xenia.UseVisualStyleBackColor = true;
            this.btn_xenia.Click += new System.EventHandler(this.btn_xenia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Xenia executable";
            // 
            // stxt_xeniaexe
            // 
            this.stxt_xeniaexe.AutoSize = true;
            this.stxt_xeniaexe.Location = new System.Drawing.Point(105, 42);
            this.stxt_xeniaexe.Name = "stxt_xeniaexe";
            this.stxt_xeniaexe.Size = new System.Drawing.Size(86, 13);
            this.stxt_xeniaexe.TabIndex = 2;
            this.stxt_xeniaexe.Text = "-No file selected-";
            // 
            // stxt_XeniaCexe
            // 
            this.stxt_XeniaCexe.AutoSize = true;
            this.stxt_XeniaCexe.Location = new System.Drawing.Point(105, 121);
            this.stxt_XeniaCexe.Name = "stxt_XeniaCexe";
            this.stxt_XeniaCexe.Size = new System.Drawing.Size(86, 13);
            this.stxt_XeniaCexe.TabIndex = 5;
            this.stxt_XeniaCexe.Text = "-No file selected-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Select Xenia Canary executable";
            // 
            // btn_xeniaC
            // 
            this.btn_xeniaC.Location = new System.Drawing.Point(12, 104);
            this.btn_xeniaC.Name = "btn_xeniaC";
            this.btn_xeniaC.Size = new System.Drawing.Size(87, 30);
            this.btn_xeniaC.TabIndex = 3;
            this.btn_xeniaC.Text = "Search";
            this.btn_xeniaC.UseVisualStyleBackColor = true;
            this.btn_xeniaC.Click += new System.EventHandler(this.btn_xeniaC_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(448, 413);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(87, 30);
            this.btn_aceptar.TabIndex = 12;
            this.btn_aceptar.Text = "Save";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(15, 413);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 30);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Cancel";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 195);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(523, 192);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_rom
            // 
            this.btn_rom.Location = new System.Drawing.Point(448, 159);
            this.btn_rom.Name = "btn_rom";
            this.btn_rom.Size = new System.Drawing.Size(87, 30);
            this.btn_rom.TabIndex = 15;
            this.btn_rom.Text = "Add rom path";
            this.btn_rom.UseVisualStyleBackColor = true;
            this.btn_rom.Click += new System.EventHandler(this.btn_rom_Click);
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(561, 461);
            this.Controls.Add(this.btn_rom);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.stxt_XeniaCexe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_xeniaC);
            this.Controls.Add(this.stxt_xeniaexe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xenia);
            this.Name = "Opciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Files directory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_xenia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stxt_xeniaexe;
        private System.Windows.Forms.Label stxt_XeniaCexe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_xeniaC;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_rom;
    }
}