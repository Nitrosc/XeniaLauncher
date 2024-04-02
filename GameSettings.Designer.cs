namespace XeniaLauncher
{
    partial class GameSettings
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
            this.cb_fscreen = new System.Windows.Forms.CheckBox();
            this.stxt_title = new System.Windows.Forms.Label();
            this.cb_internal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_postanti = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_resolutionx = new System.Windows.Forms.ComboBox();
            this.cb_drawresolitony = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_allowinvalid = new System.Windows.Forms.CheckBox();
            this.cb_vsync = new System.Windows.Forms.CheckBox();
            this.cb_msaa = new System.Windows.Forms.CheckBox();
            this.cb_lang = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.cb_master = new System.Windows.Forms.CheckBox();
            this.cb_canary = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_renderer = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.etxt_FrameLimit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_fscreen
            // 
            this.cb_fscreen.AutoSize = true;
            this.cb_fscreen.Location = new System.Drawing.Point(9, 76);
            this.cb_fscreen.Name = "cb_fscreen";
            this.cb_fscreen.Size = new System.Drawing.Size(110, 17);
            this.cb_fscreen.TabIndex = 0;
            this.cb_fscreen.Text = "Start in full screen";
            this.cb_fscreen.UseVisualStyleBackColor = true;
            // 
            // stxt_title
            // 
            this.stxt_title.AutoSize = true;
            this.stxt_title.Location = new System.Drawing.Point(12, 18);
            this.stxt_title.Name = "stxt_title";
            this.stxt_title.Size = new System.Drawing.Size(58, 13);
            this.stxt_title.TabIndex = 1;
            this.stxt_title.Text = "Game Title";
            // 
            // cb_internal
            // 
            this.cb_internal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_internal.FormattingEnabled = true;
            this.cb_internal.Items.AddRange(new object[] {
            "640x576",
            "720x480",
            "720x576",
            "800x600",
            "848x480",
            "1024x768",
            "1152x864",
            "1280x720 (Default)",
            "1280x768",
            "1280x960",
            "1280x1024",
            "1360x768",
            "1440x900",
            "1680x1050",
            "1920x540",
            "1920x1080"});
            this.cb_internal.Location = new System.Drawing.Point(9, 121);
            this.cb_internal.Name = "cb_internal";
            this.cb_internal.Size = new System.Drawing.Size(195, 21);
            this.cb_internal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Custom internal resolution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Allow game that support different resolutions to be rendered in specific resoluti" +
    "on.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Postprocess antialiasing";
            // 
            // cb_postanti
            // 
            this.cb_postanti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_postanti.FormattingEnabled = true;
            this.cb_postanti.Items.AddRange(new object[] {
            "none",
            "fxaa",
            "fxaa_extreme"});
            this.cb_postanti.Location = new System.Drawing.Point(9, 191);
            this.cb_postanti.Name = "cb_postanti";
            this.cb_postanti.Size = new System.Drawing.Size(127, 21);
            this.cb_postanti.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Draw resolution scale x";
            // 
            // cb_resolutionx
            // 
            this.cb_resolutionx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_resolutionx.FormattingEnabled = true;
            this.cb_resolutionx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_resolutionx.Location = new System.Drawing.Point(12, 254);
            this.cb_resolutionx.Name = "cb_resolutionx";
            this.cb_resolutionx.Size = new System.Drawing.Size(72, 21);
            this.cb_resolutionx.TabIndex = 8;
            // 
            // cb_drawresolitony
            // 
            this.cb_drawresolitony.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_drawresolitony.FormattingEnabled = true;
            this.cb_drawresolitony.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_drawresolitony.Location = new System.Drawing.Point(150, 254);
            this.cb_drawresolitony.Name = "cb_drawresolitony";
            this.cb_drawresolitony.Size = new System.Drawing.Size(72, 21);
            this.cb_drawresolitony.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Draw resolution scale y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(418, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Integer pixel width scale used for scaling the rendering resolution opaquely to t" +
    "he game.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(459, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "1, 2 and 3 may be supported, but support of anything above 1 depends on the devic" +
    "e properties";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(355, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Various effects and parts of game rendering pipelines may work incorrectly";
            // 
            // cb_allowinvalid
            // 
            this.cb_allowinvalid.AutoSize = true;
            this.cb_allowinvalid.Location = new System.Drawing.Point(9, 366);
            this.cb_allowinvalid.Name = "cb_allowinvalid";
            this.cb_allowinvalid.Size = new System.Drawing.Size(180, 17);
            this.cb_allowinvalid.TabIndex = 14;
            this.cb_allowinvalid.Text = "gpu allow invalid fetch constants";
            this.cb_allowinvalid.UseVisualStyleBackColor = true;
            // 
            // cb_vsync
            // 
            this.cb_vsync.AutoSize = true;
            this.cb_vsync.Checked = true;
            this.cb_vsync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_vsync.Location = new System.Drawing.Point(238, 366);
            this.cb_vsync.Name = "cb_vsync";
            this.cb_vsync.Size = new System.Drawing.Size(54, 17);
            this.cb_vsync.TabIndex = 15;
            this.cb_vsync.Text = "vsync";
            this.cb_vsync.UseVisualStyleBackColor = true;
            // 
            // cb_msaa
            // 
            this.cb_msaa.AutoSize = true;
            this.cb_msaa.Checked = true;
            this.cb_msaa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_msaa.Location = new System.Drawing.Point(352, 366);
            this.cb_msaa.Name = "cb_msaa";
            this.cb_msaa.Size = new System.Drawing.Size(97, 17);
            this.cb_msaa.TabIndex = 16;
            this.cb_msaa.Text = "native 2x msaa";
            this.cb_msaa.UseVisualStyleBackColor = true;
            // 
            // cb_lang
            // 
            this.cb_lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lang.FormattingEnabled = true;
            this.cb_lang.Items.AddRange(new object[] {
            "1=en",
            "2=ja",
            "3=de",
            "4=fr",
            "5=es",
            "6=it",
            "7=ko",
            "8=zh",
            "9=pt",
            "11=pl",
            "12=ru",
            "13=sv",
            "14=tr",
            "15=nb",
            "16=nl",
            "17=zh"});
            this.cb_lang.Location = new System.Drawing.Point(12, 432);
            this.cb_lang.Name = "cb_lang";
            this.cb_lang.Size = new System.Drawing.Size(142, 21);
            this.cb_lang.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "User language";
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(499, 492);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(105, 34);
            this.btn_run.TabIndex = 22;
            this.btn_run.Text = "Save and Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(9, 492);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 34);
            this.btn_cancel.TabIndex = 23;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // cb_master
            // 
            this.cb_master.AutoSize = true;
            this.cb_master.Location = new System.Drawing.Point(12, 43);
            this.cb_master.Name = "cb_master";
            this.cb_master.Size = new System.Drawing.Size(110, 17);
            this.cb_master.TabIndex = 24;
            this.cb_master.Text = "Use Xenia Master";
            this.cb_master.UseVisualStyleBackColor = true;
            this.cb_master.CheckedChanged += new System.EventHandler(this.cb_master_CheckedChanged);
            // 
            // cb_canary
            // 
            this.cb_canary.AutoSize = true;
            this.cb_canary.Checked = true;
            this.cb_canary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_canary.Location = new System.Drawing.Point(254, 43);
            this.cb_canary.Name = "cb_canary";
            this.cb_canary.Size = new System.Drawing.Size(111, 17);
            this.cb_canary.TabIndex = 25;
            this.cb_canary.Text = "Use Xenia Canary";
            this.cb_canary.UseVisualStyleBackColor = true;
            this.cb_canary.CheckedChanged += new System.EventHandler(this.cb_canary_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(194, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Renderer";
            // 
            // cb_renderer
            // 
            this.cb_renderer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_renderer.FormattingEnabled = true;
            this.cb_renderer.Items.AddRange(new object[] {
            "any",
            "d3d12",
            "vulkan",
            "null"});
            this.cb_renderer.Location = new System.Drawing.Point(194, 191);
            this.cb_renderer.Name = "cb_renderer";
            this.cb_renderer.Size = new System.Drawing.Size(127, 21);
            this.cb_renderer.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(394, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Framerate limit";
            // 
            // etxt_FrameLimit
            // 
            this.etxt_FrameLimit.Location = new System.Drawing.Point(397, 192);
            this.etxt_FrameLimit.Name = "etxt_FrameLimit";
            this.etxt_FrameLimit.Size = new System.Drawing.Size(105, 20);
            this.etxt_FrameLimit.TabIndex = 28;
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(616, 538);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.etxt_FrameLimit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cb_renderer);
            this.Controls.Add(this.cb_canary);
            this.Controls.Add(this.cb_master);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.cb_lang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_msaa);
            this.Controls.Add(this.cb_vsync);
            this.Controls.Add(this.cb_allowinvalid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_drawresolitony);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_resolutionx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_postanti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_internal);
            this.Controls.Add(this.stxt_title);
            this.Controls.Add(this.cb_fscreen);
            this.Name = "GameSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cb_fscreen;
        private System.Windows.Forms.Label stxt_title;
        private System.Windows.Forms.ComboBox cb_internal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_postanti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_resolutionx;
        private System.Windows.Forms.ComboBox cb_drawresolitony;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_allowinvalid;
        private System.Windows.Forms.CheckBox cb_vsync;
        private System.Windows.Forms.CheckBox cb_msaa;
        private System.Windows.Forms.ComboBox cb_lang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.CheckBox cb_master;
        private System.Windows.Forms.CheckBox cb_canary;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_renderer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox etxt_FrameLimit;
    }
}