namespace DistanceCalculator
{
    using System;
    using Point3D.Data;
    using DistanceCalculator.Engine;
    public static class DistanceIn3DSpace
    {
        static void Main(string[] args)
        {
            var point3DFirst = new Point3D(0, 5, 9);
            var point3DSecond = new Point3D(4, 7, 2);
            var point3DThird = new Point3D(1, 16, 27);
            var point3DCentre = Point3D.StartPoint3D;

            var distanceBetweenPoints = DistanceCalculator.CalculateDistance(point3DFirst, point3DSecond);
            var distanceToStartPoint = DistanceCalculator.CalculateDistance(point3DThird, point3DCentre);

            Console.WriteLine("Distance between {0} and {1} is {2}",
                point3DFirst,
                point3DSecond,
                distanceBetweenPoints);

            Console.WriteLine("Distance between the center of coordinate system - {0} and {1} is {2}",
                point3DCentre,
                point3DThird,
                distanceToStartPoint);
        }
    }
}
