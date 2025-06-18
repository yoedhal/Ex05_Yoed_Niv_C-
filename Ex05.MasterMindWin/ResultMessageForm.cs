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
        private readonly int r_CodeCount;
        private readonly List<Color> r_CodeColors;
        private readonly string r_Message;

        private TextBox messageTextBox;
        private Button okButton;
        private List<Button> colorButtons = new List<Button>();

        public ResultMessageForm(string i_Message, List<Color> i_TheCodeList, int i_CodeCount)
        {
            r_Message = i_Message;
            r_CodeColors = i_TheCodeList;
            r_CodeCount = i_CodeCount;

            InitializeComponent();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
