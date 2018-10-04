using System;
using System.Collections.Generic;

namespace NumberUtility
{
    public class NumberCruncher
    {

        public int Number { get; set; }

        public static List<int> Numbers { get; set; }

        


        public static int EvenSum()
        {
            var evenTotal = 0;
            foreach (int number in Numbers)
            {
                if (number % 2 == 0)
                    evenTotal = number + evenTotal;


                else
                    continue;
            }

            return evenTotal;

        }

        
            
        


       

    }
}
