
namespace r09546042_TerryYang_assignment_02
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.TopToolStrip = new System.Windows.Forms.ToolStrip();
            this.TOS_BTN_open = new System.Windows.Forms.ToolStripButton();
            this.TOS_BTN_open_excel = new System.Windows.Forms.ToolStripButton();
            this.TOS_BTN_analyze = new System.Windows.Forms.ToolStripButton();
            this.DownMenuStrip = new System.Windows.Forms.MenuStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TC1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.Job_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completion_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTN_save = new System.Windows.Forms.Button();
            this.BTN_Creat = new System.Windows.Forms.Button();
            this.TB_NOJ = new System.Windows.Forms.TextBox();
            this.TB_ASTD = new System.Windows.Forms.TextBox();
            this.TB_AST = new System.Windows.Forms.TextBox();
            this.TB_AITD = new System.Windows.Forms.TextBox();
            this.TB_AIT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TC2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.MainChart_bar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.LB_WatTime = new System.Windows.Forms.Label();
            this.LB_AvgDlyTime = new System.Windows.Forms.Label();
            this.LB_AvgSerTime = new System.Windows.Forms.Label();
            this.LB_AvgIntTime = new System.Windows.Forms.Label();
            this.LB_AJS = new System.Windows.Forms.Label();
            this.LB_AJQ = new System.Windows.Forms.Label();
            this.LB_AJN = new System.Windows.Forms.Label();
            this.CheckBox_ServerStatus = new System.Windows.Forms.CheckBox();
            this.CheckBox_JobQueue = new System.Windows.Forms.CheckBox();
            this.CheckBox_JocCount = new System.Windows.Forms.CheckBox();
            this.MainChart_stepline = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TextBox_Server_Constant = new System.Windows.Forms.TextBox();
            this.BTN_ShowPlot = new System.Windows.Forms.Button();
            this.BTN_ResetPlot = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.BTN_simulate = new System.Windows.Forms.Button();
            this.TB_TestNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_factor2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_factor1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Chart_simulation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TopToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TC1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.TC2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart_stepline)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_simulation)).BeginInit();
            this.SuspendLayout();
            // 
            // TopMenuStrip
            // 
            this.TopMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TopMenuStrip.Name = "TopMenuStrip";
            this.TopMenuStrip.Size = new System.Drawing.Size(1161, 24);
            this.TopMenuStrip.TabIndex = 0;
            this.TopMenuStrip.Text = "menuStrip1";
            // 
            // TopToolStrip
            // 
            this.TopToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.TopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TOS_BTN_open,
            this.TOS_BTN_open_excel,
            this.TOS_BTN_analyze});
            this.TopToolStrip.Location = new System.Drawing.Point(0, 24);
            this.TopToolStrip.Name = "TopToolStrip";
            this.TopToolStrip.Size = new System.Drawing.Size(1161, 39);
            this.TopToolStrip.TabIndex = 1;
            this.TopToolStrip.Text = "toolStrip1";
            // 
            // TOS_BTN_open
            // 
            this.TOS_BTN_open.AccessibleDescription = "*DAT";
            this.TOS_BTN_open.AccessibleName = "*DAT";
            this.TOS_BTN_open.Image = ((System.Drawing.Image)(resources.GetObject("TOS_BTN_open.Image")));
            this.TOS_BTN_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TOS_BTN_open.Name = "TOS_BTN_open";
            this.TOS_BTN_open.Size = new System.Drawing.Size(84, 36);
            this.TOS_BTN_open.Tag = "*DAT";
            this.TOS_BTN_open.Text = "Open...";
            this.TOS_BTN_open.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // TOS_BTN_open_excel
            // 
            this.TOS_BTN_open_excel.Image = ((System.Drawing.Image)(resources.GetObject("TOS_BTN_open_excel.Image")));
            this.TOS_BTN_open_excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TOS_BTN_open_excel.Name = "TOS_BTN_open_excel";
            this.TOS_BTN_open_excel.Size = new System.Drawing.Size(143, 36);
            this.TOS_BTN_open_excel.Text = "Open_From_Excel";
            this.TOS_BTN_open_excel.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // TOS_BTN_analyze
            // 
            this.TOS_BTN_analyze.Enabled = false;
            this.TOS_BTN_analyze.Image = ((System.Drawing.Image)(resources.GetObject("TOS_BTN_analyze.Image")));
            this.TOS_BTN_analyze.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TOS_BTN_analyze.Name = "TOS_BTN_analyze";
            this.TOS_BTN_analyze.Size = new System.Drawing.Size(87, 36);
            this.TOS_BTN_analyze.Text = "Analyze";
            this.TOS_BTN_analyze.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // DownMenuStrip
            // 
            this.DownMenuStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownMenuStrip.Location = new System.Drawing.Point(0, 541);
            this.DownMenuStrip.Name = "DownMenuStrip";
            this.DownMenuStrip.Size = new System.Drawing.Size(1161, 24);
            this.DownMenuStrip.TabIndex = 2;
            this.DownMenuStrip.Text = "menuStrip2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Location = new System.Drawing.Point(0, 66);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TC1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TC2);
            this.splitContainer1.Size = new System.Drawing.Size(1161, 475);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 3;
            // 
            // TC1
            // 
            this.TC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TC1.Controls.Add(this.tabPage1);
            this.TC1.Controls.Add(this.tabPage2);
            this.TC1.Location = new System.Drawing.Point(12, 3);
            this.TC1.Name = "TC1";
            this.TC1.SelectedIndex = 0;
            this.TC1.Size = new System.Drawing.Size(371, 469);
            this.TC1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGV1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(363, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Problem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGV1
            // 
            this.DGV1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Job_ID,
            this.Arrival_time,
            this.Service_time,
            this.Delay_time,
            this.Completion_time});
            this.DGV1.Location = new System.Drawing.Point(6, 77);
            this.DGV1.Name = "DGV1";
            this.DGV1.RowTemplate.Height = 24;
            this.DGV1.Size = new System.Drawing.Size(351, 360);
            this.DGV1.TabIndex = 2;
            // 
            // Job_ID
            // 
            this.Job_ID.HeaderText = "Job";
            this.Job_ID.Name = "Job_ID";
            this.Job_ID.Width = 80;
            // 
            // Arrival_time
            // 
            this.Arrival_time.HeaderText = "Arrival Time";
            this.Arrival_time.Name = "Arrival_time";
            // 
            // Service_time
            // 
            this.Service_time.HeaderText = "Service Time";
            this.Service_time.Name = "Service_time";
            // 
            // Delay_time
            // 
            this.Delay_time.HeaderText = "Delay Time";
            this.Delay_time.Name = "Delay_time";
            // 
            // Completion_time
            // 
            this.Completion_time.HeaderText = "Completion Time";
            this.Completion_time.Name = "Completion_time";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arrive and service time";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BTN_save);
            this.tabPage2.Controls.Add(this.BTN_Creat);
            this.tabPage2.Controls.Add(this.TB_NOJ);
            this.tabPage2.Controls.Add(this.TB_ASTD);
            this.tabPage2.Controls.Add(this.TB_AST);
            this.tabPage2.Controls.Add(this.TB_AITD);
            this.tabPage2.Controls.Add(this.TB_AIT);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(363, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create a new problem";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTN_save
            // 
            this.BTN_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_save.Enabled = false;
            this.BTN_save.Location = new System.Drawing.Point(17, 250);
            this.BTN_save.Name = "BTN_save";
            this.BTN_save.Size = new System.Drawing.Size(341, 40);
            this.BTN_save.TabIndex = 11;
            this.BTN_save.Text = "Save Data";
            this.BTN_save.UseVisualStyleBackColor = true;
            this.BTN_save.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTN_Creat
            // 
            this.BTN_Creat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Creat.Location = new System.Drawing.Point(17, 190);
            this.BTN_Creat.Name = "BTN_Creat";
            this.BTN_Creat.Size = new System.Drawing.Size(341, 40);
            this.BTN_Creat.TabIndex = 10;
            this.BTN_Creat.Text = "Creat Data";
            this.BTN_Creat.UseVisualStyleBackColor = true;
            this.BTN_Creat.Click += new System.EventHandler(this.button3_Click);
            // 
            // TB_NOJ
            // 
            this.TB_NOJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_NOJ.Location = new System.Drawing.Point(302, 150);
            this.TB_NOJ.Name = "TB_NOJ";
            this.TB_NOJ.Size = new System.Drawing.Size(56, 22);
            this.TB_NOJ.TabIndex = 9;
            this.TB_NOJ.Text = "5";
            // 
            // TB_ASTD
            // 
            this.TB_ASTD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_ASTD.Location = new System.Drawing.Point(302, 120);
            this.TB_ASTD.Name = "TB_ASTD";
            this.TB_ASTD.Size = new System.Drawing.Size(56, 22);
            this.TB_ASTD.TabIndex = 8;
            this.TB_ASTD.Text = "1";
            // 
            // TB_AST
            // 
            this.TB_AST.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_AST.Location = new System.Drawing.Point(302, 90);
            this.TB_AST.Name = "TB_AST";
            this.TB_AST.Size = new System.Drawing.Size(56, 22);
            this.TB_AST.TabIndex = 7;
            this.TB_AST.Text = "5";
            // 
            // TB_AITD
            // 
            this.TB_AITD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_AITD.Location = new System.Drawing.Point(302, 60);
            this.TB_AITD.Name = "TB_AITD";
            this.TB_AITD.Size = new System.Drawing.Size(56, 22);
            this.TB_AITD.TabIndex = 6;
            this.TB_AITD.Text = "1";
            // 
            // TB_AIT
            // 
            this.TB_AIT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_AIT.Location = new System.Drawing.Point(302, 30);
            this.TB_AIT.Name = "TB_AIT";
            this.TB_AIT.Size = new System.Drawing.Size(56, 22);
            this.TB_AIT.TabIndex = 5;
            this.TB_AIT.Text = "5";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "Number Of Jobs";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Deviation";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Average Service Time";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Deviation";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Average Interarrival Time";
            // 
            // TC2
            // 
            this.TC2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TC2.Controls.Add(this.tabPage3);
            this.TC2.Controls.Add(this.tabPage4);
            this.TC2.Location = new System.Drawing.Point(3, 3);
            this.TC2.Name = "TC2";
            this.TC2.SelectedIndex = 0;
            this.TC2.Size = new System.Drawing.Size(765, 469);
            this.TC2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.MainChart_bar);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.LB_WatTime);
            this.tabPage3.Controls.Add(this.LB_AvgDlyTime);
            this.tabPage3.Controls.Add(this.LB_AvgSerTime);
            this.tabPage3.Controls.Add(this.LB_AvgIntTime);
            this.tabPage3.Controls.Add(this.LB_AJS);
            this.tabPage3.Controls.Add(this.LB_AJQ);
            this.tabPage3.Controls.Add(this.LB_AJN);
            this.tabPage3.Controls.Add(this.CheckBox_ServerStatus);
            this.tabPage3.Controls.Add(this.CheckBox_JobQueue);
            this.tabPage3.Controls.Add(this.CheckBox_JocCount);
            this.tabPage3.Controls.Add(this.MainChart_stepline);
            this.tabPage3.Controls.Add(this.TextBox_Server_Constant);
            this.tabPage3.Controls.Add(this.BTN_ShowPlot);
            this.tabPage3.Controls.Add(this.BTN_ResetPlot);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(757, 443);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Simulate Job Processing";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainChart_bar
            // 
            this.MainChart_bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.Title = "Server \\n Status";
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.CursorY.Interval = 0.0001D;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.MainChart_bar.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.MainChart_bar.Legends.Add(legend1);
            this.MainChart_bar.Location = new System.Drawing.Point(42, 277);
            this.MainChart_bar.Name = "MainChart_bar";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.MainChart_bar.Series.Add(series1);
            this.MainChart_bar.Size = new System.Drawing.Size(719, 160);
            this.MainChart_bar.TabIndex = 16;
            this.MainChart_bar.Text = "chart1";
            this.MainChart_bar.AxisViewChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ViewEventArgs>(this.Chart_bar_AxisViewChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(434, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Service Time Factor";
            // 
            // LB_WatTime
            // 
            this.LB_WatTime.AutoSize = true;
            this.LB_WatTime.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_WatTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.LB_WatTime.Location = new System.Drawing.Point(15, 140);
            this.LB_WatTime.Name = "LB_WatTime";
            this.LB_WatTime.Size = new System.Drawing.Size(134, 16);
            this.LB_WatTime.TabIndex = 14;
            this.LB_WatTime.Text = "Average Wait Time:";
            this.LB_WatTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LB_AvgDlyTime
            // 
            this.LB_AvgDlyTime.AutoSize = true;
            this.LB_AvgDlyTime.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_AvgDlyTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.LB_AvgDlyTime.Location = new System.Drawing.Point(15, 120);
            this.LB_AvgDlyTime.Name = "LB_AvgDlyTime";
            this.LB_AvgDlyTime.Size = new System.Drawing.Size(142, 16);
            this.LB_AvgDlyTime.TabIndex = 13;
            this.LB_AvgDlyTime.Text = "Average Delay Time:";
            this.LB_AvgDlyTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LB_AvgSerTime
            // 
            this.LB_AvgSerTime.AutoSize = true;
            this.LB_AvgSerTime.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_AvgSerTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.LB_AvgSerTime.Location = new System.Drawing.Point(15, 100);
            this.LB_AvgSerTime.Name = "LB_AvgSerTime";
            this.LB_AvgSerTime.Size = new System.Drawing.Size(151, 16);
            this.LB_AvgSerTime.TabIndex = 12;
            this.LB_AvgSerTime.Text = "Average Service Time:";
            this.LB_AvgSerTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LB_AvgIntTime
            // 
            this.LB_AvgIntTime.AutoSize = true;
            this.LB_AvgIntTime.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_AvgIntTime.ForeColor = System.Drawing.Color.DarkBlue;
            this.LB_AvgIntTime.Location = new System.Drawing.Point(15, 80);
            this.LB_AvgIntTime.Name = "LB_AvgIntTime";
            this.LB_AvgIntTime.Size = new System.Drawing.Size(174, 16);
            this.LB_AvgIntTime.TabIndex = 11;
            this.LB_AvgIntTime.Text = "Average Interarrival Time:";
            this.LB_AvgIntTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LB_AJS
            // 
            this.LB_AJS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_AJS.AutoEllipsis = true;
            this.LB_AJS.AutoSize = true;
            this.LB_AJS.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_AJS.ForeColor = System.Drawing.Color.SeaGreen;
            this.LB_AJS.Location = new System.Drawing.Point(513, 120);
            this.LB_AJS.Name = "LB_AJS";
            this.LB_AJS.Size = new System.Drawing.Size(56, 16);
            this.LB_AJS.TabIndex = 10;
            this.LB_AJS.Text = "Server: ";
            this.LB_AJS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_AJQ
            // 
            this.LB_AJQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_AJQ.AutoEllipsis = true;
            this.LB_AJQ.AutoSize = true;
            this.LB_AJQ.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_AJQ.ForeColor = System.Drawing.Color.SeaGreen;
            this.LB_AJQ.Location = new System.Drawing.Point(513, 100);
            this.LB_AJQ.Name = "LB_AJQ";
            this.LB_AJQ.Size = new System.Drawing.Size(204, 16);
            this.LB_AJQ.TabIndex = 9;
            this.LB_AJQ.Text = "Time_Averaged Job in Queue: ";
            this.LB_AJQ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_AJN
            // 
            this.LB_AJN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_AJN.AutoEllipsis = true;
            this.LB_AJN.AutoSize = true;
            this.LB_AJN.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_AJN.ForeColor = System.Drawing.Color.SeaGreen;
            this.LB_AJN.Location = new System.Drawing.Point(514, 80);
            this.LB_AJN.Name = "LB_AJN";
            this.LB_AJN.Size = new System.Drawing.Size(203, 16);
            this.LB_AJN.TabIndex = 8;
            this.LB_AJN.Text = "Time_Averaged Job in Nodes: ";
            this.LB_AJN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CheckBox_ServerStatus
            // 
            this.CheckBox_ServerStatus.AutoSize = true;
            this.CheckBox_ServerStatus.Checked = true;
            this.CheckBox_ServerStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_ServerStatus.Enabled = false;
            this.CheckBox_ServerStatus.Location = new System.Drawing.Point(215, 59);
            this.CheckBox_ServerStatus.Name = "CheckBox_ServerStatus";
            this.CheckBox_ServerStatus.Size = new System.Drawing.Size(85, 16);
            this.CheckBox_ServerStatus.TabIndex = 7;
            this.CheckBox_ServerStatus.Text = "Job in Server";
            this.CheckBox_ServerStatus.UseVisualStyleBackColor = true;
            this.CheckBox_ServerStatus.CheckedChanged += new System.EventHandler(this.CheckBox_ServerStatus_CheckedChanged);
            // 
            // CheckBox_JobQueue
            // 
            this.CheckBox_JobQueue.AutoSize = true;
            this.CheckBox_JobQueue.Checked = true;
            this.CheckBox_JobQueue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_JobQueue.Enabled = false;
            this.CheckBox_JobQueue.Location = new System.Drawing.Point(115, 59);
            this.CheckBox_JobQueue.Name = "CheckBox_JobQueue";
            this.CheckBox_JobQueue.Size = new System.Drawing.Size(85, 16);
            this.CheckBox_JobQueue.TabIndex = 6;
            this.CheckBox_JobQueue.Text = "Job in Queue";
            this.CheckBox_JobQueue.UseVisualStyleBackColor = true;
            this.CheckBox_JobQueue.CheckedChanged += new System.EventHandler(this.CheckBox_JobQueue_CheckedChanged);
            // 
            // CheckBox_JocCount
            // 
            this.CheckBox_JocCount.AutoSize = true;
            this.CheckBox_JocCount.Checked = true;
            this.CheckBox_JocCount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_JocCount.Enabled = false;
            this.CheckBox_JocCount.Location = new System.Drawing.Point(15, 59);
            this.CheckBox_JocCount.Name = "CheckBox_JocCount";
            this.CheckBox_JocCount.Size = new System.Drawing.Size(80, 16);
            this.CheckBox_JocCount.TabIndex = 5;
            this.CheckBox_JocCount.Text = "Job in Node";
            this.CheckBox_JocCount.UseVisualStyleBackColor = true;
            this.CheckBox_JocCount.CheckedChanged += new System.EventHandler(this.CheckBox_JocCount_CheckedChanged);
            // 
            // MainChart_stepline
            // 
            this.MainChart_stepline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Interval = 0D;
            chartArea2.AxisX.LineColor = System.Drawing.SystemColors.GrayText;
            chartArea2.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisX.LineWidth = 0;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisX.Title = "Time";
            chartArea2.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.Title = "Job Count";
            chartArea2.BorderColor = System.Drawing.Color.Silver;
            chartArea2.CursorX.Interval = 0.0001D;
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.MainChart_stepline.ChartAreas.Add(chartArea2);
            this.MainChart_stepline.Location = new System.Drawing.Point(15, 159);
            this.MainChart_stepline.Name = "MainChart_stepline";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.MainChart_stepline.Series.Add(series2);
            this.MainChart_stepline.Size = new System.Drawing.Size(736, 112);
            this.MainChart_stepline.TabIndex = 4;
            this.MainChart_stepline.Text = "chart1";
            this.MainChart_stepline.AxisViewChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ViewEventArgs>(this.MainChart_AxisViewChanged);
            // 
            // TextBox_Server_Constant
            // 
            this.TextBox_Server_Constant.AllowDrop = true;
            this.TextBox_Server_Constant.Location = new System.Drawing.Point(573, 24);
            this.TextBox_Server_Constant.Name = "TextBox_Server_Constant";
            this.TextBox_Server_Constant.Size = new System.Drawing.Size(60, 22);
            this.TextBox_Server_Constant.TabIndex = 3;
            this.TextBox_Server_Constant.Text = "1";
            this.TextBox_Server_Constant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_ShowPlot
            // 
            this.BTN_ShowPlot.Enabled = false;
            this.BTN_ShowPlot.Location = new System.Drawing.Point(15, 14);
            this.BTN_ShowPlot.Name = "BTN_ShowPlot";
            this.BTN_ShowPlot.Size = new System.Drawing.Size(190, 39);
            this.BTN_ShowPlot.TabIndex = 0;
            this.BTN_ShowPlot.Text = "Show_Plot";
            this.BTN_ShowPlot.UseVisualStyleBackColor = true;
            this.BTN_ShowPlot.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_ResetPlot
            // 
            this.BTN_ResetPlot.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BTN_ResetPlot.Enabled = false;
            this.BTN_ResetPlot.Location = new System.Drawing.Point(211, 14);
            this.BTN_ResetPlot.Name = "BTN_ResetPlot";
            this.BTN_ResetPlot.Size = new System.Drawing.Size(190, 39);
            this.BTN_ResetPlot.TabIndex = 1;
            this.BTN_ResetPlot.Text = "Reset";
            this.BTN_ResetPlot.UseVisualStyleBackColor = true;
            this.BTN_ResetPlot.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.BTN_simulate);
            this.tabPage4.Controls.Add(this.TB_TestNumber);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.TB_factor2);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.TB_factor1);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.Chart_simulation);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(757, 443);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Service Rate Simulation";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // BTN_simulate
            // 
            this.BTN_simulate.Enabled = false;
            this.BTN_simulate.Location = new System.Drawing.Point(305, 23);
            this.BTN_simulate.Name = "BTN_simulate";
            this.BTN_simulate.Size = new System.Drawing.Size(146, 63);
            this.BTN_simulate.TabIndex = 7;
            this.BTN_simulate.Text = "Simulate";
            this.BTN_simulate.UseVisualStyleBackColor = true;
            this.BTN_simulate.Click += new System.EventHandler(this.BTN_simulate_Click);
            // 
            // TB_TestNumber
            // 
            this.TB_TestNumber.Location = new System.Drawing.Point(160, 64);
            this.TB_TestNumber.Name = "TB_TestNumber";
            this.TB_TestNumber.Size = new System.Drawing.Size(41, 22);
            this.TB_TestNumber.TabIndex = 6;
            this.TB_TestNumber.Text = "3";
            this.TB_TestNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(23, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Number of Tests";
            // 
            // TB_factor2
            // 
            this.TB_factor2.Location = new System.Drawing.Point(233, 23);
            this.TB_factor2.Name = "TB_factor2";
            this.TB_factor2.Size = new System.Drawing.Size(41, 22);
            this.TB_factor2.TabIndex = 4;
            this.TB_factor2.Text = "2";
            this.TB_factor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(207, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "to";
            // 
            // TB_factor1
            // 
            this.TB_factor1.Location = new System.Drawing.Point(160, 23);
            this.TB_factor1.Name = "TB_factor1";
            this.TB_factor1.Size = new System.Drawing.Size(41, 22);
            this.TB_factor1.TabIndex = 2;
            this.TB_factor1.Text = "0.5";
            this.TB_factor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(23, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Service Factor from";
            // 
            // Chart_simulation
            // 
            this.Chart_simulation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisX.Interval = 0.1D;
            chartArea3.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.Title = "Time-average Jobs in Service (Utilization, x-bar)";
            chartArea3.AxisX2.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisY.Title = "Time-average Jobs in Queue Length (q-bar)";
            chartArea3.AxisY2.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.BorderColor = System.Drawing.Color.Silver;
            chartArea3.Name = "ChartArea1";
            this.Chart_simulation.ChartAreas.Add(chartArea3);
            this.Chart_simulation.Location = new System.Drawing.Point(6, 137);
            this.Chart_simulation.Name = "Chart_simulation";
            this.Chart_simulation.Size = new System.Drawing.Size(745, 300);
            this.Chart_simulation.TabIndex = 0;
            this.Chart_simulation.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1161, 565);
            this.Controls.Add(this.TopToolStrip);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.TopMenuStrip);
            this.Controls.Add(this.DownMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.TopMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "r09546042_TerryYang_assignment_02";
            this.TopToolStrip.ResumeLayout(false);
            this.TopToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TC1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.TC2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart_stepline)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_simulation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenuStrip;
        private System.Windows.Forms.ToolStrip TopToolStrip;
        private System.Windows.Forms.ToolStripButton TOS_BTN_open;
        private System.Windows.Forms.MenuStrip DownMenuStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl TC1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BTN_ShowPlot;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button BTN_ResetPlot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_save;
        private System.Windows.Forms.Button BTN_Creat;
        private System.Windows.Forms.TextBox TB_NOJ;
        private System.Windows.Forms.TextBox TB_ASTD;
        private System.Windows.Forms.TextBox TB_AST;
        private System.Windows.Forms.TextBox TB_AITD;
        private System.Windows.Forms.TextBox TB_AIT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Completion_time;
        private System.Windows.Forms.TextBox TextBox_Server_Constant;
        private System.Windows.Forms.TabControl TC2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart_stepline;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox CheckBox_ServerStatus;
        private System.Windows.Forms.CheckBox CheckBox_JobQueue;
        private System.Windows.Forms.CheckBox CheckBox_JocCount;
        private System.Windows.Forms.Label LB_AJN;
        private System.Windows.Forms.Label LB_AJS;
        private System.Windows.Forms.Label LB_AJQ;
        private System.Windows.Forms.Label LB_WatTime;
        private System.Windows.Forms.Label LB_AvgDlyTime;
        private System.Windows.Forms.Label LB_AvgSerTime;
        private System.Windows.Forms.Label LB_AvgIntTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTN_simulate;
        private System.Windows.Forms.TextBox TB_TestNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_factor2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_factor1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_simulation;
        private System.Windows.Forms.ToolStripButton TOS_BTN_open_excel;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart_bar;
        private System.Windows.Forms.ToolStripButton TOS_BTN_analyze;
    }
}

