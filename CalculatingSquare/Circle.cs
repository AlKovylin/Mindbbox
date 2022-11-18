namespace CalculatingSquare
{
    public class Circle : Figure
    {
        private double Radius { get; set; }

        public Circle(string figureName, double radius) : base(figureName)
        {
            Radius = radius;
        }

        /// <summary>
        /// Функция вычисления площади.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public override double CalcSquare()
        {
            if (Radius < 0)
                throw new ArgumentException($"ERROR: Радиус \"{FigureName}\" не может быть отрицательным.");

            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
    }
}
