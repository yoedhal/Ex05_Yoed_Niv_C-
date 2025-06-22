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
    public partial class GameForm : Form
    {
        private readonly int r_MinNumberToGuess;
        private readonly int r_MaxNumberToGuess;
        private readonly int r_NumberToGuess;
        private readonly int r_NumberOfChances;
        private int m_NumberOfReamainigChances;
        private bool m_IfUserWon = false;

        private GuessTheNumberLogic<int> m_GameLogic;

        public GameForm(int i_MinNumberToGuess , int i_MaxNumberToGuess, int i_NumberOfChances)
        {
            InitializeComponent();
            this.Text = "GuessTheNumber";
            this.StartPosition = FormStartPosition.CenterScreen;
            textBoxGuess.TextAlign = HorizontalAlignment.Center;
            
            r_MinNumberToGuess = i_MinNumberToGuess;
            r_MaxNumberToGuess = i_MaxNumberToGuess;
            r_NumberOfChances = i_NumberOfChances;
            m_NumberOfReamainigChances = i_NumberOfChances;

            labelRemainingChances.Text = "remaining chances: " + m_NumberOfReamainigChances;

            Random random = new Random();
            m_GameLogic = new GuessTheNumberLogic<int>(() => random.Next(r_MinNumberToGuess, r_MaxNumberToGuess + 1), r_NumberOfChances);

            r_NumberToGuess = m_GameLogic.SecretElement;
        }


        private void buttonOfCheckGuess_Click(object sender, EventArgs e)
        {
            int userGuess;

            if (!int.TryParse(textBoxGuess.Text, out userGuess))
            {
                MessageBox.Show("Please enter a valid whole number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userGuess < r_MinNumberToGuess || userGuess > r_MaxNumberToGuess)
            {
                MessageBox.Show($"Please enter a number between {r_MinNumberToGuess} and {r_MaxNumberToGuess}.", "Out of Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(userGuess == r_NumberToGuess)
            {
                m_IfUserWon = true;

                this.operateResultForm();
            }

            if(userGuess >  r_NumberToGuess)
            {
                this.labelUserGuess.Text = "Too high";
                m_NumberOfReamainigChances--;
                if (!(this.checkIfRemainChances()))
                {
                    this.operateResultForm();
                }
                else
                {
                    labelRemainingChances.Text = "remaining chances: " + m_NumberOfReamainigChances;
                    return;
                }
            }

            if (userGuess < r_NumberToGuess)
            {
                this.labelUserGuess.Text = "Too low";
                m_NumberOfReamainigChances--;

                if (!(this.checkIfRemainChances()))
                {
                    this.operateResultForm();
                }
                else
                {
                    labelRemainingChances.Text = "remaining chances: " + m_NumberOfReamainigChances;
                    return;
                }
            }
        }

        private bool checkIfRemainChances()
        {
            bool IfRemainChance = true;
            if(this.m_NumberOfReamainigChances == 0)
            {
                IfRemainChance = false;
            }

            return IfRemainChance;
        }

        private void operateResultForm()
        {
            this.Hide();

            ResultMessageForm resultForm = new ResultMessageForm(m_IfUserWon, r_NumberToGuess);
            resultForm.ShowDialog();

            this.Close();
        }
    }
}
