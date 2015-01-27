namespace Paths
{
    using System.Text;
    using Point3D.Data;
    using Paths.Data;
    using Paths.IO;

    class PathsTester
    {
        const string FileName = "Path3D.txt";

        static void Main(string[] args)
        {
            var point3DFirst = new Point3D(0, 5, 9);
            var point3DSecond = new Point3D(4, 7, 2);
            var point3DThird = new Point3D(96, 46, 7);
            var point3DForth = new Point3D(1, 16, 27);
            var point3DFifth = new Point3D(15, 1, 127);
            var point3DSixth = new Point3D(71, 16, 217);
            var point3DSeventh = new Point3D(16, 164, 57);

            var pathFirst = new Path3D(new Point3D[]
            {
                point3DFirst,
                point3DSecond,
                point3DThird,
                point3DForth,
                point3DFifth,
                point3DSixth,
                point3DSeventh
            });

            var pathSecond = new Path3D(new Point3D[]
            {
                point3DFirst,
                point3DThird,
                point3DFifth,
                point3DSeventh
            });

            var pathThird = new Path3D(new Point3D[]
            {
                point3DSecond,
                point3DForth,
                point3DSixth
            });

            var paths = new Path3D[] {pathFirst, pathSecond, pathThird};

            var content = new StringBuilder();

            foreach (var path in paths)
            {
                content.AppendLine(path.ToString());
            }

            string contentString = content.ToString();

            Storage.SaveToFile(FileName, contentString);
            Storage.LoadFromFile(FileName);
            
            Storage.SaveToFile(FileName, contentString);
            Storage.LoadFromFile(FileName);

            Storage.ReplaceFileContent(FileName, contentString);
            Storage.LoadFromFile(FileName);

            Storage.DeleteFile(FileName);
            Storage.LoadFromFile(FileName);
        }
    }
}
