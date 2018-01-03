// This project licenses this file to you under the Unlicense.
// See the LICENSE file in the project root for more information.
using System;

namespace CalkiOS.Common.Apps
{
    class AppGuessing : IApp
    {
        public void Entry()
        {
            var numCorect = false;
            var randNumGen = new Random();
            var randNum = randNumGen.Next(1, 10 + 1).ToString();
            var appName = "Guessing Game";

            Console.WriteLine("I'm thinking of a number between 1 and 10. Take a guess.");
            do
            {
                var userGuess = OSUtil.UserInput(false, appName);

                if (userGuess == randNum)
                {
                    numCorect = true;
                    Console.WriteLine("Correct! New game? y/n");

                    var input = OSUtil.UserInput(false, appName);
                    switch (input)
                    {
                        case "y":
                            Entry();
                            break;
                        case "n":
                            OSShell.Entry();
                            break;
                        default:
                            Console.WriteLine("I didn't understand.");
                            Entry();
                            break;
                    }
                }
                else if (userGuess == "exit" || userGuess == "quit")
                    OSShell.Entry();

            } while (!numCorect);
        }
    }
}

