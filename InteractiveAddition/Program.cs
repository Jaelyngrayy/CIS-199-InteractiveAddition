using static System.Console;
using System;
class InteractiveAddition
{
    static void Main()
    {
        string name, firstString, secondString;
        int first, second, sum;

        Write("Enter your name... ");
        name = ReadLine();
        //user enters their name and is stored in String name
        Write("Hello {0}! Enter the first integer... ", name);
        firstString = ReadLine();
        first = Convert.ToInt32(firstString);
        //User enters String that is stored in firstString, and is then converted into an integer stored in first
        Write("Enter the second integer... ");
        secondString = ReadLine();
        second = Convert.ToInt32(secondString);
        //Same thing as last one but stored in second and secondString
        sum = first + second;
        WriteLine("{0}, the sum of {1} and {2} and is {3}", name, first, second, sum);
        //Adds the two integers that were convereted from strings that the user input

    }
}
