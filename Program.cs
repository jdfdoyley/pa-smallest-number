/******************************************************************************\
* Name: Jason D. F. D'Oyley
* Date: Oct. 12, 2022
* Assignment CIS214 Performance Assessment - Smallest Number
*
* Main application (program) class.
* The main application class must meet the following requirements
* - Print a line that states "Your Name - Week 2 PA Smallest Number"
* - Ask the user how many integers they will enter
* - Loop to get the specified number of integers from the user
* - Print the value of the smallest integer entered by the user
*
\******************************************************************************/
public class LoopCalculation
{
    static void Main(string[] args)
    {
        // Print a line that states "Your Name - Week 2 PA Smallest Number"
        Console.WriteLine("\nJason D'Oyley - Week 2 PA Smallest Number\n");

        // Ask the user how many integers they will enter
        Console.WriteLine("Finding the Smallest Value:");
        Console.Write("How many integers would you like to enter: ");
        string? val = Console.ReadLine();
        int inVal = Convert.ToInt32(val);

        int inVal2 = 0;
        int smallestVal = 0;

        // Loop to get the specified number of integers from the user
        for (int i = 0; i < inVal; i++)
        {
            Console.Write("Enter an integer value: ");
            val = Console.ReadLine();
            inVal2 = Convert.ToInt32(val);

            if (i == 0)
            {
                smallestVal = inVal2;
                continue;
            }

            if (inVal2 < smallestVal)
            {
                smallestVal = inVal2;
            }

        }

        // Print the value of the smallest integer entered by the user
        Console.WriteLine("The smallest value entered is: {0}", smallestVal);
    }
}