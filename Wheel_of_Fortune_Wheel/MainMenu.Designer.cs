namespace Wheel_of_Fortune_Wheel
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.playButton = new System.Windows.Forms.Button();
            this.playerOneText = new System.Windows.Forms.TextBox();
            this.playerOnePanel = new System.Windows.Forms.Panel();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playerTwoLabel = new System.Windows.Forms.Label();
            this.playerTwoTxt = new System.Windows.Forms.TextBox();
            this.playerThreePanel = new System.Windows.Forms.Panel();
            this.playerThreeLabel = new System.Windows.Forms.Label();
            this.playerThreeTxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.playerOnePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.playerThreePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.playButton.Location = new System.Drawing.Point(163, 219);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(236, 67);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // playerOneText
            // 
            this.playerOneText.Location = new System.Drawing.Point(31, 62);
            this.playerOneText.Name = "playerOneText";
            this.playerOneText.Size = new System.Drawing.Size(135, 20);
            this.playerOneText.TabIndex = 5;
            // 
            // playerOnePanel
            // 
            this.playerOnePanel.Controls.Add(this.playerOneLabel);
            this.playerOnePanel.Controls.Add(this.playerOneText);
            this.playerOnePanel.Location = new System.Drawing.Point(33, 319);
            this.playerOnePanel.Name = "playerOnePanel";
            this.playerOnePanel.Size = new System.Drawing.Size(200, 100);
            this.playerOnePanel.TabIndex = 6;
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Font = new System.Drawing.Font("SF Fortune Wheel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.playerOneLabel.Location = new System.Drawing.Point(41, 26);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(113, 19);
            this.playerOneLabel.TabIndex = 6;
            this.playerOneLabel.Text = "Player 1:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Wheel_of_Fortune_Wheel.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(163, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.playerTwoLabel);
            this.panel1.Controls.Add(this.playerTwoTxt);
            this.panel1.Location = new System.Drawing.Point(311, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 7;
            // 
            // playerTwoLabel
            // 
            this.playerTwoLabel.AutoSize = true;
            this.playerTwoLabel.Font = new System.Drawing.Font("SF Fortune Wheel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.playerTwoLabel.Location = new System.Drawing.Point(41, 26);
            this.playerTwoLabel.Name = "playerTwoLabel";
            this.playerTwoLabel.Size = new System.Drawing.Size(120, 19);
            this.playerTwoLabel.TabIndex = 6;
            this.playerTwoLabel.Text = "Player 2:";
            // 
            // playerTwoTxt
            // 
            this.playerTwoTxt.Location = new System.Drawing.Point(31, 62);
            this.playerTwoTxt.Name = "playerTwoTxt";
            this.playerTwoTxt.Size = new System.Drawing.Size(135, 20);
            this.playerTwoTxt.TabIndex = 5;
            // 
            // playerThreePanel
            // 
            this.playerThreePanel.Controls.Add(this.playerThreeLabel);
            this.playerThreePanel.Controls.Add(this.playerThreeTxt);
            this.playerThreePanel.Location = new System.Drawing.Point(577, 319);
            this.playerThreePanel.Name = "playerThreePanel";
            this.playerThreePanel.Size = new System.Drawing.Size(200, 100);
            this.playerThreePanel.TabIndex = 7;
            // 
            // playerThreeLabel
            // 
            this.playerThreeLabel.AutoSize = true;
            this.playerThreeLabel.Font = new System.Drawing.Font("SF Fortune Wheel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerThreeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.playerThreeLabel.Location = new System.Drawing.Point(41, 26);
            this.playerThreeLabel.Name = "playerThreeLabel";
            this.playerThreeLabel.Size = new System.Drawing.Size(120, 19);
            this.playerThreeLabel.TabIndex = 6;
            this.playerThreeLabel.Text = "Player 3:";
            // 
            // playerThreeTxt
            // 
            this.playerThreeTxt.Location = new System.Drawing.Point(31, 62);
            this.playerThreeTxt.Name = "playerThreeTxt";
            this.playerThreeTxt.Size = new System.Drawing.Size(135, 20);
            this.playerThreeTxt.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.button2.Location = new System.Drawing.Point(407, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 67);
            this.button2.TabIndex = 8;
            this.button2.Text = "Help";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.playerThreePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playerOnePanel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Wheel Of Fortune";
            this.playerOnePanel.ResumeLayout(false);
            this.playerOnePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.playerThreePanel.ResumeLayout(false);
            this.playerThreePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TextBox playerOneText;
        private System.Windows.Forms.Panel playerOnePanel;
        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label playerTwoLabel;
        private System.Windows.Forms.TextBox playerTwoTxt;
        private System.Windows.Forms.Panel playerThreePanel;
        private System.Windows.Forms.Label playerThreeLabel;
        private System.Windows.Forms.TextBox playerThreeTxt;
        private System.Windows.Forms.Button button2;
    }
}