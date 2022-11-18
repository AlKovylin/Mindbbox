namespace CalculatingSquare.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CalcSquare_Accepts_7_Return_153_94()
        {
            //arrange
            Circle circle = new Circle("Circle", 7);
            double expected = 153.94;

            //act
            double result = circle.CalcSquare();

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalcSquare_Must_Return_ArgumentException()
        {
            //arrange
            Circle circle = new Circle("Circle", -1);

            //assert
            Assert.Throws<ArgumentException>(() => circle.CalcSquare());
        }
    }
}