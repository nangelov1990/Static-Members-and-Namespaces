namespace Paths.Data
{
    using System.Text;
    using Point3D.Data;

    class Path3D
    {
        public Path3D(Point3D[] points3D)
        {
            this.Points3D = points3D;
        }

        public Point3D[] Points3D { get; set; }

        public override string ToString()
        {
            var output = new StringBuilder("Path in 3D space, consisting of the following points:\n");

            foreach (var point3D in Points3D)
            {
                output.AppendFormat(" {0}", point3D);
            }

            output.AppendLine();

            return output.ToString();
        }
    }
}
