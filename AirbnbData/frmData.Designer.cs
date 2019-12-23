namespace AirbnbData
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lstDistricts = new System.Windows.Forms.ListBox();
            this.lstNeighbourhoods = new System.Windows.Forms.ListBox();
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddDist = new System.Windows.Forms.Button();
            this.btnAddNbh = new System.Windows.Forms.Button();
            this.btnEditDist = new System.Windows.Forms.Button();
            this.btnEditNbh = new System.Windows.Forms.Button();
            this.btnPropMaint = new System.Windows.Forms.Button();
            this.btnLoadProps = new System.Windows.Forms.PictureBox();
            this.btnLoadNbhs = new System.Windows.Forms.PictureBox();
            this.btnLoadDists = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadProps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadNbhs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadDists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDistricts
            // 
            this.lstDistricts.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDistricts.FormattingEnabled = true;
            this.lstDistricts.ItemHeight = 15;
            this.lstDistricts.Location = new System.Drawing.Point(112, 234);
            this.lstDistricts.Name = "lstDistricts";
            this.lstDistricts.Size = new System.Drawing.Size(282, 199);
            this.lstDistricts.TabIndex = 0;
            this.lstDistricts.SelectedIndexChanged += new System.EventHandler(this.lstDistricts_SelectedIndexChanged);
            // 
            // lstNeighbourhoods
            // 
            this.lstNeighbourhoods.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNeighbourhoods.FormattingEnabled = true;
            this.lstNeighbourhoods.ItemHeight = 15;
            this.lstNeighbourhoods.Location = new System.Drawing.Point(420, 234);
            this.lstNeighbourhoods.Name = "lstNeighbourhoods";
            this.lstNeighbourhoods.Size = new System.Drawing.Size(282, 199);
            this.lstNeighbourhoods.TabIndex = 1;
            this.lstNeighbourhoods.SelectedIndexChanged += new System.EventHandler(this.lstNeighbourhoods_SelectedIndexChanged);
            // 
            // lstProperties
            // 
            this.lstProperties.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.ItemHeight = 15;
            this.lstProperties.Location = new System.Drawing.Point(727, 234);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(282, 199);
            this.lstProperties.TabIndex = 2;
            this.lstProperties.SelectedIndexChanged += new System.EventHandler(this.lstProperties_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1049, 535);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 47);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnAddDist
            // 
            this.btnAddDist.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDist.Location = new System.Drawing.Point(182, 439);
            this.btnAddDist.Name = "btnAddDist";
            this.btnAddDist.Size = new System.Drawing.Size(139, 25);
            this.btnAddDist.TabIndex = 13;
            this.btnAddDist.Text = "Add District";
            this.btnAddDist.UseVisualStyleBackColor = true;
            this.btnAddDist.Click += new System.EventHandler(this.BtnAddDist_Click);
            // 
            // btnAddNbh
            // 
            this.btnAddNbh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNbh.Location = new System.Drawing.Point(498, 439);
            this.btnAddNbh.Name = "btnAddNbh";
            this.btnAddNbh.Size = new System.Drawing.Size(139, 25);
            this.btnAddNbh.TabIndex = 14;
            this.btnAddNbh.Text = "Add Neighbourhood";
            this.btnAddNbh.UseVisualStyleBackColor = true;
            this.btnAddNbh.Click += new System.EventHandler(this.BtnAddNbh_Click);
            // 
            // btnEditDist
            // 
            this.btnEditDist.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDist.Location = new System.Drawing.Point(182, 470);
            this.btnEditDist.Name = "btnEditDist";
            this.btnEditDist.Size = new System.Drawing.Size(139, 25);
            this.btnEditDist.TabIndex = 16;
            this.btnEditDist.Text = "Edit District";
            this.btnEditDist.UseVisualStyleBackColor = true;
            this.btnEditDist.Click += new System.EventHandler(this.BtnEditDist_Click);
            // 
            // btnEditNbh
            // 
            this.btnEditNbh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditNbh.Location = new System.Drawing.Point(498, 470);
            this.btnEditNbh.Name = "btnEditNbh";
            this.btnEditNbh.Size = new System.Drawing.Size(139, 25);
            this.btnEditNbh.TabIndex = 27;
            this.btnEditNbh.Text = "Edit Neighbourhood";
            this.btnEditNbh.UseVisualStyleBackColor = true;
            this.btnEditNbh.Click += new System.EventHandler(this.BtnEditNbh_Click);
            // 
            // btnPropMaint
            // 
            this.btnPropMaint.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPropMaint.Location = new System.Drawing.Point(773, 439);
            this.btnPropMaint.Name = "btnPropMaint";
            this.btnPropMaint.Size = new System.Drawing.Size(180, 45);
            this.btnPropMaint.TabIndex = 32;
            this.btnPropMaint.Text = "Property Maintenance";
            this.btnPropMaint.UseVisualStyleBackColor = true;
            this.btnPropMaint.Click += new System.EventHandler(this.BtnPropMaint_Click);
            // 
            // btnLoadProps
            // 
            this.btnLoadProps.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadProps.Image")));
            this.btnLoadProps.Location = new System.Drawing.Point(801, 176);
            this.btnLoadProps.Name = "btnLoadProps";
            this.btnLoadProps.Size = new System.Drawing.Size(152, 52);
            this.btnLoadProps.TabIndex = 31;
            this.btnLoadProps.TabStop = false;
            this.btnLoadProps.Click += new System.EventHandler(this.btnLoadProps_Click);
            // 
            // btnLoadNbhs
            // 
            this.btnLoadNbhs.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadNbhs.Image")));
            this.btnLoadNbhs.Location = new System.Drawing.Point(486, 176);
            this.btnLoadNbhs.Name = "btnLoadNbhs";
            this.btnLoadNbhs.Size = new System.Drawing.Size(151, 52);
            this.btnLoadNbhs.TabIndex = 30;
            this.btnLoadNbhs.TabStop = false;
            this.btnLoadNbhs.Click += new System.EventHandler(this.btnLoadNbhs_Click);
            // 
            // btnLoadDists
            // 
            this.btnLoadDists.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadDists.Image")));
            this.btnLoadDists.Location = new System.Drawing.Point(182, 176);
            this.btnLoadDists.Name = "btnLoadDists";
            this.btnLoadDists.Size = new System.Drawing.Size(152, 52);
            this.btnLoadDists.TabIndex = 29;
            this.btnLoadDists.TabStop = false;
            this.btnLoadDists.Click += new System.EventHandler(this.btnLoadDists_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(745, 83);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(20, 26);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(118, 59);
            this.btnLoadData.TabIndex = 33;
            this.btnLoadData.Text = "Get Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.BtnLoadData_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 622);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnPropMaint);
            this.Controls.Add(this.btnLoadProps);
            this.Controls.Add(this.btnLoadNbhs);
            this.Controls.Add(this.btnLoadDists);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEditNbh);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEditDist);
            this.Controls.Add(this.btnAddNbh);
            this.Controls.Add(this.btnAddDist);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.lstNeighbourhoods);
            this.Controls.Add(this.lstDistricts);
            this.Name = "frmMain";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadProps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadNbhs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadDists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDistricts;
        private System.Windows.Forms.ListBox lstNeighbourhoods;
        private System.Windows.Forms.ListBox lstProperties;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnLoadDists;
        private System.Windows.Forms.PictureBox btnLoadNbhs;
        private System.Windows.Forms.PictureBox btnLoadProps;
        private System.Windows.Forms.Button btnAddDist;
        private System.Windows.Forms.Button btnAddNbh;
        private System.Windows.Forms.Button btnEditDist;
        private System.Windows.Forms.Button btnEditNbh;
        private System.Windows.Forms.Button btnPropMaint;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnLoadData;
    }
}

