using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace assignementOneExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize
            string p;
            int N;
            int n1;
            List<int> serieslist = new List<int>();
            string seriesliststring;

            p = "This is Pseudocode for Assignment One Exercise 2, Number of terms of series for integer \n";
            p = p + "Read the input integer, say it is N. Create an empty array/list\n";
            p = p + "Get first number, i.e 1, say it is n1. Add it to the array and deduct one from it. While n1 > 0, if length of array is < N, repeat the step\n";
            Debug.WriteLine(p);

            //Read input
            //N = 5;
            Debug.WriteLine("Enter the number of terms to print series, n: ");
            N = int.Parse(Console.ReadLine());
            for (int i=1; i<N+1; i++) //For each number (n1) from 1 to N, add to the array n1 times, array is < N
            {
                n1 = i; //Use the current number to find the number of times to repeat by deducting one each time until N is reached
                
                while (n1 > 0)
                {
                    if (serieslist.Count < N)
                    {
                        serieslist.Add(i);
                        //Debug.WriteLine(i);
                    }
                    else //Number of terms in the series has reached N
                    {
                        break;
                    }
                    n1 = n1 - 1; // Deduct one from the current number after adding to list.
                }
                if (serieslist.Count >= N)
                {
                    break;
                }
            }
            //serieslist.ForEach(Console.WriteLine);
            seriesliststring = string.Join(",", serieslist.ToArray());
            Debug.WriteLine($"Series till n= {N} terms is: ", N);
            Debug.WriteLine(seriesliststring);
            p = "Learnings and Recommendations for exercise 2:\n";
            Debug.WriteLine(p);
            p = p + "1. List operations is very helpful coding knowledge to manage with lesser lines of code\n";
            p = p + "2. Printing List has some iteration logic, sometimes converting to string and printing is easier and serves the purpose\n";
            p = p + "3. While dealing with Multiple loops, writing the comments for each loops purpose helps to easily debug later\n";
            p = p + "4. It is recommended to practice more on List and Array operations, as these seem important for interviews";
            Debug.WriteLine(p);
        }
    }
}
