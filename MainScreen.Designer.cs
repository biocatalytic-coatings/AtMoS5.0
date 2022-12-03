namespace AtMoS3
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.experimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNOGasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aquisitionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newContinuousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pulsedStandaloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblDataFileLocation = new System.Windows.Forms.Label();
            this.lblSystemTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Climate = new System.Windows.Forms.TabPage();
            this.lblPressure = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblNO2Conc = new System.Windows.Forms.Label();
            this.lblNOConc = new System.Windows.Forms.Label();
            this.lblNO2ConcLabel = new System.Windows.Forms.Label();
            this.lblNOConcLabel = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Volts = new System.Windows.Forms.TabPage();
            this.txtNO2AEOffset = new System.Windows.Forms.TextBox();
            this.txtNO2WEOffset = new System.Windows.Forms.TextBox();
            this.lblNO2AE = new System.Windows.Forms.Label();
            this.lblNO2WE = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNOAE = new System.Windows.Forms.Label();
            this.lblNOWE = new System.Windows.Forms.Label();
            this.txtNOAEOffset = new System.Windows.Forms.TextBox();
            this.txtNOWEOffset = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Sample = new System.Windows.Forms.TabPage();
            this.txtAdafruitUpdateInterval = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtOffsetCalibrationTime = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtClimateUpdatedInterval = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSleepTime = new System.Windows.Forms.TextBox();
            this.txtSamplingTime = new System.Windows.Forms.TextBox();
            this.txtPurgeTime = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.GasAddition = new System.Windows.Forms.TabPage();
            this.txtGasAdditionCycles = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtElectrodeStabilisationTime = new System.Windows.Forms.TextBox();
            this.txtGasAdditionTime = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SHTConstants = new System.Windows.Forms.TabPage();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tmrSystemTime = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrGetClimate = new System.Windows.Forms.Timer(this.components);
            this.tmrWrite2File = new System.Windows.Forms.Timer(this.components);
            this.bwGetSystemTime = new System.ComponentModel.BackgroundWorker();
            this.bwGetGasPulsed = new System.ComponentModel.BackgroundWorker();
            this.bwGetClimate = new System.ComponentModel.BackgroundWorker();
            this.tmrAnalysis = new System.Windows.Forms.Timer(this.components);
            this.bwCalculateElectrodeOffsets = new System.ComponentModel.BackgroundWorker();
            this.bwGetGasContinuous = new System.ComponentModel.BackgroundWorker();
            this.bwPublish2Adafruit = new System.ComponentModel.BackgroundWorker();
            this.bwPublishContinuous = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bwGasCont = new System.ComponentModel.BackgroundWorker();
            this.bwgasPulsed = new System.ComponentModel.BackgroundWorker();
            this.samplingRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stage1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stage2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stage3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Climate.SuspendLayout();
            this.Volts.SuspendLayout();
            this.Sample.SuspendLayout();
            this.GasAddition.SuspendLayout();
            this.SHTConstants.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(524, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.experimentToolStripMenuItem,
            this.aquisitionToolStripMenuItem,
            this.samplingRateToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(902, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // experimentToolStripMenuItem
            // 
            this.experimentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.addNOGasToolStripMenuItem});
            this.experimentToolStripMenuItem.Name = "experimentToolStripMenuItem";
            this.experimentToolStripMenuItem.Size = new System.Drawing.Size(84, 19);
            this.experimentToolStripMenuItem.Text = "Experiment";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // addNOGasToolStripMenuItem
            // 
            this.addNOGasToolStripMenuItem.Enabled = false;
            this.addNOGasToolStripMenuItem.Name = "addNOGasToolStripMenuItem";
            this.addNOGasToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addNOGasToolStripMenuItem.Text = "Add NO Gas";
            this.addNOGasToolStripMenuItem.Visible = false;
            // 
            // aquisitionToolStripMenuItem
            // 
            this.aquisitionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newContinuousToolStripMenuItem,
            this.pulsedStandaloneToolStripMenuItem});
            this.aquisitionToolStripMenuItem.Name = "aquisitionToolStripMenuItem";
            this.aquisitionToolStripMenuItem.Size = new System.Drawing.Size(74, 19);
            this.aquisitionToolStripMenuItem.Text = "Aquisition";
            this.aquisitionToolStripMenuItem.ToolTipText = "This function allows the operator to start or\r\nstop various data aquisition funct" +
    "ions.";
            this.aquisitionToolStripMenuItem.Visible = false;
            // 
            // newContinuousToolStripMenuItem
            // 
            this.newContinuousToolStripMenuItem.Name = "newContinuousToolStripMenuItem";
            this.newContinuousToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.newContinuousToolStripMenuItem.Text = "Continuous";
            this.newContinuousToolStripMenuItem.Click += new System.EventHandler(this.newContinuousToolStripMenuItem_Click);
            // 
            // pulsedStandaloneToolStripMenuItem
            // 
            this.pulsedStandaloneToolStripMenuItem.Name = "pulsedStandaloneToolStripMenuItem";
            this.pulsedStandaloneToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.pulsedStandaloneToolStripMenuItem.Text = "Pulsed";
            this.pulsedStandaloneToolStripMenuItem.Click += new System.EventHandler(this.pulsedStandaloneToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 19);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 19);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lblDataFileLocation);
            this.groupBox1.Controls.Add(this.lblSystemTime);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtExpDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(864, 406);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Experiment Details";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(230, 346);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "lblStatus";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 346);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "System Status";
            // 
            // lblDataFileLocation
            // 
            this.lblDataFileLocation.AutoSize = true;
            this.lblDataFileLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFileLocation.Location = new System.Drawing.Point(30, 148);
            this.lblDataFileLocation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDataFileLocation.Name = "lblDataFileLocation";
            this.lblDataFileLocation.Size = new System.Drawing.Size(97, 13);
            this.lblDataFileLocation.TabIndex = 7;
            this.lblDataFileLocation.Text = "lblDataFileLocation";
            // 
            // lblSystemTime
            // 
            this.lblSystemTime.AutoSize = true;
            this.lblSystemTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemTime.Location = new System.Drawing.Point(224, 52);
            this.lblSystemTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSystemTime.Name = "lblSystemTime";
            this.lblSystemTime.Size = new System.Drawing.Size(74, 13);
            this.lblSystemTime.TabIndex = 5;
            this.lblSystemTime.Text = "lblSystemTime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "System Time : ";
            // 
            // txtExpDesc
            // 
            this.txtExpDesc.Location = new System.Drawing.Point(36, 233);
            this.txtExpDesc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtExpDesc.Multiline = true;
            this.txtExpDesc.Name = "txtExpDesc";
            this.txtExpDesc.Size = new System.Drawing.Size(796, 83);
            this.txtExpDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description of experiment.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datafile Location.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 490);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(864, 419);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";

            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Climate);
            this.tabControl1.Controls.Add(this.Volts);
            this.tabControl1.Controls.Add(this.Sample);
            this.tabControl1.Controls.Add(this.GasAddition);
            this.tabControl1.Controls.Add(this.SHTConstants);
            this.tabControl1.Location = new System.Drawing.Point(14, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 371);
            this.tabControl1.TabIndex = 0;
            // 
            // Climate
            // 
            this.Climate.Controls.Add(this.lblPressure);
            this.Climate.Controls.Add(this.label18);
            this.Climate.Controls.Add(this.lblNO2Conc);
            this.Climate.Controls.Add(this.lblNOConc);
            this.Climate.Controls.Add(this.lblNO2ConcLabel);
            this.Climate.Controls.Add(this.lblNOConcLabel);
            this.Climate.Controls.Add(this.lblHumidity);
            this.Climate.Controls.Add(this.lblTemperature);
            this.Climate.Controls.Add(this.label5);
            this.Climate.Controls.Add(this.label4);
            this.Climate.Location = new System.Drawing.Point(4, 22);
            this.Climate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Climate.Name = "Climate";
            this.Climate.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Climate.Size = new System.Drawing.Size(822, 345);
            this.Climate.TabIndex = 0;
            this.Climate.Text = "Climate data";
            this.Climate.UseVisualStyleBackColor = true;
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressure.Location = new System.Drawing.Point(448, 135);
            this.lblPressure.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(58, 13);
            this.lblPressure.TabIndex = 17;
            this.lblPressure.Text = "lblPressure";
            this.lblPressure.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(40, 135);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(168, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Atmospheric pressure (/kPa)";
            this.label18.Visible = false;
            // 
            // lblNO2Conc
            // 
            this.lblNO2Conc.AutoSize = true;
            this.lblNO2Conc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNO2Conc.Location = new System.Drawing.Point(448, 231);
            this.lblNO2Conc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNO2Conc.Name = "lblNO2Conc";
            this.lblNO2Conc.Size = new System.Drawing.Size(64, 13);
            this.lblNO2Conc.TabIndex = 15;
            this.lblNO2Conc.Text = "lblNO2Conc";
            this.lblNO2Conc.Visible = false;

            // 
            // lblNOConc
            // 
            this.lblNOConc.AutoSize = true;
            this.lblNOConc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOConc.Location = new System.Drawing.Point(448, 183);
            this.lblNOConc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNOConc.Name = "lblNOConc";
            this.lblNOConc.Size = new System.Drawing.Size(58, 13);
            this.lblNOConc.TabIndex = 14;
            this.lblNOConc.Text = "lblNOConc";
            this.lblNOConc.Visible = false;
            // 
            // lblNO2ConcLabel
            // 
            this.lblNO2ConcLabel.AutoSize = true;
            this.lblNO2ConcLabel.Location = new System.Drawing.Point(40, 231);
            this.lblNO2ConcLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNO2ConcLabel.Name = "lblNO2ConcLabel";
            this.lblNO2ConcLabel.Size = new System.Drawing.Size(176, 13);
            this.lblNO2ConcLabel.TabIndex = 13;
            this.lblNO2ConcLabel.Text = "Nitrogen dioxide conc. (ppbV)";
            this.lblNO2ConcLabel.Visible = false;
            // 
            // lblNOConcLabel
            // 
            this.lblNOConcLabel.AutoSize = true;
            this.lblNOConcLabel.Location = new System.Drawing.Point(40, 183);
            this.lblNOConcLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNOConcLabel.Name = "lblNOConcLabel";
            this.lblNOConcLabel.Size = new System.Drawing.Size(148, 13);
            this.lblNOConcLabel.TabIndex = 12;
            this.lblNOConcLabel.Text = "Nitric oxide conc. (ppbV)";
            this.lblNOConcLabel.Visible = false;
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.Location = new System.Drawing.Point(448, 87);
            this.lblHumidity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(57, 13);
            this.lblHumidity.TabIndex = 11;
            this.lblHumidity.Text = "lblHumidity";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(448, 38);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(77, 13);
            this.lblTemperature.TabIndex = 10;
            this.lblTemperature.Text = "lblTemperature";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Humidity (%rH)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Temperature (deg C)";
            // 
            // Volts
            // 
            this.Volts.Controls.Add(this.txtNO2AEOffset);
            this.Volts.Controls.Add(this.txtNO2WEOffset);
            this.Volts.Controls.Add(this.lblNO2AE);
            this.Volts.Controls.Add(this.lblNO2WE);
            this.Volts.Controls.Add(this.label11);
            this.Volts.Controls.Add(this.label10);
            this.Volts.Controls.Add(this.lblNOAE);
            this.Volts.Controls.Add(this.lblNOWE);
            this.Volts.Controls.Add(this.txtNOAEOffset);
            this.Volts.Controls.Add(this.txtNOWEOffset);
            this.Volts.Controls.Add(this.label9);
            this.Volts.Controls.Add(this.label8);
            this.Volts.Controls.Add(this.label7);
            this.Volts.Controls.Add(this.label6);
            this.Volts.Location = new System.Drawing.Point(4, 22);
            this.Volts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Volts.Name = "Volts";
            this.Volts.Size = new System.Drawing.Size(822, 345);
            this.Volts.TabIndex = 3;
            this.Volts.Text = "Electrode readings";
            this.Volts.UseVisualStyleBackColor = true;
            // 
            // txtNO2AEOffset
            // 
            this.txtNO2AEOffset.Location = new System.Drawing.Point(602, 217);
            this.txtNO2AEOffset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNO2AEOffset.Name = "txtNO2AEOffset";
            this.txtNO2AEOffset.Size = new System.Drawing.Size(136, 20);
            this.txtNO2AEOffset.TabIndex = 31;
            this.txtNO2AEOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNO2AEOffset.Visible = false;
            // 
            // txtNO2WEOffset
            // 
            this.txtNO2WEOffset.Location = new System.Drawing.Point(602, 169);
            this.txtNO2WEOffset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNO2WEOffset.Name = "txtNO2WEOffset";
            this.txtNO2WEOffset.Size = new System.Drawing.Size(136, 20);
            this.txtNO2WEOffset.TabIndex = 30;
            this.txtNO2WEOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNO2WEOffset.Visible = false;
            // 
            // lblNO2AE
            // 
            this.lblNO2AE.AutoSize = true;
            this.lblNO2AE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNO2AE.Location = new System.Drawing.Point(390, 227);
            this.lblNO2AE.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNO2AE.Name = "lblNO2AE";
            this.lblNO2AE.Size = new System.Drawing.Size(53, 13);
            this.lblNO2AE.TabIndex = 29;
            this.lblNO2AE.Text = "lblNO2AE";
            // 
            // lblNO2WE
            // 
            this.lblNO2WE.AutoSize = true;
            this.lblNO2WE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNO2WE.Location = new System.Drawing.Point(390, 179);
            this.lblNO2WE.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNO2WE.Name = "lblNO2WE";
            this.lblNO2WE.Size = new System.Drawing.Size(57, 13);
            this.lblNO2WE.TabIndex = 28;
            this.lblNO2WE.Text = "lblNO2WE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 227);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "NO2 AE (/volts)";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 179);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "NO2 WE (/volts)";
            this.label10.Visible = false;
            // 
            // lblNOAE
            // 
            this.lblNOAE.AutoSize = true;
            this.lblNOAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOAE.Location = new System.Drawing.Point(390, 131);
            this.lblNOAE.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNOAE.Name = "lblNOAE";
            this.lblNOAE.Size = new System.Drawing.Size(47, 13);
            this.lblNOAE.TabIndex = 25;
            this.lblNOAE.Text = "lblNOAE";
            // 
            // lblNOWE
            // 
            this.lblNOWE.AutoSize = true;
            this.lblNOWE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOWE.Location = new System.Drawing.Point(390, 83);
            this.lblNOWE.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNOWE.Name = "lblNOWE";
            this.lblNOWE.Size = new System.Drawing.Size(51, 13);
            this.lblNOWE.TabIndex = 24;
            this.lblNOWE.Text = "lblNOWE";
            // 
            // txtNOAEOffset
            // 
            this.txtNOAEOffset.Location = new System.Drawing.Point(602, 121);
            this.txtNOAEOffset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNOAEOffset.Name = "txtNOAEOffset";
            this.txtNOAEOffset.Size = new System.Drawing.Size(136, 20);
            this.txtNOAEOffset.TabIndex = 23;
            this.txtNOAEOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNOAEOffset.Visible = false;
            // 
            // txtNOWEOffset
            // 
            this.txtNOWEOffset.Location = new System.Drawing.Point(602, 73);
            this.txtNOWEOffset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNOWEOffset.Name = "txtNOWEOffset";
            this.txtNOWEOffset.Size = new System.Drawing.Size(136, 20);
            this.txtNOWEOffset.TabIndex = 22;
            this.txtNOWEOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNOWEOffset.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(632, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Offset";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(358, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Current Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 131);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "NO AE (/volts)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "NO WE (/volts)";
            // 
            // Sample
            // 
            this.Sample.Controls.Add(this.txtAdafruitUpdateInterval);
            this.Sample.Controls.Add(this.label22);
            this.Sample.Controls.Add(this.txtOffsetCalibrationTime);
            this.Sample.Controls.Add(this.label17);
            this.Sample.Controls.Add(this.txtClimateUpdatedInterval);
            this.Sample.Controls.Add(this.label16);
            this.Sample.Controls.Add(this.txtSleepTime);
            this.Sample.Controls.Add(this.txtSamplingTime);
            this.Sample.Controls.Add(this.txtPurgeTime);
            this.Sample.Controls.Add(this.label14);
            this.Sample.Controls.Add(this.label13);
            this.Sample.Controls.Add(this.label12);
            this.Sample.Location = new System.Drawing.Point(4, 22);
            this.Sample.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Sample.Name = "Sample";
            this.Sample.Size = new System.Drawing.Size(822, 345);
            this.Sample.TabIndex = 2;
            this.Sample.Text = "Sampling rates";
            this.Sample.UseVisualStyleBackColor = true;
            // 
            // txtAdafruitUpdateInterval
            // 
            this.txtAdafruitUpdateInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdafruitUpdateInterval.Location = new System.Drawing.Point(560, 260);
            this.txtAdafruitUpdateInterval.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtAdafruitUpdateInterval.Name = "txtAdafruitUpdateInterval";
            this.txtAdafruitUpdateInterval.Size = new System.Drawing.Size(102, 20);
            this.txtAdafruitUpdateInterval.TabIndex = 11;
            this.txtAdafruitUpdateInterval.Text = "15";
            this.txtAdafruitUpdateInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdafruitUpdateInterval.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(36, 260);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(199, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "Adafruit update interval (seconds)";
            this.label22.Visible = false;
            // 
            // txtOffsetCalibrationTime
            // 
            this.txtOffsetCalibrationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOffsetCalibrationTime.Location = new System.Drawing.Point(560, 206);
            this.txtOffsetCalibrationTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtOffsetCalibrationTime.Name = "txtOffsetCalibrationTime";
            this.txtOffsetCalibrationTime.Size = new System.Drawing.Size(102, 20);
            this.txtOffsetCalibrationTime.TabIndex = 9;
            this.txtOffsetCalibrationTime.Text = "60";
            this.txtOffsetCalibrationTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOffsetCalibrationTime.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 212);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(205, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Offset calibration interval (minutes)";
            this.label17.Visible = false;
            // 
            // txtClimateUpdatedInterval
            // 
            this.txtClimateUpdatedInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClimateUpdatedInterval.Location = new System.Drawing.Point(560, 158);
            this.txtClimateUpdatedInterval.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtClimateUpdatedInterval.Name = "txtClimateUpdatedInterval";
            this.txtClimateUpdatedInterval.Size = new System.Drawing.Size(102, 20);
            this.txtClimateUpdatedInterval.TabIndex = 7;
            this.txtClimateUpdatedInterval.Text = "1";
            this.txtClimateUpdatedInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(36, 163);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(196, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Climate update interval (seconds)";
            // 
            // txtSleepTime
            // 
            this.txtSleepTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSleepTime.Location = new System.Drawing.Point(560, 110);
            this.txtSleepTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSleepTime.Name = "txtSleepTime";
            this.txtSleepTime.Size = new System.Drawing.Size(102, 20);
            this.txtSleepTime.TabIndex = 5;
            this.txtSleepTime.Text = "60";
            this.txtSleepTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // 
            // txtSamplingTime
            // 
            this.txtSamplingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSamplingTime.Location = new System.Drawing.Point(560, 62);
            this.txtSamplingTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSamplingTime.Name = "txtSamplingTime";
            this.txtSamplingTime.Size = new System.Drawing.Size(102, 20);
            this.txtSamplingTime.TabIndex = 4;
            this.txtSamplingTime.Text = "25";
            this.txtSamplingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // 
            // txtPurgeTime
            // 
            this.txtPurgeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurgeTime.Location = new System.Drawing.Point(560, 13);
            this.txtPurgeTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPurgeTime.Name = "txtPurgeTime";
            this.txtPurgeTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPurgeTime.Size = new System.Drawing.Size(102, 20);
            this.txtPurgeTime.TabIndex = 3;
            this.txtPurgeTime.Text = "25";
            this.txtPurgeTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 115);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Sensor sleep time (seconds)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 67);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Sensor sampling time (seconds)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Sensor purge time (seconds)";
            // 
            // GasAddition
            // 
            this.GasAddition.Controls.Add(this.txtGasAdditionCycles);
            this.GasAddition.Controls.Add(this.label21);
            this.GasAddition.Controls.Add(this.txtElectrodeStabilisationTime);
            this.GasAddition.Controls.Add(this.txtGasAdditionTime);
            this.GasAddition.Controls.Add(this.label20);
            this.GasAddition.Controls.Add(this.label19);
            this.GasAddition.Location = new System.Drawing.Point(4, 22);
            this.GasAddition.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GasAddition.Name = "GasAddition";
            this.GasAddition.Size = new System.Drawing.Size(822, 345);
            this.GasAddition.TabIndex = 4;
            this.GasAddition.Text = "NO Gas Addn.";
            this.GasAddition.UseVisualStyleBackColor = true;
            // 
            // txtGasAdditionCycles
            // 
            this.txtGasAdditionCycles.Location = new System.Drawing.Point(610, 150);
            this.txtGasAdditionCycles.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtGasAdditionCycles.Name = "txtGasAdditionCycles";
            this.txtGasAdditionCycles.Size = new System.Drawing.Size(114, 20);
            this.txtGasAdditionCycles.TabIndex = 5;
            this.txtGasAdditionCycles.Text = "5";
            this.txtGasAdditionCycles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(40, 150);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 13);
            this.label21.TabIndex = 4;
            this.label21.Text = "Cycles";
            // 
            // txtElectrodeStabilisationTime
            // 
            this.txtElectrodeStabilisationTime.Location = new System.Drawing.Point(610, 96);
            this.txtElectrodeStabilisationTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtElectrodeStabilisationTime.Name = "txtElectrodeStabilisationTime";
            this.txtElectrodeStabilisationTime.Size = new System.Drawing.Size(114, 20);
            this.txtElectrodeStabilisationTime.TabIndex = 3;
            this.txtElectrodeStabilisationTime.Text = "180";
            this.txtElectrodeStabilisationTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGasAdditionTime
            // 
            this.txtGasAdditionTime.Location = new System.Drawing.Point(610, 44);
            this.txtGasAdditionTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtGasAdditionTime.Name = "txtGasAdditionTime";
            this.txtGasAdditionTime.Size = new System.Drawing.Size(114, 20);
            this.txtGasAdditionTime.TabIndex = 2;
            this.txtGasAdditionTime.Text = "22.5";
            this.txtGasAdditionTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(40, 98);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(218, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Electrode stabilisation time (seconds)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(40, 44);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(164, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Gas addition time (seconds)";
            // 
            // SHTConstants
            // 
            this.SHTConstants.Controls.Add(this.label27);
            this.SHTConstants.Controls.Add(this.label26);
            this.SHTConstants.Controls.Add(this.label25);
            this.SHTConstants.Controls.Add(this.label24);
            this.SHTConstants.Controls.Add(this.label23);
            this.SHTConstants.Location = new System.Drawing.Point(4, 22);
            this.SHTConstants.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SHTConstants.Name = "SHTConstants";
            this.SHTConstants.Size = new System.Drawing.Size(822, 345);
            this.SHTConstants.TabIndex = 5;
            this.SHTConstants.Text = "BME280 Constants";
            this.SHTConstants.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(606, 50);
            this.label27.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(58, 13);
            this.label27.TabIndex = 4;
            this.label27.Text = "Intercept";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(412, 52);
            this.label26.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 13);
            this.label26.TabIndex = 3;
            this.label26.Text = "Gradient";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(48, 238);
            this.label25.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(129, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "Atmospheric Pressure";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(48, 177);
            this.label24.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 13);
            this.label24.TabIndex = 1;
            this.label24.Text = "Humidity";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(48, 113);
            this.label23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "Temperature";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 974);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(902, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(872, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "AtMoS - Licensed to Southern Cross University";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // tmrWrite2File
            // 
            this.tmrWrite2File.Interval = 1000;
            // 
            // bwGetSystemTime
            // 
            this.bwGetSystemTime.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetSystemTime_DoWork);
            // 
            // bwGetClimate
            // 
            this.bwGetClimate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGetClimate_DoWork);
            // 
            // bwCalculateElectrodeOffsets
            // 
            this.bwCalculateElectrodeOffsets.WorkerSupportsCancellation = true;
            // 
            // bwPublishContinuous
            // 
            this.bwPublishContinuous.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwPublishContinuous_DoWork);
            // 
            // bwGasCont
            // 
            this.bwGasCont.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwGasCont_DoWork);
            // 
            // bwgasPulsed
            // 
            this.bwgasPulsed.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwgasPulsed_DoWork);
            // 
            // samplingRateToolStripMenuItem
            // 
            this.samplingRateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stage1ToolStripMenuItem,
            this.stage2ToolStripMenuItem,
            this.stage3ToolStripMenuItem});
            this.samplingRateToolStripMenuItem.Name = "samplingRateToolStripMenuItem";
            this.samplingRateToolStripMenuItem.Size = new System.Drawing.Size(96, 19);
            this.samplingRateToolStripMenuItem.Text = "Sampling rate";
            this.samplingRateToolStripMenuItem.Visible = false;
            // 
            // stage1ToolStripMenuItem
            // 
            this.stage1ToolStripMenuItem.Name = "stage1ToolStripMenuItem";
            this.stage1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stage1ToolStripMenuItem.Text = "Stage 1";
            this.stage1ToolStripMenuItem.Click += new System.EventHandler(this.stage1ToolStripMenuItem_Click);
            // 
            // stage2ToolStripMenuItem
            // 
            this.stage2ToolStripMenuItem.Name = "stage2ToolStripMenuItem";
            this.stage2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stage2ToolStripMenuItem.Text = "Stage 2";
            this.stage2ToolStripMenuItem.Click += new System.EventHandler(this.stage2ToolStripMenuItem_Click);
            // 
            // stage3ToolStripMenuItem
            // 
            this.stage3ToolStripMenuItem.Name = "stage3ToolStripMenuItem";
            this.stage3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stage3ToolStripMenuItem.Text = "Stage 3";
            this.stage3ToolStripMenuItem.Click += new System.EventHandler(this.stage3ToolStripMenuItem_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 996);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtMoS 5.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Climate.ResumeLayout(false);
            this.Climate.PerformLayout();
            this.Volts.ResumeLayout(false);
            this.Volts.PerformLayout();
            this.Sample.ResumeLayout(false);
            this.Sample.PerformLayout();
            this.GasAddition.ResumeLayout(false);
            this.GasAddition.PerformLayout();
            this.SHTConstants.ResumeLayout(false);
            this.SHTConstants.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem experimentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aquisitionToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtExpDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Climate;
        private System.Windows.Forms.Label lblSystemTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage Sample;
        private System.Windows.Forms.Timer tmrSystemTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblDataFileLocation;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox txtSleepTime;
        private System.Windows.Forms.TextBox txtSamplingTime;
        private System.Windows.Forms.TextBox txtPurgeTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TabPage Volts;
        private System.Windows.Forms.Label lblNO2ConcLabel;
        private System.Windows.Forms.Label lblNOConcLabel;
        private System.Windows.Forms.TextBox txtNO2AEOffset;
        private System.Windows.Forms.TextBox txtNO2WEOffset;
        private System.Windows.Forms.Label lblNO2AE;
        private System.Windows.Forms.Label lblNO2WE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblNOAE;
        private System.Windows.Forms.Label lblNOWE;
        private System.Windows.Forms.TextBox txtNOAEOffset;
        private System.Windows.Forms.TextBox txtNOWEOffset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNOConc;
        private System.Windows.Forms.Label lblNO2Conc;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Timer tmrGetClimate;
        private System.Windows.Forms.Timer tmrWrite2File;
        private System.ComponentModel.BackgroundWorker bwGetSystemTime;
        private System.ComponentModel.BackgroundWorker bwGetGasPulsed;
        private System.ComponentModel.BackgroundWorker bwGetClimate;
        private System.Windows.Forms.Timer tmrAnalysis;
        private System.Windows.Forms.TextBox txtClimateUpdatedInterval;
        private System.Windows.Forms.Label label16;
        private System.ComponentModel.BackgroundWorker bwCalculateElectrodeOffsets;
        private System.ComponentModel.BackgroundWorker bwGetGasContinuous;
        private System.Windows.Forms.TextBox txtOffsetCalibrationTime;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage GasAddition;
        private System.Windows.Forms.TextBox txtElectrodeStabilisationTime;
        private System.Windows.Forms.TextBox txtGasAdditionTime;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ToolStripMenuItem addNOGasToolStripMenuItem;
        private System.Windows.Forms.TextBox txtGasAdditionCycles;
        private System.Windows.Forms.Label label21;
        private System.ComponentModel.BackgroundWorker bwPublish2Adafruit;
        private System.Windows.Forms.TextBox txtAdafruitUpdateInterval;
        private System.Windows.Forms.Label label22;
        private System.ComponentModel.BackgroundWorker bwPublishContinuous;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem newContinuousToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bwGasCont;
        private System.ComponentModel.BackgroundWorker bwgasPulsed;
        private System.Windows.Forms.ToolStripMenuItem pulsedStandaloneToolStripMenuItem;
        private System.Windows.Forms.TabPage SHTConstants;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ToolStripMenuItem samplingRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stage1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stage2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stage3ToolStripMenuItem;
    }
}

