using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MysteryN
{
    public partial class gameScreen : Form
    {

        Random GenerateRandomValue = new Random();
        int maxValueDzah = 0;
        int minValueDzah = 0;
        int randomValueDzah = 0;
        int attemptsDzah = 0;
        int wrongsDzah = 0;
        int myGuessDzah = 0;
        int numbersOffDzah = 0;
        int tempDzah = 0;
        int nrGamesPlayedDzah = 0;
        SoundPlayer uwu = new SoundPlayer(@"C:\Users\Danial\Desktop\visual studio\MysteryN\bin\wafs\waf_uwu.wav");
        SoundPlayer fortnite = new SoundPlayer(@"C:\Users\Danial\Desktop\visual studio\MysteryN\bin\wafs\ffornite waf.wav");
        SoundPlayer fart = new SoundPlayer(@"C:\Users\Danial\Desktop\visual studio\MysteryN\bin\wafs\perfect-fart wav.wav");
        SoundPlayer fail = new SoundPlayer(@"C:\Users\Danial\Desktop\visual studio\MysteryN\bin\wafs\spongebob-fail wav.wav");



        public gameScreen()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            this.StartPosition = FormStartPosition.CenterScreen;
            gbxPlayDzah.Enabled = false;
            rtbxInfoDzah.Text = "Enter the setup value first.";
            rtbxInfoDzah.ForeColor = Color.CadetBlue;
            lblNumbersOffDzah.Visible = false;
            NewMethod();
        }

        private void NewMethod()
        {
            cmbxAttemptsDzah.SelectedIndex = 0;
            gbxDebugDzah.Enabled = false;
            gbxSetUpDzah.BackColor = Color.FromArgb(32, 32, 32);
            pcbYouLoseDzah.Visible = false;
            pictureBox2.Visible = false;
        }

        //return=========================================================================================
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;   
        }

        //start==========================================================================================
        private void btnStartf2Dzah_Click(object sender, EventArgs e)
        {
            if (nrGamesPlayedDzah == 30)
            {
                MessageBox.Show("Maybe you should take a break...", "You've been playing too long!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            if (txbStartAtDzah.Text == "")                                          //error autofill
            {
                txbStartAtDzah.Text = "0";
                MessageBox.Show("You didnt fill anythig in!" + "\n" + "Default values for minimum were applied.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txbEndAtDzah.Text == "")
            {
                txbEndAtDzah.Text = "10";
                MessageBox.Show("You didnt fill anythig in!" + "\n" + "Default values for maximum were applied.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cmbxAttemptsDzah.Text == "")
            {
                cmbxAttemptsDzah.Text = "5";
                MessageBox.Show("You didnt fill anythig in!" + "\n" + "Default values for attemptsDzah were applied.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {

                                                                    //startup values setup
                if (cbSoundDzah.Checked == false)
                {
                    uwu.Play();
                }
                maxValueDzah = Convert.ToInt32(txbEndAtDzah.Text);
                minValueDzah = Convert.ToInt32(txbStartAtDzah.Text);

                randomValueDzah = GenerateRandomValue.Next(minValueDzah, maxValueDzah);
                attemptsDzah = Convert.ToInt32(cmbxAttemptsDzah.Text);
                lblRemainingTriesDzah.Text = attemptsDzah.ToString();


                gbxSetUpDzah.Enabled = false;
                gbxSetUpDzah.BackColor = Color.FromArgb(64, 64, 64);

                gbxPlayDzah.Enabled = true;
                gbxPlayDzah.BackColor = Color.FromArgb(32, 32, 32);
                rtbxInfoDzah.Text = ("Guess the number!");
                rtbxInfoDzah.ForeColor = Color.CadetBlue;

                tbGuessDzah.Maximum = randomValueDzah;
                tbGuessDzah.Minimum = minValueDzah;

                pgbGuessDzah.Maximum = attemptsDzah;
                pgbGuessDzah.Value = attemptsDzah;

                pgbWrongsDzah.Maximum = attemptsDzah;
                pgbWrongsDzah.Value = wrongsDzah;
            }
            catch                                                   //error message
            {
                MessageBox.Show("Please only enter numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtbxInfoDzah.Text = ("Why would you even try that?");
                rtbxInfoDzah.ForeColor = Color.Red;
                txbStartAtDzah.Text = "0";
                txbEndAtDzah.Text = "10";
            }

        }   
        //cheat========================================================================================
        private void btnCheat_Click(object sender, EventArgs e)
        {
            rtbxInfoDzah.Text = ("Random value is " + randomValueDzah.ToString());
            rtbxInfoDzah.ForeColor = Color.CadetBlue;
        }


        //guess=========================================================================================
         void btnGuess_Click(object sender, EventArgs e)
        {
            try
            {
                myGuessDzah = Convert.ToInt32(txbMyGuessDzah.Text);
                txbMyGuessDzah.Text = myGuessDzah.ToString();



                if (myGuessDzah > maxValueDzah)                                       //error if the guess is more or less than the max or min values
                {
                    MessageBox.Show("You cant go over the maximum", "Error");
                }
                if (myGuessDzah < minValueDzah)
                {
                    MessageBox.Show("You cant go under the minimum", "Error");
                }


                if (myGuessDzah == randomValueDzah)
                {

                    tbGuessDzah.Value = myGuessDzah;
                    lblCorrectIncorrectDzah.Text = "Correct!";
                    this.BackColor = Color.Green;
                    lblCorrectIncorrectDzah.ForeColor = Color.Green;
                    btnGuessDzah.BackColor = Color.Green;
                    rtbxInfoDzah.Text = ("You guessed it!");
                    rtbxInfoDzah.ForeColor = Color.Green;
                    if (cbSoundDzah.Checked == false)
                    {
                        fortnite.Play();
                    }
                    this.Width = 800;
                    pictureBox2.Visible = true;
                    MessageBox.Show("Congratulations you guessed it right!", "Yay!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Width = 380;
                    pictureBox2.Visible = false;
                    this.BackColor = Color.FromArgb(28, 28, 28);
                    btnGuessDzah.BackColor = Color.FromArgb(64, 64, 64);
                    pgbGuessDzah.Value = 0;
                    nrGamesPlayedDzah++;
                    pnlNrGamesPlayedDzah.Width = Convert.ToInt32(pnlNrGamesPlayedDzah.Width) + 10;
                    lblNrGamesPlayedDzah.Text = nrGamesPlayedDzah.ToString();

                    gbxPlayDzah.Enabled = false;
                    gbxPlayDzah.BackColor = Color.FromArgb(64, 64, 64);
                    gbxSetUpDzah.Enabled = true;
                    gbxSetUpDzah.BackColor = Color.FromArgb(32, 32, 32);
                                                                                                //resets values
                    pgbWrongsDzah.Value = 0;
                    txbMyGuessDzah.Text = "0";
                    lblRemainingTriesDzah.Text = "-";
                    lblWrongCounterDzah.Text = "0";
                    wrongsDzah = wrongsDzah = 0;
                    lblCorrectIncorrectDzah.Text = "?????";
                    lblCorrectIncorrectDzah.ForeColor = Color.White;
                    lblNumbersOffDzah.Text = "-";

                }
                else
                {                                                   //if guess is wrong
                    if (cbSoundDzah.Checked == false)
                    {
                        fart.Play();
                    }
                    attemptsDzah = attemptsDzah - 1;
                    lblRemainingTriesDzah.Text = attemptsDzah.ToString();

                    wrongsDzah = wrongsDzah + 1;
                    lblWrongCounterDzah.Text = wrongsDzah.ToString();

                    pgbGuessDzah.Value = pgbGuessDzah.Value - 1;
                    pgbWrongsDzah.Value = pgbWrongsDzah.Value + 1;

                    lblCorrectIncorrectDzah.Text = "False!";
                    lblCorrectIncorrectDzah.ForeColor = Color.Red;
                    rtbxInfoDzah.Text = ("Nope! Try again.");
                    rtbxInfoDzah.ForeColor = Color.Red;
                    btnGuessDzah.BackColor = Color.Red;

                    //numbersoff::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                    numbersOffDzah = (randomValueDzah - myGuessDzah);
                    lblNumbersOffDzah.Text = numbersOffDzah.ToString();



                    if (attemptsDzah == 0)
                    {                                                                       //game over message
                        if (cbSoundDzah.Checked == false)
                        {
                            fail.Play();
                        }
                        this.BackColor = Color.Red;
                        this.Width = 800;
                        pcbYouLoseDzah.Visible = true;
                        MessageBox.Show("No more attempts! You lost!", "LOL noob.");
                        this.Width = 380;
                        pcbYouLoseDzah.Visible = false;
                        rtbxInfoDzah.Text = "Enter the setup value first";
                        rtbxInfoDzah.ForeColor = Color.CadetBlue;
                        btnGuessDzah.BackColor = Color.FromArgb(64,64,64);
                        gbxPlayDzah.Enabled = false;
                        gbxPlayDzah.BackColor = Color.FromArgb(64, 64, 64);
                        this.BackColor = Color.FromArgb(28,28, 28);
                        nrGamesPlayedDzah++;
                        pnlNrGamesPlayedDzah.Width = Convert.ToInt32(pnlNrGamesPlayedDzah.Width) + 10;
                        lblNrGamesPlayedDzah.Text = nrGamesPlayedDzah.ToString();

                        gbxSetUpDzah.Enabled = true;
                        gbxSetUpDzah.BackColor = Color.FromArgb(32, 32, 32);

                        pgbWrongsDzah.Value = 0;
                        txbMyGuessDzah.Text = "0";                                          //reset values
                        lblRemainingTriesDzah.Text = "-";
                        lblWrongCounterDzah.Text = "0";
                        wrongsDzah = wrongsDzah = 0;
                        lblCorrectIncorrectDzah.Text = "?????";
                        lblCorrectIncorrectDzah.ForeColor = Color.White;
                        lblNumbersOffDzah.Text = "-";

                    }
                                                                        //trackbar
                    if (myGuessDzah < minValueDzah)
                    {
                        myGuessDzah = minValueDzah;
                    }

                    if (myGuessDzah < randomValueDzah)
                    {
                        tbGuessDzah.Maximum = randomValueDzah;
                        tbGuessDzah.Value = myGuessDzah;
                    }

                    if (myGuessDzah > randomValueDzah)
                    {
                        tempDzah = (randomValueDzah - (myGuessDzah - randomValueDzah));

                        if (tempDzah < minValueDzah)
                        {
                            tbGuessDzah.Value = minValueDzah;
                        }
                        else
                        {
                            tbGuessDzah.Value = randomValueDzah - (myGuessDzah - randomValueDzah);
                        }
                    }


                }
            }                                                   
            catch                                                                                      //error message
            {
                MessageBox.Show("Please only enter numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtbxInfoDzah.Text = ("Bruh -_-");
                rtbxInfoDzah.ForeColor = Color.Red;
                txbMyGuessDzah.Text = "";
            }
        }

        #region Scroll
        //tb scroll======================================================================================================
        private void tbGuess_Scroll(object sender, EventArgs e)                     //prevents touching te trackbar scroll
        {
            tbGuessDzah.Value = tbGuessDzah.Minimum;
            MessageBox.Show("DO NOT TOUCH THE SLIDER.", "NO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }
        #endregion

        private void btnNumbersOffShow_Click(object sender, EventArgs e)                //shows how many numbers youre off
        {
            

            if (lblNumbersOffDzah.Visible == false)
            {
                lblNumbersOffDzah.Visible = true;
            }
            else lblNumbersOffDzah.Visible = false;
            

        }

        private void btnClear_Click(object sender, EventArgs e)                 //resets values
        {
            gbxPlayDzah.Enabled = false;
            gbxPlayDzah.BackColor = Color.FromArgb(64, 64, 64);

            gbxSetUpDzah.Enabled = true;
            gbxSetUpDzah.BackColor = Color.FromArgb(32, 32, 32);

            txbMyGuessDzah.Text = "0";
            lblRemainingTriesDzah.Text = "-";
            lblWrongCounterDzah.Text = "0";
            wrongsDzah = wrongsDzah = 0;
            lblCorrectIncorrectDzah.Text = "?????";
            lblCorrectIncorrectDzah.ForeColor = Color.White;
            lblNumbersOffDzah.Text = "-";
            txbEndAtDzah.Text = "";
            txbStartAtDzah.Text = "";
            cmbxAttemptsDzah.Text = "";
            
        }

        private void btnDefault_Click(object sender, EventArgs e)                   //applies default values
        {
            txbStartAtDzah.Text = "0";
            txbEndAtDzah.Text = "10";
            cmbxAttemptsDzah.Text = "5";

        }

        private void btnDebug_Click(object sender, EventArgs e)                   //applies big values used for debugging
        {
            txbStartAtDzah.Text = "0";
            txbEndAtDzah.Text = "1000";
            cmbxAttemptsDzah.Text = "100";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)              //enables debug group (not finished, not neccesary)
        {
            gbxDebugDzah.Enabled = cbDebugDzah.Checked;
            if (cbDebugDzah.Checked)
            {
                gbxDebugDzah.BackColor = Color.FromArgb(32, 32, 32);
            }
            else gbxDebugDzah.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ik ben verliefd op jayjay");
        }

        private void cbSoundDzah_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSoundDzah.BackColor == Color.Green)
            {
                cbSoundDzah.BackColor = Color.Red;
            }
            else cbSoundDzah.BackColor = Color.Green;
        }

    }
}
