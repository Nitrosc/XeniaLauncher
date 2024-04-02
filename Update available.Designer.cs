namespace XeniaLauncher
{
    partial class Update_available
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.stxt_wichxenia = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(296, 107);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(69, 33);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "Update";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // stxt_wichxenia
            // 
            this.stxt_wichxenia.AutoSize = true;
            this.stxt_wichxenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stxt_wichxenia.Location = new System.Drawing.Point(12, 41);
            this.stxt_wichxenia.Name = "stxt_wichxenia";
            this.stxt_wichxenia.Size = new System.Drawing.Size(269, 16);
            this.stxt_wichxenia.TabIndex = 1;
            this.stxt_wichxenia.Text = "There is an update to xernia availabel";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(12, 107);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(69, 33);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Update_available
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 152);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.stxt_wichxenia);
            this.Controls.Add(this.btn_ok);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update_available";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update available";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label stxt_wichxenia;
        private System.Windows.Forms.Button btn_cancel;
    }
}