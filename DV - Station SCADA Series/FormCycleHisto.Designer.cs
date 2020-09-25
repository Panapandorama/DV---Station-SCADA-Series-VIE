namespace DV_Station_SCADA_Series
{
    partial class FormCycleHisto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCycleHisto));
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxMDB = new System.Windows.Forms.TextBox();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.MDB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(642, 87);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxMDB
            // 
            this.textBoxMDB.Location = new System.Drawing.Point(115, 24);
            this.textBoxMDB.Name = "textBoxMDB";
            this.textBoxMDB.Size = new System.Drawing.Size(602, 20);
            this.textBoxMDB.TabIndex = 1;
            this.textBoxMDB.Text = "C:\\Project\\3SE\\Vessel\\DV\\SIMULATION\\DV 2012 TO 2017.accdb";
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(115, 50);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(602, 20);
            this.textBoxTable.TabIndex = 4;
            this.textBoxTable.Text = "OT__AIMANP_1000480_Exclude_Derating_S38_to_0_Noise_0_CYCLES";
            // 
            // MDB
            // 
            this.MDB.AutoSize = true;
            this.MDB.Location = new System.Drawing.Point(12, 27);
            this.MDB.Name = "MDB";
            this.MDB.Size = new System.Drawing.Size(43, 13);
            this.MDB.TabIndex = 5;
            this.MDB.Text = "ACCDB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Table/Query";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 228);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(730, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Notes";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(116, 115);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(602, 110);
            this.textBoxNotes.TabIndex = 9;
            this.textBoxNotes.Text = "Qry_S30_to_0_2017_09_08_16_33_BIN_CYCLES\r\nQry_S14_to_0_2017_09_08_16_36_BIN_CYCLE" +
    "S\r\nQry_S14_to_0_2017_09_08_16_36_BIN\r\nQry_S30_to_0_2017_09_08_16_33_BIN";
            // 
            // FormCycleHisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MDB);
            this.Controls.Add(this.textBoxTable);
            this.Controls.Add(this.textBoxMDB);
            this.Controls.Add(this.buttonOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCycleHisto";
            this.Text = "Create Histogram from Cycles";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxMDB;
        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.Label MDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNotes;
    }
}