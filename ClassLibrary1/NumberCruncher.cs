using System;
using System.Collections.Generic;

namespace NumberUtility
{
    public class NumberCruncher
    {

        

        
        //NumberUtility class library with a class called NumberCruncher

        
        
         //method to total the sum of all even numbers in a list
         //checks number to see if it is even then adds together
         //if odd, number is skipped and loop continues
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
