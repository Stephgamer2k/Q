using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Ice_Task
{
    class Welcome
    {
        public static void ShowWelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════╗");
            Console.WriteLine("║       QUIZ GAME        ║");
            Console.WriteLine("╚════════════════════════╝");

            Console.ResetColor();
        }
    }
}
