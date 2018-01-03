// This project licenses this file to you under the Unlicense.
// See the LICENSE file in the project root for more information.
using CalkiOS.Common;
using cSys = Cosmos.System;

namespace CalkiOS
{
    public class Kernel : cSys.Kernel
    {
        protected override void BeforeRun()
        {
            SysShell.FirstBoot();
        }

        protected override void Run()
        {
            OSShell.Entry();
        }
    }
}
