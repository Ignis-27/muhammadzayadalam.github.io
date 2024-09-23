namespace DogYearsConverter
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.dogYearTextBox = new System.Windows.Forms.TextBox();
            this.dogYearsLabel = new System.Windows.Forms.Label();
            this.humanYearLabel = new System.Windows.Forms.Label();
            this.infoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.errorTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.mainPanel.SuspendLayout();
            this.outputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.PaleGreen;
            this.mainPanel.Controls.Add(this.outputPanel);
            this.mainPanel.Controls.Add(this.numericUpDown1);
            this.mainPanel.Controls.Add(this.calculateButton);
            this.mainPanel.Controls.Add(this.resetButton);
            this.mainPanel.Controls.Add(this.dogYearTextBox);
            this.mainPanel.Controls.Add(this.dogYearsLabel);
            this.mainPanel.Controls.Add(this.humanYearLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(714, 591);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // outputPanel
            // 
            this.outputPanel.Controls.Add(this.pictureBox1);
            this.outputPanel.Controls.Add(this.infoLabel);
            this.outputPanel.Location = new System.Drawing.Point(12, 249);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(690, 330);
            this.outputPanel.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(202, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(24, 33);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(639, 23);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = "info";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infoLabel.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(393, 43);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(282, 22);
            this.numericUpDown1.TabIndex = 7;
            this.infoToolTip.SetToolTip(this.numericUpDown1, "Enter the dogs age in human years ");
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(421, 196);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(112, 30);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.infoToolTip.SetToolTip(this.calculateButton, "this will calculate the dogs age ");
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(98, 196);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(99, 30);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.infoToolTip.SetToolTip(this.resetButton, "this will reset all the values to zero ");
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // dogYearTextBox
            // 
            this.dogYearTextBox.Location = new System.Drawing.Point(393, 100);
            this.dogYearTextBox.Name = "dogYearTextBox";
            this.dogYearTextBox.ReadOnly = true;
            this.dogYearTextBox.Size = new System.Drawing.Size(282, 22);
            this.dogYearTextBox.TabIndex = 3;
            this.infoToolTip.SetToolTip(this.dogYearTextBox, "the age of the dog in dog years ");
            // 
            // dogYearsLabel
            // 
            this.dogYearsLabel.AutoSize = true;
            this.dogYearsLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dogYearsLabel.Location = new System.Drawing.Point(12, 87);
            this.dogYearsLabel.Name = "dogYearsLabel";
            this.dogYearsLabel.Size = new System.Drawing.Size(325, 37);
            this.dogYearsLabel.TabIndex = 1;
            this.dogYearsLabel.Text = "Dog\'s age in dog years :";
            // 
            // humanYearLabel
            // 
            this.humanYearLabel.AutoSize = true;
            this.humanYearLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humanYearLabel.Location = new System.Drawing.Point(12, 29);
            this.humanYearLabel.Name = "humanYearLabel";
            this.humanYearLabel.Size = new System.Drawing.Size(366, 37);
            this.humanYearLabel.TabIndex = 0;
            this.humanYearLabel.Text = "Dog\'s age in human years :";
            // 
            // infoToolTip
            // 
            this.infoToolTip.IsBalloon = true;
            // 
            // errorTooltip
            // 
            this.errorTooltip.AutoPopDelay = 5000;
            this.errorTooltip.InitialDelay = 500;
            this.errorTooltip.ReshowDelay = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 591);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dog Years Coverter - Zayad Alam ";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.outputPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label dogYearsLabel;
        private System.Windows.Forms.Label humanYearLabel;
        private System.Windows.Forms.TextBox dogYearTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolTip infoToolTip;
        private System.Windows.Forms.ToolTip errorTooltip;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.Label infoLabel;
    }
}

