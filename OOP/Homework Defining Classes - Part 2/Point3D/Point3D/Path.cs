using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Path
    {
        private List<Point3D> pointList = new List<Point3D>();

        public List<Point3D> PointList
        {
            get { return this.pointList; }
            set { this.pointList = value; }
        }

        public void AddPoint(Point3D pointList)
        {
            this.PointList.Add(pointList);
        
        }
        

    }
}
