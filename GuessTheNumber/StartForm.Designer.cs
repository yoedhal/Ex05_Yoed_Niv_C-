namespace GuessTheNumber
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.buttonInstruction = new System.Windows.Forms.Button();
            this.buttonNumOfAttempts = new System.Windows.Forms.Button();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Coral;
            this.buttonStart.Location = new System.Drawing.Point(394, 171);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(169, 53);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonOfStart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Coral;
            this.buttonExit.Location = new System.Drawing.Point(22, 171);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(169, 53);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonOfExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 100);
            this.label1.TabIndex = 0;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(136, 51);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(67, 22);
            this.textBoxMin.TabIndex = 4;
            this.textBoxMin.Text = "1";
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(360, 51);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(59, 22);
            this.textBoxMax.TabIndex = 5;
            this.textBoxMax.Text = "100";
            // 
            // buttonInstruction
            // 
            this.buttonInstruction.BackColor = System.Drawing.Color.Coral;
            this.buttonInstruction.Location = new System.Drawing.Point(206, 171);
            this.buttonInstruction.Name = "buttonInstruction";
            this.buttonInstruction.Size = new System.Drawing.Size(169, 53);
            this.buttonInstruction.TabIndex = 0;
            this.buttonInstruction.Text = "Instruction";
            this.buttonInstruction.UseVisualStyleBackColor = false;
            this.buttonInstruction.Click += new System.EventHandler(this.buttonOfInstructions_Click);
            // 
            // buttonNumOfAttempts
            // 
            this.buttonNumOfAttempts.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonNumOfAttempts.Location = new System.Drawing.Point(239, 99);
            this.buttonNumOfAttempts.Name = "buttonNumOfAttempts";
            this.buttonNumOfAttempts.Size = new System.Drawing.Size(110, 43);
            this.buttonNumOfAttempts.TabIndex = 8;
            this.buttonNumOfAttempts.UseVisualStyleBackColor = false;
            this.buttonNumOfAttempts.Click += new System.EventHandler(this.buttonOfGuesses_Click);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(106, 21);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(129, 16);
            this.labelMin.TabIndex = 9;
            this.labelMin.Text = "Choose Min Number";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(319, 21);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(133, 16);
            this.labelMax.TabIndex = 10;
            this.labelMax.Text = "Choose Max Number";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 264);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.buttonNumOfAttempts);
            this.Controls.Add(this.buttonInstruction);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStart);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Button buttonInstruction;
        private System.Windows.Forms.Button buttonNumOfAttempts;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
    }
}