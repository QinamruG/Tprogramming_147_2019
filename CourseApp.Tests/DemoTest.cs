using System;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Theory]
        [InlineData(0, 0, double.NaN)]
        [InlineData(1.11, 1.3, 2)]
        [InlineData(2, 2.1, 11)]

        public void TestCalc(double a, double x, double exp)
        {
            var res = Program.MyFunction(a, x);
            res = Math.Round(res);
            Assert.Equal(exp, res, 3);
        }

        [Fact]
        public void TestNotaNumber()
        {
            var a = Program.MyFunction(1.1, 1.3);
            Assert.False(double.IsNaN(a));
        }

        [Theory]
        [InlineData(1, 2, 3, 4)]
        [InlineData(4, 3, 2, 1)]
        public void TestNormalA(double a, double xn, double xk, double dx)
        {
            var c = Program.TaskA(a, xn, xk, dx);
             Assert.NotNull(c);
        }

        [Theory]
        [InlineData(3, 5)]
        public void TestNormalB(int t, double a)
        {
            double[] x = new double[t];
            var c = Program.TaskB(a, x);
            Assert.NotNull(c);
        }

        [Fact]
        public void TestZeroLengthB()
        {
            var res = Program.TaskB(0, new double[0]);
            Assert.Empty(res);
        }
    }
}
