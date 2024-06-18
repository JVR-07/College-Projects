using System;
using System.Collections.Generic;
using MathNet.Numerics.Distributions;

namespace SeriesTestLib
{
    public class SeriesTest
    {
        public List<float> LstPseudoRandomNumbers { get; set; } // List of pseudorandom numbers 
        public int Groups { get; set; } // List of groups (the groups are symmetric in the rows and columns quantity)
        public float Alpha { get; set; } // Level of significance
        private List<(float, float)> LstPairs;
        private List<(float, float)> LstProbIntervals;
        private int[,] observedFrequency;
        private int totalSubGroups;
        private float expectedFrequency;
        private double chiCalculated;
        private double chiSquare;

        public SeriesTest() { } // Default constructor

        public SeriesTest(List<float> lstPseudoRandomNumbers, int groups, float alpha) //Constructor
        {
            LstPseudoRandomNumbers = lstPseudoRandomNumbers;
            Groups = groups;
            Alpha = alpha;
        }

        private void DefinePairs()
        {
            if (LstPairs != null) LstPairs.Clear();
            LstPairs = new List<(float, float)>(LstPseudoRandomNumbers.Count - 1);
            for (int i = 0; i < LstPseudoRandomNumbers.Count - 1; i++)
            {
                LstPairs.Add((LstPseudoRandomNumbers[i], LstPseudoRandomNumbers[i + 1])); //Creating a tuple and adding it to the list
            }
        }
        public List<(float, float)> GetPairs()
        {
            if (LstPairs == null) DefinePairs();
            return LstPairs;
        }
        private void DefineTotalSubGroups()
        {
            totalSubGroups = Groups * Groups;
        }
        public int GetTotalSubGroups()
        {
            DefineTotalSubGroups();
            return totalSubGroups;
        }
        private void DefineIntervals()
        {
            if (LstProbIntervals != null) LstProbIntervals.Clear();
            this.LstProbIntervals = new List<(float, float)>(Groups); //List for save the probability of each interval
            float topLimit = 0f, bottomLimit;
            //Find the probability of each interval
            float prob = (float)1 / this.Groups;
            //Define the limits of each interval
            for (int i = 0; i < Groups; i++)
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
        private void DefineExpectedFrequency()
        {
            if (LstPairs == null) DefinePairs();
            if (totalSubGroups == 0) DefineTotalSubGroups();
            expectedFrequency = (float)LstPairs.Count / totalSubGroups;
        }
        public float GetExpectedFrequency()
        {
            if (expectedFrequency == 0.0f) DefineExpectedFrequency();
            return expectedFrequency;
        }
        private void DefineObservedFrequency()
        {
            if (LstProbIntervals == null) DefineIntervals(); // Checking if the probabilities of each interval are defined
            if (LstPairs == null) DefinePairs();

            int c, group1 = 0; //Counter for the interval
            int j, group2 = 0; //Counter for the interval
            observedFrequency = new int[Groups, Groups];
            foreach ((float Pair1, float Pair2) in LstPairs) //Getting each pseudorandom number pair
            {
                c = 0; //Starting counter
                j = 0; //Starting counter
                foreach ((float bottomLimit, float TopLimit) in LstProbIntervals) //Getting each limit of each interval
                {

                    if (bottomLimit < Pair1 && Pair1 <= TopLimit) //Checking if number is between both limits
                    {
                        group1 = c; //Counter
                        break;
                    }
                    c++; //Counter
                }
                foreach ((float bottomLimit, float TopLimit) in LstProbIntervals) //Getting each limit of each interval
                {

                    if (bottomLimit < Pair2 && Pair2 <= TopLimit) //Checking if number is between both limits
                    {
                        group2 = j; //Counter
                        break;
                    }
                    j++; //Counter
                }
                observedFrequency[group1, group2]++;
            }
        }
        public int[,] GetObservedFrequency()
        {
            if (observedFrequency == null) DefineObservedFrequency();
            return observedFrequency;
        }
        private void DefineChiSquare()
        {
            chiSquare = ChiSquared.InvCDF((double)totalSubGroups - 1, (double)Alpha); //Use MathNet.Numerics Library
        }
        public double GetChiSquare()
        {
            if (chiSquare == 0) DefineChiSquare();
            return chiSquare;
        }
        private void DefineChiCalculated()
        {
            if (observedFrequency == null) DefineObservedFrequency();
            if (expectedFrequency == 0) DefineExpectedFrequency();

            for (int i = 0; i < Groups; i++)
            {
                for (int j = 0; j < Groups; j++)
                {
                    chiCalculated += Math.Pow(observedFrequency[i, j] - expectedFrequency, 2) / expectedFrequency;
                }
            }
        }
        public double GetChiCalculated()
        {
            if (chiCalculated == 0) DefineChiCalculated();
            return chiCalculated;
        }
        public bool Approved()
        {
            if (chiCalculated == 0) DefineChiCalculated();
            if (chiSquare == 0) DefineChiSquare();

            //return chiCalculated < chiSquare; // Final condition
            return chiCalculated < chiSquare ? true : false;
        }
    }
}
