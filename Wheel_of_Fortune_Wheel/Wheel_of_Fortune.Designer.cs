namespace Wheel_of_Fortune_Wheel
{
    partial class Main
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
            this.WOF_Wheel = new System.Windows.Forms.PictureBox();
            this.Spin_Button = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WOF_Wheel)).BeginInit();
            this.SuspendLayout();
            // 
            // WOF_Wheel
            // 
            this.WOF_Wheel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WOF_Wheel.BackColor = System.Drawing.Color.White;
            this.WOF_Wheel.BackgroundImage = global::Wheel_of_Fortune_Wheel.Properties.Resources.No_slots_active;
            this.WOF_Wheel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WOF_Wheel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WOF_Wheel.Location = new System.Drawing.Point(715, 104);
            this.WOF_Wheel.Name = "WOF_Wheel";
            this.WOF_Wheel.Size = new System.Drawing.Size(512, 467);
            this.WOF_Wheel.TabIndex = 0;
            this.WOF_Wheel.TabStop = false;
            // 
            // Spin_Button
            // 
            this.Spin_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Spin_Button.BackColor = System.Drawing.Color.Gold;
            this.Spin_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Spin_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin_Button.Location = new System.Drawing.Point(854, 577);
            this.Spin_Button.Name = "Spin_Button";
            this.Spin_Button.Size = new System.Drawing.Size(234, 71);
            this.Spin_Button.TabIndex = 1;
            this.Spin_Button.Text = "Spin That Wheel!";
            this.Spin_Button.UseVisualStyleBackColor = false;
            this.Spin_Button.Click += new System.EventHandler(this.Spin_Button_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(810, 36);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(279, 37);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Wheel of Fortune";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 659);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.Spin_Button);
            this.Controls.Add(this.WOF_Wheel);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Wheel_of_Fortune";
            this.Click += new System.EventHandler(this.Spin_Button_Click);
            ((System.ComponentModel.ISupportInitialize)(this.WOF_Wheel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Spin_Button;
        private System.Windows.Forms.PictureBox WOF_Wheel;
        private System.Windows.Forms.Label TitleLabel;
    }
}

