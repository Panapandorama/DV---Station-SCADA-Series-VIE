namespace DV_Station_SCADA_Series
{
    partial class Distribution_Raw_SCADA_by_ACCDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Distribution_Raw_SCADA_by_ACCDB));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxACCDB = new System.Windows.Forms.TextBox();
            this.textBoxTableQuery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownMOP = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownBinCount = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownMaxPressure = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownMinPressure = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBinCount)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPressure)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACCDB";
            // 
            // textBoxACCDB
            // 
            this.textBoxACCDB.Location = new System.Drawing.Point(124, 14);
            this.textBoxACCDB.Name = "textBoxACCDB";
            this.textBoxACCDB.Size = new System.Drawing.Size(467, 20);
            this.textBoxACCDB.TabIndex = 1;
            this.textBoxACCDB.Text = "C:\\Project\\3SE\\Vessel\\OT\\SIMULATION\\OT 2012 TO 2017.ACCDB";
            // 
            // textBoxTableQuery
            // 
            this.textBoxTableQuery.Location = new System.Drawing.Point(124, 40);
            this.textBoxTableQuery.Name = "textBoxTableQuery";
            this.textBoxTableQuery.Size = new System.Drawing.Size(467, 20);
            this.textBoxTableQuery.TabIndex = 3;
            this.textBoxTableQuery.Text = "Qry_DV__AIMANP_1000476_S49_CYCLES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Table/Query";
            // 
            // numericUpDownMOP
            // 
            this.numericUpDownMOP.Location = new System.Drawing.Point(124, 86);
            this.numericUpDownMOP.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownMOP.Name = "numericUpDownMOP";
            this.numericUpDownMOP.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownMOP.TabIndex = 4;
            this.numericUpDownMOP.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "MOP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Step Size";
            // 
            // numericUpDownBinCount
            // 
            this.numericUpDownBinCount.Location = new System.Drawing.Point(124, 159);
            this.numericUpDownBinCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownBinCount.Name = "numericUpDownBinCount";
            this.numericUpDownBinCount.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownBinCount.TabIndex = 6;
            this.numericUpDownBinCount.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(516, 159);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStatus,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 199);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(620, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelStatus
            // 
            this.toolStripStatusLabelStatus.Name = "toolStripStatusLabelStatus";
            this.toolStripStatusLabelStatus.Size = new System.Drawing.Size(230, 17);
            this.toolStripStatusLabelStatus.Text = "Load Table/Query to Generate Distribution";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(154, 17);
            this.toolStripStatusLabel1.Text = "PANN Consulting Inc (2017)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Max Pressure";
            // 
            // numericUpDownMaxPressure
            // 
            this.numericUpDownMaxPressure.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxPressure.Location = new System.Drawing.Point(124, 134);
            this.numericUpDownMaxPressure.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownMaxPressure.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxPressure.Name = "numericUpDownMaxPressure";
            this.numericUpDownMaxPressure.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownMaxPressure.TabIndex = 10;
            this.numericUpDownMaxPressure.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Min Pressure";
            // 
            // numericUpDownMinPressure
            // 
            this.numericUpDownMinPressure.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMinPressure.Location = new System.Drawing.Point(124, 111);
            this.numericUpDownMinPressure.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownMinPressure.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericUpDownMinPressure.Name = "numericUpDownMinPressure";
            this.numericUpDownMinPressure.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownMinPressure.TabIndex = 12;
            this.numericUpDownMinPressure.Value = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            // 
            // Distribution_Raw_SCADA_by_ACCDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 221);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownMinPressure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownMaxPressure);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownBinCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownMOP);
            this.Controls.Add(this.textBoxTableQuery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxACCDB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Distribution_Raw_SCADA_by_ACCDB";
            this.Text = "Distribution by ACCDB";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBinCount)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinPressure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxACCDB;
        private System.Windows.Forms.TextBox textBoxTableQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownMOP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownBinCount;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStatus;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxPressure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownMinPressure;
    }
}