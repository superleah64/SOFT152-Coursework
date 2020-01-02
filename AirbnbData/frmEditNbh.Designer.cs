namespace AirbnbData
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
            this.btnDoneNbh = new System.Windows.Forms.Button();
            this.txtEditNbh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDoneNbh
            // 
            this.btnDoneNbh.Location = new System.Drawing.Point(136, 113);
            this.btnDoneNbh.Name = "btnDoneNbh";
            this.btnDoneNbh.Size = new System.Drawing.Size(75, 23);
            this.btnDoneNbh.TabIndex = 5;
            this.btnDoneNbh.Text = "Done";
            this.btnDoneNbh.UseVisualStyleBackColor = true;
            this.btnDoneNbh.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // txtEditNbh
            // 
            this.txtEditNbh.Location = new System.Drawing.Point(20, 74);
            this.txtEditNbh.Name = "txtEditNbh";
            this.txtEditNbh.Size = new System.Drawing.Size(323, 20);
            this.txtEditNbh.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter new neighbourhood name.";
            // 
            // frmEditNbh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 164);
            this.Controls.Add(this.btnDoneNbh);
            this.Controls.Add(this.txtEditNbh);
            this.Controls.Add(this.label1);
            this.Name = "frmEditNbh";
            this.Text = "Edit Neighbourhood Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoneNbh;
        private System.Windows.Forms.TextBox txtEditNbh;
        private System.Windows.Forms.Label label1;
    }
}