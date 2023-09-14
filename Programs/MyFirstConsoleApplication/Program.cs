using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName, location, currentDateString;

            fullName = "Amanda Cole";
            location = "Utah";

            Console.WriteLine($"My name is {fullName}.");
            Console.WriteLine($"I am from {location}.");

            // Get only the current date without time
            DateTime currentDate = DateTime.Today;
            // Display the current date with day, month, and year spelled out
            currentDateString = currentDate.ToString("dddd, MMMM dd, yyyy");
            Console.WriteLine($"Current Date: {currentDateString}");

            // Calculate the date for Christmas (December 25th of the current year)
            DateTime christmas = new DateTime(currentDate.Year, 12, 25);

            // Calculate the number of days until Christmas
            TimeSpan timeUntilChristmas = christmas - currentDate;
            int daysUntilChristmas = timeUntilChristmas.Days;
            Console.WriteLine($"There are {daysUntilChristmas} days until Christmas!");
            Console.WriteLine();

            Console.WriteLine("Window Measuring");
            Console.WriteLine();

            //Example code from 2.1
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //Adding user prompt
            Console.Write("What is the window WIDTH in feet: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            //Adding user prompt
            Console.Write("What is the window HEIGHT in feet: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            Console.WriteLine();

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine($"The length of the wood is {woodLength} feet.");
            Console.WriteLine($"The area of the glass is {glassArea} square metres.");

            Console.ReadKey();

        }
    }
}
