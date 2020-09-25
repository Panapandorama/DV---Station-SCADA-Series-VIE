namespace DV_Station_SCADA_Series
{
    partial class FormSparseLoadChart
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
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSparseLoadChart));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlDataScreening = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageParameter = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownGapMin = new System.Windows.Forms.NumericUpDown();
            this.checkBoxDataGap = new System.Windows.Forms.CheckBox();
            this.checkBoxDuplicate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxACCDB = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDataSet = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.tabControlDataScreening.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPageParameter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGapMin)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 320);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(745, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(121, 17);
            this.toolStripStatusLabel1.Text = "Data Screening Status";
            // 
            // tabControlDataScreening
            // 
            this.tabControlDataScreening.Controls.Add(this.tabPage1);
            this.tabControlDataScreening.Controls.Add(this.tabPageParameter);
            this.tabControlDataScreening.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDataScreening.Location = new System.Drawing.Point(0, 0);
            this.tabControlDataScreening.Name = "tabControlDataScreening";
            this.tabControlDataScreening.SelectedIndex = 0;
            this.tabControlDataScreening.Size = new System.Drawing.Size(745, 320);
            this.tabControlDataScreening.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(737, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data Screening";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.AxisY.Minimum = -15D;
            chartArea1.Name = "Default";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Far;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Flow";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Red;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series2.Name = "Suction Pressure";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.GreenYellow;
            series3.Name = "Temperature";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.ChartArea = "Default";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "Differential Pressure";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(731, 288);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "SCADA Data";
            this.chart1.Titles.Add(title1);
            // 
            // tabPageParameter
            // 
            this.tabPageParameter.Controls.Add(this.groupBox1);
            this.tabPageParameter.Controls.Add(this.label2);
            this.tabPageParameter.Controls.Add(this.textBoxACCDB);
            this.tabPageParameter.Controls.Add(this.buttonOK);
            this.tabPageParameter.Controls.Add(this.label1);
            this.tabPageParameter.Controls.Add(this.textBoxDataSet);
            this.tabPageParameter.Location = new System.Drawing.Point(4, 22);
            this.tabPageParameter.Name = "tabPageParameter";
            this.tabPageParameter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParameter.Size = new System.Drawing.Size(737, 294);
            this.tabPageParameter.TabIndex = 1;
            this.tabPageParameter.Text = "Setting";
            this.tabPageParameter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownGapMin);
            this.groupBox1.Controls.Add(this.checkBoxDataGap);
            this.groupBox1.Controls.Add(this.checkBoxDuplicate);
            this.groupBox1.Location = new System.Drawing.Point(148, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 92);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "(hrs)";
            // 
            // numericUpDownGapMin
            // 
            this.numericUpDownGapMin.Location = new System.Drawing.Point(118, 43);
            this.numericUpDownGapMin.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.numericUpDownGapMin.Name = "numericUpDownGapMin";
            this.numericUpDownGapMin.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownGapMin.TabIndex = 2;
            this.numericUpDownGapMin.Value = new decimal(new int[] {
            48,
            0,
            0,
            0});
            // 
            // checkBoxDataGap
            // 
            this.checkBoxDataGap.AutoSize = true;
            this.checkBoxDataGap.Checked = true;
            this.checkBoxDataGap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDataGap.Location = new System.Drawing.Point(7, 43);
            this.checkBoxDataGap.Name = "checkBoxDataGap";
            this.checkBoxDataGap.Size = new System.Drawing.Size(72, 17);
            this.checkBoxDataGap.TabIndex = 1;
            this.checkBoxDataGap.Text = "Data Gap";
            this.checkBoxDataGap.UseVisualStyleBackColor = true;
            // 
            // checkBoxDuplicate
            // 
            this.checkBoxDuplicate.AutoSize = true;
            this.checkBoxDuplicate.Location = new System.Drawing.Point(7, 20);
            this.checkBoxDuplicate.Name = "checkBoxDuplicate";
            this.checkBoxDuplicate.Size = new System.Drawing.Size(71, 17);
            this.checkBoxDuplicate.TabIndex = 0;
            this.checkBoxDuplicate.Text = "Duplicate";
            this.checkBoxDuplicate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ACCDB";
            // 
            // textBoxACCDB
            // 
            this.textBoxACCDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxACCDB.Location = new System.Drawing.Point(148, 11);
            this.textBoxACCDB.Name = "textBoxACCDB";
            this.textBoxACCDB.Size = new System.Drawing.Size(570, 20);
            this.textBoxACCDB.TabIndex = 3;
            this.textBoxACCDB.Text = "C:\\Project\\3SE\\Vessel\\FP\\SCADA\\FP_RA.ACCDB";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(643, 256);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Load data sets";
            // 
            // textBoxDataSet
            // 
            this.textBoxDataSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDataSet.Location = new System.Drawing.Point(148, 45);
            this.textBoxDataSet.Multiline = true;
            this.textBoxDataSet.Name = "textBoxDataSet";
            this.textBoxDataSet.Size = new System.Drawing.Size(570, 102);
            this.textBoxDataSet.TabIndex = 0;
            this.textBoxDataSet.Text = "Qry_FT__AILIN_1000913\r\nQry_FT__AILIN_U34_1000567\r\nQry_FT__AIOTLAT_1000481\r\nQry_FT" +
    "__AISUC_1000808\r\nQry_FT__AISUC_U34_1000565\r\nQry_FT__AITMP_EST_1000498";
            // 
            // FormSparseLoadChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 342);
            this.Controls.Add(this.tabControlDataScreening);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSparseLoadChart";
            this.Text = "Data Screening";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControlDataScreening.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPageParameter.ResumeLayout(false);
            this.tabPageParameter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGapMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControlDataScreening;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageParameter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDataSet;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxACCDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxDataGap;
        private System.Windows.Forms.CheckBox checkBoxDuplicate;
        private System.Windows.Forms.NumericUpDown numericUpDownGapMin;
        private System.Windows.Forms.Label label3;
    }
}