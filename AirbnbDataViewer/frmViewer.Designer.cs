namespace AirbnbData
{
    partial class frmViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewer));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnLoadProps = new System.Windows.Forms.PictureBox();
            this.btnLoadNbhs = new System.Windows.Forms.PictureBox();
            this.btnLoadDists = new System.Windows.Forms.PictureBox();
            this.imgTitle = new System.Windows.Forms.PictureBox();
            this.btnEditNbh = new System.Windows.Forms.Button();
            this.btnEditDist = new System.Windows.Forms.Button();
            this.btnAddNbh = new System.Windows.Forms.Button();
            this.btnAddDist = new System.Windows.Forms.Button();
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.lstNeighbourhoods = new System.Windows.Forms.ListBox();
            this.lstDistricts = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAddProp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEditProp = new System.Windows.Forms.Button();
            this.lblClick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadProps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadNbhs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadDists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(777, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 50;
            this.label1.Visible = false;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(392, 189);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(262, 59);
            this.btnLoadData.TabIndex = 48;
            this.btnLoadData.Text = "Select File";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnLoadProps
            // 
            this.btnLoadProps.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadProps.Image")));
            this.btnLoadProps.Location = new System.Drawing.Point(742, 116);
            this.btnLoadProps.Name = "btnLoadProps";
            this.btnLoadProps.Size = new System.Drawing.Size(152, 52);
            this.btnLoadProps.TabIndex = 47;
            this.btnLoadProps.TabStop = false;
            this.btnLoadProps.Visible = false;
            this.btnLoadProps.Click += new System.EventHandler(this.btnLoadProps_Click);
            // 
            // btnLoadNbhs
            // 
            this.btnLoadNbhs.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadNbhs.Image")));
            this.btnLoadNbhs.Location = new System.Drawing.Point(446, 116);
            this.btnLoadNbhs.Name = "btnLoadNbhs";
            this.btnLoadNbhs.Size = new System.Drawing.Size(151, 52);
            this.btnLoadNbhs.TabIndex = 46;
            this.btnLoadNbhs.TabStop = false;
            this.btnLoadNbhs.Visible = false;
            this.btnLoadNbhs.Click += new System.EventHandler(this.btnLoadNbhs_Click);
            // 
            // btnLoadDists
            // 
            this.btnLoadDists.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadDists.Image")));
            this.btnLoadDists.Location = new System.Drawing.Point(166, 116);
            this.btnLoadDists.Name = "btnLoadDists";
            this.btnLoadDists.Size = new System.Drawing.Size(152, 52);
            this.btnLoadDists.TabIndex = 45;
            this.btnLoadDists.TabStop = false;
            this.btnLoadDists.Visible = false;
            this.btnLoadDists.Click += new System.EventHandler(this.btnLoadDists_Click);
            // 
            // imgTitle
            // 
            this.imgTitle.Image = ((System.Drawing.Image)(resources.GetObject("imgTitle.Image")));
            this.imgTitle.Location = new System.Drawing.Point(162, 10);
            this.imgTitle.Name = "imgTitle";
            this.imgTitle.Size = new System.Drawing.Size(745, 83);
            this.imgTitle.TabIndex = 44;
            this.imgTitle.TabStop = false;
            // 
            // btnEditNbh
            // 
            this.btnEditNbh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditNbh.Location = new System.Drawing.Point(458, 422);
            this.btnEditNbh.Name = "btnEditNbh";
            this.btnEditNbh.Size = new System.Drawing.Size(139, 25);
            this.btnEditNbh.TabIndex = 43;
            this.btnEditNbh.Text = "Edit Neighbourhood";
            this.btnEditNbh.UseVisualStyleBackColor = true;
            this.btnEditNbh.Visible = false;
            this.btnEditNbh.Click += new System.EventHandler(this.btnEditNbh_Click);
            // 
            // btnEditDist
            // 
            this.btnEditDist.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDist.Location = new System.Drawing.Point(166, 422);
            this.btnEditDist.Name = "btnEditDist";
            this.btnEditDist.Size = new System.Drawing.Size(139, 25);
            this.btnEditDist.TabIndex = 42;
            this.btnEditDist.Text = "Edit District";
            this.btnEditDist.UseVisualStyleBackColor = true;
            this.btnEditDist.Visible = false;
            this.btnEditDist.Click += new System.EventHandler(this.btnEditDist_Click);
            // 
            // btnAddNbh
            // 
            this.btnAddNbh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNbh.Location = new System.Drawing.Point(458, 391);
            this.btnAddNbh.Name = "btnAddNbh";
            this.btnAddNbh.Size = new System.Drawing.Size(139, 25);
            this.btnAddNbh.TabIndex = 41;
            this.btnAddNbh.Text = "Add Neighbourhood";
            this.btnAddNbh.UseVisualStyleBackColor = true;
            this.btnAddNbh.Visible = false;
            this.btnAddNbh.Click += new System.EventHandler(this.btnAddNbh_Click);
            // 
            // btnAddDist
            // 
            this.btnAddDist.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDist.Location = new System.Drawing.Point(166, 391);
            this.btnAddDist.Name = "btnAddDist";
            this.btnAddDist.Size = new System.Drawing.Size(139, 25);
            this.btnAddDist.TabIndex = 40;
            this.btnAddDist.Text = "Add District";
            this.btnAddDist.UseVisualStyleBackColor = true;
            this.btnAddDist.Visible = false;
            this.btnAddDist.Click += new System.EventHandler(this.btnAddDist_Click);
            // 
            // lstProperties
            // 
            this.lstProperties.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.ItemHeight = 15;
            this.lstProperties.Location = new System.Drawing.Point(671, 174);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(282, 199);
            this.lstProperties.TabIndex = 39;
            this.lstProperties.Visible = false;
            // 
            // lstNeighbourhoods
            // 
            this.lstNeighbourhoods.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNeighbourhoods.FormattingEnabled = true;
            this.lstNeighbourhoods.ItemHeight = 15;
            this.lstNeighbourhoods.Location = new System.Drawing.Point(383, 174);
            this.lstNeighbourhoods.Name = "lstNeighbourhoods";
            this.lstNeighbourhoods.Size = new System.Drawing.Size(282, 199);
            this.lstNeighbourhoods.TabIndex = 38;
            this.lstNeighbourhoods.Visible = false;
            // 
            // lstDistricts
            // 
            this.lstDistricts.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDistricts.FormattingEnabled = true;
            this.lstDistricts.ItemHeight = 15;
            this.lstDistricts.Location = new System.Drawing.Point(95, 174);
            this.lstDistricts.Name = "lstDistricts";
            this.lstDistricts.Size = new System.Drawing.Size(282, 199);
            this.lstDistricts.TabIndex = 37;
            this.lstDistricts.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddProp
            // 
            this.btnAddProp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProp.Location = new System.Drawing.Point(742, 391);
            this.btnAddProp.Name = "btnAddProp";
            this.btnAddProp.Size = new System.Drawing.Size(139, 25);
            this.btnAddProp.TabIndex = 53;
            this.btnAddProp.Text = "Add Property";
            this.btnAddProp.UseVisualStyleBackColor = true;
            this.btnAddProp.Visible = false;
            this.btnAddProp.Click += new System.EventHandler(this.btnAddProp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(909, 473);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 47);
            this.btnExit.TabIndex = 52;
            this.btnExit.Text = "Save and Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEditProp
            // 
            this.btnEditProp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProp.Location = new System.Drawing.Point(742, 422);
            this.btnEditProp.Name = "btnEditProp";
            this.btnEditProp.Size = new System.Drawing.Size(139, 25);
            this.btnEditProp.TabIndex = 54;
            this.btnEditProp.Text = "Edit Property";
            this.btnEditProp.UseVisualStyleBackColor = true;
            this.btnEditProp.Visible = false;
            this.btnEditProp.Click += new System.EventHandler(this.BtnEditProp_Click);
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.Location = new System.Drawing.Point(443, 171);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(156, 13);
            this.lblClick.TabIndex = 55;
            this.lblClick.Text = "Click below to select a data file.";
            // 
            // frmViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 550);
            this.Controls.Add(this.lblClick);
            this.Controls.Add(this.btnEditProp);
            this.Controls.Add(this.btnAddProp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnLoadProps);
            this.Controls.Add(this.btnLoadNbhs);
            this.Controls.Add(this.btnLoadDists);
            this.Controls.Add(this.imgTitle);
            this.Controls.Add(this.btnEditNbh);
            this.Controls.Add(this.btnEditDist);
            this.Controls.Add(this.btnAddNbh);
            this.Controls.Add(this.btnAddDist);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.lstNeighbourhoods);
            this.Controls.Add(this.lstDistricts);
            this.Name = "frmViewer";
            this.Text = "Airbnb Data Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadProps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadNbhs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadDists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.PictureBox btnLoadProps;
        private System.Windows.Forms.PictureBox btnLoadNbhs;
        private System.Windows.Forms.PictureBox btnLoadDists;
        private System.Windows.Forms.PictureBox imgTitle;
        private System.Windows.Forms.Button btnEditNbh;
        private System.Windows.Forms.Button btnEditDist;
        private System.Windows.Forms.Button btnAddNbh;
        private System.Windows.Forms.Button btnAddDist;
        private System.Windows.Forms.ListBox lstProperties;
        private System.Windows.Forms.ListBox lstNeighbourhoods;
        private System.Windows.Forms.ListBox lstDistricts;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAddProp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditProp;
        private System.Windows.Forms.Label lblClick;
    }
}

