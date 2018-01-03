// This project licenses this file to you under the Unlicense.
// See the LICENSE file in the project root for more information.
using System;

namespace CalkiOS.Common
{
    internal static class OSUtil
    {
        static string greaterThen = "> ";

        /// <summary>
        /// Provides the operating system or application name
        /// next to the input field.
        /// </summary>
        /// <returns>input</returns>
        public static string UserInput(bool showOSName = true, string appName = null)
        {
            if (showOSName == true)
                Console.Write($"{OSCompat.Name} {greaterThen}");
            else
            {
                if (appName == null)
                    Console.Write(greaterThen);
                else if (appName != null)
                    Console.Write($"{appName} {greaterThen}");
            }

            var input = Console.ReadLine();
            return input;
        }
    }
}
