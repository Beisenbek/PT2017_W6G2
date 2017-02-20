using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeII
{
    public class Worm:GameObject
    {
        Game game = null;
        public int dx;
        public int dy;


        public void AttachGameLink(Game game)
        {
            this.game = game;
        }

        public Worm()
        {
            this.sign = '*';
            this.points.Add(new Point(20, 4));
        }

        public void Move()
        {
            while (true)
            {
                if (points[0].x + dx < 0) continue;
                if (points[0].y + dy < 0) continue;
                if (points[0].x + dx > 40) continue;
                if (points[0].y + dy > 40) continue;

                Clear();

                for (int i = points.Count - 1; i > 0; --i)
                {
                    points[i].x = points[i - 1].x;
                    points[i].y = points[i - 1].y;
                }

                points[0].x = points[0].x + dx;
                points[0].y = points[0].y + dy;

                Draw();

                game.CanEat();

                Thread.Sleep(300);
            }
        }
    }
}
