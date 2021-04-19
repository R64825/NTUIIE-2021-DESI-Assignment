
namespace r09546042_TerryYang_assignment_04
{
    partial class Main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.Tool_Strip = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ComboBox_Seed = new System.Windows.Forms.ComboBox();
            this.Label_Seed = new System.Windows.Forms.Label();
            this.TextBox_Replications = new System.Windows.Forms.TextBox();
            this.Label_Replications = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Random_Matrix = new System.Windows.Forms.TabPage();
            this.RM_RichTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.RM_Button_Clear = new System.Windows.Forms.Button();
            this.RM_Button_Simulate = new System.Windows.Forms.Button();
            this.RM_RichTextBox_Info = new System.Windows.Forms.RichTextBox();
            this.Gambling_Craps = new System.Windows.Forms.TabPage();
            this.GC_Button_Clear = new System.Windows.Forms.Button();
            this.GC_Button_Simulate = new System.Windows.Forms.Button();
            this.GC_RichTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.GC_Label_Info = new System.Windows.Forms.Label();
            this.Hatcheck_Girl = new System.Windows.Forms.TabPage();
            this.HG_TextBox_NumberOfCustomers = new System.Windows.Forms.TextBox();
            this.HG_Button_Clear = new System.Windows.Forms.Button();
            this.HG_Button_Simulate = new System.Windows.Forms.Button();
            this.HG_RichTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.HG_Label_Info = new System.Windows.Forms.Label();
            this.Stochastic_Activity_Networks = new System.Windows.Forms.TabPage();
            this.Panel_nodes = new System.Windows.Forms.Panel();
            this.ToolStrip_creat = new System.Windows.Forms.ToolStrip();
            this.ToolStrip_creat_normal_cursor = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip_creat_nodes = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip_creat_paths = new System.Windows.Forms.ToolStripButton();
            this.RichTextBox_result = new System.Windows.Forms.RichTextBox();
            this.SAN_Button_Simulate = new System.Windows.Forms.Button();
            this.Label_SAN_Info = new System.Windows.Forms.Label();
            this.TabControl_minor = new System.Windows.Forms.TabControl();
            this.Open_benchmark = new System.Windows.Forms.TabPage();
            this.RichTextBox_Benchmark = new System.Windows.Forms.RichTextBox();
            this.Label_file_content = new System.Windows.Forms.Label();
            this.Label_read_file = new System.Windows.Forms.Label();
            this.Button_Open = new System.Windows.Forms.Button();
            this.Creat_benchmark = new System.Windows.Forms.TabPage();
            this.Button_Clear_Data = new System.Windows.Forms.Button();
            this.Button_save = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.HG_Label_Number_of_customers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.Random_Matrix.SuspendLayout();
            this.Gambling_Craps.SuspendLayout();
            this.Hatcheck_Girl.SuspendLayout();
            this.Stochastic_Activity_Networks.SuspendLayout();
            this.Panel_nodes.SuspendLayout();
            this.ToolStrip_creat.SuspendLayout();
            this.TabControl_minor.SuspendLayout();
            this.Open_benchmark.SuspendLayout();
            this.Creat_benchmark.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tool_Strip
            // 
            this.Tool_Strip.Location = new System.Drawing.Point(0, 0);
            this.Tool_Strip.Name = "Tool_Strip";
            this.Tool_Strip.Size = new System.Drawing.Size(1101, 25);
            this.Tool_Strip.TabIndex = 0;
            this.Tool_Strip.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ComboBox_Seed);
            this.splitContainer1.Panel1.Controls.Add(this.Label_Seed);
            this.splitContainer1.Panel1.Controls.Add(this.TextBox_Replications);
            this.splitContainer1.Panel1.Controls.Add(this.Label_Replications);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TabControl);
            this.splitContainer1.Size = new System.Drawing.Size(1101, 627);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 1;
            // 
            // ComboBox_Seed
            // 
            this.ComboBox_Seed.FormattingEnabled = true;
            this.ComboBox_Seed.Items.AddRange(new object[] {
            "987654321",
            "123456789",
            "555555555"});
            this.ComboBox_Seed.Location = new System.Drawing.Point(97, 51);
            this.ComboBox_Seed.Name = "ComboBox_Seed";
            this.ComboBox_Seed.Size = new System.Drawing.Size(100, 20);
            this.ComboBox_Seed.TabIndex = 3;
            this.ComboBox_Seed.Text = "987654321";
            // 
            // Label_Seed
            // 
            this.Label_Seed.AutoSize = true;
            this.Label_Seed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Seed.Location = new System.Drawing.Point(13, 59);
            this.Label_Seed.Name = "Label_Seed";
            this.Label_Seed.Size = new System.Drawing.Size(27, 12);
            this.Label_Seed.TabIndex = 2;
            this.Label_Seed.Text = "Seed";
            // 
            // TextBox_Replications
            // 
            this.TextBox_Replications.Location = new System.Drawing.Point(97, 17);
            this.TextBox_Replications.Name = "TextBox_Replications";
            this.TextBox_Replications.Size = new System.Drawing.Size(100, 22);
            this.TextBox_Replications.TabIndex = 1;
            this.TextBox_Replications.Text = "2000000";
            // 
            // Label_Replications
            // 
            this.Label_Replications.AutoSize = true;
            this.Label_Replications.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_Replications.Location = new System.Drawing.Point(13, 20);
            this.Label_Replications.Name = "Label_Replications";
            this.Label_Replications.Size = new System.Drawing.Size(62, 12);
            this.Label_Replications.TabIndex = 0;
            this.Label_Replications.Text = "Replications";
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.Random_Matrix);
            this.TabControl.Controls.Add(this.Gambling_Craps);
            this.TabControl.Controls.Add(this.Hatcheck_Girl);
            this.TabControl.Controls.Add(this.Stochastic_Activity_Networks);
            this.TabControl.Location = new System.Drawing.Point(3, 3);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(894, 621);
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // Random_Matrix
            // 
            this.Random_Matrix.Controls.Add(this.RM_RichTextBox_Result);
            this.Random_Matrix.Controls.Add(this.RM_Button_Clear);
            this.Random_Matrix.Controls.Add(this.RM_Button_Simulate);
            this.Random_Matrix.Controls.Add(this.RM_RichTextBox_Info);
            this.Random_Matrix.Location = new System.Drawing.Point(4, 22);
            this.Random_Matrix.Name = "Random_Matrix";
            this.Random_Matrix.Padding = new System.Windows.Forms.Padding(3);
            this.Random_Matrix.Size = new System.Drawing.Size(886, 595);
            this.Random_Matrix.TabIndex = 0;
            this.Random_Matrix.Text = "Random Matrix";
            this.Random_Matrix.UseVisualStyleBackColor = true;
            // 
            // RM_RichTextBox_Result
            // 
            this.RM_RichTextBox_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RM_RichTextBox_Result.Location = new System.Drawing.Point(264, 89);
            this.RM_RichTextBox_Result.Name = "RM_RichTextBox_Result";
            this.RM_RichTextBox_Result.Size = new System.Drawing.Size(489, 500);
            this.RM_RichTextBox_Result.TabIndex = 3;
            this.RM_RichTextBox_Result.Text = "";
            // 
            // RM_Button_Clear
            // 
            this.RM_Button_Clear.Location = new System.Drawing.Point(676, 6);
            this.RM_Button_Clear.Name = "RM_Button_Clear";
            this.RM_Button_Clear.Size = new System.Drawing.Size(77, 77);
            this.RM_Button_Clear.TabIndex = 2;
            this.RM_Button_Clear.Text = "Clear";
            this.RM_Button_Clear.UseVisualStyleBackColor = true;
            this.RM_Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // RM_Button_Simulate
            // 
            this.RM_Button_Simulate.Location = new System.Drawing.Point(264, 6);
            this.RM_Button_Simulate.Name = "RM_Button_Simulate";
            this.RM_Button_Simulate.Size = new System.Drawing.Size(144, 77);
            this.RM_Button_Simulate.TabIndex = 1;
            this.RM_Button_Simulate.Text = "Simulate";
            this.RM_Button_Simulate.UseVisualStyleBackColor = true;
            this.RM_Button_Simulate.Click += new System.EventHandler(this.RM_Button_Simulate_Click);
            // 
            // RM_RichTextBox_Info
            // 
            this.RM_RichTextBox_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RM_RichTextBox_Info.Location = new System.Drawing.Point(6, 6);
            this.RM_RichTextBox_Info.Name = "RM_RichTextBox_Info";
            this.RM_RichTextBox_Info.Size = new System.Drawing.Size(252, 584);
            this.RM_RichTextBox_Info.TabIndex = 0;
            this.RM_RichTextBox_Info.Text = "Find the probability of a 3x3 random matrix to have a positive determinant, where" +
    " the matrix is\n\nThe probability should be 0.0502.\n";
            // 
            // Gambling_Craps
            // 
            this.Gambling_Craps.Controls.Add(this.GC_Button_Clear);
            this.Gambling_Craps.Controls.Add(this.GC_Button_Simulate);
            this.Gambling_Craps.Controls.Add(this.GC_RichTextBox_Result);
            this.Gambling_Craps.Controls.Add(this.GC_Label_Info);
            this.Gambling_Craps.Location = new System.Drawing.Point(4, 22);
            this.Gambling_Craps.Name = "Gambling_Craps";
            this.Gambling_Craps.Padding = new System.Windows.Forms.Padding(3);
            this.Gambling_Craps.Size = new System.Drawing.Size(886, 595);
            this.Gambling_Craps.TabIndex = 1;
            this.Gambling_Craps.Text = "Gambling Craps";
            this.Gambling_Craps.UseVisualStyleBackColor = true;
            // 
            // GC_Button_Clear
            // 
            this.GC_Button_Clear.Location = new System.Drawing.Point(402, 80);
            this.GC_Button_Clear.Name = "GC_Button_Clear";
            this.GC_Button_Clear.Size = new System.Drawing.Size(144, 52);
            this.GC_Button_Clear.TabIndex = 3;
            this.GC_Button_Clear.Text = "Clear";
            this.GC_Button_Clear.UseVisualStyleBackColor = true;
            this.GC_Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // GC_Button_Simulate
            // 
            this.GC_Button_Simulate.Location = new System.Drawing.Point(402, 6);
            this.GC_Button_Simulate.Name = "GC_Button_Simulate";
            this.GC_Button_Simulate.Size = new System.Drawing.Size(144, 68);
            this.GC_Button_Simulate.TabIndex = 2;
            this.GC_Button_Simulate.Text = "Simulate";
            this.GC_Button_Simulate.UseVisualStyleBackColor = true;
            this.GC_Button_Simulate.Click += new System.EventHandler(this.GC_Button_Simulate_Click);
            // 
            // GC_RichTextBox_Result
            // 
            this.GC_RichTextBox_Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GC_RichTextBox_Result.Location = new System.Drawing.Point(8, 138);
            this.GC_RichTextBox_Result.Name = "GC_RichTextBox_Result";
            this.GC_RichTextBox_Result.Size = new System.Drawing.Size(538, 451);
            this.GC_RichTextBox_Result.TabIndex = 1;
            this.GC_RichTextBox_Result.Text = "";
            // 
            // GC_Label_Info
            // 
            this.GC_Label_Info.AutoSize = true;
            this.GC_Label_Info.Location = new System.Drawing.Point(6, 3);
            this.GC_Label_Info.Name = "GC_Label_Info";
            this.GC_Label_Info.Size = new System.Drawing.Size(376, 132);
            this.GC_Label_Info.TabIndex = 0;
            this.GC_Label_Info.Text = resources.GetString("GC_Label_Info.Text");
            // 
            // Hatcheck_Girl
            // 
            this.Hatcheck_Girl.Controls.Add(this.HG_Label_Number_of_customers);
            this.Hatcheck_Girl.Controls.Add(this.HG_TextBox_NumberOfCustomers);
            this.Hatcheck_Girl.Controls.Add(this.HG_Button_Clear);
            this.Hatcheck_Girl.Controls.Add(this.HG_Button_Simulate);
            this.Hatcheck_Girl.Controls.Add(this.HG_RichTextBox_Result);
            this.Hatcheck_Girl.Controls.Add(this.HG_Label_Info);
            this.Hatcheck_Girl.Location = new System.Drawing.Point(4, 22);
            this.Hatcheck_Girl.Name = "Hatcheck_Girl";
            this.Hatcheck_Girl.Size = new System.Drawing.Size(886, 595);
            this.Hatcheck_Girl.TabIndex = 2;
            this.Hatcheck_Girl.Text = "Hatcheck Girl";
            this.Hatcheck_Girl.UseVisualStyleBackColor = true;
            // 
            // HG_TextBox_NumberOfCustomers
            // 
            this.HG_TextBox_NumberOfCustomers.Location = new System.Drawing.Point(600, 85);
            this.HG_TextBox_NumberOfCustomers.Name = "HG_TextBox_NumberOfCustomers";
            this.HG_TextBox_NumberOfCustomers.Size = new System.Drawing.Size(100, 22);
            this.HG_TextBox_NumberOfCustomers.TabIndex = 4;
            this.HG_TextBox_NumberOfCustomers.Text = "10";
            // 
            // HG_Button_Clear
            // 
            this.HG_Button_Clear.Location = new System.Drawing.Point(405, 77);
            this.HG_Button_Clear.Name = "HG_Button_Clear";
            this.HG_Button_Clear.Size = new System.Drawing.Size(144, 35);
            this.HG_Button_Clear.TabIndex = 3;
            this.HG_Button_Clear.Text = "Clear";
            this.HG_Button_Clear.UseVisualStyleBackColor = true;
            this.HG_Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // HG_Button_Simulate
            // 
            this.HG_Button_Simulate.Location = new System.Drawing.Point(405, 4);
            this.HG_Button_Simulate.Name = "HG_Button_Simulate";
            this.HG_Button_Simulate.Size = new System.Drawing.Size(144, 67);
            this.HG_Button_Simulate.TabIndex = 2;
            this.HG_Button_Simulate.Text = "Simulate";
            this.HG_Button_Simulate.UseVisualStyleBackColor = true;
            this.HG_Button_Simulate.Click += new System.EventHandler(this.HG_Button_Simulate_Click);
            // 
            // HG_RichTextBox_Result
            // 
            this.HG_RichTextBox_Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HG_RichTextBox_Result.Location = new System.Drawing.Point(6, 115);
            this.HG_RichTextBox_Result.Name = "HG_RichTextBox_Result";
            this.HG_RichTextBox_Result.Size = new System.Drawing.Size(694, 475);
            this.HG_RichTextBox_Result.TabIndex = 1;
            this.HG_RichTextBox_Result.Text = "";
            // 
            // HG_Label_Info
            // 
            this.HG_Label_Info.AutoSize = true;
            this.HG_Label_Info.Location = new System.Drawing.Point(4, 4);
            this.HG_Label_Info.Name = "HG_Label_Info";
            this.HG_Label_Info.Size = new System.Drawing.Size(378, 108);
            this.HG_Label_Info.TabIndex = 0;
            this.HG_Label_Info.Text = resources.GetString("HG_Label_Info.Text");
            // 
            // Stochastic_Activity_Networks
            // 
            this.Stochastic_Activity_Networks.Controls.Add(this.Panel_nodes);
            this.Stochastic_Activity_Networks.Controls.Add(this.RichTextBox_result);
            this.Stochastic_Activity_Networks.Controls.Add(this.SAN_Button_Simulate);
            this.Stochastic_Activity_Networks.Controls.Add(this.Label_SAN_Info);
            this.Stochastic_Activity_Networks.Controls.Add(this.TabControl_minor);
            this.Stochastic_Activity_Networks.Location = new System.Drawing.Point(4, 22);
            this.Stochastic_Activity_Networks.Name = "Stochastic_Activity_Networks";
            this.Stochastic_Activity_Networks.Size = new System.Drawing.Size(886, 595);
            this.Stochastic_Activity_Networks.TabIndex = 3;
            this.Stochastic_Activity_Networks.Text = "Stochastic Activity Networks";
            this.Stochastic_Activity_Networks.UseVisualStyleBackColor = true;
            // 
            // Panel_nodes
            // 
            this.Panel_nodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_nodes.BackColor = System.Drawing.Color.White;
            this.Panel_nodes.Controls.Add(this.ToolStrip_creat);
            this.Panel_nodes.Location = new System.Drawing.Point(271, 175);
            this.Panel_nodes.Name = "Panel_nodes";
            this.Panel_nodes.Size = new System.Drawing.Size(607, 413);
            this.Panel_nodes.TabIndex = 4;
            this.Panel_nodes.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_nodes_Paint);
            this.Panel_nodes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_nodes_MouseDown);
            this.Panel_nodes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_nodes_MouseMove);
            this.Panel_nodes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_nodes_MouseUp);
            // 
            // ToolStrip_creat
            // 
            this.ToolStrip_creat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_creat_normal_cursor,
            this.ToolStrip_creat_nodes,
            this.ToolStrip_creat_paths});
            this.ToolStrip_creat.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip_creat.Name = "ToolStrip_creat";
            this.ToolStrip_creat.Size = new System.Drawing.Size(607, 25);
            this.ToolStrip_creat.TabIndex = 0;
            this.ToolStrip_creat.Text = "toolStrip2";
            // 
            // ToolStrip_creat_normal_cursor
            // 
            this.ToolStrip_creat_normal_cursor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStrip_creat_normal_cursor.Image = ((System.Drawing.Image)(resources.GetObject("ToolStrip_creat_normal_cursor.Image")));
            this.ToolStrip_creat_normal_cursor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStrip_creat_normal_cursor.Name = "ToolStrip_creat_normal_cursor";
            this.ToolStrip_creat_normal_cursor.Size = new System.Drawing.Size(23, 22);
            this.ToolStrip_creat_normal_cursor.Text = "toolStripButton1";
            this.ToolStrip_creat_normal_cursor.Click += new System.EventHandler(this.ToolStrip_creat_normal_cursor_Click);
            // 
            // ToolStrip_creat_nodes
            // 
            this.ToolStrip_creat_nodes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStrip_creat_nodes.Image = ((System.Drawing.Image)(resources.GetObject("ToolStrip_creat_nodes.Image")));
            this.ToolStrip_creat_nodes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStrip_creat_nodes.Name = "ToolStrip_creat_nodes";
            this.ToolStrip_creat_nodes.Size = new System.Drawing.Size(23, 22);
            this.ToolStrip_creat_nodes.Text = "toolStripButton2";
            this.ToolStrip_creat_nodes.Click += new System.EventHandler(this.ToolStrip_creat_nodes_Click);
            // 
            // ToolStrip_creat_paths
            // 
            this.ToolStrip_creat_paths.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStrip_creat_paths.Image = ((System.Drawing.Image)(resources.GetObject("ToolStrip_creat_paths.Image")));
            this.ToolStrip_creat_paths.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStrip_creat_paths.Name = "ToolStrip_creat_paths";
            this.ToolStrip_creat_paths.Size = new System.Drawing.Size(23, 22);
            this.ToolStrip_creat_paths.Text = "toolStripButton3";
            this.ToolStrip_creat_paths.Click += new System.EventHandler(this.ToolStrip_creat_paths_Click);
            // 
            // RichTextBox_result
            // 
            this.RichTextBox_result.Location = new System.Drawing.Point(577, 68);
            this.RichTextBox_result.Name = "RichTextBox_result";
            this.RichTextBox_result.Size = new System.Drawing.Size(301, 101);
            this.RichTextBox_result.TabIndex = 3;
            this.RichTextBox_result.Text = "";
            // 
            // SAN_Button_Simulate
            // 
            this.SAN_Button_Simulate.Location = new System.Drawing.Point(577, 24);
            this.SAN_Button_Simulate.Name = "SAN_Button_Simulate";
            this.SAN_Button_Simulate.Size = new System.Drawing.Size(198, 33);
            this.SAN_Button_Simulate.TabIndex = 2;
            this.SAN_Button_Simulate.Text = "Simulate";
            this.SAN_Button_Simulate.UseVisualStyleBackColor = true;
            this.SAN_Button_Simulate.Click += new System.EventHandler(this.SAN_Button_Simulate_Click);
            // 
            // Label_SAN_Info
            // 
            this.Label_SAN_Info.AutoSize = true;
            this.Label_SAN_Info.Location = new System.Drawing.Point(271, 48);
            this.Label_SAN_Info.Name = "Label_SAN_Info";
            this.Label_SAN_Info.Size = new System.Drawing.Size(262, 96);
            this.Label_SAN_Info.TabIndex = 1;
            this.Label_SAN_Info.Text = resources.GetString("Label_SAN_Info.Text");
            // 
            // TabControl_minor
            // 
            this.TabControl_minor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TabControl_minor.Controls.Add(this.Open_benchmark);
            this.TabControl_minor.Controls.Add(this.Creat_benchmark);
            this.TabControl_minor.Location = new System.Drawing.Point(3, 26);
            this.TabControl_minor.Name = "TabControl_minor";
            this.TabControl_minor.SelectedIndex = 0;
            this.TabControl_minor.Size = new System.Drawing.Size(262, 566);
            this.TabControl_minor.TabIndex = 0;
            this.TabControl_minor.SelectedIndexChanged += new System.EventHandler(this.TabControl_minor_SelectedIndexChanged);
            // 
            // Open_benchmark
            // 
            this.Open_benchmark.Controls.Add(this.RichTextBox_Benchmark);
            this.Open_benchmark.Controls.Add(this.Label_file_content);
            this.Open_benchmark.Controls.Add(this.Label_read_file);
            this.Open_benchmark.Controls.Add(this.Button_Open);
            this.Open_benchmark.Location = new System.Drawing.Point(4, 22);
            this.Open_benchmark.Name = "Open_benchmark";
            this.Open_benchmark.Padding = new System.Windows.Forms.Padding(3);
            this.Open_benchmark.Size = new System.Drawing.Size(254, 540);
            this.Open_benchmark.TabIndex = 0;
            this.Open_benchmark.Text = "Open benchmark";
            this.Open_benchmark.UseVisualStyleBackColor = true;
            // 
            // RichTextBox_Benchmark
            // 
            this.RichTextBox_Benchmark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RichTextBox_Benchmark.Location = new System.Drawing.Point(6, 127);
            this.RichTextBox_Benchmark.Name = "RichTextBox_Benchmark";
            this.RichTextBox_Benchmark.Size = new System.Drawing.Size(242, 407);
            this.RichTextBox_Benchmark.TabIndex = 3;
            this.RichTextBox_Benchmark.Text = "";
            // 
            // Label_file_content
            // 
            this.Label_file_content.AutoSize = true;
            this.Label_file_content.Location = new System.Drawing.Point(6, 112);
            this.Label_file_content.Name = "Label_file_content";
            this.Label_file_content.Size = new System.Drawing.Size(65, 12);
            this.Label_file_content.TabIndex = 2;
            this.Label_file_content.Text = "File Content:";
            // 
            // Label_read_file
            // 
            this.Label_read_file.AutoSize = true;
            this.Label_read_file.Location = new System.Drawing.Point(6, 69);
            this.Label_read_file.Name = "Label_read_file";
            this.Label_read_file.Size = new System.Drawing.Size(55, 12);
            this.Label_read_file.TabIndex = 1;
            this.Label_read_file.Text = "File Name:";
            // 
            // Button_Open
            // 
            this.Button_Open.Location = new System.Drawing.Point(6, 6);
            this.Button_Open.Name = "Button_Open";
            this.Button_Open.Size = new System.Drawing.Size(242, 48);
            this.Button_Open.TabIndex = 0;
            this.Button_Open.Text = "Open Project File";
            this.Button_Open.UseVisualStyleBackColor = true;
            this.Button_Open.Click += new System.EventHandler(this.Button_Open_Click);
            // 
            // Creat_benchmark
            // 
            this.Creat_benchmark.Controls.Add(this.Button_Clear_Data);
            this.Creat_benchmark.Controls.Add(this.Button_save);
            this.Creat_benchmark.Location = new System.Drawing.Point(4, 22);
            this.Creat_benchmark.Name = "Creat_benchmark";
            this.Creat_benchmark.Padding = new System.Windows.Forms.Padding(3);
            this.Creat_benchmark.Size = new System.Drawing.Size(254, 540);
            this.Creat_benchmark.TabIndex = 1;
            this.Creat_benchmark.Text = "Create_benchmark";
            this.Creat_benchmark.UseVisualStyleBackColor = true;
            // 
            // Button_Clear_Data
            // 
            this.Button_Clear_Data.Location = new System.Drawing.Point(6, 82);
            this.Button_Clear_Data.Name = "Button_Clear_Data";
            this.Button_Clear_Data.Size = new System.Drawing.Size(242, 70);
            this.Button_Clear_Data.TabIndex = 1;
            this.Button_Clear_Data.Text = "Clear all";
            this.Button_Clear_Data.UseVisualStyleBackColor = true;
            this.Button_Clear_Data.Click += new System.EventHandler(this.Button_Clear_Data_Click);
            // 
            // Button_save
            // 
            this.Button_save.Location = new System.Drawing.Point(3, 6);
            this.Button_save.Name = "Button_save";
            this.Button_save.Size = new System.Drawing.Size(245, 70);
            this.Button_save.TabIndex = 0;
            this.Button_save.Text = "Save";
            this.Button_save.UseVisualStyleBackColor = true;
            this.Button_save.Click += new System.EventHandler(this.Button_save_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // HG_Label_Number_of_customers
            // 
            this.HG_Label_Number_of_customers.AutoSize = true;
            this.HG_Label_Number_of_customers.Location = new System.Drawing.Point(600, 67);
            this.HG_Label_Number_of_customers.Name = "HG_Label_Number_of_customers";
            this.HG_Label_Number_of_customers.Size = new System.Drawing.Size(105, 12);
            this.HG_Label_Number_of_customers.TabIndex = 5;
            this.HG_Label_Number_of_customers.Text = "Number of customers";
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 652);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Tool_Strip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_form";
            this.Text = "r09546042_TerryYang_assignment_04";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.Random_Matrix.ResumeLayout(false);
            this.Gambling_Craps.ResumeLayout(false);
            this.Gambling_Craps.PerformLayout();
            this.Hatcheck_Girl.ResumeLayout(false);
            this.Hatcheck_Girl.PerformLayout();
            this.Stochastic_Activity_Networks.ResumeLayout(false);
            this.Stochastic_Activity_Networks.PerformLayout();
            this.Panel_nodes.ResumeLayout(false);
            this.Panel_nodes.PerformLayout();
            this.ToolStrip_creat.ResumeLayout(false);
            this.ToolStrip_creat.PerformLayout();
            this.TabControl_minor.ResumeLayout(false);
            this.Open_benchmark.ResumeLayout(false);
            this.Open_benchmark.PerformLayout();
            this.Creat_benchmark.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tool_Strip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox ComboBox_Seed;
        private System.Windows.Forms.Label Label_Seed;
        private System.Windows.Forms.TextBox TextBox_Replications;
        private System.Windows.Forms.Label Label_Replications;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Random_Matrix;
        private System.Windows.Forms.RichTextBox RM_RichTextBox_Result;
        private System.Windows.Forms.Button RM_Button_Clear;
        private System.Windows.Forms.Button RM_Button_Simulate;
        private System.Windows.Forms.RichTextBox RM_RichTextBox_Info;
        private System.Windows.Forms.TabPage Gambling_Craps;
        private System.Windows.Forms.Button GC_Button_Clear;
        private System.Windows.Forms.Button GC_Button_Simulate;
        private System.Windows.Forms.RichTextBox GC_RichTextBox_Result;
        private System.Windows.Forms.Label GC_Label_Info;
        private System.Windows.Forms.TabPage Hatcheck_Girl;
        private System.Windows.Forms.TextBox HG_TextBox_NumberOfCustomers;
        private System.Windows.Forms.Button HG_Button_Clear;
        private System.Windows.Forms.Button HG_Button_Simulate;
        private System.Windows.Forms.RichTextBox HG_RichTextBox_Result;
        private System.Windows.Forms.Label HG_Label_Info;
        private System.Windows.Forms.TabPage Stochastic_Activity_Networks;
        private System.Windows.Forms.Panel Panel_nodes;
        private System.Windows.Forms.ToolStrip ToolStrip_creat;
        private System.Windows.Forms.RichTextBox RichTextBox_result;
        private System.Windows.Forms.Button SAN_Button_Simulate;
        private System.Windows.Forms.Label Label_SAN_Info;
        private System.Windows.Forms.TabControl TabControl_minor;
        private System.Windows.Forms.TabPage Open_benchmark;
        private System.Windows.Forms.RichTextBox RichTextBox_Benchmark;
        private System.Windows.Forms.Label Label_file_content;
        private System.Windows.Forms.Label Label_read_file;
        private System.Windows.Forms.Button Button_Open;
        private System.Windows.Forms.TabPage Creat_benchmark;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ToolStripButton ToolStrip_creat_normal_cursor;
        private System.Windows.Forms.ToolStripButton ToolStrip_creat_nodes;
        private System.Windows.Forms.ToolStripButton ToolStrip_creat_paths;
        private System.Windows.Forms.Button Button_Clear_Data;
        private System.Windows.Forms.Button Button_save;
        private System.Windows.Forms.Label HG_Label_Number_of_customers;
    }
}

