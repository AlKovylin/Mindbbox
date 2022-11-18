namespace CalculatingSquare.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CalcSquare_Accepts_7_5_9_Return_17_41()
        {
            //arrange
            Triangle triangle = new Triangle("Triangle", 7, 5, 9);
            double expected = 17.41;

            //act
            double result = triangle.CalcSquare();

            //assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void CalcSquare_Accepts_NegativeValue_Return_ArgumentException()
        {
            //arrange
            Triangle triangle = new Triangle("Triangle", -7, 5, 9);

            //assert
            Assert.Throws<ArgumentException>(() => triangle.CalcSquare());
        }

        [Fact]
        public void CalcSquare_Must_Return_ArgumentException_NotTriangle()
        {
            //arrange
            Triangle triangle = new Triangle("Triangle", 3, 5, 9);

            //assert
            Assert.Throws<ArgumentException>(() => triangle.CalcSquare());
        }

        [Fact]
        public void IsRectangular_Accepts_NotRectangular_Return_False()
        {
            //Arrange
            var triangle = new Triangle("Triangle", 7, 5, 9);

            //Act
            var result = triangle.IsRectangular();

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void IsRectangular_Accepts_Rectangular_Return_True()
        {
            //Arrange
            var triangle = new Triangle("Triangle", 3, 4, 5);

            //Act
            var result = triangle.IsRectangular();

            //Assert
            Assert.True(result);
        }
    }
}
