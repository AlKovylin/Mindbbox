using CalculatingSquare;

namespace Mindbbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure circle_1 = new Circle("Круг_1", 5);
            PrintResultCalculation(circle_1);
            PrintResultIsRectangular(circle_1);//пытаемся проверить круг на прямоугольность

            //отлавливаем исключение - "отрицательный радиус"
            try
            {
                Figure circle_2 = new Circle("Круг_2", -5);
                PrintResultCalculation(circle_2);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(string.Concat("\n", ex.Message));
            }

            //прямоугольный треугольник
            Figure triangle_1 = new Triangle("Треугольник_1", 3, 4, 5);
            PrintResultCalculation(triangle_1);
            PrintResultIsRectangular(triangle_1);

            //не прямоугольный треугольник
            Figure triangle_2 = new Triangle("Треугольник_2", 7, 5, 9);
            PrintResultCalculation(triangle_2);
            PrintResultIsRectangular(triangle_2);

            //отлавливаем исключение - "не треугольник"            
            try
            {
                Figure triangle_3 = new Triangle("Треугольник_3", 1, 5, 9);
                PrintResultCalculation(triangle_3);
                PrintResultIsRectangular(triangle_3);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(string.Concat("\n", ex.Message));
            }

            //отлавливаем исключение - "отрицательное значение"            
            try
            {
                Figure triangle_4 = new Triangle("Треугольник_4", 7, -5, 9);
                PrintResultCalculation(triangle_4);
                PrintResultIsRectangular(triangle_4);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(string.Concat("\n", ex.Message));
            }
        }

        /// <summary>
        /// Выводит в консоль результат вычисления площади фигуры.
        /// </summary>
        /// <param name="figure"></param>
        private static void PrintResultCalculation(Figure figure)
        {
            Console.WriteLine($"\nПлощадь фигуры \"{figure.FigureName}\" составляет {figure.CalcSquare()} мм2");
        }

        /// <summary>
        /// Выводит в консоль результат проверки является ли фигура прямоугольным треугольником.
        /// Дополнительно проверяет является ли фигура объектом класса Triangle.
        /// </summary>
        /// <param name="figure"></param>
        private static void PrintResultIsRectangular(Figure figure)
        {
            Triangle? triangle;

            if (figure is Triangle)
            {
                triangle = figure as Triangle;

                if (!triangle!.IsRectangular())
                    Console.WriteLine("Этот треугольник не является прямоугольным.");
                else
                    Console.WriteLine("Этот треугольник является прямоугольным.");
            }
            else
            {
                Console.WriteLine("Эта фигура не является треугольником.");
            }
        }
    }
}