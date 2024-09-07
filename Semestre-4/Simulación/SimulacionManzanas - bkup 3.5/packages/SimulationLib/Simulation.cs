using System;
using System.Collections.Generic;

namespace SimulationLib
{
    public class Application : ICloneable
    {
        public List<float> LstPseudoRandomNumbers { get; set; }
        public List<(float, float, int)> LstProbabilityInterval { get; set; } = new List<(float, float, int)>()
            {
                (0.00f, 0.15f, 3),
                (0.15f, 0.23f, 5),
                (0.23f, 0.35f, 8),
                (0.35f, 0.55f, 10),
                (0.55f, 0.80f, 14),
                (0.80f, 1.00f, 16)
            };
        public List<int> LstSimulatedYears { get; set; } = new List<int>();
        public float Percentage { get; set; }
        public float UnitPrice { get; set; }
        public int ActualYear { get; set; }
        public int SimulatedYears { get; set; }
        public char SalesPolicy { get; set; }
        public float TotalPrice { get; set; }

        public Application() { }

        public Application(List<float> lstPseudoRandomNumbers, int simulatedYears)
        {
            LstPseudoRandomNumbers = lstPseudoRandomNumbers;
            SimulatedYears = simulatedYears;
        }

        private void DefineSimulatedYears()
        {
            if (LstSimulatedYears.Count != 0) LstSimulatedYears.Clear(); 
            int c = SimulatedYears;
            foreach (float Number in LstPseudoRandomNumbers)
            {
                foreach ((float BottomLimit, float TopLimit, int Days) in LstProbabilityInterval)
                {
                    if (BottomLimit < Number && Number <= TopLimit)
                    {
                        LstSimulatedYears.Add(Days);
                    }
                }
                if (c > 1) c--;
                else break;
            }
        }

        public List<int> GetSimulatedYears()
        {
            DefineSimulatedYears();
            return LstSimulatedYears;
        }

        private void DefinePercentage()
        {
            if (LstSimulatedYears == null || LstSimulatedYears.Count == 0) GetSimulatedYears();
            int LowerToTwoWeeksCounter = 0;

            foreach (int Day in LstSimulatedYears)
            {
                if (Day < 12) LowerToTwoWeeksCounter++;
            }

            Percentage = (float)LowerToTwoWeeksCounter / (float)LstSimulatedYears.Count;
        }

        private void SimulateActualYear()
        {
            float Number = LstPseudoRandomNumbers[SimulatedYears];
            foreach ((float BottomLimit, float TopLimit, int Days) in LstProbabilityInterval)
            {
                if (BottomLimit < Number && Number <= TopLimit)
                {
                    ActualYear = Days;
                    break;
                }
            }
        }

        public float GetPercentage()
        {
            DefinePercentage();
            return Percentage;
        }

        public (char, float) RunSimulation()
        {
            float UnitPrice = 150.00f;

            if (Percentage == 0.0f) GetPercentage();

            if (Percentage >= 0.45)
            {
                SalesPolicy = '1';
                this.UnitPrice = UnitPrice * 1.30f;
                TotalPrice = this.UnitPrice * 100f;
                return (SalesPolicy, TotalPrice);
            }
            else
            {
                SimulateActualYear();
                if (ActualYear < 14)
                {
                    SalesPolicy = '3';
                    this.UnitPrice = UnitPrice * 1.10f;
                    TotalPrice = this.UnitPrice * 100f;
                    return (SalesPolicy, TotalPrice);
                }
                else
                {
                    SalesPolicy = '2';
                    this.UnitPrice = UnitPrice * 1.70f;
                    TotalPrice = this.UnitPrice * 100f;
                    return (SalesPolicy, TotalPrice);
                }
            }
        }

        public object Clone()
        {
            Application Cloned = this.MemberwiseClone() as Application;
            List<float> LstPseudoRandomNumbersCloned = new List<float>(this.LstPseudoRandomNumbers);
            List<(float, float, int)> LstProbabilityIntervalCloned = new List<(float, float, int)>(this.LstProbabilityInterval);
            List<int> LstSimulatedYearsCloned = new List<int>(this.LstSimulatedYears);
            Cloned.LstPseudoRandomNumbers = LstPseudoRandomNumbersCloned;
            Cloned.LstProbabilityInterval = LstProbabilityIntervalCloned;
            Cloned.LstSimulatedYears = LstSimulatedYearsCloned;
            return Cloned;
        }
    }
}
