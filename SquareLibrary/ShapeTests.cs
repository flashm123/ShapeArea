using System;
using NUnit.Framework;

namespace SquareLibrary
{
	[TestFixture]
	public class ShapeTests
	{
		[Test]
		public void CheckAreaOfRectangle()
		{
			var a = 5;
			var b = 7;
			var expectedArea = 35;
			
			var actualArea = new ShapeFactoryBuilder().Sides(a, b).GetArea();
			
			Assert.AreEqual(expectedArea, actualArea);
		}
		
		[Test]
		public void CheckAreaOfCircle()
		{
			var radius = 5;
			var expectedArea = 5 * 5 * Math.PI;
			
			var actualArea = new ShapeFactoryBuilder().Radius(radius).GetArea();
			
			Assert.AreEqual(expectedArea, actualArea);
		}
		
		[Test]
		public void CheckAreaOfTriangle()
		{
			var a = 5;
			var b = 7;
			var c = 9;
			var expectedArea = 17.41;
			
			var actualArea = new ShapeFactoryBuilder().Sides(a, b, c).GetArea();
			
			Assert.AreEqual(expectedArea, Math.Round(actualArea, 2));
		}
		
	}
}
