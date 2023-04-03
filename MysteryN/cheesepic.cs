using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MysteryN
{

    public partial class cheesepic : Form
        
    {
        
        public cheesepic()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You ate the cheese!");
            DialogResult = DialogResult.OK;
            {
                DialogResult result1 = MessageBox.Show("Did you like the cheese?",
                    "Important Question",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result1 == DialogResult.No)
                {
                    MessageBox.Show("kys");
                    UseWaitCursor = true;
                    blu newform = new blu();
                    newform.ShowDialog();
                }
                else if (result1 == DialogResult.Yes)
                {
                    this.Hide();
                    AteCheese newform = new AteCheese();
                    newform.ShowDialog();


                }
            }
        }
    }
}

    
