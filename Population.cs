using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            double tempPopulation = initialPopulation;

            int currentYear = 0;

            do
            {
                tempPopulation = tempPopulation + (tempPopulation * (percent / 100)) + visitors;
                currentYear++;
            }
            while (tempPopulation < currentPopulation);

            return currentYear;
        }
    }
}
    
