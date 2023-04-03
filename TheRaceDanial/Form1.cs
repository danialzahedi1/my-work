using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DragRacerPrep;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DragRacerPrep
{
    public partial class Form1 : Form
    {
        //classes
        CarBase obCarOneDZAH = new CarBase();
        CarBase obCarTwoDZAH = new CarBase();
        CarBase obCarThreeDZAH = new CarBase();
        CarBase obCarFourDZAH = new CarBase();

        SoundPlayer betWinDZAH = new SoundPlayer(@"C:\Users\Danial\Desktop\Appr\TheRaceDanial\wav\betWin.wav");
        SoundPlayer betLoseDZAH = new SoundPlayer(@"C:\Users\Danial\Desktop\Appr\TheRaceDanial\wav\spongeBob.wav");
        SoundPlayer countDownDZAH = new SoundPlayer(@"C:\Users\Danial\Desktop\Appr\TheRaceDanial\wav\countDown.wav");
    
        //all ints
        int laneLenght = 0;
        int finishedPositions = 0;
        int raceTime = 0;
        int countDownTickDZAH = 0;
        int raceNumber = 0;
        int minSpeed = 0;
        int maxSpeed = 0;

        int saveLoc1xDZAH = 0;
        int saveLoc1yDZAH = 0;
        int saveLoc2xDZAH = 0;
        int saveLoc2yDZAH = 0;
        int saveLoc3xDZAH = 0;
        int saveLoc3yDZAH = 0;
        int saveLoc4xDZAH = 0;
        int saveLoc4yDZAH = 0;
        int coinsDZAH = 0;

        public Form1()
        {
            //does all the things below just once when the form loads
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            tcStart.Appearance = TabAppearance.FlatButtons;
            tcStart.ItemSize = new Size(0, 1);
            tcStart.SizeMode = TabSizeMode.Fixed;

            tcStart.TabPages.Remove(tabSetupPageDZAH);
            tcStart.TabPages.Remove(tabRacePageDZAH);

            saveLoc1xDZAH = Convert.ToInt32(pbxCarOneDZAH.Location.X);
            saveLoc1yDZAH = Convert.ToInt32(pbxCarOneDZAH.Location.Y);
                     
            saveLoc2xDZAH = Convert.ToInt32(pbxCarTwoDZAH.Location.X);
            saveLoc2yDZAH = Convert.ToInt32(pbxCarTwoDZAH.Location.Y);
                     
            saveLoc3xDZAH = Convert.ToInt32(pbxCarThreeDZAH.Location.X);
            saveLoc3yDZAH = Convert.ToInt32(pbxCarThreeDZAH.Location.Y);
                     
            saveLoc4xDZAH = Convert.ToInt32(pbxCarFourDZAH.Location.X);
            saveLoc4yDZAH = Convert.ToInt32(pbxCarFourDZAH.Location.Y);

            pbxTrailOneDZAH.Width = 200;
            pbxTrailTwoDZAH.Width = 200;
            pbxTrailThreeDZAH.Width = 200;
            pbxTrailFourDZAH.Width = 200;

            coinsDZAH = 10;
            lblCoinsDZAH.Text = coinsDZAH.ToString();
        }

        private void theRaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tcStart.TabPages.Remove(tabStartPageDZAH);
            tcStart.TabPages.Remove(tabSetupPageDZAH);
            tcStart.TabPages.Remove(tabRacePageDZAH);

            tcStart.TabPages.Add(tabRacePageDZAH);

            tcStart.SelectedTab = tabRacePageDZAH;
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tcStart.TabPages.Remove(tabStartPageDZAH);
            tcStart.TabPages.Remove(tabSetupPageDZAH);
            tcStart.TabPages.Remove(tabRacePageDZAH);

            tcStart.TabPages.Add(tabSetupPageDZAH);

            tcStart.SelectedTab = tabSetupPageDZAH;
        }
        //are you sure message when the player wants to leave
        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Exit game", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                this.Close();
            }
        }

        //sets the lane length and sets up the cars
        private void btnSetupCarsDZAH_Click(object sender, EventArgs e)
        {
            try
            {
                laneLenght = pnlStartPositionDZAH.Left + pnlStartPositionDZAH.Width + pnlFinishLineDZAH.Left + pnlFinishLineDZAH.Width;

                tmrMainDZAH.Interval = Convert.ToInt32(txbTrackSpeedDZAH.Text);
                minSpeed = Convert.ToInt32(txbMinSpeedDZAH.Text);
                maxSpeed = Convert.ToInt32(txbMaxSpeedDZAH.Text);

                SetUpCarsDZAH();

                btnRaceStartDZAH.Enabled = true;

                lblRacerNameOneDZAH.Text = txbCarNameOneDZAH.Text + ":";
                lblRacerNameTwoDZAH.Text = txbCarNameTwoDZAH.Text + ":";
                lblRacerNameThreeDZAH.Text = txbCarNameThreeDZAH.Text + ":";
                lblRacerNameFourDZAH.Text = txbCarNameFourDZAH.Text + ":";

                rbtnRacerOneDZAH.Text = txbCarNameOneDZAH.Text;
                rbtnRacerTwoDZAH.Text = txbCarNameTwoDZAH.Text;
                rbtnRacerThreeDZAH.Text = txbCarNameThreeDZAH.Text;
                rbtnRacerFourDZAH.Text = txbCarNameFourDZAH.Text;

                gbxBettingDZAH.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Please enter numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //sets the cars up and updates the labels
        private void SetUpCarsDZAH()
        {
            obCarOneDZAH.setSpeed(minSpeed, maxSpeed);
            obCarTwoDZAH.setSpeed(minSpeed, maxSpeed);
            obCarThreeDZAH.setSpeed(minSpeed, maxSpeed);
            obCarFourDZAH.setSpeed(minSpeed, maxSpeed);


            obCarOneDZAH.calculateStepSize(laneLenght);
            obCarTwoDZAH.calculateStepSize(laneLenght);
            obCarThreeDZAH.calculateStepSize(laneLenght);
            obCarFourDZAH.calculateStepSize(laneLenght);


            lblCarOneSpeedDZAH.Text = obCarOneDZAH.GetTunedCarSpeed.ToString();
            lblCarTwoSpeedDZAH.Text = obCarTwoDZAH.GetTunedCarSpeed.ToString();
            lblCarThreeSpeedDZAH.Text = obCarThreeDZAH.GetTunedCarSpeed.ToString();
            lblCarFourSpeedDZAH.Text = obCarFourDZAH.GetTunedCarSpeed.ToString();

            lblCarOneStepDZAH.Text = obCarOneDZAH.GetSetStepSizePerTick.ToString();
            lblCarTwoStepDZAH.Text = obCarTwoDZAH.GetSetStepSizePerTick.ToString();
            lblCarThreeStepDZAH.Text = obCarThreeDZAH.GetSetStepSizePerTick.ToString();
            lblCarFourStepDZAH.Text = obCarFourDZAH.GetSetStepSizePerTick.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tcStart.TabPages.Remove(tabStartPageDZAH);
            tcStart.TabPages.Remove(tabSetupPageDZAH);
            tcStart.TabPages.Remove(tabRacePageDZAH);

            tcStart.TabPages.Add(tabSetupPageDZAH);

            tcStart.SelectedTab = tabSetupPageDZAH;
        }

        //looks if the car is passed the finish line and sets it to finished, updates labels, shows who won and checks if u betted on them
        private void UpdatePositionsDZAH()
        {
            if (pbxCarOneDZAH.Left > pnlFinishLineDZAH.Left + 10)
            {
                if (obCarOneDZAH.carFinished == false)
                {
                    obCarOneDZAH.carFinished = true;
                    finishedPositions++;
                    lblCarOneFinishedPositionDZAH.Text = finishedPositions.ToString();
                    lblFinishedOneDZAH.Text = finishedPositions.ToString();

                    rtbRaceHistoryDZAH.AppendText(txbCarNameOneDZAH.Text + " Place: " + finishedPositions.ToString());
                    rtbRaceHistoryDZAH.AppendText("\n");

                    checkBet(rbtnRacerOneDZAH, cbxRacerOneBetDZAH);

                    if (finishedPositions == 1)
                    {
                        MessageBox.Show(txbCarNameOneDZAH.Text + " won!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                obCarOneDZAH.calculateCurrentPosition();
                pbxCarOneDZAH.Left = obCarOneDZAH.GetActualPositionInLaneRounded;
                lblCarOneStepActualDZAH.Text = obCarOneDZAH.GetTunedCarSpeed.ToString() + " S/t";
            }

            if (pbxCarTwoDZAH.Left > pnlFinishLineDZAH.Left + 10)
            {
                if (obCarTwoDZAH.carFinished == false)
                {
                    obCarTwoDZAH.carFinished = true;
                    finishedPositions++;
                    lblCarTwoFinishedPositionDZAH.Text = finishedPositions.ToString();
                    lblFinishedTwoDZAH.Text = finishedPositions.ToString();

                    rtbRaceHistoryDZAH.AppendText(txbCarNameTwoDZAH.Text + " Place: " + finishedPositions.ToString());
                    rtbRaceHistoryDZAH.AppendText("\n");

                    checkBet(rbtnRacerTwoDZAH, cbxRacerTwoBetDZAH);

                    if (finishedPositions == 1)
                    {
                        MessageBox.Show(txbCarNameTwoDZAH.Text + " won!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                obCarTwoDZAH.calculateCurrentPosition();
                pbxCarTwoDZAH.Left = obCarTwoDZAH.GetActualPositionInLaneRounded;
                lblCarTwoStepActualDZAH.Text = obCarTwoDZAH.GetTunedCarSpeed.ToString() + " S/t";
            }

            if (pbxCarThreeDZAH.Left > pnlFinishLineDZAH.Left + 10)
            {
                if (obCarThreeDZAH.carFinished == false)
                {
                    obCarThreeDZAH.carFinished = true;
                    finishedPositions++;
                    lblCarThreeFinishedPositionDZAH.Text = finishedPositions.ToString();
                    lblFinishedThreeDZAH.Text = finishedPositions.ToString();

                    rtbRaceHistoryDZAH.AppendText(txbCarNameThreeDZAH.Text + " Place: " + finishedPositions.ToString());
                    rtbRaceHistoryDZAH.AppendText("\n");

                    checkBet(rbtnRacerThreeDZAH, cbxRacerThreeBetDZAH);

                    if (finishedPositions == 1)
                    {
                        MessageBox.Show(txbCarNameThreeDZAH.Text + " won!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                obCarThreeDZAH.calculateCurrentPosition();
                pbxCarThreeDZAH.Left = obCarThreeDZAH.GetActualPositionInLaneRounded;
                lblCarThreeStepActualDZAH.Text = obCarThreeDZAH.GetTunedCarSpeed.ToString() + " S/t";
            }

            if (pbxCarFourDZAH.Left > pnlFinishLineDZAH.Left + 10)
            {
                if (obCarFourDZAH.carFinished == false)
                {
                    obCarFourDZAH.carFinished = true;
                    finishedPositions++;
                    lblCarFourFinishedPositionDZAH.Text = finishedPositions.ToString();
                    lblFinishedFourDZAH.Text = finishedPositions.ToString();

                    rtbRaceHistoryDZAH.AppendText(txbCarNameFourDZAH.Text + " Place: " + finishedPositions.ToString());
                    rtbRaceHistoryDZAH.AppendText("\n");

                    checkBet(rbtnRacerFourDZAH, cbxRacerFourBetDZAH);

                    if (finishedPositions == 1)
                    {
                        MessageBox.Show(txbCarNameFourDZAH.Text + " won!", "Winner!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                obCarFourDZAH.calculateCurrentPosition();
                pbxCarFourDZAH.Left = obCarFourDZAH.GetActualPositionInLaneRounded;
                lblCarFourStepActualDZAH.Text = obCarFourDZAH.GetTunedCarSpeed.ToString() + " S/t";
            }

            if (obCarOneDZAH.carFinished == true &&
                obCarTwoDZAH.carFinished == true &&
                obCarThreeDZAH.carFinished == true &&
                obCarFourDZAH.carFinished == true)
            {
                tmrMainDZAH.Enabled = false;
                btnResetPositionsDZAH.Enabled = true;
                rtbRaceHistoryDZAH.AppendText("++++++++++++++++++++++++++++++++++++");
                rtbRaceHistoryDZAH.AppendText("\n");
            }
        }

        // changes the speeds of the cars while racing
        private void ModifySpeedDynamically()
        {
            if (cbxDynamicSpeedDZAH.Checked == true)
            {
                if (raceTime == 50)
                {
                    SetUpCarsDZAH();
                }

                if (raceTime == 100)
                {
                    SetUpCarsDZAH();
                }

                if (raceTime == 150)
                {
                    SetUpCarsDZAH();
                }

                if (raceTime == 200)
                {
                    SetUpCarsDZAH();
                }

                if (raceTime == 250)
                {
                    SetUpCarsDZAH();
                }

                if (raceTime == 300)
                {
                    SetUpCarsDZAH();
                }

                if (raceTime == 350)
                {
                    SetUpCarsDZAH();
                }

                if (raceTime == 400)
                {
                    SetUpCarsDZAH();
                }

                if (raceTime == 450)
                {
                    SetUpCarsDZAH();
                }

                if (raceTime == 500)
                {
                    SetUpCarsDZAH();
                }
            }
        }
        // start the race, updates labels and disables the setup and betting groupboxes
        private void btnRaceStartDZAH_Click(object sender, EventArgs e)
        {
            countDownDZAH.Play();

            tmrCountDownDZAH.Enabled = true;

            pbxTrailOneDZAH.Visible = true;
            pbxTrailTwoDZAH.Visible = true;
            pbxTrailThreeDZAH.Visible = true;
            pbxTrailFourDZAH.Visible = true;

            gbxBettingDZAH.Enabled = false;
            gbxSetupDZAH.Enabled = false;

            tmrMainDZAH.Interval = 10;
            btnRaceStartDZAH.Enabled = false;
            btnResetPositionsDZAH.Enabled = false;
            raceNumber++;
            lblRaceNumberDZAH.Text = ("Race: " + raceNumber.ToString());
            rtbRaceHistoryDZAH.AppendText("Race Number: " + raceNumber.ToString());
            rtbRaceHistoryDZAH.AppendText("\n");
            rtbRaceHistoryDZAH.AppendText("++++++++++++++++++++++++++++++++++++");
            rtbRaceHistoryDZAH.AppendText("\n");
        }
        // sets the 3 default value presets
        private void btnDefaultDZAH_Click(object sender, EventArgs e)
        {
            txbTrackSpeedDZAH.Text = ("10");
            txbMinSpeedDZAH.Text = ("1250");
            txbMaxSpeedDZAH.Text = ("2000");
            cbxDynamicSpeedDZAH.Checked = true;
        }

        private void btnPreset2DZAH_Click(object sender, EventArgs e)
        {
            txbTrackSpeedDZAH.Text = ("100");
            txbMinSpeedDZAH.Text = ("2000");
            txbMaxSpeedDZAH.Text = ("3000");
            cbxDynamicSpeedDZAH.Checked = true;
        }

        private void btnPreset3DZAH_Click(object sender, EventArgs e)
        {
            txbTrackSpeedDZAH.Text = ("1000");
            txbMinSpeedDZAH.Text = ("5000");
            txbMaxSpeedDZAH.Text = ("10000");
            cbxDynamicSpeedDZAH.Checked = true;
        }
        // resets the race and enables the setup and betting groupboxes
        private void btnResetPositionsDZAH_Click(object sender, EventArgs e)
        {
            ClearData();

            gbxSetupDZAH.Enabled = true;
            gbxBettingDZAH.Enabled = true;
        }
        //reset function
        public void ClearData()
        {
            btnRaceStartDZAH.Enabled = false;
            btnResetPositionsDZAH.Enabled = false;
            lblCarOneStepActualDZAH.Text = "-";
            lblCarTwoStepActualDZAH.Text = "-";
            lblCarThreeStepActualDZAH.Text = "-";
            lblCarFourStepActualDZAH.Text = "-";

            lblCarOneSpeedDZAH.Text = "-";
            lblCarTwoSpeedDZAH.Text = "-";
            lblCarThreeSpeedDZAH.Text = "-";
            lblCarFourSpeedDZAH.Text = "-";

            lblCarOneStepDZAH.Text = "-";
            lblCarTwoStepDZAH.Text = "-";
            lblCarThreeStepDZAH.Text = "-";
            lblCarFourStepDZAH.Text = "-";

            laneLenght = 0;
            finishedPositions = 0;
            raceTime = 0;

            minSpeed = 0;
            maxSpeed = 0;

            obCarOneDZAH.resetRacers();
            obCarTwoDZAH.resetRacers();
            obCarThreeDZAH.resetRacers();
            obCarFourDZAH.resetRacers();


            txbTrackSpeedDZAH.Text = "";
            txbMinSpeedDZAH.Text = "";
            txbMaxSpeedDZAH.Text = "";
            lblRaceTimeDZAH.Text = "Time: -:--";
            lblFinishedOneDZAH.Text = finishedPositions.ToString();
            lblFinishedTwoDZAH.Text = finishedPositions.ToString();
            lblFinishedThreeDZAH.Text = finishedPositions.ToString();
            lblFinishedFourDZAH.Text = finishedPositions.ToString();

            cbxRacerOneBetDZAH.Text = "";
            cbxRacerTwoBetDZAH.Text = "";
            cbxRacerThreeBetDZAH.Text = "";
            cbxRacerFourBetDZAH.Text = "";

            cbxRacerOneBetDZAH.Enabled = false;
            cbxRacerTwoBetDZAH.Enabled = false;
            cbxRacerThreeBetDZAH.Enabled = false;
            cbxRacerFourBetDZAH.Enabled = false;

            cbxRacerOneBetDZAH.Text = null;
            cbxRacerTwoBetDZAH.Text = null;
            cbxRacerThreeBetDZAH.Text = null;
            cbxRacerFourBetDZAH.Text = null;

            rbtnRacerOneDZAH.Checked = false;
            rbtnRacerTwoDZAH.Checked = false;
            rbtnRacerThreeDZAH.Checked = false;
            rbtnRacerFourDZAH.Checked = false;


            pbxCarOneDZAH.Location = new Point(saveLoc1xDZAH, saveLoc1yDZAH);
            pbxCarTwoDZAH.Location = new Point(saveLoc2xDZAH, saveLoc2yDZAH);
            pbxCarThreeDZAH.Location = new Point(saveLoc3xDZAH, saveLoc3yDZAH);
            pbxCarFourDZAH.Location = new Point(saveLoc4xDZAH, saveLoc4yDZAH);

            pbxTrailOneDZAH.Width = 200;
            pbxTrailTwoDZAH.Width = 200;
            pbxTrailThreeDZAH.Width = 200;
            pbxTrailFourDZAH.Width = 200;

        }

        private void btnClearHistoryDZAH_Click(object sender, EventArgs e)
        {
            rtbRaceHistoryDZAH.Clear();
        }

        //updates the positions of the cars, the trails and shows race time
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            raceTime++;
            lblRaceTimeDZAH.Text = ("Time: " + raceTime.ToString());

            UpdatePositionsDZAH();
            ModifySpeedDynamically();

            pbxTrailOneDZAH.Width = pbxCarOneDZAH.Left;
            pbxTrailTwoDZAH.Width = pbxCarTwoDZAH.Left;
            pbxTrailThreeDZAH.Width = pbxCarThreeDZAH.Left;
            pbxTrailFourDZAH.Width = pbxCarFourDZAH.Left;
        }


        //custom method for checking if the player has enough coins to play, if they do it subtracts the betted coins and locks the bet
        public void checkRacer(RadioButton check, ComboBox cbx)
        {
            if (check.Checked == true)
            {
                try
                {
                    cbx.Enabled = true;
                    if (Convert.ToInt32(lblCoinsDZAH.Text) >= Convert.ToInt32(cbx.Text))
                    {
                        lblBettingInfoDZAH.Text = "Succes!";
                        lblBettingInfoDZAH.ForeColor = Color.Green;

                        coinsDZAH = coinsDZAH - Convert.ToInt32(cbx.Text);
                        lblCoinsDZAH.Text = coinsDZAH.ToString();
                        gbxBettingDZAH.Enabled = false;
                    }
                    else
                    {
                        lblBettingInfoDZAH.Text = "Not enough coins!";
                        lblBettingInfoDZAH.ForeColor = Color.Red;
                    }
                }
                catch
                {
                    MessageBox.Show("You haven't placed a bet yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //custom method for checking if the racer you betted on won, if they did you double your betted coins, if they lost you lose your betted coins
        private void checkBet(RadioButton check, ComboBox cbx)
        {
            if (check.Checked == true)
            {
                if(finishedPositions == 1)
                {
                    Console.WriteLine("if");
                    coinsDZAH = coinsDZAH + Convert.ToInt32(cbx.Text) * 2;
                    lblCoinsDZAH.Text = coinsDZAH.ToString();
                    check.Checked = false;

                    lblBettingInfoDZAH.ForeColor = Color.Green;
                    betWinDZAH.Play();
                    lblBettingInfoDZAH.Text = "You won!";
                }
                else
                {
                    Console.WriteLine("else");
                    check.Checked = false;

                    lblBettingInfoDZAH.ForeColor = Color.Red;
                    betLoseDZAH.Play();
                    lblBettingInfoDZAH.Text = "You lost!";
                }
            }
        }


        //bet button that executes the checkracer method for each racer
        private void btnBetDZAH_Click(object sender, EventArgs e)
        {
            checkRacer(rbtnRacerOneDZAH, cbxRacerOneBetDZAH);
            checkRacer(rbtnRacerTwoDZAH, cbxRacerTwoBetDZAH);
            checkRacer(rbtnRacerThreeDZAH, cbxRacerThreeBetDZAH);
            checkRacer(rbtnRacerFourDZAH, cbxRacerFourBetDZAH);
        }

        //disables the comboboxes that are not checked by the radio buttons
        private void rbtnRacerOneDZAH_CheckedChanged(object sender, EventArgs e)
        {
            cbxRacerOneBetDZAH.Enabled = true;
            cbxRacerTwoBetDZAH.Enabled = false;
            cbxRacerThreeBetDZAH.Enabled = false;
            cbxRacerFourBetDZAH.Enabled = false;

            cbxRacerTwoBetDZAH.Text = null;
            cbxRacerThreeBetDZAH.Text = null;
            cbxRacerFourBetDZAH.Text = null;
        }

        private void rbtnRacerTwoDZAH_CheckedChanged(object sender, EventArgs e)
        {
            cbxRacerOneBetDZAH.Enabled = false;
            cbxRacerTwoBetDZAH.Enabled = true;
            cbxRacerThreeBetDZAH.Enabled = false;
            cbxRacerFourBetDZAH.Enabled = false;

            cbxRacerOneBetDZAH.Text = null;
            cbxRacerThreeBetDZAH.Text = null;
            cbxRacerFourBetDZAH.Text = null;
        }

        private void rbtnRacerThreeDZAH_CheckedChanged(object sender, EventArgs e)
        {
            cbxRacerOneBetDZAH.Enabled = false;
            cbxRacerTwoBetDZAH.Enabled = false;
            cbxRacerThreeBetDZAH.Enabled = true;
            cbxRacerFourBetDZAH.Enabled = false;

            cbxRacerOneBetDZAH.Text = null;
            cbxRacerTwoBetDZAH.Text = null;
            cbxRacerFourBetDZAH.Text = null;
        }

        private void rbtnRacerFourDZAH_CheckedChanged(object sender, EventArgs e)
        {
            cbxRacerOneBetDZAH.Enabled = false;
            cbxRacerTwoBetDZAH.Enabled = false;
            cbxRacerThreeBetDZAH.Enabled = false;
            cbxRacerFourBetDZAH.Enabled = true;

            cbxRacerOneBetDZAH.Text = null;
            cbxRacerTwoBetDZAH.Text = null;
            cbxRacerThreeBetDZAH.Text = null;
        }

        //buttons to add coins (with easteregg)
        private void btnAddCoinsDZAH_Click(object sender, EventArgs e)
        {
            coinsDZAH++;
            lblCoinsDZAH.Text = coinsDZAH.ToString();

            if(coinsDZAH == 69)
            {
                MessageBox.Show("Nice!");
            }
        }

        //timer for the start of the race count down
        private void tmrCountDownDZAH_Tick(object sender, EventArgs e)
        {
            countDownTickDZAH++;

            if(countDownTickDZAH == 200)
            {
                countDownTickDZAH = 0;
                tmrMainDZAH.Enabled = true;
                tmrCountDownDZAH.Enabled = false;
            }
        }

        private void tsmiHelpDZAH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To play The Race, you need to setup the cars first." +
                "                                                                                                                                 " +
                " You can do this manually, or by selecting one of the presets." +
                " You can also toggle the dynamic speed, this makes the cars change speeds throughout the race." +
                "                                                                                                                                                      " +
                " Betting is optional and safe for kids because the coins are free to get." +
                "                                                                                                                                                                                                  " +
                " After a race has finished, click reset to start a new race.",
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
