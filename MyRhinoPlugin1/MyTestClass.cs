using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino;
using Rhino.Geometry;

namespace MyRhinoPlugin1
{
    public class MyTestClass
    {

        public static Brep GetABrep()
        {
            return new Box(new BoundingBox(0, 0, 0, 10, 10, 10)).ToBrep();
        }
    }
}
