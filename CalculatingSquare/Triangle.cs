namespace CalculatingSquare
{
    public class Triangle : Figure
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }

        public Triangle(string figureName, double a, double b, double c) : base(figureName)
        {
            A = a;
            B = b;
            C = c;
        }

        /// <summary>
        /// Функция вычисления площади поверхности фигуры.
        /// </summary>
        /// <returns></returns>
        public override double CalcSquare()
        {
            CheckTriangle();

            double p = (A + B + C) / 2;

            return Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 2);
        }

        /// <summary>
        /// Проверяет является ли треугольник треугольником.
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        private void CheckTriangle()
        {
            if (A < 0 || B < 0 || C < 0)
                throw new ArgumentException("ERROR: Сторона треугольника не может быть меньше нуля.");

            if ((A + B) < C || (A + C) < B || (B + C) < A)
                throw new ArgumentException($"ERROR: Фигура \"{FigureName}\" не является тругольником.");
        }

        /// <summary>
        /// Проверяет является ли треугольник прямоугольным.
        /// </summary>
        /// <returns></returns>
        public bool IsRectangular()
        {
            if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2)
                || Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2)
                || Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2))
                return true;

            return false;
        }
    }
}
