using System;
using System.Collections.Generic;
using System.Text;


namespace DesignPatternCodes.WarriorGame
{
    
        public static class Tools
        {

            public static void colorfulWriteLine(string text, ConsoleColor color)
            {
                Console.ForegroundColor = color;
                Console.WriteLine(text);
                Console.ResetColor();
            }

        }


    
}
