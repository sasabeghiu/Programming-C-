namespace Assignment5
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.rbMovie1 = new System.Windows.Forms.RadioButton();
            this.rbMovie2 = new System.Windows.Forms.RadioButton();
            this.rbMovie3 = new System.Windows.Forms.RadioButton();
            this.btnCalculatePrice = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(103, 16);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 3;
            // 
            // rbMovie1
            // 
            this.rbMovie1.AutoSize = true;
            this.rbMovie1.Location = new System.Drawing.Point(103, 63);
            this.rbMovie1.Name = "rbMovie1";
            this.rbMovie1.Size = new System.Drawing.Size(185, 17);
            this.rbMovie1.TabIndex = 4;
            this.rbMovie1.TabStop = true;
            this.rbMovie1.Text = "Star Wars: The Rise of Skywalker";
            this.rbMovie1.UseVisualStyleBackColor = true;
            // 
            // rbMovie2
            // 
            this.rbMovie2.AutoSize = true;
            this.rbMovie2.Location = new System.Drawing.Point(103, 86);
            this.rbMovie2.Name = "rbMovie2";
            this.rbMovie2.Size = new System.Drawing.Size(139, 17);
            this.rbMovie2.TabIndex = 5;
            this.rbMovie2.TabStop = true;
            this.rbMovie2.Text = "Jumanji: The Next Level";
            this.rbMovie2.UseVisualStyleBackColor = true;
            // 
            // rbMovie3
            // 
            this.rbMovie3.AutoSize = true;
            this.rbMovie3.Location = new System.Drawing.Point(103, 109);
            this.rbMovie3.Name = "rbMovie3";
            this.rbMovie3.Size = new System.Drawing.Size(151, 17);
            this.rbMovie3.TabIndex = 6;
            this.rbMovie3.TabStop = true;
            this.rbMovie3.Text = "Penoza: The Final Chapter";
            this.rbMovie3.UseVisualStyleBackColor = true;
            // 
            // btnCalculatePrice
            // 
            this.btnCalculatePrice.Location = new System.Drawing.Point(103, 153);
            this.btnCalculatePrice.Name = "btnCalculatePrice";
            this.btnCalculatePrice.Size = new System.Drawing.Size(100, 23);
            this.btnCalculatePrice.TabIndex = 7;
            this.btnCalculatePrice.Text = "Calculate Price";
            this.btnCalculatePrice.UseVisualStyleBackColor = true;
            this.btnCalculatePrice.Click += new System.EventHandler(this.btnCalculatePrice_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(100, 209);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 13);
            this.lblPrice.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 251);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnCalculatePrice);
            this.Controls.Add(this.rbMovie3);
            this.Controls.Add(this.rbMovie2);
            this.Controls.Add(this.rbMovie1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.RadioButton rbMovie1;
        private System.Windows.Forms.RadioButton rbMovie2;
        private System.Windows.Forms.RadioButton rbMovie3;
        private System.Windows.Forms.Button btnCalculatePrice;
        private System.Windows.Forms.Label lblPrice;
    }
}

