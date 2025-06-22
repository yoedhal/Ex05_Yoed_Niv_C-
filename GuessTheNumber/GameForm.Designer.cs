using System.Drawing;

namespace GuessTheNumber
{
    partial class GameForm
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
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.labelUserGuess = new System.Windows.Forms.Label();
            this.buttonCheckGuess = new System.Windows.Forms.Button();
            this.labelRemainingChances = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.textBoxGuess.Location = new System.Drawing.Point(241, 145);
            this.textBoxGuess.Multiline = true;
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(166, 80);
            this.textBoxGuess.TabIndex = 0;
            // 
            // labelUserGuess
            // 
            this.labelUserGuess.AutoSize = true;
            this.labelUserGuess.BackColor = System.Drawing.Color.CornflowerBlue;
            this.labelUserGuess.Location = new System.Drawing.Point(263, 52);
            this.labelUserGuess.Name = "labelUserGuess";
            this.labelUserGuess.Size = new System.Drawing.Size(114, 16);
            this.labelUserGuess.TabIndex = 1;
            this.labelUserGuess.Text = "Enter Your Guess!";
            // 
            // buttonCheckGuess
            // 
            this.buttonCheckGuess.BackColor = System.Drawing.Color.Cornsilk;
            this.buttonCheckGuess.Location = new System.Drawing.Point(241, 282);
            this.buttonCheckGuess.Name = "buttonCheckGuess";
            this.buttonCheckGuess.Size = new System.Drawing.Size(166, 46);
            this.buttonCheckGuess.TabIndex = 2;
            this.buttonCheckGuess.Text = "Check Your Guess";
            this.buttonCheckGuess.UseVisualStyleBackColor = false;
            this.buttonCheckGuess.Click += new System.EventHandler(this.buttonOfCheckGuess_Click);
            // 
            // labelRemainingChances
            // 
            this.labelRemainingChances.AutoSize = true;
            this.labelRemainingChances.BackColor = System.Drawing.Color.DarkSalmon;
            this.labelRemainingChances.Location = new System.Drawing.Point(294, 343);
            this.labelRemainingChances.Name = "labelRemainingChances";
            this.labelRemainingChances.Size = new System.Drawing.Size(0, 16);
            this.labelRemainingChances.TabIndex = 3;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 389);
            this.Controls.Add(this.labelRemainingChances);
            this.Controls.Add(this.buttonCheckGuess);
            this.Controls.Add(this.labelUserGuess);
            this.Controls.Add(this.textBoxGuess);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.Label labelUserGuess;
        private System.Windows.Forms.Button buttonCheckGuess;
        private System.Windows.Forms.TextBox textBoxRemainingChances;
        private System.Windows.Forms.Label labelRemainingChances;
    }
}