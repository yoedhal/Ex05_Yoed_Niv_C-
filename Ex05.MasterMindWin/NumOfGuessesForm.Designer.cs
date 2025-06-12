namespace Ex05.MasterMindWin
{
    partial class NumOfGuessesForm
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
            this.buttonOfChances.Location = new System.Drawing.Point(34, 40);
            this.buttonOfChances.Name = "buttonOfChances";
            this.buttonOfChances.Size = new System.Drawing.Size(347, 51);
            this.buttonOfChances.TabIndex = 0;
            this.buttonOfChances.UseVisualStyleBackColor = false;
            this.buttonOfChances.Click += new System.EventHandler(this.buttonOfChances_Click_1);
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StartButton.Location = new System.Drawing.Point(263, 138);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(118, 39);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            // 
            // BoolPgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(388, 186);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.buttonOfChances);
            this.Name = "BoolPgia";
            this.Text = "Bool Pgia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOfChances;
        private System.Windows.Forms.Button StartButton;
    }
}