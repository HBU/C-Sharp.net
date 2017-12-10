namespace Test5_5
{
    partial class Test5_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnGlobe = new System.Windows.Forms.Button();
            this.btnCone = new System.Windows.Forms.Button();
            this.btnCylinder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "半径：";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(71, 9);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(66, 21);
            this.txtRadius.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "高：";
            // 
            // txtHigh
            // 
            this.txtHigh.Location = new System.Drawing.Point(200, 9);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(66, 21);
            this.txtHigh.TabIndex = 1;
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(15, 47);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(251, 33);
            this.lblShow.TabIndex = 10;
            // 
            // btnGlobe
            // 
            this.btnGlobe.Location = new System.Drawing.Point(23, 94);
            this.btnGlobe.Name = "btnGlobe";
            this.btnGlobe.Size = new System.Drawing.Size(65, 23);
            this.btnGlobe.TabIndex = 11;
            this.btnGlobe.Text = "圆球";
            this.btnGlobe.UseVisualStyleBackColor = true;
            this.btnGlobe.Click += new System.EventHandler(this.btnGlobe_Click);
            // 
            // btnCone
            // 
            this.btnCone.Location = new System.Drawing.Point(106, 94);
            this.btnCone.Name = "btnCone";
            this.btnCone.Size = new System.Drawing.Size(65, 23);
            this.btnCone.TabIndex = 11;
            this.btnCone.Text = "圆锥";
            this.btnCone.UseVisualStyleBackColor = true;
            this.btnCone.Click += new System.EventHandler(this.btnCone_Click);
            // 
            // btnCylinder
            // 
            this.btnCylinder.Location = new System.Drawing.Point(189, 94);
            this.btnCylinder.Name = "btnCylinder";
            this.btnCylinder.Size = new System.Drawing.Size(65, 23);
            this.btnCylinder.TabIndex = 11;
            this.btnCylinder.Text = "圆柱";
            this.btnCylinder.UseVisualStyleBackColor = true;
            this.btnCylinder.Click += new System.EventHandler(this.btnCylinder_Click);
            // 
            // Test5_5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 131);
            this.Controls.Add(this.btnCylinder);
            this.Controls.Add(this.btnCone);
            this.Controls.Add(this.btnGlobe);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Test5_5";
            this.Text = "Test5_5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnGlobe;
        private System.Windows.Forms.Button btnCone;
        private System.Windows.Forms.Button btnCylinder;
    }
}