﻿namespace AirbnbDataViewer
{
    partial class frmAddDist
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
            this.btnDoneDist = new System.Windows.Forms.Button();
            this.txtAddDist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDoneDist
            // 
            this.btnDoneDist.Location = new System.Drawing.Point(136, 113);
            this.btnDoneDist.Name = "btnDoneDist";
            this.btnDoneDist.Size = new System.Drawing.Size(75, 23);
            this.btnDoneDist.TabIndex = 8;
            this.btnDoneDist.Text = "Done";
            this.btnDoneDist.UseVisualStyleBackColor = true;
            this.btnDoneDist.Click += new System.EventHandler(this.btnDoneDist_Click);
            // 
            // txtAddDist
            // 
            this.txtAddDist.Location = new System.Drawing.Point(20, 74);
            this.txtAddDist.Name = "txtAddDist";
            this.txtAddDist.Size = new System.Drawing.Size(323, 20);
            this.txtAddDist.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter new district name.";
            // 
            // frmAddDist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 164);
            this.Controls.Add(this.btnDoneDist);
            this.Controls.Add(this.txtAddDist);
            this.Controls.Add(this.label1);
            this.Name = "frmAddDist";
            this.Text = "Add New District";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoneDist;
        private System.Windows.Forms.TextBox txtAddDist;
        private System.Windows.Forms.Label label1;
    }
}