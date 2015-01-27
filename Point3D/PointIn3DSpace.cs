namespace Point3D
{
    using System;
    using Point3D.Data;

    class PointIn3DSpace
    {
        static void Main(string[] args)
        {
            var point3DFirst = new Point3D(0, 5, 9);
            var point3DSecond = new Point3D(4, 7, 2);
            var point3DThird = new Point3D(1, 16, 27);

            var point3DCentre = Point3D.StartPoint3D;

            var points = new Point3D[] { point3DCentre, point3DFirst, point3DSecond, point3DThird };

            foreach (var point in points)
            {
                Console.WriteLine(point);
            }
        }
    }
}
