using System;
using Xunit;

namespace Perimeter.tests
{
    public class UnitTestPerimeter
    {
        Point point1 = new Point(0, 0, nameof(point1));
        Point point2 = new Point(0, 3, nameof(point2));
        Point point3 = new Point(1, 4, nameof(point3));
        Point point4 = new Point(3, 3, nameof(point4));
        Point point5 = new Point(3, 0, nameof(point5));
        
        [Fact]
        public void TriangleVolumeTest()
        {
            Polygon polygon1 = new Polygon(point1, point2, point5);
            double result = polygon1.Perimeter();
            Assert.Equal(10.242640687119284, result, 5);
        }
        [Fact]
        public void SquareVolumeTest()
        {
            Polygon polygon2 = new Polygon(point1, point2, point4, point5);
            double result = polygon2.Perimeter();
            Assert.Equal(12.0, result, 5);
        }
        [Fact]
        public void PentagonVolumeTest()
        {
            Polygon polygon3 = new Polygon(point1, point2, point3, point4, point5);
            double result = polygon3.Perimeter();
            Assert.Equal(12.650281539872886, result, 5);
        }

    }
}
