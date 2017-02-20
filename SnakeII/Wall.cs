using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeII
{
    public class Wall : GameObject
    {
        public Wall()
        {
            this.sign = '#';
            this.points.Add(new Point(2, 4));
            this.points.Add(new Point(2, 5));
            this.points.Add(new Point(2, 6));
            this.points.Add(new Point(2, 7));
        }
    }
}
