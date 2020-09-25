namespace DV_Station_SCADA_Series
{
    partial class FormASME_SN
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormASME_SN));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlSN = new System.Windows.Forms.TabControl();
            this.tabPageCurve = new System.Windows.Forms.TabPage();
            this.chartASME_SN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.richTextBoxData = new System.Windows.Forms.RichTextBox();
            this.tabPageBaseline = new System.Windows.Forms.TabPage();
            this.tabPageAnnotate = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.sA517XXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sA51790ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.caseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownStep = new System.Windows.Forms.NumericUpDown();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownYield = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownTensile = new System.Windows.Forms.NumericUpDown();
            this.groupBoxRepresentation = new System.Windows.Forms.GroupBox();
            this.checkBoxDerateYield = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxTensile = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownTemperature = new System.Windows.Forms.NumericUpDown();
            this.checkBoxClearChart = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownY0 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownConfidence = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownA1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlSN.SuspendLayout();
            this.tabPageCurve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartASME_SN)).BeginInit();
            this.tabPageData.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTensile)).BeginInit();
            this.groupBoxRepresentation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY0)).BeginInit();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConfidence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControlSN);
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownStep);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxMaterial);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownYield);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownTensile);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxRepresentation);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownTemperature);
            this.splitContainer1.Panel2.Controls.Add(this.checkBoxClearChart);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownY0);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonProcess);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip2);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownConfidence);
            this.splitContainer1.Panel2.Controls.Add(this.numericUpDownA1);
            this.splitContainer1.Size = new System.Drawing.Size(947, 452);
            this.splitContainer1.SplitterDistance = 756;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControlSN
            // 
            this.tabControlSN.Controls.Add(this.tabPageCurve);
            this.tabControlSN.Controls.Add(this.tabPageData);
            this.tabControlSN.Controls.Add(this.tabPageBaseline);
            this.tabControlSN.Controls.Add(this.tabPageAnnotate);
            this.tabControlSN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSN.Location = new System.Drawing.Point(0, 0);
            this.tabControlSN.Name = "tabControlSN";
            this.tabControlSN.SelectedIndex = 0;
            this.tabControlSN.Size = new System.Drawing.Size(756, 430);
            this.tabControlSN.TabIndex = 2;
            // 
            // tabPageCurve
            // 
            this.tabPageCurve.Controls.Add(this.chartASME_SN);
            this.tabPageCurve.Location = new System.Drawing.Point(4, 22);
            this.tabPageCurve.Name = "tabPageCurve";
            this.tabPageCurve.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCurve.Size = new System.Drawing.Size(748, 404);
            this.tabPageCurve.TabIndex = 0;
            this.tabPageCurve.Text = "Curve";
            this.tabPageCurve.UseVisualStyleBackColor = true;
            // 
            // chartASME_SN
            // 
            this.chartASME_SN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.LabelStyle.Format = "#.##";
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "N Cycles";
            chartArea1.AxisY.Title = "% Strength";
            chartArea1.Name = "ChartArea1";
            this.chartASME_SN.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartASME_SN.Legends.Add(legend1);
            this.chartASME_SN.Location = new System.Drawing.Point(3, 3);
            this.chartASME_SN.Name = "chartASME_SN";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Red;
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star4;
            series1.Name = "Tensile";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Yield";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series3.Name = "Yield - Derated";
            this.chartASME_SN.Series.Add(series1);
            this.chartASME_SN.Series.Add(series2);
            this.chartASME_SN.Series.Add(series3);
            this.chartASME_SN.Size = new System.Drawing.Size(742, 395);
            this.chartASME_SN.TabIndex = 1;
            this.chartASME_SN.Text = "chart1";
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.richTextBoxData);
            this.tabPageData.Location = new System.Drawing.Point(4, 22);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(748, 404);
            this.tabPageData.TabIndex = 1;
            this.tabPageData.Text = "Data";
            this.tabPageData.UseVisualStyleBackColor = true;
            // 
            // richTextBoxData
            // 
            this.richTextBoxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxData.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxData.Name = "richTextBoxData";
            this.richTextBoxData.Size = new System.Drawing.Size(742, 398);
            this.richTextBoxData.TabIndex = 0;
            this.richTextBoxData.Text = "";
            // 
            // tabPageBaseline
            // 
            this.tabPageBaseline.Location = new System.Drawing.Point(4, 22);
            this.tabPageBaseline.Name = "tabPageBaseline";
            this.tabPageBaseline.Size = new System.Drawing.Size(748, 404);
            this.tabPageBaseline.TabIndex = 2;
            this.tabPageBaseline.Text = "Baseline";
            this.tabPageBaseline.UseVisualStyleBackColor = true;
            // 
            // tabPageAnnotate
            // 
            this.tabPageAnnotate.Location = new System.Drawing.Point(4, 22);
            this.tabPageAnnotate.Name = "tabPageAnnotate";
            this.tabPageAnnotate.Size = new System.Drawing.Size(748, 404);
            this.tabPageAnnotate.TabIndex = 3;
            this.tabPageAnnotate.Text = "Annotate";
            this.tabPageAnnotate.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel3,
            this.toolStripSplitButton1,
            this.toolStripSplitButton2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 430);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(756, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel2.Text = "Progress";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel3.Text = "Analytics";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sA517XXToolStripMenuItem,
            this.sA51790ToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // sA517XXToolStripMenuItem
            // 
            this.sA517XXToolStripMenuItem.Name = "sA517XXToolStripMenuItem";
            this.sA517XXToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.sA517XXToolStripMenuItem.Text = "SA-517-XX";
            // 
            // sA51790ToolStripMenuItem
            // 
            this.sA51790ToolStripMenuItem.Name = "sA51790ToolStripMenuItem";
            this.sA51790ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.sA51790ToolStripMenuItem.Text = "SA-517-90";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caseToolStripMenuItem});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            // 
            // caseToolStripMenuItem
            // 
            this.caseToolStripMenuItem.Name = "caseToolStripMenuItem";
            this.caseToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.caseToolStripMenuItem.Text = "Case";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Step";
            // 
            // numericUpDownStep
            // 
            this.numericUpDownStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownStep.DecimalPlaces = 2;
            this.numericUpDownStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownStep.Location = new System.Drawing.Point(103, 230);
            this.numericUpDownStep.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownStep.Name = "numericUpDownStep";
            this.numericUpDownStep.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownStep.TabIndex = 26;
            this.numericUpDownStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Items.AddRange(new object[] {
            "SA-285 C",
            "SA-516 70"});
            this.comboBoxMaterial.Location = new System.Drawing.Point(103, 21);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(74, 21);
            this.comboBoxMaterial.TabIndex = 25;
            this.comboBoxMaterial.Text = "SA-285 C";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Material";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Yield (PSI)";
            // 
            // numericUpDownYield
            // 
            this.numericUpDownYield.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownYield.Location = new System.Drawing.Point(103, 74);
            this.numericUpDownYield.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownYield.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownYield.Name = "numericUpDownYield";
            this.numericUpDownYield.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownYield.TabIndex = 21;
            this.numericUpDownYield.Value = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tensile (PSI)";
            // 
            // numericUpDownTensile
            // 
            this.numericUpDownTensile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownTensile.Location = new System.Drawing.Point(103, 48);
            this.numericUpDownTensile.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownTensile.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTensile.Name = "numericUpDownTensile";
            this.numericUpDownTensile.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownTensile.TabIndex = 19;
            this.numericUpDownTensile.Value = new decimal(new int[] {
            55000,
            0,
            0,
            0});
            // 
            // groupBoxRepresentation
            // 
            this.groupBoxRepresentation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRepresentation.Controls.Add(this.checkBoxDerateYield);
            this.groupBoxRepresentation.Controls.Add(this.checkBox1);
            this.groupBoxRepresentation.Controls.Add(this.checkBoxTensile);
            this.groupBoxRepresentation.Location = new System.Drawing.Point(19, 134);
            this.groupBoxRepresentation.Name = "groupBoxRepresentation";
            this.groupBoxRepresentation.Size = new System.Drawing.Size(150, 89);
            this.groupBoxRepresentation.TabIndex = 18;
            this.groupBoxRepresentation.TabStop = false;
            this.groupBoxRepresentation.Text = "Representation";
            // 
            // checkBoxDerateYield
            // 
            this.checkBoxDerateYield.AutoSize = true;
            this.checkBoxDerateYield.Checked = true;
            this.checkBoxDerateYield.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDerateYield.Location = new System.Drawing.Point(6, 66);
            this.checkBoxDerateYield.Name = "checkBoxDerateYield";
            this.checkBoxDerateYield.Size = new System.Drawing.Size(114, 17);
            this.checkBoxDerateYield.TabIndex = 20;
            this.checkBoxDerateYield.Text = "Derate Yield stress";
            this.checkBoxDerateYield.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Yield stress";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBoxTensile
            // 
            this.checkBoxTensile.AutoSize = true;
            this.checkBoxTensile.Checked = true;
            this.checkBoxTensile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTensile.Location = new System.Drawing.Point(6, 22);
            this.checkBoxTensile.Name = "checkBoxTensile";
            this.checkBoxTensile.Size = new System.Drawing.Size(90, 17);
            this.checkBoxTensile.TabIndex = 18;
            this.checkBoxTensile.Text = "Tensile stress";
            this.checkBoxTensile.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Temp (C)";
            // 
            // numericUpDownTemperature
            // 
            this.numericUpDownTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownTemperature.Location = new System.Drawing.Point(103, 100);
            this.numericUpDownTemperature.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownTemperature.Name = "numericUpDownTemperature";
            this.numericUpDownTemperature.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownTemperature.TabIndex = 14;
            this.numericUpDownTemperature.Value = new decimal(new int[] {
            38,
            0,
            0,
            0});
            // 
            // checkBoxClearChart
            // 
            this.checkBoxClearChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxClearChart.AutoSize = true;
            this.checkBoxClearChart.Checked = true;
            this.checkBoxClearChart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxClearChart.Location = new System.Drawing.Point(29, 345);
            this.checkBoxClearChart.Name = "checkBoxClearChart";
            this.checkBoxClearChart.Size = new System.Drawing.Size(124, 17);
            this.checkBoxClearChart.TabIndex = 9;
            this.checkBoxClearChart.Text = "Clear on Regenerate";
            this.checkBoxClearChart.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Y0";
            // 
            // numericUpDownY0
            // 
            this.numericUpDownY0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownY0.DecimalPlaces = 4;
            this.numericUpDownY0.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownY0.Location = new System.Drawing.Point(103, 282);
            this.numericUpDownY0.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownY0.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownY0.Name = "numericUpDownY0";
            this.numericUpDownY0.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownY0.TabIndex = 7;
            this.numericUpDownY0.Value = new decimal(new int[] {
            97800,
            0,
            0,
            -2147090432});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "A1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Derate";
            // 
            // buttonProcess
            // 
            this.buttonProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcess.Location = new System.Drawing.Point(111, 393);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(66, 31);
            this.buttonProcess.TabIndex = 4;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripDropDownButton1});
            this.statusStrip2.Location = new System.Drawing.Point(0, 430);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(187, 22);
            this.statusStrip2.TabIndex = 3;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(164, 19);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // numericUpDownConfidence
            // 
            this.numericUpDownConfidence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownConfidence.DecimalPlaces = 2;
            this.numericUpDownConfidence.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownConfidence.Location = new System.Drawing.Point(103, 308);
            this.numericUpDownConfidence.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            this.numericUpDownConfidence.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownConfidence.Name = "numericUpDownConfidence";
            this.numericUpDownConfidence.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownConfidence.TabIndex = 2;
            this.numericUpDownConfidence.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // numericUpDownA1
            // 
            this.numericUpDownA1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownA1.DecimalPlaces = 4;
            this.numericUpDownA1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.numericUpDownA1.Location = new System.Drawing.Point(103, 256);
            this.numericUpDownA1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownA1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownA1.Name = "numericUpDownA1";
            this.numericUpDownA1.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownA1.TabIndex = 1;
            this.numericUpDownA1.Value = new decimal(new int[] {
            493000,
            0,
            0,
            -2147090432});
            // 
            // FormASME_SN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 452);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormASME_SN";
            this.Text = "ASME Fatigue S-N Curve";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlSN.ResumeLayout(false);
            this.tabPageCurve.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartASME_SN)).EndInit();
            this.tabPageData.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTensile)).EndInit();
            this.groupBoxRepresentation.ResumeLayout(false);
            this.groupBoxRepresentation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY0)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConfidence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem sA517XXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sA51790ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem caseToolStripMenuItem;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.NumericUpDown numericUpDownConfidence;
        private System.Windows.Forms.NumericUpDown numericUpDownA1;
        private System.Windows.Forms.TabControl tabControlSN;
        private System.Windows.Forms.TabPage tabPageCurve;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartASME_SN;
        private System.Windows.Forms.TabPage tabPageData;
        private System.Windows.Forms.RichTextBox richTextBoxData;
        private System.Windows.Forms.TabPage tabPageBaseline;
        private System.Windows.Forms.TabPage tabPageAnnotate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownY0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxClearChart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownTemperature;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownYield;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownTensile;
        private System.Windows.Forms.GroupBox groupBoxRepresentation;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBoxTensile;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownStep;
        private System.Windows.Forms.CheckBox checkBoxDerateYield;
    }
}