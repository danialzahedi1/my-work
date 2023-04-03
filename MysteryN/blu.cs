using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MysteryN
{
    public partial class blu : Form
    {
        SoundPlayer error = new SoundPlayer(@"C:\Users\Danial\Desktop\visual studio\MysteryN\bin\wafs\windows error wav.wav");
        public blu()
        {
            InitializeComponent();
        }

        private void blu_Load(object sender, EventArgs e)       //full screen and sound effect
        {
            error.Play();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Cursor = Cursors.WaitCursor;
        }


    }
}
