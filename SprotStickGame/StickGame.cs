using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprotStickGame
{
    public partial class StickGame
    {
        public int StickCount { get; private set; }

        public  Gamestatus GameStatus { get; set; }

        public delegate void Action();

        public StickGame(int StickCount)
        {
            this.StickCount = StickCount;
            GameStatus = Gamestatus.Unstarted;

        }

        public void TurnMaker()
        {
            while (StickCount > 0)
            {
                GameStatus = Gamestatus.Inprogress;
                Action method1 = HumanTurn;
                method1 += ComputerTurn;
                method1();

            }
        }

        public void HumanTurn()
        {
            
            int min = 1;
            int max = 3;
            Console.WriteLine($"Возьмите палочки от {min} - {max}");

            while (true)
            {
                int GrabCount = int.Parse(Console.ReadLine());
                if (GrabCount >= min && GrabCount <= max && GrabCount <= StickCount)
                {
                    StickCount -= GrabCount;

                    Console.WriteLine($"Осталось {StickCount} палочек");

                    if (StickCount == 0)
                    {
                        GameStatus = Gamestatus.ComputerWon;
                        Console.WriteLine("Computer win!");
                    }

                    break;
                }
                else
                {
                    Console.WriteLine($"Количество взятых палочек должно быть от {min} - {max} и не больше {StickCount}");
                }


            }


        }

        public void ComputerTurn()
        {
            
            Random rnd = new Random();
            int comt = rnd.Next(1, 3);
            if (comt > StickCount)
            { 
                comt = StickCount;
            }

            else
            {
                StickCount -= comt;

                Console.WriteLine($"Компьютер берет  {comt} палки");

                Console.WriteLine($"Осталось {StickCount} - палок");
                if (StickCount == 0)
                {
                    GameStatus = Gamestatus.HumanWon;
                    Console.WriteLine("Human win!");

                }

            }

        }
    }
}
