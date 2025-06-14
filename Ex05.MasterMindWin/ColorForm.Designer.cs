using System.Runtime.CompilerServices;
using System.Drawing;

namespace Ex05.MasterMindWin
{
    partial class ColorForm
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
            this.PurpleButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.YellowButton = new System.Windows.Forms.Button();
            this.BrownButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.WhiteButton = new System.Windows.Forms.Button();
            this.RedButton = new System.Windows.Forms.Button();
            this.LightBlueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PurpleButton
            // 
            this.PurpleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PurpleButton.BackColor = Color.Purple;
            this.PurpleButton.Location = new System.Drawing.Point(5, 6);
            this.PurpleButton.Name = "PurpleButton";
            this.PurpleButton.Size = new System.Drawing.Size(80, 80);
            this.PurpleButton.TabIndex = 0;
            this.PurpleButton.UseVisualStyleBackColor = false;
            this.PurpleButton.Click += new System.EventHandler(this.color_button_Click);
            // 
            // YellowButton
            // 
            this.YellowButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YellowButton.BackColor = Color.Yellow;
            this.YellowButton.Location = new System.Drawing.Point(104, 102);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(80, 80);
            this.YellowButton.TabIndex = 2;
            this.YellowButton.UseVisualStyleBackColor = false;
            this.YellowButton.Click += new System.EventHandler(this.color_button_Click);
            // 
            // BrownButton
            // 
            this.BrownButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BrownButton.BackColor = Color.Brown;
            this.BrownButton.Location = new System.Drawing.Point(211, 102);
            this.BrownButton.Name = "BrownButton";
            this.BrownButton.Size = new System.Drawing.Size(80, 80);
            this.BrownButton.TabIndex = 3;
            this.BrownButton.UseVisualStyleBackColor = false;
            this.BrownButton.Click += new System.EventHandler(this.color_button_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GreenButton.BackColor = Color.Green;
            this.GreenButton.Location = new System.Drawing.Point(211, 3);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(80, 80);
            this.GreenButton.TabIndex = 4;
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.Click += new System.EventHandler(this.color_button_Click);
            // 
            // BlueButton
            // 
            this.BlueButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BlueButton.BackColor = Color.Blue;
            this.BlueButton.Location = new System.Drawing.Point(5, 102);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(80, 80);
            this.BlueButton.TabIndex = 5;
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.Click += new System.EventHandler(this.color_button_Click);
            // 
            // WhiteButton
            // 
            this.WhiteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WhiteButton.BackColor = Color.White;
            this.WhiteButton.Location = new System.Drawing.Point(313, 102);
            this.WhiteButton.Name = "WhiteButton";
            this.WhiteButton.Size = new System.Drawing.Size(80, 80);
            this.WhiteButton.TabIndex = 6;
            this.WhiteButton.UseVisualStyleBackColor = false;
            this.WhiteButton.Click += new System.EventHandler(this.color_button_Click);
            // 
            // RedButton
            // 
            this.RedButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RedButton.BackColor = Color.Red;
            this.RedButton.Location = new System.Drawing.Point(104, 6);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(80, 80);
            this.RedButton.TabIndex = 7;
            this.RedButton.UseVisualStyleBackColor = false;
            this.RedButton.Click += new System.EventHandler(this.color_button_Click);
            // 
            // LightBlueButton
            // 
            this.LightBlueButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LightBlueButton.BackColor = Color.LightBlue;
            this.LightBlueButton.Location = new System.Drawing.Point(313, 6);
            this.LightBlueButton.Name = "LightBlueButton";
            this.LightBlueButton.Size = new System.Drawing.Size(80, 80);
            this.LightBlueButton.TabIndex = 8;
            this.LightBlueButton.UseVisualStyleBackColor = false;
            this.LightBlueButton.Click += new System.EventHandler(this.color_button_Click);
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 207);
            this.Controls.Add(this.LightBlueButton);
            this.Controls.Add(this.RedButton);
            this.Controls.Add(this.WhiteButton);
            this.Controls.Add(this.BlueButton);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.BrownButton);
            this.Controls.Add(this.YellowButton);
            this.Controls.Add(this.PurpleButton);
            this.Name = "ColorForm";
            this.Text = "ColorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PurpleButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button YellowButton;
        private System.Windows.Forms.Button BrownButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button WhiteButton;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button LightBlueButton;
    }
}