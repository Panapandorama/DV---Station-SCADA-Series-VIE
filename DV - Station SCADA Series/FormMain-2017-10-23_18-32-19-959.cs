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
using System.Data.OleDb;

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
        private ToolStripMenuItem toCSVToolStripMenuItem1;
        private ToolStripMenuItem loadBINToolStripMenuItem;
        private ToolStripMenuItem loadACCDToolStripMenuItem;
        private IContainer components;
        private ToolStripMenuItem aCCDBToolStripMenuItem;
        private ToolStripMenuItem dataBindingToolStripMenuItem;
        DataView.ClassSeries ClassSeries;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.loadBINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recreateHistoricalReadingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toCSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.openFileDialogDeserialize = new System.Windows.Forms.OpenFileDialog();
            this.loadACCDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCCDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBindingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            chartArea1.AxisY.Minimum = -15D;
            chartArea1.Name = "Default";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "Legend1";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Far;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 27);
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
            series2.Name = "Suction";
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.MarkerBorderColor = System.Drawing.Color.GreenYellow;
            series3.Name = "Temperature";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(833, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "SCADA Data";
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
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
            this.legendToolStripMenuItem,
            this.loadBINToolStripMenuItem,
            this.loadACCDToolStripMenuItem});
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.chartToolStripMenuItem.Text = "&Chart";
            this.chartToolStripMenuItem.Click += new System.EventHandler(this.chartToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.legendToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // loadBINToolStripMenuItem
            // 
            this.loadBINToolStripMenuItem.Name = "loadBINToolStripMenuItem";
            this.loadBINToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadBINToolStripMenuItem.Text = "Load BIN";
            this.loadBINToolStripMenuItem.Click += new System.EventHandler(this.loadBINToolStripMenuItem_Click);
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
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadDataToolStripMenuItem.Text = "Load Data";
            this.loadDataToolStripMenuItem.Click += new System.EventHandler(this.loadDataToolStripMenuItem_Click);
            // 
            // countCyclesToolStripMenuItem
            // 
            this.countCyclesToolStripMenuItem.Name = "countCyclesToolStripMenuItem";
            this.countCyclesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.countCyclesToolStripMenuItem.Text = "Count Cycles";
            this.countCyclesToolStripMenuItem.Click += new System.EventHandler(this.countCyclesToolStripMenuItem_Click);
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
            this.deserializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toCSVToolStripMenuItem1});
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // toCSVToolStripMenuItem1
            // 
            this.toCSVToolStripMenuItem1.Name = "toCSVToolStripMenuItem1";
            this.toCSVToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toCSVToolStripMenuItem1.Text = "To CSV";
            this.toCSVToolStripMenuItem1.Click += new System.EventHandler(this.toCSVToolStripMenuItem_Click);
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
            // openFileDialogDeserialize
            // 
            this.openFileDialogDeserialize.DefaultExt = "*.BIN";
            this.openFileDialogDeserialize.Filter = "SCADA Series|*.BIN|All files|*.*";
            // 
            // loadACCDToolStripMenuItem
            // 
            this.loadACCDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCCDBToolStripMenuItem,
            this.dataBindingToolStripMenuItem});
            this.loadACCDToolStripMenuItem.Name = "loadACCDToolStripMenuItem";
            this.loadACCDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadACCDToolStripMenuItem.Text = "Load ACCDB";
            this.loadACCDToolStripMenuItem.Click += new System.EventHandler(this.loadACCDToolStripMenuItem_Click_1);
            // 
            // aCCDBToolStripMenuItem
            // 
            this.aCCDBToolStripMenuItem.Name = "aCCDBToolStripMenuItem";
            this.aCCDBToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aCCDBToolStripMenuItem.Text = "ACCDB";
            this.aCCDBToolStripMenuItem.Click += new System.EventHandler(this.aCCDBToolStripMenuItem_Click);
            // 
            // dataBindingToolStripMenuItem
            // 
            this.dataBindingToolStripMenuItem.Name = "dataBindingToolStripMenuItem";
            this.dataBindingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dataBindingToolStripMenuItem.Text = "Data Binding";
            this.dataBindingToolStripMenuItem.Click += new System.EventHandler(this.dataBindingToolStripMenuItem_Click);
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
            LoadDataToChart(@"C:\Project\3SE\Vessel\MT\SCADA\06 MT__AISUC(1000473).XLSX", "2012-2016", 0);
            LoadDataToChart(@"C:\Project\3SE\Vessel\MT\SCADA\08 MT__AIFLO(1000900).XLSX", "Sheet1", 1);
            LoadDataToChart(@"C:\Project\3SE\Vessel\MT\SCADA\09 MT__AITMP(1000471).XLSX", "Sheet1", 2);

            //LoadDataToChart(@"C:\Project\3SE\Vessel\OA\OA__AIFLO_2012-2017(new_fromMDCDSS).XLS", "OA__AIFLO_2012-2017(new)", 0);
            //LoadDataToChart(@"C:\Project\3SE\Vessel\OA\OA__AISUC_2012-2017(new_fromMDCDSS).XLS", "OA__AISUC_2012-2017(new)", 1);
            //LoadDataToChart(@"C:\Project\3SE\Vessel\OA\OA__AITMP_2012-2017(new_fromMDCDSS).XLS", "OA__AITMP_2012-2017(new)", 2);

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

            DVGMap.DataTableUtils DataTableUtils = new DVGMap.DataTableUtils();
            DataTable DataTable1 = DataTableUtils.LoadACCDBToDataTable(@"C:\Project\3SE\Vessel\MT\SCADA\MT 2012 TO 2017.accdb", @"MT__SUC_2012_to_2016");
//            DataTable DataTable1 = DataTableUtils.LoadACCDBToDataTable(@"C:\Project\3SE\Vessel\MT\SCADA\MT 2012 TO 2017.accdb", @"MT__SUC_2012_to_2017");
            int iCount = DataTable.Rows.Count;

            // DataTable DataTable1 = DV_Station_Series_Util.LoadSeries(@"C:\Project\3SE\Vessel\OA\SCADA\OA__AISUC_2012-2017(new_fromMDCDSS).xlsx", "OA__AISUC_2012-2017(new)");
            //            DataTable DataTable1 = DV_Station_Series_Util.LoadSeries(@"C:\Project\3SE\Vessel\OA\SCADA\NK__AISUC_2012-2017(new_fromMDCDSS).XLSX", "NK__AISUC_2012-2017(new)");

            int duration = (int)DateTime.Now.Subtract(DateTimeLoadDataTable).TotalSeconds;
            
            DatasetPacket DatasetPacket = new DatasetPacket();
            DatasetPacket.ProcessDatapacket(DataTable1, Constant.FLD_TIME, 12 * 3600);  // Get bookmarks

            RecreateHistorical RecreateHistorical = new RecreateHistorical();
            RecreateHistorical.DatasetPacket = DatasetPacket;
            RecreateHistorical.RecreatePast(40, 0, DataTable1, 5, 5);
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private List<HistoricalRecord> DeSerialize(string aFilename)
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }

                return HistoricalRecordList;
        }

        private void toCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iCounter = 0;

            DialogResult result = openFileDialogDeserialize.ShowDialog(); // Show the dialog.

            if (result == DialogResult.Cancel) // Test result.
                return;

            List<HistoricalRecord> HistoricalRecordList = DeSerialize(openFileDialogDeserialize.FileName);

            string filename = openFileDialogDeserialize.FileName + "_" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm") + ".CSV";
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

        private void countCyclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rainflow Rainflow = new Rainflow();
            string fileBIN = @"C:\Project\3SE\Vessel\MT\SCADA\Serialize_from40_to_0_2017-06-17-23-08.BIN";
            string fileFOLDER = @"C:\Project\3SE\Vessel\MT\SCADA\SIMULATION";

            Rainflow.CountCycleforBIN(fileBIN, fileFOLDER, 0, false);
            Rainflow.CountCycleforBIN(fileBIN, fileFOLDER, 0, true);
        }

        private void loadBINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int iCounter = 0;

            DatasetPacket DatasetPacket = new DatasetPacket();
            List<HistoricalRecord> ListRecord = DatasetPacket.DeSerialize(@"C:\Project\3SE\Vessel\OA\SIMULATION\Serialize_from38_to_0_2017-06-04-20-35.BIN");

            chart1.ChartAreas[0].AxisY.Minimum = 0;

            int year = 1985;  // Set Year
            // Clear Chart
            chart1.Series[0].Points.Clear();
            chart1.Titles[0].Text = "Simulation Data for year " + year.ToString();
            chart1.Series[0].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            // Try 1985
            foreach (HistoricalRecord historicalRecord in ListRecord)
            {
                if (historicalRecord.Time.Year == year)
                    chart1.Series[0].Points.AddXY(historicalRecord.Time, historicalRecord.Value);

                iCounter++;
                if (iCounter % 10000 == 0)
                {
                    toolStripStatusLabelStatus.Text = "Reading and charting record " + iCounter.ToString("0000000");
                    Application.DoEvents();
                }
            }

        }

        private void loadACCDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void dataBindingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection connect = new OleDbConnection(
                @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Project\3SE\Vessel\MT\SCADA\MT 2012 TO 2017.accdb");

            OleDbCommand cmd = new OleDbCommand(" SELECT * from MT__SUC_2012_to_2017", connect);
            connect.Open();

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            int iRows = ds.Tables[0].Rows.Count;
        }

        private void loadACCDToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void aCCDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DVGMap.DataTableUtils DataTableUtils = new DVGMap.DataTableUtils();
            DataTable DataTable = DataTableUtils.LoadACCDBToDataTable(@"C:\Project\3SE\Vessel\MT\SCADA\MT 2012 TO 2017.accdb", @"MT__SUC_2012_to_2017");
            int iCount = DataTable.Rows.Count;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
