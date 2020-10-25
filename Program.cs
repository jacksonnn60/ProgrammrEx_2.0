using System;

namespace Udemy__OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int angelNumber = int.Parse(Console.ReadLine());

            if (angelNumber >= 0 && angelNumber <= 90)
            {
                Console.WriteLine(1);
            }

            if (angelNumber >= 91 && angelNumber <= 180)
            {
                Console.WriteLine(2);
            }

            if (angelNumber >= 181 && angelNumber <= 270)
            {
                Console.WriteLine(3);
            }

            if (angelNumber >= 271 && angelNumber <= 360)
            {
                Console.WriteLine(4);
            }

        }

        static void AddingOfFive()
        {
            int[] arr = new int[5];

            int sum = 0;

            for (int i = 0; i != arr.Length; i++)
            {
                int number = int.Parse(Console.ReadLine());

                arr[i] = number;
            }

            for (int k = 0; k != arr.Length; k++)
            {
                sum += arr[k];
            }

            Console.WriteLine("Total is:" + sum);
        }
        static void FahrenheitTemperature()
        {
            //wind_chill = 35.74 + 0.6215*70 + (0.4275*70 - 35.75) * 15 ^ 0.16

            double supposeTemperature = double.Parse(Console.ReadLine());

            double windSpeed = double.Parse(Console.ReadLine());

            Console.WriteLine("Suppose temp " + supposeTemperature + " and wind speed is " + windSpeed + ".");

            double wind_chill = 35.74 + 0.6215 * supposeTemperature + (0.4275 * supposeTemperature - 35.75) * Math.Pow(windSpeed, 0.16); ;

            Console.WriteLine("so wind_chill is = " + wind_chill);
        }
        static void NumberOccurrence()
        {
            int curNum = int.Parse(Console.ReadLine());

            int[] arr = new int[8];

            int number;

            int sum = 0;

            for (int i = 0; i != arr.Length; i++)
            {
                number = int.Parse(Console.ReadLine());

                arr[i] = number;
            }

            for (int k = 0; k != arr.Length; k++)
            {
                if (arr[k] == curNum)
                {
                    sum++;
                }
            }

            Console.WriteLine(curNum + " :" + sum);
        }
    }
}
