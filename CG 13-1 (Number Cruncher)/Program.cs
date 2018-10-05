using NumberUtility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CG_13_1__Number_Cruncher_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that has a static method to find the sum 
            //    of all the even numbers in a list. This method should 
            //    be in a class called NumberCruncher in its own class 
            //library called NumberUtility.Within your console project, 
            //    create a list with at least 10 integers and call your 
            //    method on the list
            


            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum = NumberCruncher.EvenSum(numbers);

            Console.WriteLine("The sum of the even numbers in a list from 1-10: {0}", sum);






            Console.WriteLine();
            





            Console.ReadLine();
        }
    }
}
