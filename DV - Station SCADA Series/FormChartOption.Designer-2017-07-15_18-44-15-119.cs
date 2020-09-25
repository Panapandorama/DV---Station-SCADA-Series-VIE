namespace DVGMap
{
    partial class FormChartOption
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.numericUpDownXMax = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownXMin = new System.Windows.Forms.NumericUpDown();
            this.checkBoxLogithmic = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoScale = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownYMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownYMin = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxSynchronize = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMin)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownXMax);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDownXMin);
            this.groupBox1.Controls.Add(this.checkBoxLogithmic);
            this.groupBox1.Controls.Add(this.checkBoxAutoScale);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 138);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "X-Scale";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpdate.Location = new System.Drawing.Point(383, 166);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update Chart";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // numericUpDownXMax
            // 
            this.numericUpDownXMax.DecimalPlaces = 1;
            this.numericUpDownXMax.Location = new System.Drawing.Point(70, 83);
            this.numericUpDownXMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownXMax.Name = "numericUpDownXMax";
            this.numericUpDownXMax.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownXMax.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "X-Max";
            // 
            // numericUpDownXMin
            // 
            this.numericUpDownXMin.DecimalPlaces = 1;
            this.numericUpDownXMin.Location = new System.Drawing.Point(70, 58);
            this.numericUpDownXMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownXMin.Name = "numericUpDownXMin";
            this.numericUpDownXMin.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownXMin.TabIndex = 3;
            // 
            // checkBoxLogithmic
            // 
            this.checkBoxLogithmic.AutoSize = true;
            this.checkBoxLogithmic.Location = new System.Drawing.Point(13, 40);
            this.checkBoxLogithmic.Name = "checkBoxLogithmic";
            this.checkBoxLogithmic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxLogithmic.Size = new System.Drawing.Size(71, 17);
            this.checkBoxLogithmic.TabIndex = 2;
            this.checkBoxLogithmic.Text = "Logithmic";
            this.checkBoxLogithmic.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoScale
            // 
            this.checkBoxAutoScale.AutoSize = true;
            this.checkBoxAutoScale.Location = new System.Drawing.Point(6, 19);
            this.checkBoxAutoScale.Name = "checkBoxAutoScale";
            this.checkBoxAutoScale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxAutoScale.Size = new System.Drawing.Size(78, 17);
            this.checkBoxAutoScale.TabIndex = 1;
            this.checkBoxAutoScale.Text = "Auto Scale";
            this.checkBoxAutoScale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "X-Min";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownYMax);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDownYMin);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(238, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 138);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Y-Scale";
            // 
            // numericUpDownYMax
            // 
            this.numericUpDownYMax.DecimalPlaces = 1;
            this.numericUpDownYMax.Location = new System.Drawing.Point(70, 83);
            this.numericUpDownYMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownYMax.Name = "numericUpDownYMax";
            this.numericUpDownYMax.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownYMax.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Y-Max";
            // 
            // numericUpDownYMin
            // 
            this.numericUpDownYMin.DecimalPlaces = 1;
            this.numericUpDownYMin.Location = new System.Drawing.Point(70, 58);
            this.numericUpDownYMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownYMin.Name = "numericUpDownYMin";
            this.numericUpDownYMin.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownYMin.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Logithmic";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox2.Size = new System.Drawing.Size(78, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Auto Scale";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y-Min";
            // 
            // checkBoxSynchronize
            // 
            this.checkBoxSynchronize.AutoSize = true;
            this.checkBoxSynchronize.Location = new System.Drawing.Point(12, 165);
            this.checkBoxSynchronize.Name = "checkBoxSynchronize";
            this.checkBoxSynchronize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxSynchronize.Size = new System.Drawing.Size(131, 17);
            this.checkBoxSynchronize.TabIndex = 6;
            this.checkBoxSynchronize.Text = "Synchronize All Charts";
            this.checkBoxSynchronize.UseVisualStyleBackColor = true;
            // 
            // FormChartOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 203);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxSynchronize);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormChartOption";
            this.ShowInTaskbar = false;
            this.Text = "Chart Viewing Option";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXMin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.NumericUpDown numericUpDownXMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownXMin;
        private System.Windows.Forms.CheckBox checkBoxLogithmic;
        private System.Windows.Forms.CheckBox checkBoxAutoScale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownYMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownYMin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxSynchronize;
    }
}