﻿namespace assignmnent10
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
            this.lblNew = new System.Windows.Forms.Label();
            this.lblRaise = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(291, 199);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(35, 13);
            this.lblNew.TabIndex = 3;
            this.lblNew.Text = "label4";
            // 
            // lblRaise
            // 
            this.lblRaise.AutoSize = true;
            this.lblRaise.Location = new System.Drawing.Point(291, 159);
            this.lblRaise.Name = "lblRaise";
            this.lblRaise.Size = new System.Drawing.Size(35, 13);
            this.lblRaise.TabIndex = 4;
            this.lblRaise.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(226, 44);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(100, 20);
            this.txtS.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 253);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRaise);
            this.Controls.Add(this.lblNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Label lblRaise;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtS;
    }
}

