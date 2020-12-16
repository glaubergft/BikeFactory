namespace MyBikesFactoryClientLayer
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
            this.gbAddBike = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDisplayRoadBikes = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.btnDisplayMountainBikes = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Exit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.rightMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.gbCommon = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMountain = new System.Windows.Forms.GroupBox();
            this.lblHeightFromGround = new System.Windows.Forms.Label();
            this.cbSuspension = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.trackHeightFromGround = new System.Windows.Forms.TrackBar();
            this.gbRoad = new System.Windows.Forms.GroupBox();
            this.trackSeatHeight = new System.Windows.Forms.TrackBar();
            this.lblSeatHeight = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.panelUnityViewer = new System.Windows.Forms.Panel();
            this.webView1 = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.trackSpeed = new System.Windows.Forms.TrackBar();
            this.trackRotation = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBikeState = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SerialNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Made = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MadeDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Specific1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Specific2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbAddBike.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.rightMenu.SuspendLayout();
            this.gbCommon.SuspendLayout();
            this.gbMountain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackHeightFromGround)).BeginInit();
            this.gbRoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSeatHeight)).BeginInit();
            this.panelUnityViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRotation)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddBike
            // 
            this.gbAddBike.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddBike.Controls.Add(this.cbType);
            this.gbAddBike.Controls.Add(this.label11);
            this.gbAddBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddBike.Location = new System.Drawing.Point(11, 12);
            this.gbAddBike.Name = "gbAddBike";
            this.gbAddBike.Size = new System.Drawing.Size(703, 63);
            this.gbAddBike.TabIndex = 0;
            this.gbAddBike.TabStop = false;
            this.gbAddBike.Text = "Add Bike";
            // 
            // cbType
            // 
            this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(111, 21);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(579, 24);
            this.cbType.TabIndex = 1;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Type:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 125);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnLoadFile, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(353, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(169, 119);
            this.tableLayoutPanel4.TabIndex = 27;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 53);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadFile.Location = new System.Drawing.Point(3, 62);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(163, 54);
            this.btnLoadFile.TabIndex = 7;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(169, 119);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnDisplayRoadBikes, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnDisplayAll, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDisplayMountainBikes, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(178, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(169, 119);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // btnDisplayRoadBikes
            // 
            this.btnDisplayRoadBikes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisplayRoadBikes.Location = new System.Drawing.Point(3, 81);
            this.btnDisplayRoadBikes.Name = "btnDisplayRoadBikes";
            this.btnDisplayRoadBikes.Size = new System.Drawing.Size(163, 35);
            this.btnDisplayRoadBikes.TabIndex = 5;
            this.btnDisplayRoadBikes.Text = "Display RoadBikes Bikes";
            this.btnDisplayRoadBikes.UseVisualStyleBackColor = true;
            this.btnDisplayRoadBikes.Click += new System.EventHandler(this.btnDisplayRoadBikes_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisplayAll.Location = new System.Drawing.Point(3, 3);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(163, 33);
            this.btnDisplayAll.TabIndex = 3;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // btnDisplayMountainBikes
            // 
            this.btnDisplayMountainBikes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisplayMountainBikes.Location = new System.Drawing.Point(3, 42);
            this.btnDisplayMountainBikes.Name = "btnDisplayMountainBikes";
            this.btnDisplayMountainBikes.Size = new System.Drawing.Size(163, 33);
            this.btnDisplayMountainBikes.TabIndex = 4;
            this.btnDisplayMountainBikes.Text = "Display Mountain Bikes";
            this.btnDisplayMountainBikes.UseVisualStyleBackColor = true;
            this.btnDisplayMountainBikes.Click += new System.EventHandler(this.btnDisplayMountainBikes_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Exit, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnReset, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(528, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(169, 119);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // Exit
            // 
            this.Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit.Location = new System.Drawing.Point(3, 62);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(163, 54);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(3, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(163, 53);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "List of Bikes:";
            // 
            // rightMenu
            // 
            this.rightMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightMenu.BackColor = System.Drawing.SystemColors.Control;
            this.rightMenu.Controls.Add(this.gbCommon);
            this.rightMenu.Controls.Add(this.gbMountain);
            this.rightMenu.Controls.Add(this.gbRoad);
            this.rightMenu.Controls.Add(this.btnAdd);
            this.rightMenu.Controls.Add(this.btnUpdate);
            this.rightMenu.Controls.Add(this.btnDelete);
            this.rightMenu.Location = new System.Drawing.Point(717, 12);
            this.rightMenu.Name = "rightMenu";
            this.rightMenu.Size = new System.Drawing.Size(334, 682);
            this.rightMenu.TabIndex = 29;
            // 
            // gbCommon
            // 
            this.gbCommon.Controls.Add(this.monthCalendar1);
            this.gbCommon.Controls.Add(this.label20);
            this.gbCommon.Controls.Add(this.label19);
            this.gbCommon.Controls.Add(this.btnColor);
            this.gbCommon.Controls.Add(this.txtModel);
            this.gbCommon.Controls.Add(this.label13);
            this.gbCommon.Controls.Add(this.txtMade);
            this.gbCommon.Controls.Add(this.label2);
            this.gbCommon.Controls.Add(this.txtSerialNumber);
            this.gbCommon.Controls.Add(this.label1);
            this.gbCommon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCommon.Location = new System.Drawing.Point(3, 3);
            this.gbCommon.Name = "gbCommon";
            this.gbCommon.Size = new System.Drawing.Size(319, 391);
            this.gbCommon.TabIndex = 14;
            this.gbCommon.TabStop = false;
            this.gbCommon.Text = "General Data:";
            this.gbCommon.Visible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 172);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(42, 118);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 17);
            this.label20.TabIndex = 30;
            this.label20.Text = "Color:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(15, 149);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 23);
            this.label19.TabIndex = 18;
            this.label19.Text = "Made Date:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Blue;
            this.btnColor.Location = new System.Drawing.Point(144, 115);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(89, 23);
            this.btnColor.TabIndex = 18;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(144, 87);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(89, 22);
            this.txtModel.TabIndex = 17;
            this.txtModel.Text = "1";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 23);
            this.label13.TabIndex = 16;
            this.label13.Text = "Model:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMade
            // 
            this.txtMade.Location = new System.Drawing.Point(144, 59);
            this.txtMade.Name = "txtMade";
            this.txtMade.Size = new System.Drawing.Size(89, 22);
            this.txtMade.TabIndex = 16;
            this.txtMade.Text = "1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Made:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(144, 31);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(89, 22);
            this.txtSerialNumber.TabIndex = 15;
            this.txtSerialNumber.Text = "1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbMountain
            // 
            this.gbMountain.Controls.Add(this.lblHeightFromGround);
            this.gbMountain.Controls.Add(this.cbSuspension);
            this.gbMountain.Controls.Add(this.label10);
            this.gbMountain.Controls.Add(this.trackHeightFromGround);
            this.gbMountain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMountain.Location = new System.Drawing.Point(3, 400);
            this.gbMountain.Name = "gbMountain";
            this.gbMountain.Size = new System.Drawing.Size(319, 143);
            this.gbMountain.TabIndex = 20;
            this.gbMountain.TabStop = false;
            this.gbMountain.Tag = "MountainBike";
            this.gbMountain.Text = "Mountain Bike Specific Data:";
            this.gbMountain.Visible = false;
            // 
            // lblHeightFromGround
            // 
            this.lblHeightFromGround.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightFromGround.Location = new System.Drawing.Point(12, 54);
            this.lblHeightFromGround.Name = "lblHeightFromGround";
            this.lblHeightFromGround.Size = new System.Drawing.Size(195, 35);
            this.lblHeightFromGround.TabIndex = 32;
            this.lblHeightFromGround.Text = "Height from Ground (100cm):";
            this.lblHeightFromGround.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbSuspension
            // 
            this.cbSuspension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuspension.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuspension.FormattingEnabled = true;
            this.cbSuspension.Location = new System.Drawing.Point(144, 27);
            this.cbSuspension.Name = "cbSuspension";
            this.cbSuspension.Size = new System.Drawing.Size(130, 24);
            this.cbSuspension.TabIndex = 21;
            this.cbSuspension.SelectedIndexChanged += new System.EventHandler(this.cbSuspension_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Suspension Type:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackHeightFromGround
            // 
            this.trackHeightFromGround.Location = new System.Drawing.Point(12, 83);
            this.trackHeightFromGround.Maximum = 120;
            this.trackHeightFromGround.Minimum = 80;
            this.trackHeightFromGround.Name = "trackHeightFromGround";
            this.trackHeightFromGround.Size = new System.Drawing.Size(262, 56);
            this.trackHeightFromGround.TabIndex = 22;
            this.trackHeightFromGround.TickFrequency = 5;
            this.trackHeightFromGround.Value = 100;
            this.trackHeightFromGround.Scroll += new System.EventHandler(this.trackHeightFromGround_Scroll);
            // 
            // gbRoad
            // 
            this.gbRoad.Controls.Add(this.trackSeatHeight);
            this.gbRoad.Controls.Add(this.lblSeatHeight);
            this.gbRoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRoad.Location = new System.Drawing.Point(3, 549);
            this.gbRoad.Name = "gbRoad";
            this.gbRoad.Size = new System.Drawing.Size(319, 112);
            this.gbRoad.TabIndex = 23;
            this.gbRoad.TabStop = false;
            this.gbRoad.Tag = "RoadBike";
            this.gbRoad.Text = "Road Bike Specific Data:";
            this.gbRoad.Visible = false;
            // 
            // trackSeatHeight
            // 
            this.trackSeatHeight.Location = new System.Drawing.Point(18, 53);
            this.trackSeatHeight.Maximum = 15;
            this.trackSeatHeight.Name = "trackSeatHeight";
            this.trackSeatHeight.Size = new System.Drawing.Size(262, 56);
            this.trackSeatHeight.TabIndex = 24;
            this.trackSeatHeight.Value = 8;
            this.trackSeatHeight.Scroll += new System.EventHandler(this.trackSeatHeight_Scroll);
            // 
            // lblSeatHeight
            // 
            this.lblSeatHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeatHeight.Location = new System.Drawing.Point(15, 33);
            this.lblSeatHeight.Name = "lblSeatHeight";
            this.lblSeatHeight.Size = new System.Drawing.Size(176, 17);
            this.lblSeatHeight.TabIndex = 0;
            this.lblSeatHeight.Text = "Seat Height (8cm):";
            this.lblSeatHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(3, 667);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(319, 45);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "ADD BIKE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(3, 718);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 45);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "UPDATE BIKE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Location = new System.Drawing.Point(165, 718);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 45);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "DELETE BIKE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Location = new System.Drawing.Point(629, 208);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(82, 23);
            this.btnMaximize.TabIndex = 11;
            this.btnMaximize.Text = "Maximize";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // panelUnityViewer
            // 
            this.panelUnityViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUnityViewer.Controls.Add(this.webView1);
            this.panelUnityViewer.Location = new System.Drawing.Point(11, 356);
            this.panelUnityViewer.Name = "panelUnityViewer";
            this.panelUnityViewer.Size = new System.Drawing.Size(700, 265);
            this.panelUnityViewer.TabIndex = 30;
            // 
            // webView1
            // 
            this.webView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webView1.IsPrivateNetworkClientServerCapabilityEnabled = true;
            this.webView1.IsScriptNotifyAllowed = true;
            this.webView1.Location = new System.Drawing.Point(0, 0);
            this.webView1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webView1.Name = "webView1";
            this.webView1.Size = new System.Drawing.Size(700, 265);
            this.webView1.Source = new System.Uri("https://bikewebviewer20190803065011.azurewebsites.net/?v1", System.UriKind.Absolute);
            this.webView1.TabIndex = 3;
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(8, 624);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(175, 35);
            this.lblSpeed.TabIndex = 33;
            this.lblSpeed.Text = "Accelerate / Decelerate Speed (0km/h):";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trackSpeed
            // 
            this.trackSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackSpeed.Location = new System.Drawing.Point(189, 629);
            this.trackSpeed.Maximum = 60;
            this.trackSpeed.Name = "trackSpeed";
            this.trackSpeed.Size = new System.Drawing.Size(522, 56);
            this.trackSpeed.TabIndex = 12;
            this.trackSpeed.Scroll += new System.EventHandler(this.trackSpeed_Scroll);
            // 
            // trackRotation
            // 
            this.trackRotation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackRotation.Location = new System.Drawing.Point(192, 669);
            this.trackRotation.Maximum = 50;
            this.trackRotation.Minimum = -50;
            this.trackRotation.Name = "trackRotation";
            this.trackRotation.Size = new System.Drawing.Size(522, 56);
            this.trackRotation.TabIndex = 13;
            this.trackRotation.TickFrequency = 5;
            this.trackRotation.Scroll += new System.EventHandler(this.trackRotation_Scroll);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 669);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Camera Animation:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(202, 708);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Fast Counterclockwise";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(605, 708);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "Fast Clockwise";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBikeState
            // 
            this.lblBikeState.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBikeState.Location = new System.Drawing.Point(11, 332);
            this.lblBikeState.Name = "lblBikeState";
            this.lblBikeState.Size = new System.Drawing.Size(223, 25);
            this.lblBikeState.TabIndex = 39;
            this.lblBikeState.Text = "Bike state: Stopped";
            this.lblBikeState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 708);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Stop";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.SerialNumber,
            this.Made,
            this.Model,
            this.Color,
            this.MadeDate,
            this.Specific1,
            this.Specific2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 229);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(700, 100);
            this.listView1.TabIndex = 41;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 80;
            // 
            // SerialNumber
            // 
            this.SerialNumber.Text = "Serial Number";
            this.SerialNumber.Width = 90;
            // 
            // Made
            // 
            this.Made.Text = "Made";
            // 
            // Model
            // 
            this.Model.Text = "Model";
            // 
            // Color
            // 
            this.Color.Text = "Color";
            this.Color.Width = 50;
            // 
            // MadeDate
            // 
            this.MadeDate.Text = "Made Date";
            this.MadeDate.Width = 90;
            // 
            // Specific1
            // 
            this.Specific1.Text = "Specific";
            this.Specific1.Width = 150;
            // 
            // Specific2
            // 
            this.Specific2.Text = "Specific";
            this.Specific2.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 777);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackRotation);
            this.Controls.Add(this.trackSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.panelUnityViewer);
            this.Controls.Add(this.rightMenu);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gbAddBike);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.lblBikeState);
            this.MinimumSize = new System.Drawing.Size(992, 741);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbAddBike.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.rightMenu.ResumeLayout(false);
            this.gbCommon.ResumeLayout(false);
            this.gbCommon.PerformLayout();
            this.gbMountain.ResumeLayout(false);
            this.gbMountain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackHeightFromGround)).EndInit();
            this.gbRoad.ResumeLayout(false);
            this.gbRoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSeatHeight)).EndInit();
            this.panelUnityViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackRotation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddBike;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDisplayRoadBikes;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Button btnDisplayMountainBikes;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.FlowLayoutPanel rightMenu;
        private System.Windows.Forms.GroupBox gbCommon;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbMountain;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbRoad;
        private System.Windows.Forms.Label lblSeatHeight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbSuspension;
        private System.Windows.Forms.Label lblHeightFromGround;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Panel panelUnityViewer;
        private Microsoft.Toolkit.Forms.UI.Controls.WebView webView1;
        private System.Windows.Forms.TrackBar trackHeightFromGround;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TrackBar trackSpeed;
        private System.Windows.Forms.TrackBar trackRotation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBikeState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackSeatHeight;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader SerialNumber;
        private System.Windows.Forms.ColumnHeader Made;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader MadeDate;
        private System.Windows.Forms.ColumnHeader Specific1;
        private System.Windows.Forms.ColumnHeader Specific2;
    }
}