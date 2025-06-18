using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex05.MasterMindWin
{
    public partial class GameForm : Form
    {
        private MasterMindLogic<Color> m_GameLogic;
        private readonly int r_CodeCount;
        private readonly int r_NumOfGuesses;
        private int m_CurrentGuessIndex = 0;
        private int m_CurrentArrowButtonIndex = 0;
        private int m_CurrentComperingButtonIndex = 0;
        private readonly List<Button> r_GuessesButtons = new List<Button>();
        private readonly List<Button> r_ComperingButtons = new List<Button>();
        private readonly List<Button> r_ArrowButtons = new List<Button>();
        private readonly List<Color> r_ListOfOptions = new List<Color>
        {
            Color.Purple,
            Color.Yellow,
            Color.Brown,
            Color.Green,
            Color.Blue,
            Color.White,
            Color.Red,
            Color.LightBlue
        };
        private readonly List<Button> r_SecretButtons = new List<Button>();

        public GameForm(int i_NumberOfChances, int i_CodeCount)
        {
            r_NumOfGuesses = i_NumberOfChances;
            r_CodeCount = i_CodeCount;
            m_GameLogic = new MasterMindLogic<Color>(r_ListOfOptions,r_CodeCount ,r_NumOfGuesses);

            InitializeComponent(i_NumberOfChances);
            this.StartPosition = FormStartPosition.CenterScreen;

            for (int i = 0; i < r_CodeCount; i++)
            {
                r_GuessesButtons[i].Enabled = true;
            }
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            ColorForm colorForm = new ColorForm();
            colorForm.ShowDialog();
            if (colorForm.Color != Color.Empty)
            {
                Color selectedColor = colorForm.Color;

                foreach (Color color in m_GameLogic.UserGuesses[m_CurrentGuessIndex].UserGuess)
                {
                    if (color == selectedColor)
                    {
                        MessageBox.Show("You already selected this color. Please choose another one.");
                        return;
                    }
                }

                m_GameLogic.UserGuesses[m_CurrentGuessIndex].UserGuess[(int)(sender as Button).Tag] = selectedColor;
                (sender as Button).BackColor = selectedColor;

                foreach (Color color in m_GameLogic.UserGuesses[m_CurrentGuessIndex].UserGuess)
                {
                    if (color == Color.Empty)
                    {
                        return;
                    }
                }

                r_ArrowButtons[m_CurrentArrowButtonIndex].Enabled = true;
            }
        }

        private void arrowButton_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            m_GameLogic.CompareGuess(m_GameLogic.UserGuesses[m_CurrentGuessIndex]);

            int copyOfCurrentGuessButtonIndex = m_CurrentGuessIndex * r_CodeCount;

            for (int i = 0; i < r_CodeCount; i++)
            {
                r_GuessesButtons[copyOfCurrentGuessButtonIndex].Enabled = false;
                copyOfCurrentGuessButtonIndex++;
            }

            for (int j = 0; j < m_GameLogic.UserGuesses[m_CurrentGuessIndex].BullCount; j++)
            {
                r_ComperingButtons[m_CurrentComperingButtonIndex].BackColor = Color.Black;
                m_CurrentComperingButtonIndex++;
            }

            if (m_GameLogic.UserGuesses[m_CurrentGuessIndex].BullCount == r_CodeCount)
            {
                int j = 0;

                foreach (Button button in r_SecretButtons)
                {
                    button.BackColor = m_GameLogic.RandomCode[j];
                    j++;
                }

                this.Close();
                ResultMessageForm resultMessageForm = new ResultMessageForm("You won!", m_GameLogic.RandomCode, r_CodeCount);
                resultMessageForm.ShowDialog();
                return;
            }

            for (int j = 0; j < m_GameLogic.UserGuesses[m_CurrentGuessIndex].HitCount; j++)
            {
                r_ComperingButtons[m_CurrentComperingButtonIndex].BackColor = Color.Yellow;
                m_CurrentComperingButtonIndex++;
            }

            m_CurrentComperingButtonIndex += r_CodeCount - m_GameLogic.UserGuesses[m_CurrentGuessIndex].BullCount - m_GameLogic.UserGuesses[m_CurrentGuessIndex].HitCount;

            m_CurrentGuessIndex++;

            if (m_CurrentGuessIndex < r_NumOfGuesses)
            {
                copyOfCurrentGuessButtonIndex = m_CurrentGuessIndex * r_CodeCount;

                for (int i = 0; i < r_CodeCount; i++)
                {
                    r_GuessesButtons[copyOfCurrentGuessButtonIndex].Enabled = true;
                    copyOfCurrentGuessButtonIndex++;
                }
            }
            else
            {
                int j = 0;

                foreach (Button button in r_SecretButtons)
                {
                    button.BackColor = m_GameLogic.RandomCode[j];
                    j++;
                }

                this.Close();
                ResultMessageForm resultMessageForm = new ResultMessageForm("You lost!", m_GameLogic.RandomCode, r_CodeCount);
                resultMessageForm.ShowDialog();
            }

            m_CurrentArrowButtonIndex++;
        }
    }
}
