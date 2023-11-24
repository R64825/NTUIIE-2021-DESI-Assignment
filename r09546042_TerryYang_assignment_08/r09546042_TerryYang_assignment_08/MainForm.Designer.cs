
namespace r09546042_TerryYang_assignment_08
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.RBTN_Queue = new System.Windows.Forms.RadioButton();
            this.RBTN_Server = new System.Windows.Forms.RadioButton();
            this.RBTN_Client = new System.Windows.Forms.RadioButton();
            this.BTN_Run_End = new System.Windows.Forms.Button();
            this.BTN_Run_One = new System.Windows.Forms.Button();
            this.BTN_Reset = new System.Windows.Forms.Button();
            this.BTN_Creat_SSQ_Model = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.RTB_Process = new System.Windows.Forms.RichTextBox();
            this.Pie_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TP_Server_And_Queue = new System.Windows.Forms.TabPage();
            this.Gantt_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TP_Clients = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pie_Chart)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TP_Server_And_Queue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gantt_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(940, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PropertyGrid);
            this.splitContainer1.Panel1.Controls.Add(this.RBTN_Queue);
            this.splitContainer1.Panel1.Controls.Add(this.RBTN_Server);
            this.splitContainer1.Panel1.Controls.Add(this.RBTN_Client);
            this.splitContainer1.Panel1.Controls.Add(this.BTN_Run_End);
            this.splitContainer1.Panel1.Controls.Add(this.BTN_Run_One);
            this.splitContainer1.Panel1.Controls.Add(this.BTN_Reset);
            this.splitContainer1.Panel1.Controls.Add(this.BTN_Creat_SSQ_Model);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(940, 514);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 1;
            // 
            // PropertyGrid
            // 
            this.PropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PropertyGrid.Location = new System.Drawing.Point(12, 253);
            this.PropertyGrid.Name = "PropertyGrid";
            this.PropertyGrid.Size = new System.Drawing.Size(239, 249);
            this.PropertyGrid.TabIndex = 7;
            // 
            // RBTN_Queue
            // 
            this.RBTN_Queue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RBTN_Queue.AutoSize = true;
            this.RBTN_Queue.Location = new System.Drawing.Point(12, 231);
            this.RBTN_Queue.Name = "RBTN_Queue";
            this.RBTN_Queue.Size = new System.Drawing.Size(53, 16);
            this.RBTN_Queue.TabIndex = 6;
            this.RBTN_Queue.TabStop = true;
            this.RBTN_Queue.Text = "Queue";
            this.RBTN_Queue.UseVisualStyleBackColor = true;
            this.RBTN_Queue.CheckedChanged += new System.EventHandler(this.RBTN_Queue_CheckedChanged);
            // 
            // RBTN_Server
            // 
            this.RBTN_Server.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RBTN_Server.AutoSize = true;
            this.RBTN_Server.Location = new System.Drawing.Point(13, 208);
            this.RBTN_Server.Name = "RBTN_Server";
            this.RBTN_Server.Size = new System.Drawing.Size(53, 16);
            this.RBTN_Server.TabIndex = 5;
            this.RBTN_Server.TabStop = true;
            this.RBTN_Server.Text = "Server";
            this.RBTN_Server.UseVisualStyleBackColor = true;
            this.RBTN_Server.CheckedChanged += new System.EventHandler(this.RBTN_Server_CheckedChanged);
            // 
            // RBTN_Client
            // 
            this.RBTN_Client.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RBTN_Client.AutoSize = true;
            this.RBTN_Client.Location = new System.Drawing.Point(13, 185);
            this.RBTN_Client.Name = "RBTN_Client";
            this.RBTN_Client.Size = new System.Drawing.Size(100, 16);
            this.RBTN_Client.TabIndex = 4;
            this.RBTN_Client.TabStop = true;
            this.RBTN_Client.Text = "Client Generator";
            this.RBTN_Client.UseVisualStyleBackColor = true;
            this.RBTN_Client.CheckedChanged += new System.EventHandler(this.RBTN_Client_CheckedChanged);
            // 
            // BTN_Run_End
            // 
            this.BTN_Run_End.Enabled = false;
            this.BTN_Run_End.Location = new System.Drawing.Point(13, 124);
            this.BTN_Run_End.Name = "BTN_Run_End";
            this.BTN_Run_End.Size = new System.Drawing.Size(225, 55);
            this.BTN_Run_End.TabIndex = 3;
            this.BTN_Run_End.Text = "Run to end";
            this.BTN_Run_End.UseVisualStyleBackColor = true;
            this.BTN_Run_End.Click += new System.EventHandler(this.BTN_Run_End_Click);
            // 
            // BTN_Run_One
            // 
            this.BTN_Run_One.Enabled = false;
            this.BTN_Run_One.Location = new System.Drawing.Point(13, 65);
            this.BTN_Run_One.Name = "BTN_Run_One";
            this.BTN_Run_One.Size = new System.Drawing.Size(225, 52);
            this.BTN_Run_One.TabIndex = 2;
            this.BTN_Run_One.Text = "Run one event";
            this.BTN_Run_One.UseVisualStyleBackColor = true;
            this.BTN_Run_One.Click += new System.EventHandler(this.BTN_Run_One_Click);
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.Enabled = false;
            this.BTN_Reset.Location = new System.Drawing.Point(172, 3);
            this.BTN_Reset.Name = "BTN_Reset";
            this.BTN_Reset.Size = new System.Drawing.Size(66, 55);
            this.BTN_Reset.TabIndex = 1;
            this.BTN_Reset.Text = "Reset";
            this.BTN_Reset.UseVisualStyleBackColor = true;
            this.BTN_Reset.Click += new System.EventHandler(this.BTN_Reset_Click);
            // 
            // BTN_Creat_SSQ_Model
            // 
            this.BTN_Creat_SSQ_Model.Location = new System.Drawing.Point(12, 3);
            this.BTN_Creat_SSQ_Model.Name = "BTN_Creat_SSQ_Model";
            this.BTN_Creat_SSQ_Model.Size = new System.Drawing.Size(154, 55);
            this.BTN_Creat_SSQ_Model.TabIndex = 0;
            this.BTN_Creat_SSQ_Model.Text = "Create a SSQ model";
            this.BTN_Creat_SSQ_Model.UseVisualStyleBackColor = true;
            this.BTN_Creat_SSQ_Model.Click += new System.EventHandler(this.BTN_Creat_SSQ_Model_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.TabControl);
            this.splitContainer2.Size = new System.Drawing.Size(682, 514);
            this.splitContainer2.SplitterDistance = 177;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.RTB_Process);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.Pie_Chart);
            this.splitContainer3.Size = new System.Drawing.Size(682, 177);
            this.splitContainer3.SplitterDistance = 448;
            this.splitContainer3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Event List:";
            // 
            // RTB_Process
            // 
            this.RTB_Process.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Process.Location = new System.Drawing.Point(4, 21);
            this.RTB_Process.Name = "RTB_Process";
            this.RTB_Process.Size = new System.Drawing.Size(441, 153);
            this.RTB_Process.TabIndex = 0;
            this.RTB_Process.Text = "";
            // 
            // Pie_Chart
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.Pie_Chart.ChartAreas.Add(chartArea1);
            this.Pie_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pie_Chart.Location = new System.Drawing.Point(0, 0);
            this.Pie_Chart.Name = "Pie_Chart";
            this.Pie_Chart.Size = new System.Drawing.Size(230, 177);
            this.Pie_Chart.TabIndex = 1;
            this.Pie_Chart.Text = "chart1";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TP_Server_And_Queue);
            this.TabControl.Controls.Add(this.TP_Clients);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(682, 333);
            this.TabControl.TabIndex = 0;
            // 
            // TP_Server_And_Queue
            // 
            this.TP_Server_And_Queue.Controls.Add(this.Gantt_Chart);
            this.TP_Server_And_Queue.Location = new System.Drawing.Point(4, 22);
            this.TP_Server_And_Queue.Name = "TP_Server_And_Queue";
            this.TP_Server_And_Queue.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Server_And_Queue.Size = new System.Drawing.Size(674, 307);
            this.TP_Server_And_Queue.TabIndex = 0;
            this.TP_Server_And_Queue.Text = "Server and Queue";
            this.TP_Server_And_Queue.UseVisualStyleBackColor = true;
            // 
            // Gantt_Chart
            // 
            chartArea2.Name = "ChartArea1";
            chartArea3.Name = "ChartArea2";
            this.Gantt_Chart.ChartAreas.Add(chartArea2);
            this.Gantt_Chart.ChartAreas.Add(chartArea3);
            this.Gantt_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gantt_Chart.Location = new System.Drawing.Point(3, 3);
            this.Gantt_Chart.Name = "Gantt_Chart";
            this.Gantt_Chart.Size = new System.Drawing.Size(668, 301);
            this.Gantt_Chart.TabIndex = 0;
            this.Gantt_Chart.Text = "chart1";
            this.Gantt_Chart.AxisViewChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ViewEventArgs>(this.Gantt_Chart_AxisViewChanged);
            // 
            // TP_Clients
            // 
            this.TP_Clients.Location = new System.Drawing.Point(4, 22);
            this.TP_Clients.Name = "TP_Clients";
            this.TP_Clients.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Clients.Size = new System.Drawing.Size(674, 307);
            this.TP_Clients.TabIndex = 1;
            this.TP_Clients.Text = "Clients";
            this.TP_Clients.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 539);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment_08";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pie_Chart)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TP_Server_And_Queue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gantt_Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PropertyGrid PropertyGrid;
        private System.Windows.Forms.RadioButton RBTN_Queue;
        private System.Windows.Forms.RadioButton RBTN_Server;
        private System.Windows.Forms.RadioButton RBTN_Client;
        private System.Windows.Forms.Button BTN_Run_End;
        private System.Windows.Forms.Button BTN_Run_One;
        private System.Windows.Forms.Button BTN_Reset;
        private System.Windows.Forms.Button BTN_Creat_SSQ_Model;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox RTB_Process;
        private System.Windows.Forms.DataVisualization.Charting.Chart Pie_Chart;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TP_Server_And_Queue;
        private System.Windows.Forms.TabPage TP_Clients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataVisualization.Charting.Chart Gantt_Chart;
    }
}

