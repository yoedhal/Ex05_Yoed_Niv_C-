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
        private const int k_CodeCount = 4;
        private readonly int r_NumOfGuesses;
        private int m_CurrentGuessIndex = 0;
        private int m_CurrentGuessButtonIndex = 0;
        private int m_CurrentArrowButtonIndex = 0;
        private int m_CurrentComperingButtonIndex = 0;
        private List<Button> m_GuessesButtons = new List<Button>();
        private List<Button> m_ComperingButtons = new List<Button>();
        private List<Button> m_ArrowButtons = new List<Button>();
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
        private List<Button> m_SecretButtons = new List<Button>();

        public GameForm(int i_NumberOfChances)
        {
            r_NumOfGuesses = i_NumberOfChances;
            m_GameLogic = new MasterMindLogic<Color>(r_ListOfOptions,k_CodeCount,r_NumOfGuesses);
            InitializeComponent(i_NumberOfChances);
            for (int i = 0; i < k_CodeCount; i++)
            {
                m_GuessesButtons[i].Enabled = true;
            }
            int j = 0;
            foreach (Button button in m_SecretButtons)
            {
                button.BackColor = m_GameLogic.RandomCode[j];
                j++;
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
                m_ArrowButtons[m_CurrentArrowButtonIndex].Enabled = true;
            }
        }


        private void arrowButton_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;
            m_GameLogic.CompareGuess(m_GameLogic.UserGuesses[m_CurrentGuessIndex]);

            m_CurrentGuessButtonIndex = m_CurrentGuessIndex * k_CodeCount;

            int copyOfCurrentGuessButtonIndex = m_CurrentGuessButtonIndex;
            for (int i = 0; i < k_CodeCount; i++)
            {
                m_GuessesButtons[copyOfCurrentGuessButtonIndex].Enabled = false;
                copyOfCurrentGuessButtonIndex++;
            }

            for (int j = 0; j < m_GameLogic.UserGuesses[m_CurrentGuessIndex].BullCount; j++)
            {
                m_ComperingButtons[m_CurrentComperingButtonIndex].BackColor = Color.Black;
                m_CurrentComperingButtonIndex++;
            }

            if (m_GameLogic.UserGuesses[m_CurrentGuessIndex].BullCount == k_CodeCount)
            {
                MessageBox.Show("Congratulations! You guessed the code!");
                this.Close();
            }

            for (int j = 0; j < m_GameLogic.UserGuesses[m_CurrentGuessIndex].HitCount; j++)
            {
                m_ComperingButtons[m_CurrentComperingButtonIndex].BackColor = Color.Yellow;
                m_CurrentComperingButtonIndex++;
            }

            m_CurrentComperingButtonIndex += k_CodeCount - m_GameLogic.UserGuesses[m_CurrentGuessIndex].BullCount - m_GameLogic.UserGuesses[m_CurrentGuessIndex].HitCount;

            m_CurrentGuessIndex++;
            if (m_CurrentGuessIndex < r_NumOfGuesses)
            {
                copyOfCurrentGuessButtonIndex = m_CurrentGuessIndex * k_CodeCount;
                for (int i = 0; i < k_CodeCount; i++)
                {
                    m_GuessesButtons[copyOfCurrentGuessButtonIndex].Enabled = true;
                    copyOfCurrentGuessButtonIndex++;
                }
            }
            else
            {
                this.Close();
                MessageBox.Show("No more guesses allowed. You lost. The code was: " + string.Join(" ", m_GameLogic.RandomCode));
            }
            m_CurrentArrowButtonIndex++;
        }
    }
}
