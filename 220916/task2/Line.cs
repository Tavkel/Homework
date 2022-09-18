namespace HomeworkSep16
{
    public class Line
    {
        public Line(double inclination, double offset)
        {
            Inclinaton = inclination;
            Offset = offset;
        }
        public double Inclinaton { get; set; }
        public double Offset { get; set; }
        
        public bool? IsParallel(Line line)
        {
            if (this.Inclinaton == line.Inclinaton)
            {
                if(this.Offset == line.Offset) return null;
                return true;
            }
            return false;
        }
        public double[] Intersection(Line line)
        {
            double[] result = new double[2];
            //y = a1*x + b1
            //y = a2*x + b2
            //a2*x + b2 = a1*x + b1
            //x(a1-a2) = b2 - b1
            //x = (b2-b1)/(a1-a2)

            result[0] = Math.Round((line.Offset - this.Offset)/(this.Inclinaton - line.Inclinaton), 2);
            result[1] = Math.Round((this.Inclinaton * result[0] + this.Offset), 2);
            return result;
        }
    }
}