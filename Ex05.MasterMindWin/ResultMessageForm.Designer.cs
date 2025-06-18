using System.Drawing;
using System.Windows.Forms;
using System;

namespace Ex05.MasterMindWin
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
        //private void InitializeComponent()
        //{
        //    this.button1 = new System.Windows.Forms.Button();
        //    this.textBox1 = new System.Windows.Forms.TextBox();
        //    this.button2 = new System.Windows.Forms.Button();
        //    this.button3 = new System.Windows.Forms.Button();
        //    this.button4 = new System.Windows.Forms.Button();
        //    this.button5 = new System.Windows.Forms.Button();
        //    this.SuspendLayout();
        //    // 
        //    // button1
        //    // 
        //    this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        //    this.button1.Location = new System.Drawing.Point(549, 177);
        //    this.button1.Name = "button1";
        //    this.button1.Size = new System.Drawing.Size(136, 49);
        //    this.button1.TabIndex = 0;
        //    this.button1.Text = "OK";
        //    this.button1.UseVisualStyleBackColor = true;
        //    this.button1.Click += new System.EventHandler(this.OKbutton_Click);
        //    // 
        //    // textBox1
        //    // 
        //    this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        //    | System.Windows.Forms.AnchorStyles.Right)));
        //    this.textBox1.Enabled = false;
        //    this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //    this.textBox1.Location = new System.Drawing.Point(12, 12);
        //    this.textBox1.Multiline = true;
        //    this.textBox1.Name = "textBox1";
        //    this.textBox1.Size = new System.Drawing.Size(673, 69);
        //    this.textBox1.TabIndex = 1;
        //    this.textBox1.Text = "kjbknknkn";
        //    // 
        //    // button2
        //    // 
        //    this.button2.Location = new System.Drawing.Point(111, 117);
        //    this.button2.Name = "button2";
        //    this.button2.Size = new System.Drawing.Size(75, 75);
        //    this.button2.TabIndex = 2;
        //    this.button2.UseVisualStyleBackColor = true;
        //    button2.Enabled = false;
        //    m_buttons.Add(button2);
        //    // 
        //    // button3
        //    // 
        //    this.button3.Location = new System.Drawing.Point(212, 117);
        //    this.button3.Name = "button3";
        //    this.button3.Size = new System.Drawing.Size(75, 75);
        //    this.button3.TabIndex = 3;
        //    this.button3.UseVisualStyleBackColor = true;
        //    button3.Enabled = false;
        //    m_buttons.Add(button3);
        //    // 
        //    // button4
        //    // 
        //    this.button4.Location = new System.Drawing.Point(318, 117);
        //    this.button4.Name = "button4";
        //    this.button4.Size = new System.Drawing.Size(75, 75);
        //    this.button4.TabIndex = 4;
        //    this.button4.UseVisualStyleBackColor = true;
        //    button4.Enabled = false;
        //    m_buttons.Add(button4);
        //    // 
        //    // button5
        //    // 
        //    this.button5.Location = new System.Drawing.Point(419, 117);
        //    this.button5.Name = "button5";
        //    this.button5.Size = new System.Drawing.Size(75, 75);
        //    this.button5.TabIndex = 5;
        //    this.button5.UseVisualStyleBackColor = true;
        //    button5.Enabled = false;
        //    m_buttons.Add(button5);
        //    // 
        //    // ResultMessageForm
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(697, 238);
        //    this.Controls.Add(this.button5);
        //    this.Controls.Add(this.button4);
        //    this.Controls.Add(this.button3);
        //    this.Controls.Add(this.button2);
        //    this.Controls.Add(this.textBox1);
        //    this.Controls.Add(this.button1);
        //    this.MaximizeBox = false;
        //    this.MinimizeBox = false;
        //    this.Name = "ResultMessageForm";
        //    this.Text = "ResultMessageForm";
        //    this.ResumeLayout(false);
        //    this.PerformLayout();

        //}
        private void InitializeComponent()
        {
            int buttonSize = 60;
            int spacing = 10;
            int padding = 20;

            // 🟥 תיבת טקסט להודעה
            messageTextBox = new TextBox();
            messageTextBox.Multiline = true;
            messageTextBox.Enabled = false;
            messageTextBox.Font = new Font("Microsoft Sans Serif", 11F);
            messageTextBox.Text = $"{r_Message}{Environment.NewLine}The code was:";
            messageTextBox.Size = new Size(400, 60);
            messageTextBox.Location = new Point(padding, padding);
            messageTextBox.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(messageTextBox);

            // 🟦 יצירת כפתורי צבעים
            int totalButtonWidth = r_CodeCount * buttonSize + (r_CodeCount - 1) * spacing;
            int startX = (messageTextBox.Width - totalButtonWidth) / 2 + padding;
            int buttonY = messageTextBox.Bottom + spacing;

            for (int i = 0; i < r_CodeCount; i++)
            {
                Button colorButton = new Button();
                colorButton.Size = new Size(buttonSize, buttonSize);
                colorButton.Location = new Point(startX + i * (buttonSize + spacing), buttonY);
                colorButton.BackColor = r_CodeColors[i];
                colorButton.Enabled = false;
                colorButton.FlatStyle = FlatStyle.Flat;
                this.Controls.Add(colorButton);
                colorButtons.Add(colorButton);
            }

            // 🟩 כפתור OK
            okButton = new Button();
            okButton.Text = "OK";
            okButton.Size = new Size(100, 40);
            okButton.Location = new Point((messageTextBox.Width - okButton.Width) / 2 + padding, buttonY + buttonSize + spacing);
            okButton.Click += OKbutton_Click;
            this.Controls.Add(okButton);

            // 🟪 הגדרת הטופס עצמו
            this.ClientSize = new Size(messageTextBox.Width + 2 * padding, okButton.Bottom + padding);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "MasterMind Result";
        }
        #endregion

        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.TextBox textBox1;
        //private System.Windows.Forms.Button button2;
        //private System.Windows.Forms.Button button3;
        //private System.Windows.Forms.Button button4;
        //private System.Windows.Forms.Button button5;
    }
}