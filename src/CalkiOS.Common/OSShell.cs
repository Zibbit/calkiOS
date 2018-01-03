// This project licenses this file to you under the Unlicense.
// See the LICENSE file in the project root for more information.
using System;
using CalkiOS.Common.Apps;

namespace CalkiOS.Common
{
    public class OSShell
    {
        static void Command(string cmd)
        {
            var guessing = new AppGuessing();
            var thelang = new AppLanj();

            var cmds = new OSCmds();
            switch (cmd)
            {
                case "help":
                    cmds.Help();
                    break;
                case "about":
                    cmds.About();
                    break;
                case "guess":
                    guessing.Entry();
                    break;
                case "thelang":
                    thelang.Entry();
                    break;
#if PAWOS_EMU
                case "exit":
                    Environment.Exit(0);
                    break;
#endif
                default:
                    cmds.NotFound();
                    break;
            }
        }

        public static void Entry()
        {
            var input = OSUtil.UserInput();
            Command(input);
        }
    }
}
