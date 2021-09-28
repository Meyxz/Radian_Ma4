using System;
using System.Collections.Generic;
using System.Text;

namespace Radian_Ma4
{
    class MyProgram
    {
        public void Run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                DegtoRad(ref isRunning);
            }
        }

        void DegtoRad(ref bool isRunning)
        {
            Console.Clear();
            double inputAng = 0;
            double rad = 0;
            string inputTxt = string.Empty;
            bool isDone = false;
            bool isInputValid = false;

            while (!isInputValid)
            {
                Console.WriteLine("Hur många grader?");
                inputTxt = Console.ReadLine().Trim().Replace(".", ",");
                isInputValid = double.TryParse(inputTxt, out inputAng);
                if (!isInputValid)
                {
                    Console.Clear();
                }
            }

            rad = (Math.PI / 180) * inputAng;
            rad = Math.Round(rad, 2);
            Console.WriteLine("{0}° blir {1} radianer", inputAng, rad);
            Console.WriteLine("\nTryck Y för att testa igen");
            Console.WriteLine("Tryck N för att avsluta");
            while (!isDone)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.N)
                    {
                        isRunning = false;
                        isDone = true;
                    }
                    else if (keyInfo.Key == ConsoleKey.Y)
                    {
                        isDone = true;
                    }
                }
            }
        }
    }
}
