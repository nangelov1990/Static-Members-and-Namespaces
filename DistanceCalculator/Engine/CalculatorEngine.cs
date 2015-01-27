namespace DistanceCalculator.Engine
{
    using System;
    using Point3D.Data;

    static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D firstPoint3D, Point3D secondPoint3D)
        {
            double x = Math.Pow((firstPoint3D.X - secondPoint3D.X), 2);
            double y = Math.Pow((firstPoint3D.Y - secondPoint3D.Y), 2);
            double z = Math.Pow((firstPoint3D.Z - secondPoint3D.Z), 2);

            double distance = Math.Sqrt(x + y + z);

            return distance;
        }
    }
}
