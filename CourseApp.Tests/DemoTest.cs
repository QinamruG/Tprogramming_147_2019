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

        [Fact]
        public void TestNormalA()
        {
            var exp = Program.TaskA(2.25, 1.2, 2.7, 0.3);
            var act = new double[] { 2.7853106952595, 3.65876594762302, 6.79994634014975, 16.350605890362, 47.7890653567819, 164.346493221504 };

            for (int i = 0; i < 5; i++)
            {
            Assert.Equal(exp[i], act[i], 3);
            }
        }

        [Fact]
        public void TestNormalB()
        {
            var x = new double[] { 1.31, 1.39, 1.44, 1.56, 1.92 };
            var act = Program.TaskB(2, x);
            var exp = new double[] { 2.78776158956314, 2.93858884457848, 3.07383618485121, 3.54477114149419, 7.00788077097357 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(exp[i], act[i], 3);
            }
        }

        [Fact]
        public void TestZeroLengthB()
        {
            var res = Program.TaskB(0, new double[0]);
            Assert.Empty(res);
        }
    }
}
