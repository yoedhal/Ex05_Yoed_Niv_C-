namespace Ex05.MasterMindWin
{
    partial class StartForm
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
            this.buttonOfChances = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOfChances
            // 
            this.buttonOfChances.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOfChances.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonOfChances.Location = new System.Drawing.Point(22, 51);
            this.buttonOfChances.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOfChances.Name = "buttonOfChances";
            this.buttonOfChances.Size = new System.Drawing.Size(390, 64);
            this.buttonOfChances.TabIndex = 0;
            this.buttonOfChances.UseVisualStyleBackColor = false;
            this.buttonOfChances.Click += new System.EventHandler(this.buttonOfChances_Click);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StartButton.Location = new System.Drawing.Point(296, 172);
            this.StartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(133, 49);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(436, 232);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.buttonOfChances);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StartForm";
            this.Text = "MasterMind";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOfChances;
        private System.Windows.Forms.Button StartButton;
    }
}