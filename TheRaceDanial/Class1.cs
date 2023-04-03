using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacerPrep
{
    class CarBase
    {
        int tunedCarMaxSpeed = 0; //Random Speed
        double stepSizePerTick = 0;
        double actualPositionInLane = 0; //Position of the car, not rounded
        int actualPositionInLaneRounded; //Rounded position of the car

        public bool carFinished = false; //Racer finished

        public void setSpeed(int a_speedWithBadTuning, int a_speedWithGoodTuning)
        {

            Random generateCarSpeed = new Random();

            tunedCarMaxSpeed = generateCarSpeed.Next(a_speedWithBadTuning, a_speedWithGoodTuning);

            ResetSpeedSettings();

        }

        private void ResetSpeedSettings()
        {
            int m_setupCounter = 0;

            for (int i = 0; i < 12345678; i++)
            {
                m_setupCounter++;
            }
        }

        public void calculateStepSize(double a_laneLengthToFinishLine)
        {
            stepSizePerTick = tunedCarMaxSpeed / a_laneLengthToFinishLine;
        }

        public void calculateCurrentPosition()
        {
            actualPositionInLane = actualPositionInLane + stepSizePerTick;

            actualPositionInLaneRounded = Convert.ToInt32(actualPositionInLane);
        }

        public void resetPosition(int a_startPosition)
        {
            actualPositionInLane = a_startPosition;
        }

        public int GetTunedCarSpeed
        {
            get
            {
                return tunedCarMaxSpeed;
            }
        }

        public double GetSetStepSizePerTick
        {
            get
            {
                return stepSizePerTick;
            }

            set
            {
                stepSizePerTick *= value;
            }
        }

        public int GetActualPositionInLaneRounded
        {
            get
            {
                return actualPositionInLaneRounded;
            }
        }
        /// <summary>
        /// Resets racers
        /// </summary>
        public void resetRacers()
        {
            stepSizePerTick = 0;
            actualPositionInLaneRounded = 0;
            GetSetStepSizePerTick = 0;
            actualPositionInLane = 0;
            tunedCarMaxSpeed = 0;
            carFinished = false;

        }
    }
}