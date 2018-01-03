// This project licenses this file to you under the Unlicense.
// See the LICENSE file in the project root for more information.
using System;

namespace CalkiOS.Common
{
    /// <summary>
    /// Internal programs used by OSTask.
    /// </summary>
    internal class OSCmds
    {
        /// <summary>
        /// Gives information on the system's name, version and codename.
        /// </summary>
        public void About()
        {
            var credits = "Based on the COSMOS Userkit.";
            var license = $"The {OSCompat.Name} project licenses this operating system to you under the Unlicense.";
            Console.WriteLine($"{OSCompat.Logo}\n{OSCompat.About}\n{credits}\n{license}");
            OSShell.Entry();
        }

        /// <summary>
        /// For unknown commands. Tells the user to type "help" for a list commands.
        /// </summary>
        public void NotFound()
        {
            Console.WriteLine("Command not found. Type in \"help\" for a list of commands.");
            OSShell.Entry();
        }

        /// <summary>
        /// Lists any accessable commands that the user can access.
        /// </summary>
        public void Help()
        {
            Console.WriteLine("help - lists any accessable commands\nabout - Prints the OS version and logo.");
            OSShell.Entry();
        }
    }
}
