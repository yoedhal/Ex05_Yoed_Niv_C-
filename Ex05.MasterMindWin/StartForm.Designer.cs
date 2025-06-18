using System.Drawing;
using System.Windows.Forms;

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
            this.buttonlength = new System.Windows.Forms.Button();
            this.buttonInstructions = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOfChances
            // 
            this.buttonOfChances.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOfChances.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonOfChances.Location = new System.Drawing.Point(12, 40);
            this.buttonOfChances.Name = "buttonOfChances";
            this.buttonOfChances.Size = new System.Drawing.Size(160, 70);
            this.buttonOfChances.TabIndex = 0;
            this.buttonOfChances.UseVisualStyleBackColor = false;
            this.buttonOfChances.Click += new System.EventHandler(this.buttonOfChances_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StartButton.Location = new System.Drawing.Point(132, 0);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(118, 39);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // buttonlength
            // 
            this.buttonlength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonlength.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonlength.Location = new System.Drawing.Point(213, 40);
            this.buttonlength.Name = "buttonlength";
            this.buttonlength.Size = new System.Drawing.Size(160, 70);
            this.buttonlength.TabIndex = 0;
            this.buttonlength.UseVisualStyleBackColor = false;
            this.buttonlength.Click += new System.EventHandler(this.buttonOfLengthOfCode_Click);
            // 
            // buttonInstructions
            // 
            this.buttonInstructions.Location = new System.Drawing.Point(0, 0);
            this.buttonInstructions.Name = "buttonInstructions";
            this.buttonInstructions.Size = new System.Drawing.Size(111, 39);
            this.buttonInstructions.TabIndex = 1;
            this.buttonInstructions.Text = "Instructions";
            this.buttonInstructions.UseVisualStyleBackColor = false;
            this.buttonInstructions.Click += new System.EventHandler(this.InstructionButton_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.Controls.Add(this.buttonInstructions);
            this.panelButtons.Controls.Add(this.StartButton);
            this.panelButtons.Location = new System.Drawing.Point(126, 133);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(250, 50);
            this.panelButtons.TabIndex = 1;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(388, 186);
            this.Controls.Add(this.buttonlength);
            this.Controls.Add(this.buttonOfChances);
            this.Controls.Add(this.panelButtons);
            this.Name = "StartForm";
            this.Text = "MasterMind";
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button buttonOfChances;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button buttonlength;
        private System.Windows.Forms.Button buttonInstructions;
    }
}