namespace Point3D
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public struct Point3D
    {
        //private decimal pointX;
        //private decimal pointY;
        //private decimal pointZ;
        private static readonly Point3D origin = new Point3D(0, 0, 0);

        public Point3D(decimal x, decimal y, decimal z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;


        }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }
        public static Point3D Origin { get; set; }


        

        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}; Z = {2}", this.X, this.Y, this.Z);
        }
    }



}


