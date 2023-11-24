
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.TopToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolButton_Stochastic = new System.Windows.Forms.ToolStripButton();
            this.ToolButton_Tracedown = new System.Windows.Forms.ToolStripButton();
            this.TOS_BTN_open = new System.Windows.Forms.ToolStripButton();
            this.DownMenuStrip = new System.Windows.Forms.MenuStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TabControl_Data = new System.Windows.Forms.TabControl();
            this.TabPage_Stochastic = new System.Windows.Forms.TabPage();
            this.ComboBox_Seed = new System.Windows.Forms.ComboBox();
            this.Label_Number_of_Jobs = new System.Windows.Forms.Label();
            this.TextBox_UpperBound = new System.Windows.Forms.TextBox();
            this.TextBox_LowerBound = new System.Windows.Forms.TextBox();
            this.TextBox_Average_InterarrivalTime = new System.Windows.Forms.TextBox();
            this.TextBox_NumberOfJobs = new System.Windows.Forms.TextBox();
            this.Buttom_Simulate_Stochastic = new System.Windows.Forms.Button();
            this.TabPage_CurrentPRO = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Job_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delay_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completion_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TabPage_CreatePRO = new System.Windows.Forms.TabPage();
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
            this.TabControl_Chart = new System.Windows.Forms.TabControl();
            this.TabPage_Processing = new System.Windows.Forms.TabPage();
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
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TextBox_Server_Constant = new System.Windows.Forms.TextBox();
            this.BTN_ShowPlot = new System.Windows.Forms.Button();
            this.BTN_ResetPlot = new System.Windows.Forms.Button();
            this.TabPage_RateSimulation = new System.Windows.Forms.TabPage();
            this.BTN_simulate = new System.Windows.Forms.Button();
            this.TB_TestNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_factor2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_factor1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Chart_simulation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TabPage_SteadyTest = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Chart_Steady_Test = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TextBox_NumberOfTests = new System.Windows.Forms.TextBox();
            this.TextBox_StartTo = new System.Windows.Forms.TextBox();
            this.TextBox_StartFrom = new System.Windows.Forms.TextBox();
            this.Button_Steady_clear = new System.Windows.Forms.Button();
            this.Button_steady_simulate = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TopToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TabControl_Data.SuspendLayout();
            this.TabPage_Stochastic.SuspendLayout();
            this.TabPage_CurrentPRO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TabPage_CreatePRO.SuspendLayout();
            this.TabControl_Chart.SuspendLayout();
            this.TabPage_Processing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.TabPage_RateSimulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_simulation)).BeginInit();
            this.TabPage_SteadyTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Steady_Test)).BeginInit();
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
            this.ToolButton_Stochastic,
            this.ToolButton_Tracedown,
            this.TOS_BTN_open});
            this.TopToolStrip.Location = new System.Drawing.Point(0, 24);
            this.TopToolStrip.Name = "TopToolStrip";
            this.TopToolStrip.Size = new System.Drawing.Size(1161, 39);
            this.TopToolStrip.TabIndex = 1;
            this.TopToolStrip.Text = "toolStrip1";
            // 
            // ToolButton_Stochastic
            // 
            this.ToolButton_Stochastic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolButton_Stochastic.Image = ((System.Drawing.Image)(resources.GetObject("ToolButton_Stochastic.Image")));
            this.ToolButton_Stochastic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButton_Stochastic.Name = "ToolButton_Stochastic";
            this.ToolButton_Stochastic.Size = new System.Drawing.Size(36, 36);
            this.ToolButton_Stochastic.Text = "Stochastic";
            this.ToolButton_Stochastic.Click += new System.EventHandler(this.ToolButton_Stochastic_Click);
            // 
            // ToolButton_Tracedown
            // 
            this.ToolButton_Tracedown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolButton_Tracedown.Enabled = false;
            this.ToolButton_Tracedown.Image = ((System.Drawing.Image)(resources.GetObject("ToolButton_Tracedown.Image")));
            this.ToolButton_Tracedown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolButton_Tracedown.Name = "ToolButton_Tracedown";
            this.ToolButton_Tracedown.Size = new System.Drawing.Size(36, 36);
            this.ToolButton_Tracedown.Text = "Tracedown";
            this.ToolButton_Tracedown.Click += new System.EventHandler(this.ToolButton_Tracedown_Click);
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
            this.TOS_BTN_open.Click += new System.EventHandler(this.TOS_BTN_open_Click);
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
            this.splitContainer1.Panel1.Controls.Add(this.TabControl_Data);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TabControl_Chart);
            this.splitContainer1.Size = new System.Drawing.Size(1161, 475);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 3;
            // 
            // TabControl_Data
            // 
            this.TabControl_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Data.Controls.Add(this.TabPage_Stochastic);
            this.TabControl_Data.Controls.Add(this.TabPage_CurrentPRO);
            this.TabControl_Data.Controls.Add(this.TabPage_CreatePRO);
            this.TabControl_Data.Location = new System.Drawing.Point(12, 3);
            this.TabControl_Data.Name = "TabControl_Data";
            this.TabControl_Data.SelectedIndex = 0;
            this.TabControl_Data.Size = new System.Drawing.Size(371, 469);
            this.TabControl_Data.TabIndex = 0;
            // 
            // TabPage_Stochastic
            // 
            this.TabPage_Stochastic.Controls.Add(this.ComboBox_Seed);
            this.TabPage_Stochastic.Controls.Add(this.Label_Number_of_Jobs);
            this.TabPage_Stochastic.Controls.Add(this.TextBox_UpperBound);
            this.TabPage_Stochastic.Controls.Add(this.TextBox_LowerBound);
            this.TabPage_Stochastic.Controls.Add(this.TextBox_Average_InterarrivalTime);
            this.TabPage_Stochastic.Controls.Add(this.TextBox_NumberOfJobs);
            this.TabPage_Stochastic.Controls.Add(this.Buttom_Simulate_Stochastic);
            this.TabPage_Stochastic.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Stochastic.Name = "TabPage_Stochastic";
            this.TabPage_Stochastic.Size = new System.Drawing.Size(363, 443);
            this.TabPage_Stochastic.TabIndex = 2;
            this.TabPage_Stochastic.Text = "Stochastic";
            this.TabPage_Stochastic.UseVisualStyleBackColor = true;
            // 
            // ComboBox_Seed
            // 
            this.ComboBox_Seed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Seed.FormattingEnabled = true;
            this.ComboBox_Seed.Items.AddRange(new object[] {
            "New Random",
            "12345",
            "54321",
            "2121212"});
            this.ComboBox_Seed.Location = new System.Drawing.Point(244, 320);
            this.ComboBox_Seed.Name = "ComboBox_Seed";
            this.ComboBox_Seed.Size = new System.Drawing.Size(100, 20);
            this.ComboBox_Seed.TabIndex = 10;
            this.ComboBox_Seed.Text = "New Random";
            // 
            // Label_Number_of_Jobs
            // 
            this.Label_Number_of_Jobs.AutoSize = true;
            this.Label_Number_of_Jobs.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Number_of_Jobs.Location = new System.Drawing.Point(18, 52);
            this.Label_Number_of_Jobs.Name = "Label_Number_of_Jobs";
            this.Label_Number_of_Jobs.Size = new System.Drawing.Size(171, 288);
            this.Label_Number_of_Jobs.TabIndex = 7;
            this.Label_Number_of_Jobs.Text = "Number of Jobs:\r\n\r\n\r\n\r\nInterarrival Time~\r\n(Exponential Distribution)\r\n     Avera" +
    "ge:\r\n\r\n\r\n\r\nService Time~\r\n(Uniform Distribution)\r\n     Lower Bound:\r\n     Upper " +
    "Bound:\r\n\r\n\r\n\r\nSeed:\r\n";
            // 
            // TextBox_UpperBound
            // 
            this.TextBox_UpperBound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_UpperBound.Location = new System.Drawing.Point(244, 262);
            this.TextBox_UpperBound.Name = "TextBox_UpperBound";
            this.TextBox_UpperBound.Size = new System.Drawing.Size(100, 22);
            this.TextBox_UpperBound.TabIndex = 4;
            this.TextBox_UpperBound.Text = "2.0";
            // 
            // TextBox_LowerBound
            // 
            this.TextBox_LowerBound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_LowerBound.Location = new System.Drawing.Point(244, 234);
            this.TextBox_LowerBound.Name = "TextBox_LowerBound";
            this.TextBox_LowerBound.Size = new System.Drawing.Size(100, 22);
            this.TextBox_LowerBound.TabIndex = 3;
            this.TextBox_LowerBound.Text = "1.0";
            // 
            // TextBox_Average_InterarrivalTime
            // 
            this.TextBox_Average_InterarrivalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Average_InterarrivalTime.Location = new System.Drawing.Point(244, 146);
            this.TextBox_Average_InterarrivalTime.Name = "TextBox_Average_InterarrivalTime";
            this.TextBox_Average_InterarrivalTime.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Average_InterarrivalTime.TabIndex = 2;
            this.TextBox_Average_InterarrivalTime.Text = "2";
            // 
            // TextBox_NumberOfJobs
            // 
            this.TextBox_NumberOfJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_NumberOfJobs.Location = new System.Drawing.Point(244, 53);
            this.TextBox_NumberOfJobs.Name = "TextBox_NumberOfJobs";
            this.TextBox_NumberOfJobs.Size = new System.Drawing.Size(100, 22);
            this.TextBox_NumberOfJobs.TabIndex = 1;
            this.TextBox_NumberOfJobs.Text = "1000";
            // 
            // Buttom_Simulate_Stochastic
            // 
            this.Buttom_Simulate_Stochastic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buttom_Simulate_Stochastic.Location = new System.Drawing.Point(3, 384);
            this.Buttom_Simulate_Stochastic.Name = "Buttom_Simulate_Stochastic";
            this.Buttom_Simulate_Stochastic.Size = new System.Drawing.Size(357, 50);
            this.Buttom_Simulate_Stochastic.TabIndex = 0;
            this.Buttom_Simulate_Stochastic.Text = "Simulat Stochastic Case";
            this.Buttom_Simulate_Stochastic.UseVisualStyleBackColor = true;
            this.Buttom_Simulate_Stochastic.Click += new System.EventHandler(this.Buttom_Simulate_Stochastic_Click);
            // 
            // TabPage_CurrentPRO
            // 
            this.TabPage_CurrentPRO.Controls.Add(this.dataGridView1);
            this.TabPage_CurrentPRO.Controls.Add(this.label1);
            this.TabPage_CurrentPRO.Location = new System.Drawing.Point(4, 22);
            this.TabPage_CurrentPRO.Name = "TabPage_CurrentPRO";
            this.TabPage_CurrentPRO.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_CurrentPRO.Size = new System.Drawing.Size(363, 443);
            this.TabPage_CurrentPRO.TabIndex = 0;
            this.TabPage_CurrentPRO.Text = "Current Problem";
            this.TabPage_CurrentPRO.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Job_ID,
            this.Arrival_time,
            this.Service_time,
            this.Delay_time,
            this.Completion_time});
            this.dataGridView1.Location = new System.Drawing.Point(6, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(351, 360);
            this.dataGridView1.TabIndex = 2;
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
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arrive and service time";
            // 
            // TabPage_CreatePRO
            // 
            this.TabPage_CreatePRO.Controls.Add(this.BTN_save);
            this.TabPage_CreatePRO.Controls.Add(this.BTN_Creat);
            this.TabPage_CreatePRO.Controls.Add(this.TB_NOJ);
            this.TabPage_CreatePRO.Controls.Add(this.TB_ASTD);
            this.TabPage_CreatePRO.Controls.Add(this.TB_AST);
            this.TabPage_CreatePRO.Controls.Add(this.TB_AITD);
            this.TabPage_CreatePRO.Controls.Add(this.TB_AIT);
            this.TabPage_CreatePRO.Controls.Add(this.label6);
            this.TabPage_CreatePRO.Controls.Add(this.label5);
            this.TabPage_CreatePRO.Controls.Add(this.label4);
            this.TabPage_CreatePRO.Controls.Add(this.label3);
            this.TabPage_CreatePRO.Controls.Add(this.label2);
            this.TabPage_CreatePRO.Location = new System.Drawing.Point(4, 22);
            this.TabPage_CreatePRO.Name = "TabPage_CreatePRO";
            this.TabPage_CreatePRO.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_CreatePRO.Size = new System.Drawing.Size(363, 443);
            this.TabPage_CreatePRO.TabIndex = 1;
            this.TabPage_CreatePRO.Text = "Create a new problem";
            this.TabPage_CreatePRO.UseVisualStyleBackColor = true;
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
            this.BTN_save.Click += new System.EventHandler(this.BTN_save_Click);
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
            this.BTN_Creat.Click += new System.EventHandler(this.BTN_Creat_Click);
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
            // TabControl_Chart
            // 
            this.TabControl_Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Chart.Controls.Add(this.TabPage_Processing);
            this.TabControl_Chart.Controls.Add(this.TabPage_RateSimulation);
            this.TabControl_Chart.Controls.Add(this.TabPage_SteadyTest);
            this.TabControl_Chart.Location = new System.Drawing.Point(3, 3);
            this.TabControl_Chart.Name = "TabControl_Chart";
            this.TabControl_Chart.SelectedIndex = 0;
            this.TabControl_Chart.Size = new System.Drawing.Size(765, 469);
            this.TabControl_Chart.TabIndex = 4;
            // 
            // TabPage_Processing
            // 
            this.TabPage_Processing.Controls.Add(this.label7);
            this.TabPage_Processing.Controls.Add(this.LB_WatTime);
            this.TabPage_Processing.Controls.Add(this.LB_AvgDlyTime);
            this.TabPage_Processing.Controls.Add(this.LB_AvgSerTime);
            this.TabPage_Processing.Controls.Add(this.LB_AvgIntTime);
            this.TabPage_Processing.Controls.Add(this.LB_AJS);
            this.TabPage_Processing.Controls.Add(this.LB_AJQ);
            this.TabPage_Processing.Controls.Add(this.LB_AJN);
            this.TabPage_Processing.Controls.Add(this.CheckBox_ServerStatus);
            this.TabPage_Processing.Controls.Add(this.CheckBox_JobQueue);
            this.TabPage_Processing.Controls.Add(this.CheckBox_JocCount);
            this.TabPage_Processing.Controls.Add(this.MainChart);
            this.TabPage_Processing.Controls.Add(this.TextBox_Server_Constant);
            this.TabPage_Processing.Controls.Add(this.BTN_ShowPlot);
            this.TabPage_Processing.Controls.Add(this.BTN_ResetPlot);
            this.TabPage_Processing.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Processing.Name = "TabPage_Processing";
            this.TabPage_Processing.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Processing.Size = new System.Drawing.Size(757, 443);
            this.TabPage_Processing.TabIndex = 0;
            this.TabPage_Processing.Text = "Simulate Job Processing";
            this.TabPage_Processing.UseVisualStyleBackColor = true;
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
            this.LB_AJS.Location = new System.Drawing.Point(520, 120);
            this.LB_AJS.Name = "LB_AJS";
            this.LB_AJS.Size = new System.Drawing.Size(203, 16);
            this.LB_AJS.TabIndex = 10;
            this.LB_AJS.Text = "Time_Averaged Job in Server: ";
            this.LB_AJS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LB_AJQ
            // 
            this.LB_AJQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_AJQ.AutoEllipsis = true;
            this.LB_AJQ.AutoSize = true;
            this.LB_AJQ.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_AJQ.ForeColor = System.Drawing.Color.SeaGreen;
            this.LB_AJQ.Location = new System.Drawing.Point(520, 100);
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
            this.LB_AJN.Location = new System.Drawing.Point(521, 80);
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
            this.CheckBox_JocCount.Location = new System.Drawing.Point(15, 59);
            this.CheckBox_JocCount.Name = "CheckBox_JocCount";
            this.CheckBox_JocCount.Size = new System.Drawing.Size(80, 16);
            this.CheckBox_JocCount.TabIndex = 5;
            this.CheckBox_JocCount.Text = "Job in Node";
            this.CheckBox_JocCount.UseVisualStyleBackColor = true;
            this.CheckBox_JocCount.CheckedChanged += new System.EventHandler(this.CheckBox_JocCount_CheckedChanged);
            // 
            // MainChart
            // 
            this.MainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea13.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea13.AxisX.Interval = 5D;
            chartArea13.AxisX.IsLabelAutoFit = false;
            chartArea13.AxisX.LabelStyle.Interval = 0D;
            chartArea13.AxisX.LineColor = System.Drawing.SystemColors.GrayText;
            chartArea13.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea13.AxisX.LineWidth = 0;
            chartArea13.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea13.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea13.AxisX.Minimum = 0D;
            chartArea13.AxisX.Title = "Time";
            chartArea13.AxisY.Interval = 1D;
            chartArea13.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea13.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea13.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea13.AxisY.Title = "Job Count";
            chartArea13.BorderColor = System.Drawing.Color.Silver;
            chartArea13.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea13);
            this.MainChart.Location = new System.Drawing.Point(15, 159);
            this.MainChart.Name = "MainChart";
            this.MainChart.Size = new System.Drawing.Size(736, 275);
            this.MainChart.TabIndex = 4;
            this.MainChart.Text = "chart1";
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
            this.BTN_ShowPlot.Click += new System.EventHandler(this.BTN_ShowPlot_Click);
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
            this.BTN_ResetPlot.Click += new System.EventHandler(this.BTN_ResetPlot_Click);
            // 
            // TabPage_RateSimulation
            // 
            this.TabPage_RateSimulation.Controls.Add(this.BTN_simulate);
            this.TabPage_RateSimulation.Controls.Add(this.TB_TestNumber);
            this.TabPage_RateSimulation.Controls.Add(this.label10);
            this.TabPage_RateSimulation.Controls.Add(this.TB_factor2);
            this.TabPage_RateSimulation.Controls.Add(this.label9);
            this.TabPage_RateSimulation.Controls.Add(this.TB_factor1);
            this.TabPage_RateSimulation.Controls.Add(this.label8);
            this.TabPage_RateSimulation.Controls.Add(this.Chart_simulation);
            this.TabPage_RateSimulation.Location = new System.Drawing.Point(4, 22);
            this.TabPage_RateSimulation.Name = "TabPage_RateSimulation";
            this.TabPage_RateSimulation.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_RateSimulation.Size = new System.Drawing.Size(757, 443);
            this.TabPage_RateSimulation.TabIndex = 1;
            this.TabPage_RateSimulation.Text = "Service Rate Simulation";
            this.TabPage_RateSimulation.UseVisualStyleBackColor = true;
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
            chartArea14.AxisX.Interval = 0.1D;
            chartArea14.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea14.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea14.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea14.AxisX.Minimum = 0D;
            chartArea14.AxisX.Title = "Time-average Jobs in Service (Utilization, x-bar)";
            chartArea14.AxisX2.LineColor = System.Drawing.Color.Silver;
            chartArea14.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea14.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea14.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea14.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea14.AxisY.Title = "Time-average Jobs in Queue Length (q-bar)";
            chartArea14.AxisY2.LineColor = System.Drawing.Color.Silver;
            chartArea14.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea14.BorderColor = System.Drawing.Color.Silver;
            chartArea14.Name = "ChartArea1";
            this.Chart_simulation.ChartAreas.Add(chartArea14);
            this.Chart_simulation.Location = new System.Drawing.Point(6, 137);
            this.Chart_simulation.Name = "Chart_simulation";
            this.Chart_simulation.Size = new System.Drawing.Size(745, 300);
            this.Chart_simulation.TabIndex = 0;
            this.Chart_simulation.Text = "chart1";
            // 
            // TabPage_SteadyTest
            // 
            this.TabPage_SteadyTest.Controls.Add(this.label13);
            this.TabPage_SteadyTest.Controls.Add(this.label12);
            this.TabPage_SteadyTest.Controls.Add(this.label11);
            this.TabPage_SteadyTest.Controls.Add(this.Chart_Steady_Test);
            this.TabPage_SteadyTest.Controls.Add(this.TextBox_NumberOfTests);
            this.TabPage_SteadyTest.Controls.Add(this.TextBox_StartTo);
            this.TabPage_SteadyTest.Controls.Add(this.TextBox_StartFrom);
            this.TabPage_SteadyTest.Controls.Add(this.Button_Steady_clear);
            this.TabPage_SteadyTest.Controls.Add(this.Button_steady_simulate);
            this.TabPage_SteadyTest.Location = new System.Drawing.Point(4, 22);
            this.TabPage_SteadyTest.Name = "TabPage_SteadyTest";
            this.TabPage_SteadyTest.Size = new System.Drawing.Size(757, 443);
            this.TabPage_SteadyTest.TabIndex = 2;
            this.TabPage_SteadyTest.Text = "Steady State Test";
            this.TabPage_SteadyTest.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 12);
            this.label13.TabIndex = 8;
            this.label13.Text = "Numbers of Jobs Start from";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 12);
            this.label12.TabIndex = 7;
            this.label12.Text = "Number of Tests";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(283, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 12);
            this.label11.TabIndex = 6;
            this.label11.Text = "to";
            // 
            // Chart_Steady_Test
            // 
            this.Chart_Steady_Test.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea15.AxisX.Title = "Number of Jobs (n)";
            chartArea15.AxisY.Title = "Average Wait Time";
            chartArea15.Name = "ChartArea1";
            this.Chart_Steady_Test.ChartAreas.Add(chartArea15);
            legend5.Alignment = System.Drawing.StringAlignment.Center;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Name = "Legend1";
            this.Chart_Steady_Test.Legends.Add(legend5);
            this.Chart_Steady_Test.Location = new System.Drawing.Point(3, 134);
            this.Chart_Steady_Test.Name = "Chart_Steady_Test";
            this.Chart_Steady_Test.Size = new System.Drawing.Size(749, 300);
            this.Chart_Steady_Test.TabIndex = 5;
            this.Chart_Steady_Test.Text = "chart1";
            // 
            // TextBox_NumberOfTests
            // 
            this.TextBox_NumberOfTests.Location = new System.Drawing.Point(195, 74);
            this.TextBox_NumberOfTests.Name = "TextBox_NumberOfTests";
            this.TextBox_NumberOfTests.Size = new System.Drawing.Size(69, 22);
            this.TextBox_NumberOfTests.TabIndex = 4;
            this.TextBox_NumberOfTests.Text = "50";
            // 
            // TextBox_StartTo
            // 
            this.TextBox_StartTo.Location = new System.Drawing.Point(322, 40);
            this.TextBox_StartTo.Name = "TextBox_StartTo";
            this.TextBox_StartTo.Size = new System.Drawing.Size(69, 22);
            this.TextBox_StartTo.TabIndex = 3;
            this.TextBox_StartTo.Text = "1000";
            // 
            // TextBox_StartFrom
            // 
            this.TextBox_StartFrom.Location = new System.Drawing.Point(195, 40);
            this.TextBox_StartFrom.Name = "TextBox_StartFrom";
            this.TextBox_StartFrom.Size = new System.Drawing.Size(69, 22);
            this.TextBox_StartFrom.TabIndex = 2;
            this.TextBox_StartFrom.Text = "20";
            // 
            // Button_Steady_clear
            // 
            this.Button_Steady_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Steady_clear.Location = new System.Drawing.Point(655, 19);
            this.Button_Steady_clear.Name = "Button_Steady_clear";
            this.Button_Steady_clear.Size = new System.Drawing.Size(97, 46);
            this.Button_Steady_clear.TabIndex = 1;
            this.Button_Steady_clear.Text = "Clear All";
            this.Button_Steady_clear.UseVisualStyleBackColor = true;
            this.Button_Steady_clear.Click += new System.EventHandler(this.Button_Steady_clear_Click);
            // 
            // Button_steady_simulate
            // 
            this.Button_steady_simulate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_steady_simulate.Location = new System.Drawing.Point(539, 19);
            this.Button_steady_simulate.Name = "Button_steady_simulate";
            this.Button_steady_simulate.Size = new System.Drawing.Size(110, 46);
            this.Button_steady_simulate.TabIndex = 0;
            this.Button_steady_simulate.Text = "Simulation";
            this.Button_steady_simulate.UseVisualStyleBackColor = true;
            this.Button_steady_simulate.Click += new System.EventHandler(this.Button_steady_simulate_Click);
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
            this.Text = "r09546042_TerryYang_assignment_05";
            this.TopToolStrip.ResumeLayout(false);
            this.TopToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TabControl_Data.ResumeLayout(false);
            this.TabPage_Stochastic.ResumeLayout(false);
            this.TabPage_Stochastic.PerformLayout();
            this.TabPage_CurrentPRO.ResumeLayout(false);
            this.TabPage_CurrentPRO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TabPage_CreatePRO.ResumeLayout(false);
            this.TabPage_CreatePRO.PerformLayout();
            this.TabControl_Chart.ResumeLayout(false);
            this.TabPage_Processing.ResumeLayout(false);
            this.TabPage_Processing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.TabPage_RateSimulation.ResumeLayout(false);
            this.TabPage_RateSimulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_simulation)).EndInit();
            this.TabPage_SteadyTest.ResumeLayout(false);
            this.TabPage_SteadyTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_Steady_Test)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenuStrip;
        private System.Windows.Forms.ToolStrip TopToolStrip;
        private System.Windows.Forms.ToolStripButton TOS_BTN_open;
        private System.Windows.Forms.MenuStrip DownMenuStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl TabControl_Data;
        private System.Windows.Forms.TabPage TabPage_CurrentPRO;
        private System.Windows.Forms.TabPage TabPage_CreatePRO;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Completion_time;
        private System.Windows.Forms.TextBox TextBox_Server_Constant;
        private System.Windows.Forms.TabControl TabControl_Chart;
        private System.Windows.Forms.TabPage TabPage_Processing;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.TabPage TabPage_RateSimulation;
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
        private System.Windows.Forms.ToolStripButton ToolButton_Stochastic;
        private System.Windows.Forms.ToolStripButton ToolButton_Tracedown;
        private System.Windows.Forms.TabPage TabPage_Stochastic;
        private System.Windows.Forms.TabPage TabPage_SteadyTest;
        private System.Windows.Forms.ComboBox ComboBox_Seed;
        private System.Windows.Forms.Label Label_Number_of_Jobs;
        private System.Windows.Forms.TextBox TextBox_UpperBound;
        private System.Windows.Forms.TextBox TextBox_LowerBound;
        private System.Windows.Forms.TextBox TextBox_Average_InterarrivalTime;
        private System.Windows.Forms.TextBox TextBox_NumberOfJobs;
        private System.Windows.Forms.Button Buttom_Simulate_Stochastic;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Steady_Test;
        private System.Windows.Forms.TextBox TextBox_NumberOfTests;
        private System.Windows.Forms.TextBox TextBox_StartTo;
        private System.Windows.Forms.TextBox TextBox_StartFrom;
        private System.Windows.Forms.Button Button_Steady_clear;
        private System.Windows.Forms.Button Button_steady_simulate;
    }
}

