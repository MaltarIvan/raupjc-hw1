using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class CollisionDetector
    {
        public static bool Overlaps(IPhysicalObject2D a, IPhysicalObject2D b)
        {
            /*
            //TODO: popraviti grešku kad se loptica preklopi sa strane s nekim od reketa (paddle)... za svaki IPhysicalObject2D provjeriti što je
            if ((int)a.X == (int)b.X + (int)b.Width || (int)a.X + (int)a.Width == (int)b.X || (int)a.Y == (int)b.Y + (int)b.Height || (int)a.Y + (int)a.Height == (int)b.Y)
            {
                return true;
            }
            return false;
            */
            return (a.X <= b.X + b.Width && a.Y + a.Height >= b.Y && a.Y <= b.Y + b.Height && a.X + a.Width >= b.X) || 
                (a.Y + a.Height >= b.Y && a.X + a.Width >= b.X && a.X <= b.X + b.Width && a.Y <= b.Y + b.Height) ||
                (a.X + a.Width >= b.X && a.Y + a.Height >= b.Y && a.Y <= b.Y +b.Height && a.X <= b.X + b.Width) ||
                (a.Y <= b.Y + b.Height && a.X + a.Width >= b.X && a.X <= b.X + b.Width && a.Y + a.Height >= b.Y);
        }
    }
}
