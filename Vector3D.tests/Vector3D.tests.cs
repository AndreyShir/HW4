using System;
using Xunit;

namespace Vector3D.tests
{
    public class UnitTestVector3D
    {
        Vector3D vector1 = new Vector3D(1, 2, 3);
        Vector3D vector2 = new Vector3D(3, 3, 3);

        [Fact]
        public void Test1()
        {
            double result = vector1.ScalarMultiplication(vector2);
            Assert.Equal(18, result, 2);
        }
        [Fact]
        public void Test2()
        {
            double result = vector1.Length();
            Assert.Equal(3.74, result, 2);
        }

    }
}
