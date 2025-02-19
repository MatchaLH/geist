using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  ________.__                    __      ________                       \r\n /  _____/|  |__   ____  _______/  |_   /  _____/_____    _____   ____  \r\n/   \\  ___|  |  \\ /  _ \\/  ___/\\   __\\ /   \\  ___\\__  \\  /     \\_/ __ \\ \r\n\\    \\_\\  \\   Y  (  <_> )___ \\  |  |   \\    \\_\\  \\/ __ \\|  Y Y  \\  ___/ \r\n \\______  /___|  /\\____/____  > |__|    \\______  (____  /__|_|  /\\___  >\r\n        \\/     \\/           \\/                 \\/     \\/      \\/     \\/ ");
            Console.WriteLine("\n\nGib deinen Name ein: ");
            string name1 = Convert.ToString(Console.ReadLine());

            int score1 = Game();

            Console.WriteLine(name1 + ", score: " +score1);


            Console.WriteLine("\n\nGib deinen Name ein: ");
            string name2 = Convert.ToString(Console.ReadLine());

            int score2 = Game();

            Console.WriteLine(name2 + ", score: " +score2);



            if (score1 > score2)
            { 
                Console.WriteLine("\n\n"+name1 + " hat mit einem Score von " + score1 + " gewonnen!");
            }
            else
            {
                Console.WriteLine("\n\n"+name2 + " hat mit einem Score von " + score2 + " gewonnen!");
            }

            Console.ReadLine();
        }

        private static int Game()
        {
            Random random = new Random();
            int ghost = random.Next(1, 4);
            bool isGameOver = false;
            int Tür = 0;
            int score = 0;

            while (isGameOver == false)
            {
                ghost = random.Next(1, 4);

                Console.WriteLine("Welche Tür wählst du 1,2 oder 3?");
                Tür = Convert.ToInt32(Console.ReadLine());

                if (Tür == 1 || Tür == 2 || Tür == 3)
                {
                    if (Tür == ghost)
                    {
                        Console.WriteLine("Game Over");
                        isGameOver = true;
                    }
                    else
                    {
                        Console.WriteLine("Du bist eine Station weiter");
                        score = score + 1;
                    }

                }
                else
                {
                    Console.WriteLine("falsche Eingabe: Probier nochmal");

                }

            }
            return score;

        }
    }
}
