
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.TopToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripComboBox_Seed = new System.Windows.Forms.ToolStripComboBox();
            this.DownMenuStrip = new System.Windows.Forms.MenuStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TabControl_Data = new System.Windows.Forms.TabControl();
            this.SSQ = new System.Windows.Forms.TabPage();
            this.TextBox_feedback_ratio = new System.Windows.Forms.TextBox();
            this.Label_Number_of_Jobs = new System.Windows.Forms.Label();
            this.TextBox_UpperBound = new System.Windows.Forms.TextBox();
            this.TextBox_LowerBound = new System.Windows.Forms.TextBox();
            this.TextBox_Average_InterarrivalTime = new System.Windows.Forms.TextBox();
            this.TextBox_NumberOfJobs = new System.Windows.Forms.TextBox();
            this.Buttom_Simulate_Stochastic = new System.Windows.Forms.Button();
            this.SIS = new System.Windows.Forms.TabPage();
            this.CheckBox_DeliveryLag = new System.Windows.Forms.CheckBox();
            this.TextBox_ShoCost = new System.Windows.Forms.TextBox();
            this.TextBox_HolCost = new System.Windows.Forms.TextBox();
            this.TextBox_SetCost = new System.Windows.Forms.TextBox();
            this.TextBox_MinLevel = new System.Windows.Forms.TextBox();
            this.TextBox_MaxLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Demand_UBound = new System.Windows.Forms.TextBox();
            this.TextBox_Demand_LBound = new System.Windows.Forms.TextBox();
            this.TextBox_NumberOfIntervals = new System.Windows.Forms.TextBox();
            this.Button_SIS_Simulate = new System.Windows.Forms.Button();
            this.TabControl_Chart = new System.Windows.Forms.TabControl();
            this.TabPage_Processing = new System.Windows.Forms.TabPage();
            this.RichTextBox_result = new System.Windows.Forms.RichTextBox();
            this.CheckBox_ServerStatus = new System.Windows.Forms.CheckBox();
            this.CheckBox_JobQueue = new System.Windows.Forms.CheckBox();
            this.CheckBox_JocCount = new System.Windows.Forms.CheckBox();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TopToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TabControl_Data.SuspendLayout();
            this.SSQ.SuspendLayout();
            this.SIS.SuspendLayout();
            this.TabControl_Chart.SuspendLayout();
            this.TabPage_Processing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // TopMenuStrip
            // 
            this.TopMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TopMenuStrip.Name = "TopMenuStrip";
            this.TopMenuStrip.Size = new System.Drawing.Size(1184, 24);
            this.TopMenuStrip.TabIndex = 0;
            this.TopMenuStrip.Text = "menuStrip1";
            // 
            // TopToolStrip
            // 
            this.TopToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.TopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.ToolStripComboBox_Seed});
            this.TopToolStrip.Location = new System.Drawing.Point(0, 24);
            this.TopToolStrip.Name = "TopToolStrip";
            this.TopToolStrip.Size = new System.Drawing.Size(1184, 25);
            this.TopToolStrip.TabIndex = 1;
            this.TopToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
            this.toolStripLabel1.Text = "Seed";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripComboBox_Seed
            // 
            this.ToolStripComboBox_Seed.Items.AddRange(new object[] {
            "New Random",
            "12345",
            "54321",
            "2121212"});
            this.ToolStripComboBox_Seed.Name = "ToolStripComboBox_Seed";
            this.ToolStripComboBox_Seed.Size = new System.Drawing.Size(100, 25);
            this.ToolStripComboBox_Seed.Text = "New Random";
            // 
            // DownMenuStrip
            // 
            this.DownMenuStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DownMenuStrip.Location = new System.Drawing.Point(0, 737);
            this.DownMenuStrip.Name = "DownMenuStrip";
            this.DownMenuStrip.Size = new System.Drawing.Size(1184, 24);
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
            this.splitContainer1.Size = new System.Drawing.Size(1184, 671);
            this.splitContainer1.SplitterDistance = 393;
            this.splitContainer1.TabIndex = 3;
            // 
            // TabControl_Data
            // 
            this.TabControl_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Data.Controls.Add(this.SSQ);
            this.TabControl_Data.Controls.Add(this.SIS);
            this.TabControl_Data.Location = new System.Drawing.Point(12, 3);
            this.TabControl_Data.Name = "TabControl_Data";
            this.TabControl_Data.SelectedIndex = 0;
            this.TabControl_Data.Size = new System.Drawing.Size(378, 665);
            this.TabControl_Data.TabIndex = 0;
            // 
            // SSQ
            // 
            this.SSQ.Controls.Add(this.TextBox_feedback_ratio);
            this.SSQ.Controls.Add(this.Label_Number_of_Jobs);
            this.SSQ.Controls.Add(this.TextBox_UpperBound);
            this.SSQ.Controls.Add(this.TextBox_LowerBound);
            this.SSQ.Controls.Add(this.TextBox_Average_InterarrivalTime);
            this.SSQ.Controls.Add(this.TextBox_NumberOfJobs);
            this.SSQ.Controls.Add(this.Buttom_Simulate_Stochastic);
            this.SSQ.Location = new System.Drawing.Point(4, 22);
            this.SSQ.Name = "SSQ";
            this.SSQ.Size = new System.Drawing.Size(370, 639);
            this.SSQ.TabIndex = 2;
            this.SSQ.Text = "SSQ with Feedback";
            this.SSQ.UseVisualStyleBackColor = true;
            // 
            // TextBox_feedback_ratio
            // 
            this.TextBox_feedback_ratio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_feedback_ratio.Location = new System.Drawing.Point(251, 347);
            this.TextBox_feedback_ratio.Name = "TextBox_feedback_ratio";
            this.TextBox_feedback_ratio.Size = new System.Drawing.Size(100, 22);
            this.TextBox_feedback_ratio.TabIndex = 11;
            this.TextBox_feedback_ratio.Text = "0.1";
            // 
            // Label_Number_of_Jobs
            // 
            this.Label_Number_of_Jobs.AutoSize = true;
            this.Label_Number_of_Jobs.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Number_of_Jobs.Location = new System.Drawing.Point(18, 17);
            this.Label_Number_of_Jobs.Name = "Label_Number_of_Jobs";
            this.Label_Number_of_Jobs.Size = new System.Drawing.Size(171, 352);
            this.Label_Number_of_Jobs.TabIndex = 7;
            this.Label_Number_of_Jobs.Text = "Number of Jobs:\r\n\r\n\r\n\r\nInterarrival Time~\r\n(Exponential Distribution)\r\n     Avera" +
    "ge:\r\n\r\n\r\n\r\nService Time~\r\n(Uniform Distribution)\r\n     Lower Bound:\r\n     Upper " +
    "Bound:\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\nFeedback Ratio:";
            // 
            // TextBox_UpperBound
            // 
            this.TextBox_UpperBound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_UpperBound.Location = new System.Drawing.Point(251, 227);
            this.TextBox_UpperBound.Name = "TextBox_UpperBound";
            this.TextBox_UpperBound.Size = new System.Drawing.Size(100, 22);
            this.TextBox_UpperBound.TabIndex = 4;
            this.TextBox_UpperBound.Text = "2.0";
            // 
            // TextBox_LowerBound
            // 
            this.TextBox_LowerBound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_LowerBound.Location = new System.Drawing.Point(251, 199);
            this.TextBox_LowerBound.Name = "TextBox_LowerBound";
            this.TextBox_LowerBound.Size = new System.Drawing.Size(100, 22);
            this.TextBox_LowerBound.TabIndex = 3;
            this.TextBox_LowerBound.Text = "1.0";
            // 
            // TextBox_Average_InterarrivalTime
            // 
            this.TextBox_Average_InterarrivalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Average_InterarrivalTime.Location = new System.Drawing.Point(251, 111);
            this.TextBox_Average_InterarrivalTime.Name = "TextBox_Average_InterarrivalTime";
            this.TextBox_Average_InterarrivalTime.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Average_InterarrivalTime.TabIndex = 2;
            this.TextBox_Average_InterarrivalTime.Text = "2";
            // 
            // TextBox_NumberOfJobs
            // 
            this.TextBox_NumberOfJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_NumberOfJobs.Location = new System.Drawing.Point(251, 18);
            this.TextBox_NumberOfJobs.Name = "TextBox_NumberOfJobs";
            this.TextBox_NumberOfJobs.Size = new System.Drawing.Size(100, 22);
            this.TextBox_NumberOfJobs.TabIndex = 1;
            this.TextBox_NumberOfJobs.Text = "1000";
            // 
            // Buttom_Simulate_Stochastic
            // 
            this.Buttom_Simulate_Stochastic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buttom_Simulate_Stochastic.Location = new System.Drawing.Point(3, 385);
            this.Buttom_Simulate_Stochastic.Name = "Buttom_Simulate_Stochastic";
            this.Buttom_Simulate_Stochastic.Size = new System.Drawing.Size(364, 80);
            this.Buttom_Simulate_Stochastic.TabIndex = 0;
            this.Buttom_Simulate_Stochastic.Text = "Simulat Stochastic Case";
            this.Buttom_Simulate_Stochastic.UseVisualStyleBackColor = true;
            this.Buttom_Simulate_Stochastic.Click += new System.EventHandler(this.Buttom_Simulate_Stochastic_Click);
            // 
            // SIS
            // 
            this.SIS.Controls.Add(this.CheckBox_DeliveryLag);
            this.SIS.Controls.Add(this.TextBox_ShoCost);
            this.SIS.Controls.Add(this.TextBox_HolCost);
            this.SIS.Controls.Add(this.TextBox_SetCost);
            this.SIS.Controls.Add(this.TextBox_MinLevel);
            this.SIS.Controls.Add(this.TextBox_MaxLevel);
            this.SIS.Controls.Add(this.label1);
            this.SIS.Controls.Add(this.TextBox_Demand_UBound);
            this.SIS.Controls.Add(this.TextBox_Demand_LBound);
            this.SIS.Controls.Add(this.TextBox_NumberOfIntervals);
            this.SIS.Controls.Add(this.Button_SIS_Simulate);
            this.SIS.Location = new System.Drawing.Point(4, 22);
            this.SIS.Name = "SIS";
            this.SIS.Padding = new System.Windows.Forms.Padding(3);
            this.SIS.Size = new System.Drawing.Size(370, 639);
            this.SIS.TabIndex = 0;
            this.SIS.Text = "SIS with Delivery Lag";
            this.SIS.UseVisualStyleBackColor = true;
            // 
            // CheckBox_DeliveryLag
            // 
            this.CheckBox_DeliveryLag.AutoSize = true;
            this.CheckBox_DeliveryLag.Location = new System.Drawing.Point(21, 387);
            this.CheckBox_DeliveryLag.Name = "CheckBox_DeliveryLag";
            this.CheckBox_DeliveryLag.Size = new System.Drawing.Size(111, 16);
            this.CheckBox_DeliveryLag.TabIndex = 25;
            this.CheckBox_DeliveryLag.Text = "With Delivery Lag";
            this.CheckBox_DeliveryLag.UseVisualStyleBackColor = true;
            // 
            // TextBox_ShoCost
            // 
            this.TextBox_ShoCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_ShoCost.Location = new System.Drawing.Point(251, 343);
            this.TextBox_ShoCost.Name = "TextBox_ShoCost";
            this.TextBox_ShoCost.Size = new System.Drawing.Size(100, 22);
            this.TextBox_ShoCost.TabIndex = 24;
            this.TextBox_ShoCost.Text = "700";
            // 
            // TextBox_HolCost
            // 
            this.TextBox_HolCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_HolCost.Location = new System.Drawing.Point(251, 315);
            this.TextBox_HolCost.Name = "TextBox_HolCost";
            this.TextBox_HolCost.Size = new System.Drawing.Size(100, 22);
            this.TextBox_HolCost.TabIndex = 23;
            this.TextBox_HolCost.Text = "25";
            // 
            // TextBox_SetCost
            // 
            this.TextBox_SetCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_SetCost.Location = new System.Drawing.Point(251, 287);
            this.TextBox_SetCost.Name = "TextBox_SetCost";
            this.TextBox_SetCost.Size = new System.Drawing.Size(100, 22);
            this.TextBox_SetCost.TabIndex = 22;
            this.TextBox_SetCost.Text = "1000";
            // 
            // TextBox_MinLevel
            // 
            this.TextBox_MinLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_MinLevel.Location = new System.Drawing.Point(251, 214);
            this.TextBox_MinLevel.Name = "TextBox_MinLevel";
            this.TextBox_MinLevel.Size = new System.Drawing.Size(100, 22);
            this.TextBox_MinLevel.TabIndex = 21;
            this.TextBox_MinLevel.Text = "20";
            // 
            // TextBox_MaxLevel
            // 
            this.TextBox_MaxLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_MaxLevel.Location = new System.Drawing.Point(251, 186);
            this.TextBox_MaxLevel.Name = "TextBox_MaxLevel";
            this.TextBox_MaxLevel.Size = new System.Drawing.Size(100, 22);
            this.TextBox_MaxLevel.TabIndex = 20;
            this.TextBox_MaxLevel.Text = "80";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 352);
            this.label1.TabIndex = 17;
            this.label1.Text = "Number of Intervals:\r\n\r\n\r\n\r\nDemand~\r\n(Uniform Distribution)\r\n     Lower Bound:\r\n " +
    "    Upper Bound:\r\n\r\n\r\n\r\nMaximal Level:\r\n\r\nMinimal Level:\r\n\r\n\r\n\r\nSetup Cost:\r\n\r\nH" +
    "olding Cost:\r\n\r\nShortage Cosst:";
            // 
            // TextBox_Demand_UBound
            // 
            this.TextBox_Demand_UBound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Demand_UBound.Location = new System.Drawing.Point(251, 130);
            this.TextBox_Demand_UBound.Name = "TextBox_Demand_UBound";
            this.TextBox_Demand_UBound.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Demand_UBound.TabIndex = 16;
            this.TextBox_Demand_UBound.Text = "50";
            // 
            // TextBox_Demand_LBound
            // 
            this.TextBox_Demand_LBound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Demand_LBound.Location = new System.Drawing.Point(251, 102);
            this.TextBox_Demand_LBound.Name = "TextBox_Demand_LBound";
            this.TextBox_Demand_LBound.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Demand_LBound.TabIndex = 15;
            this.TextBox_Demand_LBound.Text = "10";
            // 
            // TextBox_NumberOfIntervals
            // 
            this.TextBox_NumberOfIntervals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_NumberOfIntervals.Location = new System.Drawing.Point(251, 14);
            this.TextBox_NumberOfIntervals.Name = "TextBox_NumberOfIntervals";
            this.TextBox_NumberOfIntervals.Size = new System.Drawing.Size(100, 22);
            this.TextBox_NumberOfIntervals.TabIndex = 13;
            this.TextBox_NumberOfIntervals.Text = "10";
            // 
            // Button_SIS_Simulate
            // 
            this.Button_SIS_Simulate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_SIS_Simulate.Location = new System.Drawing.Point(3, 467);
            this.Button_SIS_Simulate.Name = "Button_SIS_Simulate";
            this.Button_SIS_Simulate.Size = new System.Drawing.Size(364, 80);
            this.Button_SIS_Simulate.TabIndex = 12;
            this.Button_SIS_Simulate.Text = "Simulat Stochastic Case";
            this.Button_SIS_Simulate.UseVisualStyleBackColor = true;
            this.Button_SIS_Simulate.Click += new System.EventHandler(this.Button_SIS_Simulate_Click);
            // 
            // TabControl_Chart
            // 
            this.TabControl_Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl_Chart.Controls.Add(this.TabPage_Processing);
            this.TabControl_Chart.Location = new System.Drawing.Point(3, 3);
            this.TabControl_Chart.Name = "TabControl_Chart";
            this.TabControl_Chart.SelectedIndex = 0;
            this.TabControl_Chart.Size = new System.Drawing.Size(781, 665);
            this.TabControl_Chart.TabIndex = 4;
            // 
            // TabPage_Processing
            // 
            this.TabPage_Processing.Controls.Add(this.RichTextBox_result);
            this.TabPage_Processing.Controls.Add(this.CheckBox_ServerStatus);
            this.TabPage_Processing.Controls.Add(this.CheckBox_JobQueue);
            this.TabPage_Processing.Controls.Add(this.CheckBox_JocCount);
            this.TabPage_Processing.Controls.Add(this.MainChart);
            this.TabPage_Processing.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Processing.Name = "TabPage_Processing";
            this.TabPage_Processing.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Processing.Size = new System.Drawing.Size(773, 639);
            this.TabPage_Processing.TabIndex = 0;
            this.TabPage_Processing.Text = "Simulate Job Processing";
            this.TabPage_Processing.UseVisualStyleBackColor = true;
            // 
            // RichTextBox_result
            // 
            this.RichTextBox_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox_result.Location = new System.Drawing.Point(6, 6);
            this.RichTextBox_result.Name = "RichTextBox_result";
            this.RichTextBox_result.Size = new System.Drawing.Size(761, 174);
            this.RichTextBox_result.TabIndex = 15;
            this.RichTextBox_result.Text = "";
            this.RichTextBox_result.TextChanged += new System.EventHandler(this.RichTextBox_result_TextChanged);
            // 
            // CheckBox_ServerStatus
            // 
            this.CheckBox_ServerStatus.AutoSize = true;
            this.CheckBox_ServerStatus.Checked = true;
            this.CheckBox_ServerStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_ServerStatus.Location = new System.Drawing.Point(210, 186);
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
            this.CheckBox_JobQueue.Location = new System.Drawing.Point(110, 186);
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
            this.CheckBox_JocCount.Location = new System.Drawing.Point(10, 186);
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
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Interval = 0D;
            chartArea1.AxisX.LineColor = System.Drawing.SystemColors.GrayText;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.Title = "Job Count";
            chartArea1.BorderColor = System.Drawing.Color.Silver;
            chartArea1.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea1);
            this.MainChart.Location = new System.Drawing.Point(15, 208);
            this.MainChart.Name = "MainChart";
            this.MainChart.Size = new System.Drawing.Size(752, 422);
            this.MainChart.TabIndex = 4;
            this.MainChart.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.TopToolStrip);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.TopMenuStrip);
            this.Controls.Add(this.DownMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.TopMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "r09546042_TerryYang_assignment_06";
            this.TopToolStrip.ResumeLayout(false);
            this.TopToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TabControl_Data.ResumeLayout(false);
            this.SSQ.ResumeLayout(false);
            this.SSQ.PerformLayout();
            this.SIS.ResumeLayout(false);
            this.SIS.PerformLayout();
            this.TabControl_Chart.ResumeLayout(false);
            this.TabPage_Processing.ResumeLayout(false);
            this.TabPage_Processing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenuStrip;
        private System.Windows.Forms.ToolStrip TopToolStrip;
        private System.Windows.Forms.MenuStrip DownMenuStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl TabControl_Data;
        private System.Windows.Forms.TabPage SIS;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.TabControl TabControl_Chart;
        private System.Windows.Forms.TabPage SSQ;
        private System.Windows.Forms.Label Label_Number_of_Jobs;
        private System.Windows.Forms.TextBox TextBox_UpperBound;
        private System.Windows.Forms.TextBox TextBox_LowerBound;
        private System.Windows.Forms.TextBox TextBox_Average_InterarrivalTime;
        private System.Windows.Forms.TextBox TextBox_NumberOfJobs;
        private System.Windows.Forms.Button Buttom_Simulate_Stochastic;
        private System.Windows.Forms.TabPage TabPage_Processing;
        private System.Windows.Forms.RichTextBox RichTextBox_result;
        private System.Windows.Forms.CheckBox CheckBox_ServerStatus;
        private System.Windows.Forms.CheckBox CheckBox_JobQueue;
        private System.Windows.Forms.CheckBox CheckBox_JocCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.TextBox TextBox_feedback_ratio;
        private System.Windows.Forms.TextBox TextBox_ShoCost;
        private System.Windows.Forms.TextBox TextBox_HolCost;
        private System.Windows.Forms.TextBox TextBox_SetCost;
        private System.Windows.Forms.TextBox TextBox_MinLevel;
        private System.Windows.Forms.TextBox TextBox_MaxLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBox_Demand_UBound;
        private System.Windows.Forms.TextBox TextBox_Demand_LBound;
        private System.Windows.Forms.TextBox TextBox_NumberOfIntervals;
        private System.Windows.Forms.Button Button_SIS_Simulate;
        private System.Windows.Forms.CheckBox CheckBox_DeliveryLag;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox ToolStripComboBox_Seed;
    }
}

