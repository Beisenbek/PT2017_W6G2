using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeII
{
    public class Game
    {
        public Worm worm = null;
        public Wall wall = null;
        public Food food = null;

        public bool CanEat()
        {
            if (worm.points[0].Equals(food.points[0]))
            {
                worm.points.Add(food.points[0]);
                return true;
            }
            return false;
        }

        public void Start()
        {
            worm = new Worm();
            worm.AttachGameLink(this);

            wall = new Wall();
            food = new Food();

            food.Draw();
            wall.Draw();

            Thread t = new Thread(new ThreadStart(worm.Move));
            t.Start();

            while (true)
            {
                
               
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        worm.dx = 0;
                        worm.dy = -1;
                        break;
                    case ConsoleKey.DownArrow:
                       worm.dx = 0;
                        worm.dy = 1;
                        break;
                    case ConsoleKey.LeftArrow:
                       worm.dx = -1;
                        worm.dy = 0;
                        break;
                    case ConsoleKey.RightArrow:
                        worm.dx = 1;
                        worm.dy = 0;
                        break;
                    case ConsoleKey.Escape:
                        break;
                }

            }
        }
    }
}
