namespace Test8_3
{
    partial class Test8_3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "温度：";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(60, 9);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(70, 21);
            this.txtTemp.TabIndex = 1;
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(149, 8);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(75, 23);
            this.btnMonitor.TabIndex = 2;
            this.btnMonitor.Text = "监控";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // lblColor
            // 
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColor.Location = new System.Drawing.Point(13, 73);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(211, 22);
            this.lblColor.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(13, 43);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(41, 12);
            this.lblShow.TabIndex = 4;
            this.lblShow.Text = "label2";
            // 
            // Test8_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 112);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.label1);
            this.Name = "Test8_3";
            this.Text = "Test8_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblShow;
    }
}