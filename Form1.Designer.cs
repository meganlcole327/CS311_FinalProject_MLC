namespace CS311_FinalProject_MLC
{
    partial class UnitConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fontDialog1 = new FontDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnCalculate = new Button();
            btnReset = new Button();
            grbFrom = new GroupBox();
            txtFromMeasurement = new TextBox();
            cboFromUnit = new ComboBox();
            grbTo = new GroupBox();
            txtToMeasurement = new TextBox();
            cboToUnit = new ComboBox();
            colorDialog1 = new ColorDialog();
            colorDialog2 = new ColorDialog();
            helpProvider1 = new HelpProvider();
            helpProvider2 = new HelpProvider();
            btnDirections = new Button();
            btnConversions = new Button();
            groupBox1 = new GroupBox();
            rdoMass = new RadioButton();
            rdoTemperature = new RadioButton();
            rdoLength = new RadioButton();
            pageSetupDialog1 = new PageSetupDialog();
            panel1 = new Panel();
            lblTitle = new Label();
            grbFrom.SuspendLayout();
            grbTo.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Navy;
            btnCalculate.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = SystemColors.Control;
            btnCalculate.Location = new Point(299, 392);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(128, 29);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Navy;
            btnReset.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = SystemColors.Control;
            btnReset.Location = new Point(508, 392);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(106, 29);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // grbFrom
            // 
            grbFrom.BackColor = SystemColors.ActiveCaption;
            grbFrom.Controls.Add(txtFromMeasurement);
            grbFrom.Controls.Add(cboFromUnit);
            grbFrom.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbFrom.Location = new Point(229, 206);
            grbFrom.Name = "grbFrom";
            grbFrom.Size = new Size(554, 77);
            grbFrom.TabIndex = 6;
            grbFrom.TabStop = false;
            grbFrom.Text = "From:";
            // 
            // txtFromMeasurement
            // 
            txtFromMeasurement.Location = new Point(84, 26);
            txtFromMeasurement.Name = "txtFromMeasurement";
            txtFromMeasurement.PlaceholderText = "Type your measurement here";
            txtFromMeasurement.Size = new Size(214, 34);
            txtFromMeasurement.TabIndex = 9;
            // 
            // cboFromUnit
            // 
            cboFromUnit.FormattingEnabled = true;
            cboFromUnit.Location = new Point(350, 26);
            cboFromUnit.Name = "cboFromUnit";
            cboFromUnit.Size = new Size(151, 29);
            cboFromUnit.TabIndex = 8;
            cboFromUnit.Text = "Select a unit";
            // 
            // grbTo
            // 
            grbTo.BackColor = SystemColors.ActiveCaption;
            grbTo.Controls.Add(txtToMeasurement);
            grbTo.Controls.Add(cboToUnit);
            grbTo.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbTo.Location = new Point(229, 299);
            grbTo.Name = "grbTo";
            grbTo.Size = new Size(554, 71);
            grbTo.TabIndex = 7;
            grbTo.TabStop = false;
            grbTo.Text = "To:";
            // 
            // txtToMeasurement
            // 
            txtToMeasurement.Location = new Point(84, 26);
            txtToMeasurement.Name = "txtToMeasurement";
            txtToMeasurement.ReadOnly = true;
            txtToMeasurement.Size = new Size(214, 34);
            txtToMeasurement.TabIndex = 10;
            // 
            // cboToUnit
            // 
            cboToUnit.FormattingEnabled = true;
            cboToUnit.Location = new Point(350, 26);
            cboToUnit.Name = "cboToUnit";
            cboToUnit.Size = new Size(151, 29);
            cboToUnit.TabIndex = 9;
            cboToUnit.Text = "Select a unit";
            // 
            // btnDirections
            // 
            btnDirections.BackColor = Color.Navy;
            btnDirections.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDirections.ForeColor = SystemColors.Control;
            btnDirections.Location = new Point(229, 116);
            btnDirections.Name = "btnDirections";
            btnDirections.Size = new Size(226, 45);
            btnDirections.TabIndex = 12;
            btnDirections.Text = "Read Directions";
            btnDirections.UseVisualStyleBackColor = false;
            btnDirections.Click += btnDirections_Click;
            // 
            // btnConversions
            // 
            btnConversions.BackColor = Color.Navy;
            btnConversions.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConversions.ForeColor = SystemColors.Control;
            btnConversions.Location = new Point(493, 116);
            btnConversions.Name = "btnConversions";
            btnConversions.Size = new Size(284, 45);
            btnConversions.TabIndex = 13;
            btnConversions.Text = "Supported Conversions";
            btnConversions.UseVisualStyleBackColor = false;
            btnConversions.Click += btnConversions_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(rdoMass);
            groupBox1.Controls.Add(rdoTemperature);
            groupBox1.Controls.Add(rdoLength);
            groupBox1.Font = new Font("Lucida Sans Unicode", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 206);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(181, 164);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Conversion Menu:";
            // 
            // rdoMass
            // 
            rdoMass.AutoSize = true;
            rdoMass.Location = new Point(23, 118);
            rdoMass.Name = "rdoMass";
            rdoMass.Size = new Size(138, 25);
            rdoMass.TabIndex = 15;
            rdoMass.TabStop = true;
            rdoMass.Text = "Mass/Weight";
            rdoMass.UseVisualStyleBackColor = true;
            // 
            // rdoTemperature
            // 
            rdoTemperature.AutoSize = true;
            rdoTemperature.Location = new Point(23, 78);
            rdoTemperature.Name = "rdoTemperature";
            rdoTemperature.Size = new Size(139, 25);
            rdoTemperature.TabIndex = 15;
            rdoTemperature.TabStop = true;
            rdoTemperature.Text = "Temperature";
            rdoTemperature.UseVisualStyleBackColor = true;
            // 
            // rdoLength
            // 
            rdoLength.AutoSize = true;
            rdoLength.Location = new Point(23, 38);
            rdoLength.Name = "rdoLength";
            rdoLength.Size = new Size(87, 25);
            rdoLength.TabIndex = 15;
            rdoLength.TabStop = true;
            rdoLength.Text = "Length";
            rdoLength.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(1, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 79);
            panel1.TabIndex = 15;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Lucida Sans Unicode", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ActiveCaption;
            lblTitle.Location = new Point(180, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(468, 73);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Unit Converter";
            // 
            // UnitConverter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(btnConversions);
            Controls.Add(btnDirections);
            Controls.Add(grbTo);
            Controls.Add(grbFrom);
            Controls.Add(btnReset);
            Controls.Add(btnCalculate);
            Name = "UnitConverter";
            Text = "Unit Converter";
            grbFrom.ResumeLayout(false);
            grbFrom.PerformLayout();
            grbTo.ResumeLayout(false);
            grbTo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontDialog fontDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton rdoMass;
        private Button btnCalculate;
        private Button btnReset;
        private GroupBox grbFrom;
        private ComboBox cboFromUnit;
        private GroupBox grbTo;
        private ComboBox cboToUnit;
        private TextBox txtFromMeasurement;
        private TextBox txtToMeasurement;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private HelpProvider helpProvider1;
        private HelpProvider helpProvider2;
        private Button btnDirections;
        private Button btnConversions;
        private GroupBox groupBox1;
        private RadioButton rdoLength;
        private RadioButton rdoTemperature;
        private PageSetupDialog pageSetupDialog1;
        private Panel panel1;
        private Label lblTitle;
    }
}
