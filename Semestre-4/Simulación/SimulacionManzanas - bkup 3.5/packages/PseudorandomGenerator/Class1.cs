using System;
using System.Collections.Generic;

namespace PseudorandomGenerator
{
    public class Pseudorandom : ICloneable
    {
        public float MultiplicativeConstant { get; set; } // Multiplicative Constant
        public float Seed { get; set; } //Seed
        public float AdditiveConstant { get; set; } // Additive Constant
        public float Module { get; set; } // Module
        public int Quantity { get; set; } // Quantity
        public List<float> LstNumbers { get; set; }

        public Pseudorandom() { LstNumbers = new List<float>(); } //Default Constructor

        public Pseudorandom(float multiplicativeConstant, float seed, float additiveConstant, float module, int quantity) //Constructor with values
        {
            MultiplicativeConstant = multiplicativeConstant;
            Seed = seed;
            AdditiveConstant = additiveConstant;
            Module = module;
            Quantity = quantity;
            LstNumbers = new List<float>();            
        }

        public List<float> Generate(int TotalNumbers)
        {
            LstNumbers?.Clear();
            float AuxSeed = this.Seed;

            for (int i = 0; i < TotalNumbers; i++)
            {
                AuxSeed = (MultiplicativeConstant * AuxSeed + AdditiveConstant) % this.Module;
                LstNumbers.Add(AuxSeed / this.Module);
            }
            return LstNumbers;
        }
        public List<float> Generate()
        {
            LstNumbers?.Clear();
            float AuxSeed = this.Seed;

            for (int i = 0; i < Quantity; i++)
            {
                AuxSeed = (MultiplicativeConstant * AuxSeed + AdditiveConstant) % this.Module;
                LstNumbers.Add(AuxSeed / this.Module);
            }
            return LstNumbers;
        }

        public void Clear()
        {
            MultiplicativeConstant = 0.0f;
            Seed = 0.0f;
            AdditiveConstant = 0.0f;
            Module = 0.0f;
            LstNumbers.Clear();
        }

        public object Clone()
        {
            Pseudorandom Cloned = this.MemberwiseClone() as Pseudorandom;
            List<float> LstClonedList = new List<float>(this.LstNumbers);
            Cloned.LstNumbers = LstClonedList;
            return Cloned;
        }
    }
}
