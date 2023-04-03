using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MysteryN
{
    public partial class Form1 : Form
    { 
        
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void startGame(object sender, EventArgs e)
        {
            this.Hide();
            gameScreen newform = new gameScreen();
            newform.ShowDialog();
            this.Show();

            
        }

        private void help_Click(object sender, EventArgs e)
        {
            HelpPage newform = new HelpPage();
            newform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cheesepic newform = new cheesepic();
            newform.ShowDialog();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
