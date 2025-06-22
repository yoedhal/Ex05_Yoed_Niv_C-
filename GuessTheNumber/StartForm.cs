using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class StartForm : Form
    {
        private const int k_MinGuesses = 4;
        private const int k_MaxGuesses = 10;
        private int m_NumberOfChances = 4;
        private int m_MinOptionalGuess;
        private int m_MaxOptionalGuess;
        public StartForm()
        {
            InitializeComponent();
            this.Text = "GuessTheNumber";
            buttonNumOfAttempts.Text = "Number of chances: " + m_NumberOfChances;
            this.StartPosition = FormStartPosition.CenterScreen;
            textBoxMin.TextAlign = HorizontalAlignment.Center;
            textBoxMax.TextAlign = HorizontalAlignment.Center;
        }

        private void buttonOfStart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxMin.Text, out m_MinOptionalGuess) &&
                (int.TryParse(textBoxMax.Text, out m_MaxOptionalGuess)))
            {
                if (m_MaxOptionalGuess <= m_MinOptionalGuess)
                {
                    MessageBox.Show("The maximum number must be greater than the minimum number.", "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.Close();
                GameForm gameForm = new GameForm(m_MinOptionalGuess, m_MaxOptionalGuess, m_NumberOfChances);
                gameForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please enter valid whole numbers (integers) for both minimum and maximum.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
               
        }

        private void buttonOfInstructions_Click(object sender, EventArgs e)
        {
            this.Hide();

            InstructionsForm instructionsForm = new InstructionsForm(); 
            instructionsForm.ShowDialog();

            this.Show();
        }

        private void buttonOfGuesses_Click(object sender, EventArgs e)
        {
            m_NumberOfChances++;

            if (m_NumberOfChances > k_MaxGuesses)
            {
                m_NumberOfChances = k_MinGuesses;
            }

            buttonNumOfAttempts.Text = "Number of chances: " + m_NumberOfChances;
        }

        private void buttonOfExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
