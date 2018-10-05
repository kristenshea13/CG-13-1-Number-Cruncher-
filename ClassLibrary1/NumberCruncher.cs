using System;
using System.Collections.Generic;

namespace NumberUtility
{
    public class NumberCruncher
    {

        

        

        


        public static int EvenSum(List<int> numbers)
        {
            var evenTotal = 0;
            foreach (int number in numbers)
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
