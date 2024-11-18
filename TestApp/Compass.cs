using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Compass
    {
        public Point point {  get; set; }
        public Point Rotate(Point inputPoint, Direction inputDirection)
        {
            return Point.SOUTH;
        }
    }
}
