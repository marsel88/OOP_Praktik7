using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Praktik7
{
    public class Vector
    {
        public double x {  get; set; }
        public double y { get; set; }
        public double z{ get; set; }

        Vector()
        {
            x = 0;
            y = 0;
            z = 0;              
        }
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(x * x + y * y + z * z);
            }

        }
        public void Print()
        {
            Console.WriteLine("(" + x + ", " + y + ", " + z + ")");
        }

        public Vector Add(Vector otherVector)
        {
            return new Vector(x + otherVector.x, y + otherVector.y, z + otherVector.z);
        }

        public Vector Subtract(Vector otherVector)
        {
            return new Vector(x - otherVector.x, y - otherVector.y, z - otherVector.z);
        }
    }
}
