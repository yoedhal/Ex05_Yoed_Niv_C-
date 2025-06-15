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
    public partial class ResultMessageForm : Form
    {
        private List<Button> m_buttons = new List<Button>(4);

        public ResultMessageForm(string i_message, List<Color> i_TheCodeList)
        {
            InitializeComponent();

            this.Text = "MasterMind Result";

            textBox1.Text = i_message + Environment.NewLine + "The code was: ";

            int i = 0;

            foreach(Button button in m_buttons)
            {
                button.BackColor  = i_TheCodeList[i];
                i++;
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
