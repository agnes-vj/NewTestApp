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
            if (inputPoint == Point.NORTH)
            {
                if (inputDirection == Direction.RIGHT) return Point.EAST;
                else return Point.WEST;
            }
            if (inputPoint == Point.EAST)
            {
                if (inputDirection == Direction.RIGHT) return Point.SOUTH;
                else return Point.NORTH;
            }
            if (inputPoint == Point.SOUTH)
            {
                if (inputDirection == Direction.RIGHT) return Point.WEST;
                else return Point.EAST;
            }
            if (inputPoint == Point.WEST)
            {
                if (inputDirection == Direction.RIGHT) return Point.NORTH;
                else return Point.SOUTH;
            }
            return Point.NORTH;

        }
    }
}
