namespace TicTacToe.GUI
{
    partial class oPlayerButton
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
            this.label1 = new System.Windows.Forms.Label();
            this.threexthreeRadio = new System.Windows.Forms.RadioButton();
            this.fourxfourRadio = new System.Windows.Forms.RadioButton();
            this.fivexfiveRadio = new System.Windows.Forms.RadioButton();
            this.player1XRadio = new System.Windows.Forms.RadioButton();
            this.player1ORadio = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.gameEndLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-268, -127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // threexthreeRadio
            // 
            this.threexthreeRadio.AutoSize = true;
            this.threexthreeRadio.Checked = true;
            this.threexthreeRadio.Location = new System.Drawing.Point(16, 30);
            this.threexthreeRadio.Name = "threexthreeRadio";
            this.threexthreeRadio.Size = new System.Drawing.Size(65, 29);
            this.threexthreeRadio.TabIndex = 2;
            this.threexthreeRadio.TabStop = true;
            this.threexthreeRadio.Text = "3x3";
            this.threexthreeRadio.UseVisualStyleBackColor = true;
            // 
            // fourxfourRadio
            // 
            this.fourxfourRadio.AutoSize = true;
            this.fourxfourRadio.Location = new System.Drawing.Point(87, 30);
            this.fourxfourRadio.Name = "fourxfourRadio";
            this.fourxfourRadio.Size = new System.Drawing.Size(65, 29);
            this.fourxfourRadio.TabIndex = 2;
            this.fourxfourRadio.Text = "4x4";
            this.fourxfourRadio.UseVisualStyleBackColor = true;
            // 
            // fivexfiveRadio
            // 
            this.fivexfiveRadio.AutoSize = true;
            this.fivexfiveRadio.Location = new System.Drawing.Point(170, 30);
            this.fivexfiveRadio.Name = "fivexfiveRadio";
            this.fivexfiveRadio.Size = new System.Drawing.Size(65, 29);
            this.fivexfiveRadio.TabIndex = 2;
            this.fivexfiveRadio.Text = "5x5";
            this.fivexfiveRadio.UseVisualStyleBackColor = true;
            // 
            // player1XRadio
            // 
            this.player1XRadio.AutoSize = true;
            this.player1XRadio.Checked = true;
            this.player1XRadio.Location = new System.Drawing.Point(29, 39);
            this.player1XRadio.Name = "player1XRadio";
            this.player1XRadio.Size = new System.Drawing.Size(48, 29);
            this.player1XRadio.TabIndex = 4;
            this.player1XRadio.TabStop = true;
            this.player1XRadio.Text = "X";
            this.player1XRadio.UseVisualStyleBackColor = true;
            // 
            // player1ORadio
            // 
            this.player1ORadio.AutoSize = true;
            this.player1ORadio.Location = new System.Drawing.Point(110, 39);
            this.player1ORadio.Name = "player1ORadio";
            this.player1ORadio.Size = new System.Drawing.Size(51, 29);
            this.player1ORadio.TabIndex = 4;
            this.player1ORadio.Text = "O";
            this.player1ORadio.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(555, 35);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(189, 48);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.threexthreeRadio);
            this.groupBox1.Controls.Add(this.fourxfourRadio);
            this.groupBox1.Controls.Add(this.fivexfiveRadio);
            this.groupBox1.Location = new System.Drawing.Point(49, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 75);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Board Size:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.player1XRadio);
            this.groupBox2.Controls.Add(this.player1ORadio);
            this.groupBox2.Location = new System.Drawing.Point(354, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 78);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player 1:";
            // 
            // gamePanel
            // 
            this.gamePanel.Location = new System.Drawing.Point(65, 117);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(465, 349);
            this.gamePanel.TabIndex = 8;
            // 
            // gameEndLabel
            // 
            this.gameEndLabel.AutoSize = true;
            this.gameEndLabel.BackColor = System.Drawing.SystemColors.Control;
            this.gameEndLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameEndLabel.Location = new System.Drawing.Point(555, 168);
            this.gameEndLabel.Name = "gameEndLabel";
            this.gameEndLabel.Size = new System.Drawing.Size(0, 30);
            this.gameEndLabel.TabIndex = 9;
            // 
            // oPlayerButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 478);
            this.Controls.Add(this.gameEndLabel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Name = "oPlayerButton";
            this.Text = "Play As:";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton threexthreeRadio;
        private System.Windows.Forms.RadioButton fourxfourRadio;
        private System.Windows.Forms.RadioButton fivexfiveRadio;
        private System.Windows.Forms.RadioButton player1XRadio;
        private System.Windows.Forms.RadioButton player1ORadio;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label gameEndLabel;
    }
}

