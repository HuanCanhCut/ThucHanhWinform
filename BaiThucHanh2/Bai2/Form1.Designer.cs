﻿namespace Bai2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Philippinesbtn = new System.Windows.Forms.RadioButton();
            this.Italiabtn = new System.Windows.Forms.RadioButton();
            this.USAbtn = new System.Windows.Forms.RadioButton();
            this.VietNambtn = new System.Windows.Forms.RadioButton();
            this.FlagPtb = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlagPtb)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1120, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(396, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country flag";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Philippinesbtn);
            this.groupBox2.Controls.Add(this.Italiabtn);
            this.groupBox2.Controls.Add(this.USAbtn);
            this.groupBox2.Controls.Add(this.VietNambtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(165, 260);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(226, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contry";
            // 
            // Philippinesbtn
            // 
            this.Philippinesbtn.AutoSize = true;
            this.Philippinesbtn.Location = new System.Drawing.Point(60, 197);
            this.Philippinesbtn.Name = "Philippinesbtn";
            this.Philippinesbtn.Size = new System.Drawing.Size(127, 29);
            this.Philippinesbtn.TabIndex = 3;
            this.Philippinesbtn.TabStop = true;
            this.Philippinesbtn.Text = "Philippines";
            this.Philippinesbtn.UseVisualStyleBackColor = true;
            // 
            // Italiabtn
            // 
            this.Italiabtn.AutoSize = true;
            this.Italiabtn.Location = new System.Drawing.Point(60, 149);
            this.Italiabtn.Name = "Italiabtn";
            this.Italiabtn.Size = new System.Drawing.Size(73, 29);
            this.Italiabtn.TabIndex = 2;
            this.Italiabtn.TabStop = true;
            this.Italiabtn.Text = "Italia";
            this.Italiabtn.UseVisualStyleBackColor = true;
            // 
            // USAbtn
            // 
            this.USAbtn.AutoSize = true;
            this.USAbtn.Location = new System.Drawing.Point(60, 99);
            this.USAbtn.Name = "USAbtn";
            this.USAbtn.Size = new System.Drawing.Size(75, 29);
            this.USAbtn.TabIndex = 1;
            this.USAbtn.TabStop = true;
            this.USAbtn.Text = "USA";
            this.USAbtn.UseVisualStyleBackColor = true;
            // 
            // VietNambtn
            // 
            this.VietNambtn.AutoSize = true;
            this.VietNambtn.Location = new System.Drawing.Point(60, 50);
            this.VietNambtn.Name = "VietNambtn";
            this.VietNambtn.Size = new System.Drawing.Size(108, 29);
            this.VietNambtn.TabIndex = 0;
            this.VietNambtn.TabStop = true;
            this.VietNambtn.Text = "VietNam";
            this.VietNambtn.UseVisualStyleBackColor = true;
            // 
            // FlagPtb
            // 
            this.FlagPtb.Location = new System.Drawing.Point(464, 244);
            this.FlagPtb.Name = "FlagPtb";
            this.FlagPtb.Size = new System.Drawing.Size(529, 289);
            this.FlagPtb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlagPtb.TabIndex = 2;
            this.FlagPtb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 783);
            this.Controls.Add(this.FlagPtb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FlagPtb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton VietNambtn;
        private System.Windows.Forms.RadioButton Philippinesbtn;
        private System.Windows.Forms.RadioButton Italiabtn;
        private System.Windows.Forms.RadioButton USAbtn;
        private System.Windows.Forms.PictureBox FlagPtb;
    }
}
