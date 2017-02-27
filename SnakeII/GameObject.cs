using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SnakeII
{
    public abstract class GameObject : IDrawable
    {
        public List<Point> points = new List<Point>();
        public char sign;

        public void Clear()
        {
            for (int i = 0; i < points.Count; ++i)
            {
                Console.SetCursorPosition(points[i].x, points[i].y);
                Console.Write(' ');
            }
        }
        public void Draw()
        {
            for (int i = 0; i < points.Count; ++i)
            {
                Console.SetCursorPosition(points[i].x, points[i].y);
                Console.Write(sign);
            }
        }

        public void Save()
        {
            XmlSerializer xs = new XmlSerializer(this.GetType());
            using (FileStream fs = new FileStream(string.Format("{0}.xml", this.GetType().Name), FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                xs.Serialize(fs, this);
            }
        }
    }
}
