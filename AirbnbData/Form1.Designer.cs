namespace AirbnbData
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
            this.lstDistricts = new System.Windows.Forms.ListBox();
            this.lstNeighbourhoods = new System.Windows.Forms.ListBox();
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDistricts
            // 
            this.lstDistricts.FormattingEnabled = true;
            this.lstDistricts.Location = new System.Drawing.Point(12, 140);
            this.lstDistricts.Name = "lstDistricts";
            this.lstDistricts.Size = new System.Drawing.Size(275, 303);
            this.lstDistricts.TabIndex = 0;
            // 
            // lstNeighbourhoods
            // 
            this.lstNeighbourhoods.FormattingEnabled = true;
            this.lstNeighbourhoods.Location = new System.Drawing.Point(293, 140);
            this.lstNeighbourhoods.Name = "lstNeighbourhoods";
            this.lstNeighbourhoods.Size = new System.Drawing.Size(275, 303);
            this.lstNeighbourhoods.TabIndex = 1;
            // 
            // lstProperties
            // 
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.Location = new System.Drawing.Point(574, 140);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(275, 303);
            this.lstProperties.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Airbnb Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.lstNeighbourhoods);
            this.Controls.Add(this.lstDistricts);
            this.Name = "Form1";
            this.Text = "Airbnb Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDistricts;
        private System.Windows.Forms.ListBox lstNeighbourhoods;
        private System.Windows.Forms.ListBox lstProperties;
        private System.Windows.Forms.Label label1;
    }
}

