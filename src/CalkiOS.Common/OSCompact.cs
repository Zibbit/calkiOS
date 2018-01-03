// This project licenses this file to you under the Unlicense.
// See the LICENSE file in the project root for more information.

namespace CalkiOS.Common
{

    /// <summary>
    /// Easily reuse simple but common components.
    /// </summary>
    public static class OSCompat
    {
        static int Majorver = 0;
        static int Minorver = 1;

        public static string Name => "CalkiOS";
        public static string Version => $"{Majorver}.{Minorver}";
        public static string Codename { get {
                var sysName = "System";
                var codenames = new string[] { "Orion", $"{sysName} One",
                    $"{sysName} Two", $"{sysName} Three", $"{sysName} Four" };

                return codenames[0];
            }
        }
        public static string About => $"Name: {Name}\nVersion: {Version}\nCodename: {Codename}";

        // Leave this at the bottom
       public static string Logo => @"
@@@@@  @@' @@@ @@@@@  @@@@:  @@@@@
#####: ##; ### #####  ##### :#####
 @` @; :@  `@   @  @  @, ;@ ;@    
 ++++: ,+   +   ++++  +. :+  .+;  
 ''''  ,'   '   '''+  '. ,'   ,': 
 ;     .;   ;   ;     ;` ,;     ;;
'''    .'''''  '''    ''''' ,'''''
:::     ::::,  :::    ::::. .:::: 
";


    }
}
