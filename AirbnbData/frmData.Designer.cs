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
            this.lstDistricts = new System.Windows.Forms.ListBox();
            this.lstNeighbourhoods = new System.Windows.Forms.ListBox();
            this.lstProperties = new System.Windows.Forms.ListBox();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblDists = new System.Windows.Forms.Label();
            this.lblNbhs = new System.Windows.Forms.Label();
            this.lblProps = new System.Windows.Forms.Label();
            this.lstDistData = new System.Windows.Forms.ListBox();
            this.lstNbhData = new System.Windows.Forms.ListBox();
            this.lstEditNbh = new System.Windows.Forms.ListBox();
            this.btnAddDist = new System.Windows.Forms.Button();
            this.btnAddNbh = new System.Windows.Forms.Button();
            this.btnAddProp = new System.Windows.Forms.Button();
            this.btnEditDist = new System.Windows.Forms.Button();
            this.btnEditProp = new System.Windows.Forms.Button();
            this.lblAddEdit = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShowDist = new System.Windows.Forms.Button();
            this.btnShowNbh = new System.Windows.Forms.Button();
            this.btnShowProp = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEditNbh = new System.Windows.Forms.Button();
            this.imgAirbnb = new System.Windows.Forms.PictureBox();
            this.txtPropID = new System.Windows.Forms.TextBox();
            this.lblPropID = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPropName = new System.Windows.Forms.TextBox();
            this.txtHostID = new System.Windows.Forms.TextBox();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.txtNumProp = new System.Windows.Forms.TextBox();
            this.txtLati = new System.Windows.Forms.TextBox();
            this.txtLongi = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.lblPropName = new System.Windows.Forms.Label();
            this.lblHostID = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.lblNumProp = new System.Windows.Forms.Label();
            this.lblLati = new System.Windows.Forms.Label();
            this.lblLongi = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblMinNights = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblDistName = new System.Windows.Forms.Label();
            this.lblNumNbh = new System.Windows.Forms.Label();
            this.lblNbhName = new System.Windows.Forms.Label();
            this.lblPropNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgAirbnb)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDistricts
            // 
            this.lstDistricts.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDistricts.FormattingEnabled = true;
            this.lstDistricts.ItemHeight = 15;
            this.lstDistricts.Location = new System.Drawing.Point(618, 270);
            this.lstDistricts.Name = "lstDistricts";
            this.lstDistricts.Size = new System.Drawing.Size(275, 259);
            this.lstDistricts.TabIndex = 0;
            // 
            // lstNeighbourhoods
            // 
            this.lstNeighbourhoods.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNeighbourhoods.FormattingEnabled = true;
            this.lstNeighbourhoods.ItemHeight = 15;
            this.lstNeighbourhoods.Location = new System.Drawing.Point(899, 270);
            this.lstNeighbourhoods.Name = "lstNeighbourhoods";
            this.lstNeighbourhoods.Size = new System.Drawing.Size(275, 259);
            this.lstNeighbourhoods.TabIndex = 1;
            // 
            // lstProperties
            // 
            this.lstProperties.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProperties.FormattingEnabled = true;
            this.lstProperties.ItemHeight = 15;
            this.lstProperties.Location = new System.Drawing.Point(1180, 270);
            this.lstProperties.Name = "lstProperties";
            this.lstProperties.Size = new System.Drawing.Size(275, 259);
            this.lstProperties.TabIndex = 2;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.Location = new System.Drawing.Point(489, 49);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(360, 44);
            this.lblMainTitle.TabIndex = 3;
            this.lblMainTitle.Text = "Airbnb Data Viewer";
            // 
            // lblDists
            // 
            this.lblDists.AutoSize = true;
            this.lblDists.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDists.Location = new System.Drawing.Point(725, 247);
            this.lblDists.Name = "lblDists";
            this.lblDists.Size = new System.Drawing.Size(57, 20);
            this.lblDists.TabIndex = 7;
            this.lblDists.Text = "Districts";
            // 
            // lblNbhs
            // 
            this.lblNbhs.AutoSize = true;
            this.lblNbhs.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbhs.Location = new System.Drawing.Point(989, 247);
            this.lblNbhs.Name = "lblNbhs";
            this.lblNbhs.Size = new System.Drawing.Size(102, 20);
            this.lblNbhs.TabIndex = 8;
            this.lblNbhs.Text = "Neighbourhoods";
            // 
            // lblProps
            // 
            this.lblProps.AutoSize = true;
            this.lblProps.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProps.Location = new System.Drawing.Point(1277, 247);
            this.lblProps.Name = "lblProps";
            this.lblProps.Size = new System.Drawing.Size(68, 20);
            this.lblProps.TabIndex = 9;
            this.lblProps.Text = "Properties";
            // 
            // lstDistData
            // 
            this.lstDistData.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDistData.FormattingEnabled = true;
            this.lstDistData.ItemHeight = 15;
            this.lstDistData.Location = new System.Drawing.Point(618, 587);
            this.lstDistData.Name = "lstDistData";
            this.lstDistData.Size = new System.Drawing.Size(275, 184);
            this.lstDistData.TabIndex = 10;
            // 
            // lstNbhData
            // 
            this.lstNbhData.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNbhData.FormattingEnabled = true;
            this.lstNbhData.ItemHeight = 15;
            this.lstNbhData.Location = new System.Drawing.Point(899, 587);
            this.lstNbhData.Name = "lstNbhData";
            this.lstNbhData.Size = new System.Drawing.Size(275, 184);
            this.lstNbhData.TabIndex = 11;
            // 
            // lstEditNbh
            // 
            this.lstEditNbh.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEditNbh.FormattingEnabled = true;
            this.lstEditNbh.ItemHeight = 15;
            this.lstEditNbh.Location = new System.Drawing.Point(1180, 587);
            this.lstEditNbh.Name = "lstEditNbh";
            this.lstEditNbh.Size = new System.Drawing.Size(275, 184);
            this.lstEditNbh.TabIndex = 12;
            // 
            // btnAddDist
            // 
            this.btnAddDist.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDist.Location = new System.Drawing.Point(726, 828);
            this.btnAddDist.Name = "btnAddDist";
            this.btnAddDist.Size = new System.Drawing.Size(115, 29);
            this.btnAddDist.TabIndex = 13;
            this.btnAddDist.Text = "District";
            this.btnAddDist.UseVisualStyleBackColor = true;
            this.btnAddDist.Click += new System.EventHandler(this.BtnAddDist_Click);
            // 
            // btnAddNbh
            // 
            this.btnAddNbh.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNbh.Location = new System.Drawing.Point(847, 828);
            this.btnAddNbh.Name = "btnAddNbh";
            this.btnAddNbh.Size = new System.Drawing.Size(115, 29);
            this.btnAddNbh.TabIndex = 14;
            this.btnAddNbh.Text = "Neighbourhood";
            this.btnAddNbh.UseVisualStyleBackColor = true;
            this.btnAddNbh.Click += new System.EventHandler(this.BtnAddNbh_Click);
            // 
            // btnAddProp
            // 
            this.btnAddProp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProp.Location = new System.Drawing.Point(968, 828);
            this.btnAddProp.Name = "btnAddProp";
            this.btnAddProp.Size = new System.Drawing.Size(115, 29);
            this.btnAddProp.TabIndex = 15;
            this.btnAddProp.Text = "Property";
            this.btnAddProp.UseVisualStyleBackColor = true;
            this.btnAddProp.Click += new System.EventHandler(this.BtnAddProp_Click);
            // 
            // btnEditDist
            // 
            this.btnEditDist.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDist.Location = new System.Drawing.Point(1147, 828);
            this.btnEditDist.Name = "btnEditDist";
            this.btnEditDist.Size = new System.Drawing.Size(115, 29);
            this.btnEditDist.TabIndex = 16;
            this.btnEditDist.Text = "District";
            this.btnEditDist.UseVisualStyleBackColor = true;
            this.btnEditDist.Click += new System.EventHandler(this.BtnEditDist_Click);
            // 
            // btnEditProp
            // 
            this.btnEditProp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProp.Location = new System.Drawing.Point(1389, 828);
            this.btnEditProp.Name = "btnEditProp";
            this.btnEditProp.Size = new System.Drawing.Size(114, 29);
            this.btnEditProp.TabIndex = 18;
            this.btnEditProp.Text = "Property";
            this.btnEditProp.UseVisualStyleBackColor = true;
            this.btnEditProp.Click += new System.EventHandler(this.BtnEditProp_Click);
            // 
            // lblAddEdit
            // 
            this.lblAddEdit.AutoSize = true;
            this.lblAddEdit.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEdit.Location = new System.Drawing.Point(159, 138);
            this.lblAddEdit.Name = "lblAddEdit";
            this.lblAddEdit.Size = new System.Drawing.Size(94, 16);
            this.lblAddEdit.TabIndex = 19;
            this.lblAddEdit.Text = "Add/Edit Data";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(29, 798);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 47);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnShowDist
            // 
            this.btnShowDist.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDist.Location = new System.Drawing.Point(693, 535);
            this.btnShowDist.Name = "btnShowDist";
            this.btnShowDist.Size = new System.Drawing.Size(136, 23);
            this.btnShowDist.TabIndex = 22;
            this.btnShowDist.Text = "Show Data";
            this.btnShowDist.UseVisualStyleBackColor = true;
            this.btnShowDist.Click += new System.EventHandler(this.BtnShowDist_Click);
            // 
            // btnShowNbh
            // 
            this.btnShowNbh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowNbh.Location = new System.Drawing.Point(971, 535);
            this.btnShowNbh.Name = "btnShowNbh";
            this.btnShowNbh.Size = new System.Drawing.Size(136, 23);
            this.btnShowNbh.TabIndex = 23;
            this.btnShowNbh.Text = "Show Data";
            this.btnShowNbh.UseVisualStyleBackColor = true;
            this.btnShowNbh.Click += new System.EventHandler(this.BtnShowNbh_Click);
            // 
            // btnShowProp
            // 
            this.btnShowProp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowProp.Location = new System.Drawing.Point(1258, 535);
            this.btnShowProp.Name = "btnShowProp";
            this.btnShowProp.Size = new System.Drawing.Size(136, 23);
            this.btnShowProp.TabIndex = 24;
            this.btnShowProp.Text = "Show Data";
            this.btnShowProp.UseVisualStyleBackColor = true;
            this.btnShowProp.Click += new System.EventHandler(this.BtnShowProp_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(838, 535);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnEditNbh
            // 
            this.btnEditNbh.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditNbh.Location = new System.Drawing.Point(1268, 828);
            this.btnEditNbh.Name = "btnEditNbh";
            this.btnEditNbh.Size = new System.Drawing.Size(115, 29);
            this.btnEditNbh.TabIndex = 27;
            this.btnEditNbh.Text = "Neighbourhood";
            this.btnEditNbh.UseVisualStyleBackColor = true;
            this.btnEditNbh.Click += new System.EventHandler(this.BtnEditNbh_Click);
            // 
            // imgAirbnb
            // 
            this.imgAirbnb.Image = global::AirbnbData.Properties.Resources.AirbnbLogo;
            this.imgAirbnb.Location = new System.Drawing.Point(1131, 12);
            this.imgAirbnb.Name = "imgAirbnb";
            this.imgAirbnb.Size = new System.Drawing.Size(275, 101);
            this.imgAirbnb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAirbnb.TabIndex = 6;
            this.imgAirbnb.TabStop = false;
            // 
            // txtPropID
            // 
            this.txtPropID.Location = new System.Drawing.Point(206, 475);
            this.txtPropID.Name = "txtPropID";
            this.txtPropID.Size = new System.Drawing.Size(267, 20);
            this.txtPropID.TabIndex = 28;
            // 
            // lblPropID
            // 
            this.lblPropID.AutoSize = true;
            this.lblPropID.Location = new System.Drawing.Point(92, 478);
            this.lblPropID.Name = "lblPropID";
            this.lblPropID.Size = new System.Drawing.Size(60, 13);
            this.lblPropID.TabIndex = 39;
            this.lblPropID.Text = "Property ID";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(92, 686);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 47;
            this.lblPrice.Text = "Price";
            // 
            // txtPropName
            // 
            this.txtPropName.Location = new System.Drawing.Point(206, 501);
            this.txtPropName.Name = "txtPropName";
            this.txtPropName.Size = new System.Drawing.Size(267, 20);
            this.txtPropName.TabIndex = 29;
            // 
            // txtHostID
            // 
            this.txtHostID.Location = new System.Drawing.Point(206, 527);
            this.txtHostID.Name = "txtHostID";
            this.txtHostID.Size = new System.Drawing.Size(267, 20);
            this.txtHostID.TabIndex = 30;
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(206, 553);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(267, 20);
            this.txtHostName.TabIndex = 31;
            // 
            // txtNumProp
            // 
            this.txtNumProp.Location = new System.Drawing.Point(206, 579);
            this.txtNumProp.Name = "txtNumProp";
            this.txtNumProp.Size = new System.Drawing.Size(267, 20);
            this.txtNumProp.TabIndex = 32;
            // 
            // txtLati
            // 
            this.txtLati.Location = new System.Drawing.Point(206, 605);
            this.txtLati.Name = "txtLati";
            this.txtLati.Size = new System.Drawing.Size(267, 20);
            this.txtLati.TabIndex = 33;
            // 
            // txtLongi
            // 
            this.txtLongi.Location = new System.Drawing.Point(206, 631);
            this.txtLongi.Name = "txtLongi";
            this.txtLongi.Size = new System.Drawing.Size(267, 20);
            this.txtLongi.TabIndex = 34;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(206, 657);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(267, 20);
            this.txtRoomType.TabIndex = 35;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(206, 683);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(267, 20);
            this.txtPrice.TabIndex = 36;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(206, 709);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(267, 20);
            this.textBox10.TabIndex = 37;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(206, 735);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(267, 20);
            this.textBox11.TabIndex = 38;
            // 
            // lblPropName
            // 
            this.lblPropName.AutoSize = true;
            this.lblPropName.Location = new System.Drawing.Point(92, 504);
            this.lblPropName.Name = "lblPropName";
            this.lblPropName.Size = new System.Drawing.Size(77, 13);
            this.lblPropName.TabIndex = 40;
            this.lblPropName.Text = "Property Name";
            // 
            // lblHostID
            // 
            this.lblHostID.AutoSize = true;
            this.lblHostID.Location = new System.Drawing.Point(92, 530);
            this.lblHostID.Name = "lblHostID";
            this.lblHostID.Size = new System.Drawing.Size(43, 13);
            this.lblHostID.TabIndex = 41;
            this.lblHostID.Text = "Host ID";
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Location = new System.Drawing.Point(92, 556);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(60, 13);
            this.lblHostName.TabIndex = 42;
            this.lblHostName.Text = "Host Name";
            // 
            // lblNumProp
            // 
            this.lblNumProp.AutoSize = true;
            this.lblNumProp.Location = new System.Drawing.Point(92, 582);
            this.lblNumProp.Name = "lblNumProp";
            this.lblNumProp.Size = new System.Drawing.Size(106, 13);
            this.lblNumProp.TabIndex = 43;
            this.lblNumProp.Text = "Number of Properties";
            // 
            // lblLati
            // 
            this.lblLati.AutoSize = true;
            this.lblLati.Location = new System.Drawing.Point(92, 608);
            this.lblLati.Name = "lblLati";
            this.lblLati.Size = new System.Drawing.Size(45, 13);
            this.lblLati.TabIndex = 44;
            this.lblLati.Text = "Latitude";
            // 
            // lblLongi
            // 
            this.lblLongi.AutoSize = true;
            this.lblLongi.Location = new System.Drawing.Point(92, 634);
            this.lblLongi.Name = "lblLongi";
            this.lblLongi.Size = new System.Drawing.Size(54, 13);
            this.lblLongi.TabIndex = 45;
            this.lblLongi.Text = "Longitude";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(92, 660);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(62, 13);
            this.lblRoomType.TabIndex = 46;
            this.lblRoomType.Text = "Room Type";
            // 
            // lblMinNights
            // 
            this.lblMinNights.AutoSize = true;
            this.lblMinNights.Location = new System.Drawing.Point(92, 712);
            this.lblMinNights.Name = "lblMinNights";
            this.lblMinNights.Size = new System.Drawing.Size(81, 13);
            this.lblMinNights.TabIndex = 48;
            this.lblMinNights.Text = "Minimum Nights";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(92, 738);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(77, 13);
            this.lblDays.TabIndex = 49;
            this.lblDays.Text = "Available Days";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 20);
            this.textBox1.TabIndex = 50;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(452, 323);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(21, 20);
            this.textBox2.TabIndex = 51;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(206, 385);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(267, 20);
            this.textBox3.TabIndex = 52;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(452, 411);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(21, 20);
            this.textBox4.TabIndex = 53;
            // 
            // lblDistName
            // 
            this.lblDistName.AutoSize = true;
            this.lblDistName.Location = new System.Drawing.Point(92, 300);
            this.lblDistName.Name = "lblDistName";
            this.lblDistName.Size = new System.Drawing.Size(70, 13);
            this.lblDistName.TabIndex = 54;
            this.lblDistName.Text = "District Name";
            // 
            // lblNumNbh
            // 
            this.lblNumNbh.AutoSize = true;
            this.lblNumNbh.Location = new System.Drawing.Point(92, 326);
            this.lblNumNbh.Name = "lblNumNbh";
            this.lblNumNbh.Size = new System.Drawing.Size(137, 13);
            this.lblNumNbh.TabIndex = 55;
            this.lblNumNbh.Text = "Number of Neighbourhoods";
            // 
            // lblNbhName
            // 
            this.lblNbhName.AutoSize = true;
            this.lblNbhName.Location = new System.Drawing.Point(92, 388);
            this.lblNbhName.Name = "lblNbhName";
            this.lblNbhName.Size = new System.Drawing.Size(111, 13);
            this.lblNbhName.TabIndex = 56;
            this.lblNbhName.Text = "Neighbourhood Name";
            // 
            // lblPropNum
            // 
            this.lblPropNum.AutoSize = true;
            this.lblPropNum.Location = new System.Drawing.Point(92, 414);
            this.lblPropNum.Name = "lblPropNum";
            this.lblPropNum.Size = new System.Drawing.Size(106, 13);
            this.lblPropNum.TabIndex = 57;
            this.lblPropNum.Text = "Number of Properties";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 869);
            this.Controls.Add(this.lblPropNum);
            this.Controls.Add(this.lblNbhName);
            this.Controls.Add(this.lblNumNbh);
            this.Controls.Add(this.lblDistName);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblMinNights);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblLongi);
            this.Controls.Add(this.lblLati);
            this.Controls.Add(this.lblNumProp);
            this.Controls.Add(this.lblHostName);
            this.Controls.Add(this.lblHostID);
            this.Controls.Add(this.lblPropName);
            this.Controls.Add(this.lblPropID);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.txtLongi);
            this.Controls.Add(this.txtLati);
            this.Controls.Add(this.txtNumProp);
            this.Controls.Add(this.txtHostName);
            this.Controls.Add(this.txtHostID);
            this.Controls.Add(this.txtPropName);
            this.Controls.Add(this.txtPropID);
            this.Controls.Add(this.btnEditNbh);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShowProp);
            this.Controls.Add(this.btnShowNbh);
            this.Controls.Add(this.btnShowDist);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblAddEdit);
            this.Controls.Add(this.btnEditProp);
            this.Controls.Add(this.btnEditDist);
            this.Controls.Add(this.btnAddProp);
            this.Controls.Add(this.btnAddNbh);
            this.Controls.Add(this.btnAddDist);
            this.Controls.Add(this.lstEditNbh);
            this.Controls.Add(this.lstNbhData);
            this.Controls.Add(this.lstDistData);
            this.Controls.Add(this.lblProps);
            this.Controls.Add(this.lblNbhs);
            this.Controls.Add(this.lblDists);
            this.Controls.Add(this.imgAirbnb);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.lstProperties);
            this.Controls.Add(this.lstNeighbourhoods);
            this.Controls.Add(this.lstDistricts);
            this.Name = "frmMain";
            this.Text = "Airbnb Data Viewer";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAirbnb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDistricts;
        private System.Windows.Forms.ListBox lstNeighbourhoods;
        private System.Windows.Forms.ListBox lstProperties;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.PictureBox imgAirbnb;
        private System.Windows.Forms.Label lblDists;
        private System.Windows.Forms.Label lblNbhs;
        private System.Windows.Forms.Label lblProps;
        private System.Windows.Forms.ListBox lstDistData;
        private System.Windows.Forms.ListBox lstNbhData;
        private System.Windows.Forms.ListBox lstEditNbh;
        private System.Windows.Forms.Button btnAddDist;
        private System.Windows.Forms.Button btnAddNbh;
        private System.Windows.Forms.Button btnAddProp;
        private System.Windows.Forms.Button btnEditDist;
        private System.Windows.Forms.Button btnEditProp;
        private System.Windows.Forms.Label lblAddEdit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnShowDist;
        private System.Windows.Forms.Button btnShowNbh;
        private System.Windows.Forms.Button btnShowProp;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEditNbh;
        private System.Windows.Forms.TextBox txtPropID;
        private System.Windows.Forms.Label lblPropID;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPropName;
        private System.Windows.Forms.TextBox txtHostID;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.TextBox txtNumProp;
        private System.Windows.Forms.TextBox txtLati;
        private System.Windows.Forms.TextBox txtLongi;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label lblPropName;
        private System.Windows.Forms.Label lblHostID;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Label lblNumProp;
        private System.Windows.Forms.Label lblLati;
        private System.Windows.Forms.Label lblLongi;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblMinNights;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblDistName;
        private System.Windows.Forms.Label lblNumNbh;
        private System.Windows.Forms.Label lblNbhName;
        private System.Windows.Forms.Label lblPropNum;
    }
}

