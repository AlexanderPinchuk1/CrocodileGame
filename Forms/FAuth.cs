using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrocodileGame.ConnectionTools;
using CrocodileGame.Forms;

namespace CrocodileGame
{
    public partial class FAuth : Form
    {

        public FAuth()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void ButNext_Click(object sender, EventArgs e)
        {
            if (TextBoxUserName.Text != "")
            {
                FMenu fMenu = new FMenu() { UserName = TextBoxUserName.Text };
                fMenu.Show();
                Hide();
            }
            else
                MessageBox.Show("You did not enter a name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
