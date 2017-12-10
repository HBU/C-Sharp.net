namespace Test6
{
    partial class Test6_4
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
            this.lblShow = new System.Windows.Forms.Label();
            this.btnDog = new System.Windows.Forms.Button();
            this.btnSmallDog = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnFeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(12, 12);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(168, 148);
            this.lblShow.TabIndex = 1;
            // 
            // btnDog
            // 
            this.btnDog.Location = new System.Drawing.Point(224, 40);
            this.btnDog.Name = "btnDog";
            this.btnDog.Size = new System.Drawing.Size(75, 23);
            this.btnDog.TabIndex = 2;
            this.btnDog.Text = "添加狗";
            this.btnDog.UseVisualStyleBackColor = true;
            this.btnDog.Click += new System.EventHandler(this.btnDog_Click);
            // 
            // btnSmallDog
            // 
            this.btnSmallDog.Location = new System.Drawing.Point(224, 70);
            this.btnSmallDog.Name = "btnSmallDog";
            this.btnSmallDog.Size = new System.Drawing.Size(75, 23);
            this.btnSmallDog.TabIndex = 2;
            this.btnSmallDog.Text = "添加小狗";
            this.btnSmallDog.UseVisualStyleBackColor = true;
            this.btnSmallDog.Click += new System.EventHandler(this.btnSmallDog_Click);
            // 
            // btnCat
            // 
            this.btnCat.Location = new System.Drawing.Point(224, 100);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(75, 23);
            this.btnCat.TabIndex = 2;
            this.btnCat.Text = "添加猫";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "名字：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(234, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(65, 21);
            this.txtName.TabIndex = 4;
            // 
            // btnFeed
            // 
            this.btnFeed.Location = new System.Drawing.Point(224, 130);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(75, 23);
            this.btnFeed.TabIndex = 2;
            this.btnFeed.Text = "喂食";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // Test6_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 166);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.btnSmallDog);
            this.Controls.Add(this.btnDog);
            this.Controls.Add(this.lblShow);
            this.Name = "Test6_4";
            this.Text = "Test6_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnDog;
        private System.Windows.Forms.Button btnSmallDog;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnFeed;
    }
}