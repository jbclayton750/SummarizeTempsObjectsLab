﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SummarizeTempsObjects
{
    public class TempCalculationEngine
    {
        List<int> _temperatures;
        public TempCalculationEngine(List<int> temperatures)
        {
            _temperatures = temperatures;
        }

        public int AverageTemperature()
        {
            int sumofTemps = 0;
            // loop through all attempts in list
            foreach (int temp in _temperatures)
            {
                // add each temp to sum variable
                sumofTemps += temp;
                // sumoftemps = sumoftemps + temp
            }
            
            int averageTemps = sumofTemps / _temperatures.Count;
            return averageTemps; // <-- Replace this with the actual average
        }

        public int TempsAboveThreshold(int threshold)
        {           
            int AboveSum = 0;

            foreach (int temp in _temperatures)
            {
                if (temp > threshold)
                {
                    AboveSum += 1;
                }
            }

            // add logic to calculate temps above the threshold
            return AboveSum; // <-- Replace this with the number
        }

        public int TempsBelowThreshold(int threshold)
        {
            int BelowSum = 0;

            foreach (int temp in _temperatures)
            {
                if (temp < threshold)
                {
                    BelowSum += 1;
                }
            }

            // add logic to calculate and return temps below the threshold
            return BelowSum; // <-- Replace this with the number
        }

        public int TempsAtThreshold(int threshold)
        {
            int AtSum = 0;

            foreach (int temp in _temperatures)
            {
                if (temp = threshold)
                {
                    AtSum += 1;
                }
            }

            // add logic to calculate and return temps below the threshold
            return AtSum; // <-- Replace this with the number
        }
    

        public int NumberOfTemperatures()
        {
            // add logic to return the number of temparature readings
            return _temperatures.Count; // <-- Replace this with the number
        }
    }
}
