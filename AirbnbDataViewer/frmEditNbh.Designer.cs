﻿namespace AirbnbData
{
    partial class frmEditNbh
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
            this.txtEditNbh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEditNbh
            // 
            this.txtEditNbh.Location = new System.Drawing.Point(20, 72);
            this.txtEditNbh.Name = "txtEditNbh";
            this.txtEditNbh.Size = new System.Drawing.Size(323, 20);
            this.txtEditNbh.TabIndex = 7;
            this.txtEditNbh.TextChanged += new System.EventHandler(this.txtEditNbh_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter new neighbourhood name.";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(144, 107);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmEditNbh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 164);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtEditNbh);
            this.Controls.Add(this.label1);
            this.Name = "frmEditNbh";
            this.Text = "Edit Neighbourhood Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEditNbh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDone;
    }
}