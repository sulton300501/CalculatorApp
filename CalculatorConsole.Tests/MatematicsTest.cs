namespace CalculatorConsole.Tests
{
    public class MatematicsTest
    {
        [Fact]
        public void Matematics_add_Method_Two_Number_ts_Equal()
        {


            double a = 3;
            double b = 2;
            double expectedResult = 5;

            var result = Matematics.Add(a, b);

            Assert.Equal(expectedResult, result);


        }



        [Theory]
        [InlineData(3,true)]
        [InlineData(4, true)]
        [InlineData(-2, false)]
        [InlineData(0, true)]
        [InlineData(-1, false)]

        public void IsValid_Numbers_More_than_Zero(int x , bool expectedResult)
        {
            var result =Matematics.IsValidate(x);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test_Divide_Method_For_Exeption()
        {
            double x = 3;
            double y = 0;

           // double expectedResult = 1.5;

          //  var result = Matematics.Divide(x, y);

            Action result = ()=> Matematics.Divide(x, y);

          //   Assert.Throws<DivideByZeroException>(() => result);
            var message = Assert.Throws <DivideByZeroException>(result);

            Assert.Equal(message.Message, "0 ga teng edimi");

        }


        [Fact]
        public void Equal_To_Perimeter()
        {
            int a = 10;
            int b = 7;
            int c = 9;

            int expectedResult = 26;

            var result = Matematics.CheckPerimeter(a,b,c);

            Assert.Equal(expectedResult, result);

        }




        [Theory]
        [InlineData(3,3, 6)]
        [InlineData(4,4, 7)]
        [InlineData(-2,5, 3)]
        [InlineData(0,4, 4)]
        

        public void Multiple_Numbers_Multi(int x ,int y, int expectedResult)
        {
            var result = Matematics.Multiple(x,y);
            Assert.Equal(expectedResult, result);
        }



        [Fact]
        public void Substract_To_Subs()
        {
            int a = 10;
            int b = 7;
            

            int expectedResult = 3;

            var result = Matematics.Substract(a, b);

            Assert.Equal(expectedResult, result);

        }


    }
}