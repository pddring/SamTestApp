using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamTestApp
{
    internal class Simulation
    {
        List<int> results = new List<int>();
        int[] frequencyAnalysis;

        public double[] xValues;
        public double[] yValues;

        public int numberOfDice = 1;

        public int minValue { get; }
        public int maxValue { get; }

        int numberOfSides;

        public Simulation(int numberOfDice, int numberOfSides = 6)
        {
            this.numberOfDice = numberOfDice;
            minValue = numberOfDice;
            maxValue = numberOfDice * numberOfSides;
            this.numberOfSides = numberOfSides;
        }

        public void Roll(int rollCount)
        {
            results.Clear();
            frequencyAnalysis = new int[maxValue];

            // roll all dice
            Random r = new Random();
            for(int i = 0; i < rollCount; i++)
            {
                int total = 0;
                for(int j = 0; j < numberOfDice; j++)
                {
                    total += r.Next(1, numberOfSides);
                }
                results.Add(total);
            }

            // count results
            foreach(int result in results)
            {
                frequencyAnalysis[result]++;
            }

            
            // generate x values
            xValues = new double[maxValue - minValue + 1];
            for (int i = 0; i <= maxValue - minValue; i++)
            {
                xValues[i] = i + minValue;
            }

            // generate y values
            yValues = new double[maxValue - minValue + 1];
            for(int i = 0; i < maxValue - minValue; i++)
            {
                yValues[i] = frequencyAnalysis[i + minValue];
            }
        }
    }
}
