namespace CodeWars.Eighth.BaryCenters
{
    public class BaryCenter
    {
        public static double[] BarTriang(double[] x, double[] y, double[] z)
        {
            double xCoordinates = x[0] + y[0] + z[0];
            double yCoordinates = x[1] + y[1] + z[1];

            double[] baryCenterCoordinates = new double[] {
                Math.Round(xCoordinates / 3.0,4),
                Math.Round(yCoordinates / 3.0,4)};

            return baryCenterCoordinates;
        }
    }
}
