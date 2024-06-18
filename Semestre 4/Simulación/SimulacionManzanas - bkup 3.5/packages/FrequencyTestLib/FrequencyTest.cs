using System;
using System.Collections.Generic;
using MathNet.Numerics.Distributions;

namespace FrequencyTestLib
{
    public class FrequencyTest
    {
        public List<float> LstPseudoRandomNumbers { get; set; } //List of pseudorandom numbers
        public int Intervals { get; set; } // Number of intervals
        public float Alpha { get; set; } // Level of significance
        private List<(float, float)> LstProbIntervals;
        private int[] observedFrequency;
        private float expectedFrequency;
        private double chiCalculated;
        private double chiSquare;

        public FrequencyTest() { } //Default Constructor
        public FrequencyTest(List<float> lstPseudoRandomNumbers, int intervals, float alpha) //Constructor
        {
            LstPseudoRandomNumbers = lstPseudoRandomNumbers;
            Intervals = intervals;
            Alpha = alpha;
        }

        private void DefineIntervals()
        {
            if(LstProbIntervals != null) LstProbIntervals.Clear();
            this.LstProbIntervals = new List<(float, float)>(Intervals); //List for save the probability of each interval
            float topLimit = 0f, bottomLimit;
            //Find the probability of each interval
            float prob = (float)1 / this.Intervals;
            //Define the limits of each interval
            for (int i = 0; i < Intervals; i++)
            {
                bottomLimit = topLimit;
                topLimit += prob;
                LstProbIntervals.Add((bottomLimit, topLimit));
            }
        }
        public List<(float, float)> GetIntervals()
        {
            DefineIntervals();
            return this.LstProbIntervals;
        }
        private void DefineChiSquare()
        {
            chiSquare = ChiSquared.InvCDF((double)Intervals - 1, (double)Alpha); //Use MathNet.Numerics Library
        }
        public double GetChiSquare()
        {
            DefineChiSquare();
            return chiSquare;
        }
        private void DefineObservedFrequency()
        {
            DefineIntervals(); // Checking if the probabilities of each interval are defined

            int c; //Counter for the interval
            observedFrequency = new int[Intervals];
            foreach (float Number in LstPseudoRandomNumbers) //Getting each pseudorandom number
            {
                c = 0; //Starting counter
                foreach ((float bottomLimit, float TopLimit) in LstProbIntervals) //Getting each limit of each interval
                {

                    if (bottomLimit < Number && Number <= TopLimit) //Checking if number is between both limits
                    {
                        observedFrequency[c]++; //Counter
                        break;
                    }
                    c++; //Counter
                }
            }
        }
        public int[] GetObservedFrequency()
        {
            DefineObservedFrequency();
            return observedFrequency;
        }
        private void DefineExpectedFrequency()
        {
            expectedFrequency = (float)LstPseudoRandomNumbers.Count / Intervals; //The expected frequency is the division between the total numbers and the total intervals
        }
        public float GetExpectedFrequency()
        {
            DefineExpectedFrequency();
            return expectedFrequency;
        }
        private void DefineChiCalculated()
        {
            // Checking if the values are defined yet
            DefineObservedFrequency();
            DefineExpectedFrequency();

            for (int i = 0; i < Intervals; i++)
            {   //Sum
                chiCalculated += Math.Pow(observedFrequency[i] - expectedFrequency, 2) / expectedFrequency;
            }
        }
        public double GetChiCalculated()
        {
            DefineChiCalculated();
            return chiCalculated;
        }
        public bool Approved()
        {
            DefineChiCalculated();
            DefineChiSquare();

            return chiCalculated < chiSquare; // Final condition
        }
    }
}
