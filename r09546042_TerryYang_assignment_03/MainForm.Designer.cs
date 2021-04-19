
namespace r09546042_TerryYang_assignment_03
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.TopToolStrip = new System.Windows.Forms.ToolStrip();
            this.TOS_BTN_open = new System.Windows.Forms.ToolStripButton();
            this.DownMenuStrip = new System.Windows.Forms.MenuStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LB_FliCon = new System.Windows.Forms.Label();
            this.LB_FilNam = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TB_ShoCost = new System.Windows.Forms.TextBox();
            this.TB_HolCost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TB_OrdSetCost = new System.Windows.Forms.TextBox();
            this.TB_IteCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BTN_save = new System.Windows.Forms.Button();
            this.BTN_Creat = new System.Windows.Forms.Button();
            this.TB_DemVar = new System.Windows.Forms.TextBox();
            this.TB_AvgDem = new System.Windows.Forms.TextBox();
            this.TB_NumOfInt = new System.Windows.Forms.TextBox();
            this.TB_MaxInvLev = new System.Windows.Forms.TextBox();
            this.TB_MinInvLev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LB_TimAvgShortage = new System.Windows.Forms.Label();
            this.LB_TimAvgHolding = new System.Windows.Forms.Label();
            this.LB_AvgOrd = new System.Windows.Forms.Label();
            this.LB_AvgDem = new System.Windows.Forms.Label();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BTN_ShowPlot = new System.Windows.Forms.Button();
            this.BTN_ResetPlot = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.BTN_simulate = new System.Windows.Forms.Button();
            this.LB_OptRe = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Chart_simulation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TopToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
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
            this.TOS_BTN_open});
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
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1161, 475);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(371, 469);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LB_FliCon);
            this.tabPage1.Controls.Add(this.LB_FilNam);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(363, 443);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Current Problem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LB_FliCon
            // 
            this.LB_FliCon.AutoSize = true;
            this.LB_FliCon.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_FliCon.Location = new System.Drawing.Point(6, 47);
            this.LB_FliCon.Name = "LB_FliCon";
            this.LB_FliCon.Size = new System.Drawing.Size(109, 19);
            this.LB_FliCon.TabIndex = 2;
            this.LB_FliCon.Text = "File Content: ";
            // 
            // LB_FilNam
            // 
            this.LB_FilNam.AutoSize = true;
            this.LB_FilNam.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_FilNam.Location = new System.Drawing.Point(6, 14);
            this.LB_FilNam.Name = "LB_FilNam";
            this.LB_FilNam.Size = new System.Drawing.Size(0, 19);
            this.LB_FilNam.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BulletIndent = 5;
            this.richTextBox1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(351, 365);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TB_ShoCost);
            this.tabPage2.Controls.Add(this.TB_HolCost);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.TB_OrdSetCost);
            this.tabPage2.Controls.Add(this.TB_IteCost);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.BTN_save);
            this.tabPage2.Controls.Add(this.BTN_Creat);
            this.tabPage2.Controls.Add(this.TB_DemVar);
            this.tabPage2.Controls.Add(this.TB_AvgDem);
            this.tabPage2.Controls.Add(this.TB_NumOfInt);
            this.tabPage2.Controls.Add(this.TB_MaxInvLev);
            this.tabPage2.Controls.Add(this.TB_MinInvLev);
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
            // TB_ShoCost
            // 
            this.TB_ShoCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_ShoCost.Location = new System.Drawing.Point(253, 302);
            this.TB_ShoCost.Name = "TB_ShoCost";
            this.TB_ShoCost.Size = new System.Drawing.Size(99, 22);
            this.TB_ShoCost.TabIndex = 19;
            this.TB_ShoCost.Text = "700";
            // 
            // TB_HolCost
            // 
            this.TB_HolCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_HolCost.Location = new System.Drawing.Point(253, 272);
            this.TB_HolCost.Name = "TB_HolCost";
            this.TB_HolCost.Size = new System.Drawing.Size(99, 22);
            this.TB_HolCost.TabIndex = 18;
            this.TB_HolCost.Text = "25";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "Shortage Cost";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "Holding Cost";
            // 
            // TB_OrdSetCost
            // 
            this.TB_OrdSetCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_OrdSetCost.Location = new System.Drawing.Point(253, 244);
            this.TB_OrdSetCost.Name = "TB_OrdSetCost";
            this.TB_OrdSetCost.Size = new System.Drawing.Size(99, 22);
            this.TB_OrdSetCost.TabIndex = 15;
            this.TB_OrdSetCost.Text = "1000";
            // 
            // TB_IteCost
            // 
            this.TB_IteCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_IteCost.Location = new System.Drawing.Point(253, 214);
            this.TB_IteCost.Name = "TB_IteCost";
            this.TB_IteCost.Size = new System.Drawing.Size(99, 22);
            this.TB_IteCost.TabIndex = 14;
            this.TB_IteCost.Text = "8000";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "Order Setup Cost";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Item Cost";
            // 
            // BTN_save
            // 
            this.BTN_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_save.Enabled = false;
            this.BTN_save.Location = new System.Drawing.Point(12, 391);
            this.BTN_save.Name = "BTN_save";
            this.BTN_save.Size = new System.Drawing.Size(341, 40);
            this.BTN_save.TabIndex = 11;
            this.BTN_save.Text = "Save Data";
            this.BTN_save.UseVisualStyleBackColor = true;
            this.BTN_save.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTN_Creat
            // 
            this.BTN_Creat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_Creat.Location = new System.Drawing.Point(12, 345);
            this.BTN_Creat.Name = "BTN_Creat";
            this.BTN_Creat.Size = new System.Drawing.Size(341, 40);
            this.BTN_Creat.TabIndex = 10;
            this.BTN_Creat.Text = "Creat Data";
            this.BTN_Creat.UseVisualStyleBackColor = true;
            this.BTN_Creat.Click += new System.EventHandler(this.button3_Click);
            // 
            // TB_DemVar
            // 
            this.TB_DemVar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_DemVar.Location = new System.Drawing.Point(296, 148);
            this.TB_DemVar.Name = "TB_DemVar";
            this.TB_DemVar.Size = new System.Drawing.Size(56, 22);
            this.TB_DemVar.TabIndex = 9;
            this.TB_DemVar.Text = "12";
            // 
            // TB_AvgDem
            // 
            this.TB_AvgDem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_AvgDem.Location = new System.Drawing.Point(296, 118);
            this.TB_AvgDem.Name = "TB_AvgDem";
            this.TB_AvgDem.Size = new System.Drawing.Size(56, 22);
            this.TB_AvgDem.TabIndex = 8;
            this.TB_AvgDem.Text = "25";
            // 
            // TB_NumOfInt
            // 
            this.TB_NumOfInt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_NumOfInt.Location = new System.Drawing.Point(296, 90);
            this.TB_NumOfInt.Name = "TB_NumOfInt";
            this.TB_NumOfInt.Size = new System.Drawing.Size(56, 22);
            this.TB_NumOfInt.TabIndex = 7;
            this.TB_NumOfInt.Text = "12";
            // 
            // TB_MaxInvLev
            // 
            this.TB_MaxInvLev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_MaxInvLev.Location = new System.Drawing.Point(296, 60);
            this.TB_MaxInvLev.Name = "TB_MaxInvLev";
            this.TB_MaxInvLev.Size = new System.Drawing.Size(56, 22);
            this.TB_MaxInvLev.TabIndex = 6;
            this.TB_MaxInvLev.Text = "60";
            // 
            // TB_MinInvLev
            // 
            this.TB_MinInvLev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_MinInvLev.Location = new System.Drawing.Point(296, 30);
            this.TB_MinInvLev.Name = "TB_MinInvLev";
            this.TB_MinInvLev.Size = new System.Drawing.Size(56, 22);
            this.TB_MinInvLev.TabIndex = 5;
            this.TB_MinInvLev.Text = "20";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "Demand Variance";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Average Demand";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numbers of Intervals";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Maximum Inventory Level";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mimimum Inventory Level";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(765, 469);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LB_TimAvgShortage);
            this.tabPage3.Controls.Add(this.LB_TimAvgHolding);
            this.tabPage3.Controls.Add(this.LB_AvgOrd);
            this.tabPage3.Controls.Add(this.LB_AvgDem);
            this.tabPage3.Controls.Add(this.MainChart);
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
            // LB_TimAvgShortage
            // 
            this.LB_TimAvgShortage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_TimAvgShortage.AutoSize = true;
            this.LB_TimAvgShortage.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_TimAvgShortage.ForeColor = System.Drawing.Color.Crimson;
            this.LB_TimAvgShortage.Location = new System.Drawing.Point(493, 100);
            this.LB_TimAvgShortage.Name = "LB_TimAvgShortage";
            this.LB_TimAvgShortage.Size = new System.Drawing.Size(200, 16);
            this.LB_TimAvgShortage.TabIndex = 14;
            this.LB_TimAvgShortage.Text = "Time-Average Shortage Level:";
            this.LB_TimAvgShortage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LB_TimAvgHolding
            // 
            this.LB_TimAvgHolding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_TimAvgHolding.AutoSize = true;
            this.LB_TimAvgHolding.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_TimAvgHolding.ForeColor = System.Drawing.Color.Crimson;
            this.LB_TimAvgHolding.Location = new System.Drawing.Point(493, 80);
            this.LB_TimAvgHolding.Name = "LB_TimAvgHolding";
            this.LB_TimAvgHolding.Size = new System.Drawing.Size(196, 16);
            this.LB_TimAvgHolding.TabIndex = 13;
            this.LB_TimAvgHolding.Text = "Time-Average Holding Level:";
            this.LB_TimAvgHolding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LB_AvgOrd
            // 
            this.LB_AvgOrd.AutoSize = true;
            this.LB_AvgOrd.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_AvgOrd.ForeColor = System.Drawing.Color.DarkBlue;
            this.LB_AvgOrd.Location = new System.Drawing.Point(15, 100);
            this.LB_AvgOrd.Name = "LB_AvgOrd";
            this.LB_AvgOrd.Size = new System.Drawing.Size(105, 16);
            this.LB_AvgOrd.TabIndex = 12;
            this.LB_AvgOrd.Text = "Average Order:";
            this.LB_AvgOrd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LB_AvgDem
            // 
            this.LB_AvgDem.AutoSize = true;
            this.LB_AvgDem.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_AvgDem.ForeColor = System.Drawing.Color.DarkBlue;
            this.LB_AvgDem.Location = new System.Drawing.Point(15, 80);
            this.LB_AvgDem.Name = "LB_AvgDem";
            this.LB_AvgDem.Size = new System.Drawing.Size(122, 16);
            this.LB_AvgDem.TabIndex = 11;
            this.LB_AvgDem.Text = "Average Demand:";
            this.LB_AvgDem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainChart
            // 
            this.MainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.IsMarksNextToAxis = false;
            chartArea3.AxisX.LabelStyle.Interval = 0D;
            chartArea3.AxisX.LineColor = System.Drawing.SystemColors.GrayText;
            chartArea3.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisX.LineWidth = 0;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.MinorGrid.Enabled = true;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisX.Title = "Period";
            chartArea3.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisY.MinorGrid.Enabled = true;
            chartArea3.AxisY.MinorGrid.Interval = 20D;
            chartArea3.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisY.Title = "Inventory Level";
            chartArea3.BorderColor = System.Drawing.Color.Silver;
            chartArea3.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea3);
            this.MainChart.Location = new System.Drawing.Point(15, 159);
            this.MainChart.Name = "MainChart";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.MainChart.Series.Add(series2);
            this.MainChart.Size = new System.Drawing.Size(736, 275);
            this.MainChart.TabIndex = 4;
            this.MainChart.Text = "chart1";
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
            this.tabPage4.Controls.Add(this.LB_OptRe);
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
            this.BTN_simulate.Location = new System.Drawing.Point(591, 29);
            this.BTN_simulate.Name = "BTN_simulate";
            this.BTN_simulate.Size = new System.Drawing.Size(146, 49);
            this.BTN_simulate.TabIndex = 7;
            this.BTN_simulate.Text = "Find Optimum";
            this.BTN_simulate.UseVisualStyleBackColor = true;
            this.BTN_simulate.Click += new System.EventHandler(this.BTN_simulate_Click);
            // 
            // LB_OptRe
            // 
            this.LB_OptRe.AutoSize = true;
            this.LB_OptRe.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LB_OptRe.Location = new System.Drawing.Point(23, 64);
            this.LB_OptRe.Name = "LB_OptRe";
            this.LB_OptRe.Size = new System.Drawing.Size(142, 16);
            this.LB_OptRe.TabIndex = 5;
            this.LB_OptRe.Text = "Optimization Results:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(23, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(449, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Optimization Simulation for Minimal Level from 0 to Maximal level -1";
            // 
            // Chart_simulation
            // 
            this.Chart_simulation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.AxisX.IntervalOffset = 1D;
            chartArea4.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisX.Minimum = -1D;
            chartArea4.AxisX.Title = "Minimum Level (s)";
            chartArea4.AxisX2.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisX2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisY.Title = "Cost";
            chartArea4.AxisY2.LineColor = System.Drawing.Color.Silver;
            chartArea4.AxisY2.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.BorderColor = System.Drawing.Color.Silver;
            chartArea4.Name = "ChartArea1";
            this.Chart_simulation.ChartAreas.Add(chartArea4);
            this.Chart_simulation.Location = new System.Drawing.Point(6, 137);
            this.Chart_simulation.Name = "Chart_simulation";
            this.Chart_simulation.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
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
            this.Text = "r09546042_TerryYang_assignment_03";
            this.TopToolStrip.ResumeLayout(false);
            this.TopToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BTN_ShowPlot;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button BTN_ResetPlot;
        private System.Windows.Forms.Button BTN_save;
        private System.Windows.Forms.Button BTN_Creat;
        private System.Windows.Forms.TextBox TB_DemVar;
        private System.Windows.Forms.TextBox TB_AvgDem;
        private System.Windows.Forms.TextBox TB_NumOfInt;
        private System.Windows.Forms.TextBox TB_MaxInvLev;
        private System.Windows.Forms.TextBox TB_MinInvLev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label LB_TimAvgShortage;
        private System.Windows.Forms.Label LB_TimAvgHolding;
        private System.Windows.Forms.Label LB_AvgOrd;
        private System.Windows.Forms.Label LB_AvgDem;
        private System.Windows.Forms.Button BTN_simulate;
        private System.Windows.Forms.Label LB_OptRe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_simulation;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox TB_ShoCost;
        private System.Windows.Forms.TextBox TB_HolCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TB_OrdSetCost;
        private System.Windows.Forms.TextBox TB_IteCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LB_FliCon;
        private System.Windows.Forms.Label LB_FilNam;
    }
}

