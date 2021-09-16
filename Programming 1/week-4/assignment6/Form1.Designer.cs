namespace assignment6
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblFinalCapital = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMoneay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Final capital";
            // 
            // lblFinalCapital
            // 
            this.lblFinalCapital.AutoSize = true;
            this.lblFinalCapital.Location = new System.Drawing.Point(260, 171);
            this.lblFinalCapital.Name = "lblFinalCapital";
            this.lblFinalCapital.Size = new System.Drawing.Size(22, 13);
            this.lblFinalCapital.TabIndex = 2;
            this.lblFinalCapital.Text = "-----";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate final capital";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtMoneay
            // 
            this.txtMoneay.Location = new System.Drawing.Point(195, 51);
            this.txtMoneay.Name = "txtMoneay";
            this.txtMoneay.Size = new System.Drawing.Size(100, 20);
            this.txtMoneay.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 214);
            this.Controls.Add(this.txtMoneay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFinalCapital);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinalCapital;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMoneay;
    }
}

