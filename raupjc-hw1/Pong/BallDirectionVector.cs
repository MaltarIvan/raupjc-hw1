using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class BallDirectionVector
    {
        private int _x;
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                if (value != 1 && value != -1)
                {
                    throw new ArgumentException("BallDirectionVector can only have values of -1 and 1.");
                }
                else
                {
                    _x = value;
                }
            }
        }
        private int _y;
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                if (value != 1 && value != -1)
                {
                    throw new ArgumentException("BallDirectionVector can only have values of -1 and 1.");
                }
                else
                {
                    _y = value;
                }
            }
        }

        public BallDirectionVector(int x, int y)
        {
            if (x != 1 && x != -1 || y != 1 && y != -1)
            {
                throw new ArgumentException("BallDirectionVector can only have values of -1 and 1.");
            }
            else
            {
                _x = x;
                _y = y;
            }
        }

        public static Vector2 operator *(BallDirectionVector ballDirectionVector, float a)
        {
            return new Vector2(ballDirectionVector.X * a, ballDirectionVector.Y * a);
        }
        //TODO: dodati ostale moguće operatore
    }
}
