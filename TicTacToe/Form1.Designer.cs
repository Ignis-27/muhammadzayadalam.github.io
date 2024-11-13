namespace TicTacToe
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
            this.gamePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.winnerDisplayLabel = new System.Windows.Forms.Label();
            this.winnerLabel1 = new System.Windows.Forms.Label();
            this.oPlayerScoreTextBox = new System.Windows.Forms.TextBox();
            this.xPlayerScoreTextBox = new System.Windows.Forms.TextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.oPlayerButton = new System.Windows.Forms.Button();
            this.XPlayerButton = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.oPlayerTextBox = new System.Windows.Forms.TextBox();
            this.xPlayerTextBox = new System.Windows.Forms.TextBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.gameAreaLabel = new System.Windows.Forms.Label();
            this.playerTurnLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gamePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Lavender;
            this.gamePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.gamePanel.ColumnCount = 3;
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gamePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gamePanel.Controls.Add(this.label10, 2, 2);
            this.gamePanel.Controls.Add(this.label9, 1, 2);
            this.gamePanel.Controls.Add(this.label8, 0, 2);
            this.gamePanel.Controls.Add(this.label7, 2, 1);
            this.gamePanel.Controls.Add(this.label6, 1, 1);
            this.gamePanel.Controls.Add(this.label5, 0, 1);
            this.gamePanel.Controls.Add(this.label4, 2, 0);
            this.gamePanel.Controls.Add(this.label3, 1, 0);
            this.gamePanel.Controls.Add(this.label2, 0, 0);
            this.gamePanel.Location = new System.Drawing.Point(13, 286);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.RowCount = 3;
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gamePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.gamePanel.Size = new System.Drawing.Size(487, 390);
            this.gamePanel.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(328, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 126);
            this.label10.TabIndex = 8;
            this.label10.Text = "✖️";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.labelclicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(167, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 126);
            this.label9.TabIndex = 7;
            this.label9.Text = "✖️";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.labelclicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 126);
            this.label8.TabIndex = 6;
            this.label8.Text = "✖️";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.labelclicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(328, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 126);
            this.label7.TabIndex = 5;
            this.label7.Text = "✖️";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.labelclicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 126);
            this.label6.TabIndex = 4;
            this.label6.Text = "✖️";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.labelclicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 126);
            this.label5.TabIndex = 3;
            this.label5.Text = "✖️";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.labelclicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 126);
            this.label4.TabIndex = 2;
            this.label4.Text = "✖️";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.labelclicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 126);
            this.label3.TabIndex = 1;
            this.label3.Text = "✖️";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.labelclicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 126);
            this.label2.TabIndex = 0;
            this.label2.Text = "✖️";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.labelclicked);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.winnerDisplayLabel);
            this.panel1.Controls.Add(this.winnerLabel1);
            this.panel1.Controls.Add(this.oPlayerScoreTextBox);
            this.panel1.Controls.Add(this.xPlayerScoreTextBox);
            this.panel1.Controls.Add(this.scoreLabel);
            this.panel1.Controls.Add(this.oPlayerButton);
            this.panel1.Controls.Add(this.XPlayerButton);
            this.panel1.Controls.Add(this.colorLabel);
            this.panel1.Controls.Add(this.oPlayerTextBox);
            this.panel1.Controls.Add(this.xPlayerTextBox);
            this.panel1.Controls.Add(this.yLabel);
            this.panel1.Controls.Add(this.xLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(14, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 163);
            this.panel1.TabIndex = 1;
            // 
            // winnerDisplayLabel
            // 
            this.winnerDisplayLabel.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerDisplayLabel.Location = new System.Drawing.Point(396, 53);
            this.winnerDisplayLabel.Name = "winnerDisplayLabel";
            this.winnerDisplayLabel.Size = new System.Drawing.Size(72, 66);
            this.winnerDisplayLabel.TabIndex = 12;
            this.winnerDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.winnerDisplayLabel, "This player is the winner ");
            // 
            // winnerLabel1
            // 
            this.winnerLabel1.AutoSize = true;
            this.winnerLabel1.Location = new System.Drawing.Point(393, 19);
            this.winnerLabel1.Name = "winnerLabel1";
            this.winnerLabel1.Size = new System.Drawing.Size(49, 16);
            this.winnerLabel1.TabIndex = 11;
            this.winnerLabel1.Text = "Winner";
            // 
            // oPlayerScoreTextBox
            // 
            this.oPlayerScoreTextBox.Location = new System.Drawing.Point(301, 97);
            this.oPlayerScoreTextBox.Name = "oPlayerScoreTextBox";
            this.oPlayerScoreTextBox.ReadOnly = true;
            this.oPlayerScoreTextBox.Size = new System.Drawing.Size(45, 22);
            this.oPlayerScoreTextBox.TabIndex = 10;
            this.toolTip1.SetToolTip(this.oPlayerScoreTextBox, "this is the score for player 0");
            // 
            // xPlayerScoreTextBox
            // 
            this.xPlayerScoreTextBox.Location = new System.Drawing.Point(301, 53);
            this.xPlayerScoreTextBox.Name = "xPlayerScoreTextBox";
            this.xPlayerScoreTextBox.ReadOnly = true;
            this.xPlayerScoreTextBox.Size = new System.Drawing.Size(45, 22);
            this.xPlayerScoreTextBox.TabIndex = 9;
            this.toolTip1.SetToolTip(this.xPlayerScoreTextBox, "this is the score for player X ");
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(297, 16);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(49, 19);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "Score";
            // 
            // oPlayerButton
            // 
            this.oPlayerButton.Location = new System.Drawing.Point(210, 97);
            this.oPlayerButton.Name = "oPlayerButton";
            this.oPlayerButton.Size = new System.Drawing.Size(61, 23);
            this.oPlayerButton.TabIndex = 7;
            this.toolTip1.SetToolTip(this.oPlayerButton, "This will be the color for player (O)");
            this.oPlayerButton.UseVisualStyleBackColor = true;
            this.oPlayerButton.Click += new System.EventHandler(this.oPlayerButton_Click);
            // 
            // XPlayerButton
            // 
            this.XPlayerButton.Location = new System.Drawing.Point(210, 53);
            this.XPlayerButton.Name = "XPlayerButton";
            this.XPlayerButton.Size = new System.Drawing.Size(61, 23);
            this.XPlayerButton.TabIndex = 6;
            this.toolTip1.SetToolTip(this.XPlayerButton, "This will be color for player (X)");
            this.XPlayerButton.UseVisualStyleBackColor = true;
            this.XPlayerButton.Click += new System.EventHandler(this.XPlayerButton_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(206, 16);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(49, 19);
            this.colorLabel.TabIndex = 5;
            this.colorLabel.Text = "Color";
            // 
            // oPlayerTextBox
            // 
            this.oPlayerTextBox.Location = new System.Drawing.Point(49, 97);
            this.oPlayerTextBox.Name = "oPlayerTextBox";
            this.oPlayerTextBox.Size = new System.Drawing.Size(123, 22);
            this.oPlayerTextBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.oPlayerTextBox, "Please enter the name of player O here ");
            // 
            // xPlayerTextBox
            // 
            this.xPlayerTextBox.Location = new System.Drawing.Point(49, 54);
            this.xPlayerTextBox.Name = "xPlayerTextBox";
            this.xPlayerTextBox.Size = new System.Drawing.Size(123, 22);
            this.xPlayerTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.xPlayerTextBox, "Pleasde enter the nam eof player x here ");
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yLabel.Location = new System.Drawing.Point(13, 97);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(45, 23);
            this.yLabel.TabIndex = 2;
            this.yLabel.Text = "O:- ";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(11, 54);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(42, 23);
            this.xLabel.TabIndex = 1;
            this.xLabel.Text = "X:- ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(13, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(104, 19);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Player names ";
            // 
            // gameAreaLabel
            // 
            this.gameAreaLabel.AutoSize = true;
            this.gameAreaLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameAreaLabel.Location = new System.Drawing.Point(12, 205);
            this.gameAreaLabel.Name = "gameAreaLabel";
            this.gameAreaLabel.Size = new System.Drawing.Size(95, 19);
            this.gameAreaLabel.TabIndex = 2;
            this.gameAreaLabel.Text = "Game Area:-";
            // 
            // playerTurnLabel
            // 
            this.playerTurnLabel.AutoSize = true;
            this.playerTurnLabel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTurnLabel.Location = new System.Drawing.Point(179, 244);
            this.playerTurnLabel.Name = "playerTurnLabel";
            this.playerTurnLabel.Size = new System.Drawing.Size(191, 20);
            this.playerTurnLabel.TabIndex = 3;
            this.playerTurnLabel.Text = "waiting for player names ";
            this.playerTurnLabel.Click += new System.EventHandler(this.labelclicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(524, 688);
            this.Controls.Add(this.playerTurnLabel);
            this.Controls.Add(this.gameAreaLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe - Zayad Alam ";
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel gamePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label gameAreaLabel;
        private System.Windows.Forms.Label playerTurnLabel;
        private System.Windows.Forms.Button XPlayerButton;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TextBox oPlayerTextBox;
        private System.Windows.Forms.TextBox xPlayerTextBox;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Button oPlayerButton;
        private System.Windows.Forms.TextBox oPlayerScoreTextBox;
        private System.Windows.Forms.TextBox xPlayerScoreTextBox;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label winnerLabel1;
        private System.Windows.Forms.Label winnerDisplayLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

