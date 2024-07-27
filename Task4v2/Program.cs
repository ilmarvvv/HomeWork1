namespace Task4v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0, "A");
            Point B = new Point(0, 4, "B");
            Point C = new Point(3, 0, "C");
            Point D = new Point(3, 4, "D");
            Point E = new Point(1, 2, "E");



            // Creating a polygon from three points
            Figure triangle = new Figure("Triangle", A, B, C);
            triangle.PerimeterCalculator();

            // Creating a polygon from four points
            Figure quadrilateral = new Figure("Quadrilateral", A, B, C, D);
            quadrilateral.PerimeterCalculator();

            // Creating a polygon from five points
            Figure pentagon = new Figure("Pentagon", A, B, C, D, E);
            pentagon.PerimeterCalculator();

            //// Error... Creating a polygon from six points
            //Point error = new Point(2, 3, "Error");
            //Figure hexagon = new Figure("Pentagon", A, B, C, D, E, error);
            //pentagon.PerimeterCalculator();

            // Delay
            Console.ReadKey();
        }
    }
}
