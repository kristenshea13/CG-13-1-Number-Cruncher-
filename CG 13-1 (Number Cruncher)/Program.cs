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
            //I created a set list, but can create list from user-entered integers
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //create variable for value from method in class
            int sum = NumberCruncher.EvenSum(numbers);

            //print to console in a string
            Console.WriteLine("The sum of the even numbers in a list from 1-10: {0}", sum);



            Console.ReadLine();
        }
    }
}
