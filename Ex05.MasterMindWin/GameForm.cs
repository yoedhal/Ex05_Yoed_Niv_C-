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
        private Color m_Color;
        private int m_CodeCount = 4;
        private int m_NumOfGuesses;
        private List<Color> m_Colors = new List<Color>
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

        public Color Color
        {
            get
            {
                return m_Color;
            }
        }

        public GameForm()
        {
            InitializeComponent();
        }

    }
}
