using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotStickGame
{
    public class Program
    {


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите количество палочек для игры: (10,15,20)");
                int StickCount = int.Parse(Console.ReadLine());
                if (StickCount == 10 || StickCount == 15 || StickCount == 20)
                {
                    StickGame game = new StickGame(StickCount);
                    game.TurnMaker();
                    Console.ReadLine();
                    Console.Clear();
                }

            }


        }
    }
}
