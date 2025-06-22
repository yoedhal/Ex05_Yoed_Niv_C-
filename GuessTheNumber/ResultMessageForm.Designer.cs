namespace GuessTheNumber
{
    partial class ResultMessageForm
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
            this.labelIfUserWon = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelSecretNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIfUserWon
            // 
            this.labelIfUserWon.AutoSize = true;
            this.labelIfUserWon.Location = new System.Drawing.Point(244, 56);
            this.labelIfUserWon.Name = "labelIfUserWon";
            this.labelIfUserWon.Size = new System.Drawing.Size(0, 16);
            this.labelIfUserWon.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Cyan;
            this.buttonExit.Location = new System.Drawing.Point(208, 175);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(125, 45);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonOfExit_Click);
            // 
            // labelSecretNumber
            // 
            this.labelSecretNumber.AutoSize = true;
            this.labelSecretNumber.Location = new System.Drawing.Point(244, 127);
            this.labelSecretNumber.Name = "labelSecretNumber";
            this.labelSecretNumber.Size = new System.Drawing.Size(0, 16);
            this.labelSecretNumber.TabIndex = 2;
            // 
            // ResultMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 263);
            this.Controls.Add(this.labelSecretNumber);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelIfUserWon);
            this.Name = "ResultMessageForm";
            this.Text = "ResultMessageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIfUserWon;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelSecretNumber;
    }
}