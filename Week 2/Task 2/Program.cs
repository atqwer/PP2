using System;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader(@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Week 2\Task 2\input1"); // opening a file for reading
            StreamWriter output = new StreamWriter(@"C:\Olymp\C#\PP2\Programming-Principles-2-KBTU\Week 2\Task 2\output1", true); // opening a file for writing
            string x; // created a string
            while ((x = input.ReadLine()) != null)
            { // reading all lines, where x is the current string that stores a line
                if (isPrime(int.Parse(x)))
                { // converting x to integer, and checking if it's a prime number
                    output.WriteLine(x); // Output this number our file for writing
                }
            }
            input.Close(); // close input file
            output.Close(); // close output file
        }
        static bool isPrime(int x)
        {
            if (x == 1) // a corner case
                return false;
            for (int i = 2; i * i <= x; i++) // iterating over possible divisiors <= sqrt(x)
                if (x % i == 0) // if x divides i
                    return false; // then it's not prime 
                                  // no divisors were found, then it's prime 
            return true;
        }
    }
}
