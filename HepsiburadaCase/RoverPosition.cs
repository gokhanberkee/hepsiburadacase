using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiburadaCase
{
    public enum Directions
    {
        N = 1,//North
        S = 2,//South
        E = 3,//East
        W = 4//West
    }
    class RoverPosition
    {

        public int x { get; set; }
        public int y { get; set; }
        public Directions fcn { get; set; }


        public RoverPosition()
        {
            x = y = 0;
            fcn = Directions.N;
        }
        public void setPosition(int x, int y, Directions fcn)
        {
            this.x = x;
            this.y = y;
            this.fcn = fcn;
        }


        public void printPosition(List<int> maxPoints, string cmnd)
        {
            foreach (var mv in cmnd)
            {
                switch (mv)
                {
                    case 'L':
                        turnLeft();
                        break;
                    case 'R':
                        turnRight();
                        break;
                    case 'M':
                        move();
                        break;
                    default:
                        Console.WriteLine("It is inappropriate character!");
                        break;
                }
                if (this.x < 0 || this.x > maxPoints[0] || this.y < 0 || this.y > maxPoints[1])
                {
                    throw new Exception($"Incorrect positions. Please check the values ! (0 , 0) and ({maxPoints[0]} , {maxPoints[1]})");
                }
            }
        }
        private void move()
        {
            if (this.fcn == Directions.N)
            {
                this.y += 1;
            }
            else if (this.fcn == Directions.E)
            {
                this.x += 1;
            }
            else if (this.fcn == Directions.S)
            {
                this.y -= 1;
            }
            else if (this.fcn == Directions.W)
            {
                this.x -= 1;
            }

        }
        private void turnLeft()
        {

            if (this.fcn == Directions.N)
            {
                this.fcn = Directions.W;
            }
            else if (this.fcn == Directions.E)
            {
                this.fcn = Directions.N;
            }
            else if (this.fcn == Directions.S)
            {
                this.fcn = Directions.E;
            }
            else if (this.fcn == Directions.W)
            {
                this.fcn = Directions.S;
            }
        }
        private void turnRight()
        {

            if (this.fcn == Directions.N)
            {
                this.fcn = Directions.E;
            }
            else if (this.fcn == Directions.E)
            {
                this.fcn = Directions.S;
            }
            else if (this.fcn == Directions.S)
            {
                this.fcn = Directions.W;
            }
            else if (this.fcn == Directions.W)
            {
                this.fcn = Directions.N;
            }
        }


    }
}
