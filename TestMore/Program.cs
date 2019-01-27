using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMore
{
    class Program
    {
        static void Main(string[] args)
        {
            MoreLearner.CMain MorseEngine = new MoreLearner.CMain();
            if (args.Contains("-test"))
            {
                Console.Title = "Test Window";

                RESTART:
                Console.WriteLine("Morse > English & English > Morse \n");
                Console.WriteLine("NOTICE: If you are seeing this that means you have most likely opened the wrong executable go back and run game.exe instead. \n\n");
                Console.WriteLine("Options: \n1: Translate to Morse \n2: Translate to English \n\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Type what you would like translated into Morse: \n\n");
                        Console.WriteLine(MorseEngine.CharToMorse(Console.ReadLine()));
                        Console.WriteLine("\n\n Hit [ENTER] to reset...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("Type what you would like translate into English: \n\n");
                        Console.WriteLine(MorseEngine.MorseToChar(Console.ReadLine()));
                        Console.WriteLine("\n\n Hit [ENTER] to reset...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

                goto RESTART;
            }
            else
            {
                MorseEngine.RunNorm();
                
            }
        }
    }
}
