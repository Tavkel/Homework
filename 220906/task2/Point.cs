namespace HomeworkSep06
{
    public class Point
    {
        public Point(int x, int y, int z)
        {
            CoordX = x;
            CoordY = y;
            CoordZ = z;
        }

        public int CoordX { get; set; } = 0;
        public int CoordY { get; set; } = 0;
        public int CoordZ { get; set; } = 0;

        public double GetDistance(Point point)
        {
            int diffX = this.CoordX - point.CoordX;
            int diffY = this.CoordY - point.CoordY;
            int diffZ = this.CoordZ - point.CoordZ;
            double distance = Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ);
            return distance;
        }
    }
}