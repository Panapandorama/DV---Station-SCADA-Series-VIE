using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DV_Station_SCADA_Series;
using System.Runtime.Serialization.Formatters.Binary;

namespace DV___Station_SCADA_Series
{
    public partial class FormMain : Form
    {
        private TabControl tabControlMain;
        private TabPage tabPageVisualization;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem chartToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private TabPage tabPageParameter;
        DataTable DataTable;
        DVGMap.DataTableUtils DBUtil;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabelStatus;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem debugToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripStatusLabel toolStripStatusLabelFile;
        private ToolStripStatusLabel toolStripStatusLabelPANN;
        private ToolStripMenuItem legendToolStripMenuItem;
        private ToolStripMenuItem autoToolStripMenuItem;
        private ToolStripMenuItem presetToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem analysisToolStripMenuItem;
        private ToolStripMenuItem outputToolStripMenuItem;
        private ToolStripMenuItem settingToolStripMenuItem;
        private ToolStripMenuItem diagnosticToolStripMenuItem;
        private ToolStripMenuItem sandBoxToolStripMenuItem;
        private ToolStripMenuItem rainflowToolStripMenuItem;
        private ToolStripMenuItem loadDataToolStripMenuItem;
        private ToolStripMenuItem countCyclesToolStripMenuItem;
        private ToolStripMenuItem aSMESNToolStripMenuItem;
        private ToolStripMenuItem plotToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem1;
        private ToolStripComboBox toolStripComboBox2;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem bToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem dToolStripMenuItem;
        private ToolStripMenuItem simulationToolStripMenuItem;
        private ToolStripMenuItem recreateHistoricalReadingsToolStripMenuItem;
        private ToolStripMenuItem deserializeToolStripMenuItem;
        private OpenFileDialog openFileDialogDeserialize;
        private ToolStripMenuItem serializeToolStripMenuItem;
        private ToolStripMenuItem toCSVToolStripMenuItem;
        DataView.ClassSeries ClassSeries;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageVisualization = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.analysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rainflowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countCyclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sandBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSMESNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageParameter = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabelFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPANN = new System.Windows.Forms.ToolStripStatusLabel();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recreateHistoricalReadingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogDeserialize = new System.Windows.Forms.OpenFileDialog();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain.SuspendLayout();
            this.tabPageVisualization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageVisualization);
            this.tabControlMain.Controls.Add(this.tabPageParameter);
            this.tabControlMain.Location = new System.Drawing.Point(0, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(847, 356);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageVisualization
            // 
            this.tabPageVisualization.Controls.Add(this.chart1);
            this.tabPageVisualization.Controls.Add(this.menuStrip1);
            this.tabPageVisualization.Location = new System.Drawing.Point(4, 22);
            this.tabPageVisualization.Name = "tabPageVisualization";
            this.tabPageVisualization.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVisualization.Size = new System.Drawing.Size(839, 330);
            this.tabPageVisualization.TabIndex = 0;
            this.tabPageVisualization.Text = "Visualization";
            this.tabPageVisualization.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisY.Minimum = -15D;
            chartArea3.Name = "Default";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend3.Name = "Legend1";
            legend3.Position.Auto = false;
            legend3.Position.Height = 13.71237F;
            legend3.Position.Width = 34.01442F;
            legend3.Position.X = 62.98558F;
            legend3.Position.Y = 11F;
            legend3.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            legend3.TitleAlignment = System.Drawing.StringAlignment.Far;
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 27);
            this.chart1.Name = "chart1";
            series7.ChartArea = "Default";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.EmptyPointStyle.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series7.Legend = "Legend1";
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series7.Name = "Flow";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series8.ChartArea = "Default";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series8.Legend = "Legend1";
            series8.MarkerBorderColor = System.Drawing.Color.Red;
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series8.Name = "Suction";
            series9.ChartArea = "Default";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series9.Legend = "Legend1";
            series9.MarkerBorderColor = System.Drawing.Color.GreenYellow;
            series9.Name = "Temperature";
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(833, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title3.Name = "Title1";
            title3.Text = "SCADA Data";
            this.chart1.Titles.Add(title3);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartToolStripMenuItem,
            this.analysisToolStripMenuItem,
            this.rainflowToolStripMenuItem,
            this.outputToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.diagnosticToolStripMenuItem,
            this.sandBoxToolStripMenuItem,
            this.aSMESNToolStripMenuItem,
            this.simulationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.legendToolStripMenuItem});
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.chartToolStripMenuItem.Text = "&Chart";
            this.chartToolStripMenuItem.Click += new System.EventHandler(this.chartToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.clearToolStripMenuItem.Text = "Clea&r";
            // 
            // legendToolStripMenuItem
            // 
            this.legendToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoToolStripMenuItem,
            this.presetToolStripMenuItem,
            this.toolStripComboBox1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.legendToolStripMenuItem.Name = "legendToolStripMenuItem";
            this.legendToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.legendToolStripMenuItem.Text = "Legend";
            // 
            // autoToolStripMenuItem
            // 
            this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
            this.autoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.autoToolStripMenuItem.Text = "Auto";
            this.autoToolStripMenuItem.Click += new System.EventHandler(this.autoToolStripMenuItem_Click);
            // 
            // presetToolStripMenuItem
            // 
            this.presetToolStripMenuItem.Name = "presetToolStripMenuItem";
            this.presetToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.presetToolStripMenuItem.Text = "Preset";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem3.Text = "1";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem4.Text = "10";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem5.Text = "50";
            // 
            // analysisToolStripMenuItem
            // 
            this.analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            this.analysisToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.analysisToolStripMenuItem.Text = "&Analysis";
            // 
            // rainflowToolStripMenuItem
            // 
            this.rainflowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataToolStripMenuItem,
            this.countCyclesToolStripMenuItem});
            this.rainflowToolStripMenuItem.Name = "rainflowToolStripMenuItem";
            this.rainflowToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.rainflowToolStripMenuItem.Text = "Rainflow";
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.loadDataToolStripMenuItem.Text = "Load Data";
            this.loadDataToolStripMenuItem.Click += new System.EventHandler(this.loadDataToolStripMenuItem_Click);
            // 
            // countCyclesToolStripMenuItem
            // 
            this.countCyclesToolStripMenuItem.Name = "countCyclesToolStripMenuItem";
            this.countCyclesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.countCyclesToolStripMenuItem.Text = "Count Cycles";
            // 
            // outputToolStripMenuItem
            // 
            this.outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            this.outputToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.outputToolStripMenuItem.Text = "&Output";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "&Setting";
            // 
            // diagnosticToolStripMenuItem
            // 
            this.diagnosticToolStripMenuItem.Name = "diagnosticToolStripMenuItem";
            this.diagnosticToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.diagnosticToolStripMenuItem.Text = "&Diagnostic";
            // 
            // sandBoxToolStripMenuItem
            // 
            this.sandBoxToolStripMenuItem.Name = "sandBoxToolStripMenuItem";
            this.sandBoxToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.sandBoxToolStripMenuItem.Text = "&Sand box";
            // 
            // aSMESNToolStripMenuItem
            // 
            this.aSMESNToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plotToolStripMenuItem,
            this.optionsToolStripMenuItem1});
            this.aSMESNToolStripMenuItem.Name = "aSMESNToolStripMenuItem";
            this.aSMESNToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.aSMESNToolStripMenuItem.Text = "ASME S-N";
            // 
            // plotToolStripMenuItem
            // 
            this.plotToolStripMenuItem.Name = "plotToolStripMenuItem";
            this.plotToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.plotToolStripMenuItem.Text = "Plot";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2,
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.cToolStripMenuItem,
            this.dToolStripMenuItem});
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem1.Text = "Options";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8",
            "10"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 23);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.aToolStripMenuItem.Text = "a";
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.bToolStripMenuItem.Text = "b";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cToolStripMenuItem.Text = "c";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.dToolStripMenuItem.Text = "d";
            // 
            // tabPageParameter
            // 
            this.tabPageParameter.Location = new System.Drawing.Point(4, 22);
            this.tabPageParameter.Name = "tabPageParameter";
            this.tabPageParameter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParameter.Size = new System.Drawing.Size(839, 330);
            this.tabPageParameter.TabIndex = 1;
            this.tabPageParameter.Text = "Parameter";
            this.tabPageParameter.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripProgressBar1,
            this.toolStripSplitButton1,
            this.toolStripStatusLabelFile,
            this.toolStripStatusLabelPANN});
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(847, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStripMain";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabelStatus.Text = "Status";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripStatusLabelFile
            // 
            this.toolStripStatusLabelFile.Name = "toolStripStatusLabelFile";
            this.toolStripStatusLabelFile.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabelFile.Text = "File";
            // 
            // toolStripStatusLabelPANN
            // 
            this.toolStripStatusLabelPANN.Name = "toolStripStatusLabelPANN";
            this.toolStripStatusLabelPANN.Size = new System.Drawing.Size(144, 17);
            this.toolStripStatusLabelPANN.Text = "(c) 2017 PANN Consulting";
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recreateHistoricalReadingsToolStripMenuItem,
            this.deserializeToolStripMenuItem,
            this.serializeToolStripMenuItem});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // recreateHistoricalReadingsToolStripMenuItem
            // 
            this.recreateHistoricalReadingsToolStripMenuItem.Name = "recreateHistoricalReadingsToolStripMenuItem";
            this.recreateHistoricalReadingsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.recreateHistoricalReadingsToolStripMenuItem.Text = "Recreate Historical Readings";
            this.recreateHistoricalReadingsToolStripMenuItem.Click += new System.EventHandler(this.recreateHistoricalReadingsToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // openFileDialogDeserialize
            // 
            this.openFileDialogDeserialize.DefaultExt = "*.BIN";
            this.openFileDialogDeserialize.Filter = "SCADA Series|*.BIN|All files|*.*";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toCSVToolStripMenuItem});
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.serializeToolStripMenuItem.Text = "Serialize";
            // 
            // toCSVToolStripMenuItem
            // 
            this.toCSVToolStripMenuItem.Name = "toCSVToolStripMenuItem";
            this.toCSVToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toCSVToolStripMenuItem.Text = "To CSV";
            this.toCSVToolStripMenuItem.Click += new System.EventHandler(this.toCSVToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(847, 381);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Data View - Station SCADA Series - v1.0";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageVisualization.ResumeLayout(false);
            this.tabPageVisualization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public FormMain()
        {
            InitializeComponent();

            MakeChartZoomable();

            ClassSeries = new DataView.ClassSeries();

            //string pathName, sheetName, description;
            DataTable = new DataTable();
            DBUtil = new DVGMap.DataTableUtils();
        }

        private void MakeChartZoomable()
        {
            // Enable range selection and zooming end user interface
            chart1.ChartAreas["Default"].CursorX.IsUserEnabled = true;
            chart1.ChartAreas["Default"].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas["Default"].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas["Default"].AxisX.ScrollBar.IsPositionedInside = true;

            // Y Zoomable  DanH 2015/07/01
            chart1.ChartAreas["Default"].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas["Default"].CursorY.AutoScroll = true;

            // Set Reverse value for X axis  DanH 2015/07/01
            chart1.ChartAreas["Default"].AxisX.IsReversed = true;


        }

       
        public void SeriesClear()
        {
            this.chart1.Series.Clear();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxSheetName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear Chart
            MessageBox.Show("This will clear all data, you will need to reload data.  Are you sure?", "Warning", MessageBoxButtons.YesNo);

        }

        private void userControlSeries1_Load(object sender, EventArgs e)
        {

        }


        private void LoadSeries()
        {
//            chart1.Series[0].Points.AddXY(dataRow[aXAxisFieldName], value);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataToChart(@"C:\Project\3SE\Vessel\OA\OA__AIFLO_2012-2017(new_fromMDCDSS).XLS", "OA__AIFLO_2012-2017(new)", 0);
            LoadDataToChart(@"C:\Project\3SE\Vessel\OA\OA__AISUC_2012-2017(new_fromMDCDSS).XLS", "OA__AISUC_2012-2017(new)", 1);
            LoadDataToChart(@"C:\Project\3SE\Vessel\OA\OA__AITMP_2012-2017(new_fromMDCDSS).XLS", "OA__AITMP_2012-2017(new)", 2);

            //LoadDataToChart(@"C:\Project\3SE\Vessel\NK\NK__AISUC_2012-2017(new_fromMDCDSS).XLS", "NK__AISUC_2012-2017(new)", 1);
            //LoadDataToChart(@"C:\Project\3SE\Vessel\NK\NK__AITMP_2012-2017(new_fromMDCDSS).XLS", "NK__AITMP_2012-2017(new)", 2);

            //LoadDataToChart(@"C:\Project\3SE\Vessel\NK\SCADA\NK__AIFLO_2012-2017(new_fromMDCDSS).XLSX", "NK__AIFLO_2012-2017(new)", 0);
            //LoadDataToChart(@"C:\Project\3SE\Vessel\NK\SCADA\NK__AISUC_2012-2017(new_fromMDCDSS).XLSX", "NK__AISUC_2012-2017(new)", 1);
            //LoadDataToChart(@"C:\Project\3SE\Vessel\NK\SCADA\NK__AITMP_2012-2017(new_fromMDCDSS).XLSX", "NK__AITMP_2012-2017(new)", 2);

        }

        private void LoadDataToChart(string aFilename, string aSheetname, int aSeriesIndex)
        {
            chart1.Titles[0].Text = "SCADA Data - Station Series: " + aFilename;
            chart1.Series[aSeriesIndex].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart1.Series[aSeriesIndex].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            int iCounter = 0, iTotal;
            int iPercent = 0;

            DV_Station_Series_Util DV_Station_Series_Util = new DV_Station_Series_Util();

            // Load Data
            DataTable DataTable1 = DV_Station_Series_Util.LoadSeries(aFilename, aSheetname);
            iTotal = DataTable1.Rows.Count;

            // Update
            toolStripStatusLabelFile.Text = aFilename + ", " + aSheetname;

            foreach (DataRow dataRow in DataTable1.Rows)
            {
                // tagId	time	value	dataQuality	ownSysId	datasetId	fieldTime
                // 0        1       2       3 
                chart1.Series[aSeriesIndex].Points.AddXY(dataRow[1], dataRow[2]);
                iCounter++;

                if ((iCounter % 1000) == 0)
                {
                    iPercent = 100 * (iCounter / iTotal);
                    toolStripProgressBar1.Value = iPercent;
                    Application.DoEvents();
                }
            }
        }

        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Legends[0].Position.Auto = true;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            chart1.Legends[0].Position.Y = System.Convert.ToInt16(toolStripComboBox1.Text);
        }

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DV_Station_Series_Util DV_Station_Series_Util = new DV_Station_Series_Util();
            Rainflow Rainflow = new Rainflow();
            DateTime DateTimeLoadDataTable = DateTime.Now;
            // Load Data
            LoadDataToChart(@"C:\Project\3SE\Vessel\OA\OA__AIFLO_2012-2017(new_fromMDCDSS).XLS", "OA__AIFLO_2012-2017(new)", 0);
            DataTable DataTable1 = DV_Station_Series_Util.LoadSeries(@"C:\Project\3SE\Vessel\NK\SCADA\NK__AISUC_2012-2017(new_fromMDCDSS).XLSX", "NK__AISUC_2012-2017(new)");

            DateTime DateTimeRainflow = DateTime.Now;
            Rainflow.ProcessData(DataTable1, 1, 2);  // tagId	time	value	dataQuality	ownSysId	datasetId	fieldTime

            DateTime DateTimeCompleted = DateTime.Now;
            string sHeader = DateTimeLoadDataTable.ToString() + ", " + DateTimeRainflow.ToString() + ", " + DateTimeCompleted.ToString();
            sHeader = sHeader + Environment.NewLine + "Load Data (s)            : " +  DateTimeRainflow.Subtract(DateTimeLoadDataTable).TotalSeconds;
            sHeader = sHeader + Environment.NewLine + "Count Rainflow cycles (s): " + DateTimeCompleted.Subtract(DateTimeRainflow).TotalSeconds;
            Rainflow.OutputDebugList(@"C:\Project\3SE\Vessel\NK\SCADA\RAINFLOW" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm") + ".TXT", sHeader);
        }

        private void recreateHistoricalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recreateHistoricalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recreateHistoricalReadingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DV_Station_Series_Util DV_Station_Series_Util = new DV_Station_Series_Util();

            DateTime DateTimeLoadDataTable = DateTime.Now;
            DataTable DataTable1 = DV_Station_Series_Util.LoadSeries(@"C:\Project\3SE\Vessel\OA\SCADA\OA__AISUC_2012-2017(new_fromMDCDSS).xlsx", "OA__AISUC_2012-2017(new)");
            //            DataTable DataTable1 = DV_Station_Series_Util.LoadSeries(@"C:\Project\3SE\Vessel\OA\SCADA\NK__AISUC_2012-2017(new_fromMDCDSS).XLSX", "NK__AISUC_2012-2017(new)");

            int duration = (int)DateTime.Now.Subtract(DateTimeLoadDataTable).TotalSeconds;
            
            DatasetPacket DatasetPacket = new DatasetPacket();
            DatasetPacket.ProcessDatapacket(DataTable1, 1, 12 * 3600);  // Get bookmarks

            RecreateHistorical RecreateHistorical = new RecreateHistorical();
            RecreateHistorical.DatasetPacket = DatasetPacket;
            RecreateHistorical.RecreatePast(30, 0, DataTable1, 5, 50);
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private List<HistoricalRecord> DeSerialize()
        {
            DialogResult result = openFileDialogDeserialize.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                List<HistoricalRecord> HistoricalRecordList = new List<HistoricalRecord>();

                string filename = openFileDialogDeserialize.FileName;
                try
                {
                    HistoricalRecord HistoricalRecord = new HistoricalRecord();
                    using (Stream stream = File.Open(filename, FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();

                        //                        var HistoricalRecordList = (List<HistoricalRecord>)bin.Deserialize(stream);
                        HistoricalRecordList = (List<HistoricalRecord>)bin.Deserialize(stream);

                    }
                }
                catch (IOException)
                {
                }

                return HistoricalRecordList;
            }
            else
                return null;
        }

        private void toCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iCounter = 0;
            List<HistoricalRecord> HistoricalRecordList = DeSerialize();

            string filename = @"C:\Temp\Deserialize_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm") + ".CSV";
            // Write the string to a file.
            System.IO.StreamWriter swOutputFile = new System.IO.StreamWriter(filename);


            foreach (HistoricalRecord historicalRecord in HistoricalRecordList)
            {
                if (iCounter < 1000)  // Diagnostics only
                    Console.WriteLine("{0}, {1}, {2}",
                    historicalRecord.Time,
                    historicalRecord.Value,
                    historicalRecord.DataQuality);

                swOutputFile.WriteLine(historicalRecord.Time.ToString("yyyy-MM-dd HH:mm:ss") + "\t" + historicalRecord.Value + "\t" +
                        historicalRecord.DataQuality + "\t" + historicalRecord.DataSetGroup);

                iCounter++;
                if (iCounter % 10000 == 0)
                {
                    swOutputFile.Flush();
                    toolStripStatusLabelStatus.Text = "Saving record " + iCounter.ToString("0000000");
                    Application.DoEvents();
                }
            }

            swOutputFile.Close();
            toolStripStatusLabelStatus.Text = "Completed saving file " + filename;
        }
    }
}
