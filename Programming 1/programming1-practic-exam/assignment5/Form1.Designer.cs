namespace assignment5
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
            this.radio5km = new System.Windows.Forms.RadioButton();
            this.radio10km = new System.Windows.Forms.RadioButton();
            this.radio21km = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radio5km
            // 
            this.radio5km.AutoSize = true;
            this.radio5km.Location = new System.Drawing.Point(28, 24);
            this.radio5km.Name = "radio5km";
            this.radio5km.Size = new System.Drawing.Size(48, 17);
            this.radio5km.TabIndex = 0;
            this.radio5km.TabStop = true;
            this.radio5km.Text = "5 km";
            this.radio5km.UseVisualStyleBackColor = true;
            // 
            // radio10km
            // 
            this.radio10km.AutoSize = true;
            this.radio10km.Location = new System.Drawing.Point(108, 24);
            this.radio10km.Name = "radio10km";
            this.radio10km.Size = new System.Drawing.Size(54, 17);
            this.radio10km.TabIndex = 1;
            this.radio10km.TabStop = true;
            this.radio10km.Text = "10 km";
            this.radio10km.UseVisualStyleBackColor = true;
            // 
            // radio21km
            // 
            this.radio21km.AutoSize = true;
            this.radio21km.Location = new System.Drawing.Point(198, 24);
            this.radio21km.Name = "radio21km";
            this.radio21km.Size = new System.Drawing.Size(54, 17);
            this.radio21km.TabIndex = 2;
            this.radio21km.TabStop = true;
            this.radio21km.Text = "21 km";
            this.radio21km.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "hh:mm:ss";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Speed (km/hr)";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(182, 193);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(16, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "---";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(28, 133);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(224, 29);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(123, 70);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(39, 20);
            this.txtHours.TabIndex = 7;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(168, 70);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(39, 20);
            this.txtMin.TabIndex = 8;
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(213, 70);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(39, 20);
            this.txtSec.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 216);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio21km);
            this.Controls.Add(this.radio10km);
            this.Controls.Add(this.radio5km);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio5km;
        private System.Windows.Forms.RadioButton radio10km;
        private System.Windows.Forms.RadioButton radio21km;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtSec;
    }
}

