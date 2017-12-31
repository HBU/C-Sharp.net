namespace Exp8_2
{
    partial class Exp8_2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurPrice = new System.Windows.Forms.TextBox();
            this.txtBuy = new System.Windows.Forms.TextBox();
            this.btnBuying = new System.Windows.Forms.Button();
            this.btnSelling = new System.Windows.Forms.Button();
            this.txtSell = new System.Windows.Forms.TextBox();
            this.txtStartPrice = new System.Windows.Forms.TextBox();
            this.btnOpened = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "开盘价格：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "当前价格：";
            // 
            // txtCurPrice
            // 
            this.txtCurPrice.Location = new System.Drawing.Point(85, 30);
            this.txtCurPrice.Name = "txtCurPrice";
            this.txtCurPrice.ReadOnly = true;
            this.txtCurPrice.Size = new System.Drawing.Size(141, 21);
            this.txtCurPrice.TabIndex = 1;
            // 
            // txtBuy
            // 
            this.txtBuy.Location = new System.Drawing.Point(14, 92);
            this.txtBuy.Name = "txtBuy";
            this.txtBuy.Size = new System.Drawing.Size(97, 21);
            this.txtBuy.TabIndex = 2;
            // 
            // btnBuying
            // 
            this.btnBuying.Location = new System.Drawing.Point(14, 57);
            this.btnBuying.Name = "btnBuying";
            this.btnBuying.Size = new System.Drawing.Size(97, 23);
            this.btnBuying.TabIndex = 3;
            this.btnBuying.Text = "低于此价买入";
            this.btnBuying.UseVisualStyleBackColor = true;
            this.btnBuying.Click += new System.EventHandler(this.btnBuying_Click);
            // 
            // btnSelling
            // 
            this.btnSelling.Location = new System.Drawing.Point(129, 57);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(97, 23);
            this.btnSelling.TabIndex = 3;
            this.btnSelling.Text = "高于此价卖出";
            this.btnSelling.UseVisualStyleBackColor = true;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            // 
            // txtSell
            // 
            this.txtSell.Location = new System.Drawing.Point(129, 92);
            this.txtSell.Name = "txtSell";
            this.txtSell.Size = new System.Drawing.Size(97, 21);
            this.txtSell.TabIndex = 2;
            // 
            // txtStartPrice
            // 
            this.txtStartPrice.Location = new System.Drawing.Point(85, 6);
            this.txtStartPrice.Name = "txtStartPrice";
            this.txtStartPrice.ReadOnly = true;
            this.txtStartPrice.Size = new System.Drawing.Size(50, 21);
            this.txtStartPrice.TabIndex = 1;
            this.txtStartPrice.Text = "50";
            // 
            // btnOpened
            // 
            this.btnOpened.Location = new System.Drawing.Point(151, 4);
            this.btnOpened.Name = "btnOpened";
            this.btnOpened.Size = new System.Drawing.Size(75, 23);
            this.btnOpened.TabIndex = 5;
            this.btnOpened.Text = "开盘";
            this.btnOpened.UseVisualStyleBackColor = true;
            this.btnOpened.Click += new System.EventHandler(this.btnOpened_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(12, 119);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(214, 96);
            this.rtbMessages.TabIndex = 6;
            this.rtbMessages.Text = "";
            // 
            // Exp8_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 227);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnOpened);
            this.Controls.Add(this.btnSelling);
            this.Controls.Add(this.btnBuying);
            this.Controls.Add(this.txtSell);
            this.Controls.Add(this.txtBuy);
            this.Controls.Add(this.txtStartPrice);
            this.Controls.Add(this.txtCurPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Exp8_2";
            this.Text = "Exp8_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurPrice;
        private System.Windows.Forms.TextBox txtBuy;
        private System.Windows.Forms.Button btnBuying;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.TextBox txtSell;
        private System.Windows.Forms.TextBox txtStartPrice;
        private System.Windows.Forms.Button btnOpened;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox rtbMessages;
    }
}