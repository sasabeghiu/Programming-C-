namespace Assignment9
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
            this.radioFootball = new System.Windows.Forms.RadioButton();
            this.radioHandball = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtMembership = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sport";
            // 
            // radioFootball
            // 
            this.radioFootball.AutoSize = true;
            this.radioFootball.Location = new System.Drawing.Point(198, 33);
            this.radioFootball.Name = "radioFootball";
            this.radioFootball.Size = new System.Drawing.Size(62, 17);
            this.radioFootball.TabIndex = 1;
            this.radioFootball.TabStop = true;
            this.radioFootball.Text = "Football";
            this.radioFootball.UseVisualStyleBackColor = true;
            // 
            // radioHandball
            // 
            this.radioHandball.AutoSize = true;
            this.radioHandball.Location = new System.Drawing.Point(198, 56);
            this.radioHandball.Name = "radioHandball";
            this.radioHandball.Size = new System.Drawing.Size(67, 17);
            this.radioHandball.TabIndex = 2;
            this.radioHandball.TabStop = true;
            this.radioHandball.Text = "Handball";
            this.radioHandball.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Membership duration";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(195, 239);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(22, 13);
            this.lblFee.TabIndex = 5;
            this.lblFee.Text = "-----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fee to be paid";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(38, 159);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(260, 36);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calculate Fee";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(198, 100);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 8;
            // 
            // txtMembership
            // 
            this.txtMembership.Location = new System.Drawing.Point(198, 126);
            this.txtMembership.Name = "txtMembership";
            this.txtMembership.Size = new System.Drawing.Size(100, 20);
            this.txtMembership.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 281);
            this.Controls.Add(this.txtMembership);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioHandball);
            this.Controls.Add(this.radioFootball);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioFootball;
        private System.Windows.Forms.RadioButton radioHandball;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtMembership;
    }
}

