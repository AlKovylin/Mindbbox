namespace CalculatingSquare
{
    public abstract class Figure
    {
        public string FigureName { get; private set; }

        public Figure(string figureName)
        {
            FigureName = figureName;
        }

        /// <summary>
        /// Функция вычисления площади поверхности фигуры.
        /// </summary>
        public abstract double CalcSquare();
    }
}