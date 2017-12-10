namespace Test5_6
{
    partial class Test5_6
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
            this.btnMp3 = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnMobile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMp3
            // 
            this.btnMp3.Location = new System.Drawing.Point(28, 70);
            this.btnMp3.Name = "btnMp3";
            this.btnMp3.Size = new System.Drawing.Size(75, 23);
            this.btnMp3.TabIndex = 0;
            this.btnMp3.Text = "MP3";
            this.btnMp3.UseVisualStyleBackColor = true;
            this.btnMp3.Click += new System.EventHandler(this.btnMp3_Click);
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(12, 9);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(213, 52);
            this.lblShow.TabIndex = 11;
            // 
            // btnMobile
            // 
            this.btnMobile.Location = new System.Drawing.Point(126, 70);
            this.btnMobile.Name = "btnMobile";
            this.btnMobile.Size = new System.Drawing.Size(75, 23);
            this.btnMobile.TabIndex = 12;
            this.btnMobile.Text = "手机";
            this.btnMobile.UseVisualStyleBackColor = true;
            this.btnMobile.Click += new System.EventHandler(this.btnMobile_Click);
            // 
            // Text5_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 101);
            this.Controls.Add(this.btnMobile);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnMp3);
            this.Name = "Text5_6";
            this.Text = "Text5_6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMp3;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnMobile;
    }
}