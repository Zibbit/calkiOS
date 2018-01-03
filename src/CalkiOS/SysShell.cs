using System;
using CalkiOS.Common;

namespace CalkiOS
{
    internal class SysShell : OSShell
    {
        public static void FirstBoot()
        {
            var Bootlines = @"**********************************";
            Console.WriteLine($"{Bootlines}\n{OSCompat.Logo}\n{Bootlines}");
        }
    }
}
