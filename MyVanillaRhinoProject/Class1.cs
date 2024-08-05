using Rhino.Geometry;

namespace MyVanillaRhinoProject
{
    public class Class1
    {
        public static bool IsNiceBrep()
        {
            return new Brep().IsValid;
        }
    }
}
