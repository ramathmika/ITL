using System;

namespace q2
{
    class Program
    {

        static bool isLeapYear(int year)
        {
            // If a year is multiple of 400, then it is a leap year
            if (year % 400 == 0)
                return true;

            // Else If a year is multiple of 100, then it is not a leap year
            if (year % 100 == 0)
                return false;

            // Else If a year is multiple of 4, then it is a leap year
            if (year % 4 == 0)
                return true;
            return false;
        }

        static int NumOfDays(int month, int year)
        {
            switch (month)
            {
                case 2:
                    if (isLeapYear(year))
                    {
                        return 29;
                    }
                    else
                        return 28;
                case 1: case 3: case 5: case 7: case 8: case 10: case 12: return 31;
                default: return 30;
            }
        }

        static void Main(string[] args)
        {
            //Input
            Console.WriteLine("Enter the date in the format \"DD: MM: YY: hh: mm: ss\": ");
            string dateTime = Console.ReadLine();
            Console.WriteLine("Enter the number of ticks: ");
            long ticks;
            long.TryParse(Console.ReadLine(), out ticks);

            //Check if "ticks" is in range
            if (ticks < 10000000 || ticks > 999999999999)
            {
                Console.WriteLine("Not valid. Enter ticks within the range 10000000 and 999999999999");
                return;
            }

            //Convert ticks to seconds
            int seconds = Convert.ToInt32(ticks * Math.Pow(10.0, -7.0));

            //Convert the date taken as input to an integer array
            string[] arr = dateTime.Split(": ");
            int[] dateArray = Array.ConvertAll(arr, int.Parse);

            //Calcuate new date
            int minutes = 0, hours = 0, days = 0;

            //If new ss is greater than 60, add it to minutes. The input will always be 1 second or more due to the contraint check.
            if (seconds + dateArray[5] >= 60)
            {
                minutes = (seconds + dateArray[5]) / 60;
                dateArray[5] = (seconds + dateArray[5]) % 60;
            }
            else
                dateArray[5] += seconds;

            //If new mm is greater than 60, add it to hours.
            if (minutes > 0 && minutes + dateArray[4] >= 60)
            {
                hours = (minutes + dateArray[4]) / 60;
                dateArray[4] = (minutes + dateArray[4]) % 60;
            }
            else
                dateArray[4] += minutes;

            //If new hh is greater than 24, add it to days.
            if (hours > 0 && hours + dateArray[3] >= 24)
            {
                days = (hours + dateArray[3]) / 24;
                dateArray[3] = (hours + dateArray[3]) % 24;
            }
            else
                dateArray[3] += hours;

            //If new days is greater than 1, add it to DD. The ticks will never be greater than a day due to the constraint check.
            //Check if adding day changes month
            if (days >= 1)
            {
                int numOfDays = NumOfDays(dateArray[1], dateArray[2]);
                if (days + dateArray[0] > numOfDays)
                {
                    dateArray[0] = 01;
                    if (dateArray[1] + 1 >= 12)
                    {
                        dateArray[1] = 01;
                        dateArray[2] = (dateArray[2] + 1) % 100;
                    }
                }
                else
                    dateArray[0] += days;
            }

            Console.WriteLine("New time is: ");
            Console.WriteLine(String.Join(": ", dateArray));
            Console.Read();
        }
    }
}

