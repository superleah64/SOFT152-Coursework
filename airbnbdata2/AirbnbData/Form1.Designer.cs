namespace AirbnbData
{
    partial class frmData
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
            this.btnShowDist = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditDistrict = new System.Windows.Forms.Button();
            this.btnAddDistrict = new System.Windows.Forms.Button();
            this.btnAddNbh = new System.Windows.Forms.Button();
            this.btnEditNbh = new System.Windows.Forms.Button();
            this.btnPropMaint = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowNbh = new System.Windows.Forms.Button();
            this.btnShowProp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(87, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Airbnb Data Viewer";
            // 
            // btnShowDist
            // 
            this.btnShowDist.Location = new System.Drawing.Point(64, 89);
            this.btnShowDist.Name = "btnShowDist";
            this.btnShowDist.Size = new System.Drawing.Size(177, 45);
            this.btnShowDist.TabIndex = 4;
            this.btnShowDist.Text = "Show District Data";
            this.btnShowDist.UseVisualStyleBackColor = true;
            this.btnShowDist.Click += new System.EventHandler(this.BtnDist_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AirbnbData.Properties.Resources.AirbnbLogo;
            this.pictureBox1.Location = new System.Drawing.Point(335, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditDistrict
            // 
            this.btnEditDistrict.Location = new System.Drawing.Point(48, 449);
            this.btnEditDistrict.Name = "btnEditDistrict";
            this.btnEditDistrict.Size = new System.Drawing.Size(193, 42);
            this.btnEditDistrict.TabIndex = 7;
            this.btnEditDistrict.Text = "Edit District";
            this.btnEditDistrict.UseVisualStyleBackColor = true;
            this.btnEditDistrict.Click += new System.EventHandler(this.BtnEditDistrict_Click);
            // 
            // btnAddDistrict
            // 
            this.btnAddDistrict.Location = new System.Drawing.Point(48, 497);
            this.btnAddDistrict.Name = "btnAddDistrict";
            this.btnAddDistrict.Size = new System.Drawing.Size(193, 42);
            this.btnAddDistrict.TabIndex = 8;
            this.btnAddDistrict.Text = "Add District";
            this.btnAddDistrict.UseVisualStyleBackColor = true;
            this.btnAddDistrict.Click += new System.EventHandler(this.BtnAddDistrict_Click);
            // 
            // btnAddNbh
            // 
            this.btnAddNbh.Location = new System.Drawing.Point(338, 497);
            this.btnAddNbh.Name = "btnAddNbh";
            this.btnAddNbh.Size = new System.Drawing.Size(193, 42);
            this.btnAddNbh.TabIndex = 10;
            this.btnAddNbh.Text = "Add Neighbourhood";
            this.btnAddNbh.UseVisualStyleBackColor = true;
            this.btnAddNbh.Click += new System.EventHandler(this.BtnAddNbh_Click);
            // 
            // btnEditNbh
            // 
            this.btnEditNbh.Location = new System.Drawing.Point(338, 449);
            this.btnEditNbh.Name = "btnEditNbh";
            this.btnEditNbh.Size = new System.Drawing.Size(193, 42);
            this.btnEditNbh.TabIndex = 9;
            this.btnEditNbh.Text = "Edit Neighbourhood";
            this.btnEditNbh.UseVisualStyleBackColor = true;
            this.btnEditNbh.Click += new System.EventHandler(this.BtnEditNbh_Click);
            // 
            // btnPropMaint
            // 
            this.btnPropMaint.Location = new System.Drawing.Point(624, 12);
            this.btnPropMaint.Name = "btnPropMaint";
            this.btnPropMaint.Size = new System.Drawing.Size(177, 45);
            this.btnPropMaint.TabIndex = 11;
            this.btnPropMaint.Text = "Property Maintenance";
            this.btnPropMaint.UseVisualStyleBackColor = true;
            this.btnPropMaint.Click += new System.EventHandler(this.BtnPropMaint_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(613, 469);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(221, 56);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Save Changes and Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnShowNbh
            // 
            this.btnShowNbh.Location = new System.Drawing.Point(341, 89);
            this.btnShowNbh.Name = "btnShowNbh";
            this.btnShowNbh.Size = new System.Drawing.Size(177, 45);
            this.btnShowNbh.TabIndex = 13;
            this.btnShowNbh.Text = "Show Neighbourhood Data";
            this.btnShowNbh.UseVisualStyleBackColor = true;
            this.btnShowNbh.Click += new System.EventHandler(this.BtnShowNbh_Click);
            // 
            // btnShowProp
            // 
            this.btnShowProp.Location = new System.Drawing.Point(624, 89);
            this.btnShowProp.Name = "btnShowProp";
            this.btnShowProp.Size = new System.Drawing.Size(177, 45);
            this.btnShowProp.TabIndex = 14;
            this.btnShowProp.Text = "Show Property Data";
            this.btnShowProp.UseVisualStyleBackColor = true;
            this.btnShowProp.Click += new System.EventHandler(this.BtnShowProp_Click);
            // 
            // frmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 547);
            this.Controls.Add(this.btnShowProp);
            this.Controls.Add(this.btnShowNbh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPropMaint);
            this.Controls.Add(this.btnAddNbh);
            this.Controls.Add(this.btnEditNbh);
            this.Controls.Add(this.btnAddDistrict);
            this.Controls.Add(this.btnEditDistrict);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnShowDist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.lstNeighbourhoods);
            this.Controls.Add(this.lstDistricts);
            this.Name = "frmData";
            this.Text = "Airbnb Data Viewer";
            this.Load += new System.EventHandler(this.FrmData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDistricts;
        private System.Windows.Forms.ListBox lstNeighbourhoods;
        private System.Windows.Forms.ListBox lstProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowDist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditDistrict;
        private System.Windows.Forms.Button btnAddDistrict;
        private System.Windows.Forms.Button btnAddNbh;
        private System.Windows.Forms.Button btnEditNbh;
        private System.Windows.Forms.Button btnPropMaint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowNbh;
        private System.Windows.Forms.Button btnShowProp;
    }
}

