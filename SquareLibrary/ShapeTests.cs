using System;
using NUnit.Framework;
using SquareLibrary.Models;

namespace SquareLibrary
{
	[TestFixture]
	public class ShapeTests
	{
		[Test]
		public void CheckAreaOfRectangle()
		{
			// Declare an init data
			var a = 5;
			var b = 7;
			var expectedArea = 35;
			
			// Action
			var actualArea = new ShapeFactoryBuilder().Sides(a, b).GetArea();
			
			// Assert
			Assert.AreEqual(expectedArea, actualArea);
		}
		
		[Test]
		public void CheckAreaOfCircle()
		{
            // Declare an init data
            var radius = 5;
			var expectedArea = 5 * 5 * Math.PI;

            // Action
			var actualArea = new ShapeFactoryBuilder().Radius(radius).GetArea();

            // Assert
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
		
		[Test]
		public void CheckAreaOfNoneExistentTriangle()
		{
			var a = 5;
			var b = 5;
			var c = 11;

            var expectedMessage = "The triangle doesn't exist.";

			var actualMessage = string.Empty;
			
			try
			{
				var actualArea = new ShapeFactoryBuilder().Sides(a, b, c).GetArea();
			}
			catch(Exception e)
			{
                actualMessage = e.Message;
			}

            Assert.AreEqual(expectedMessage, actualMessage);
		}
		
		[Test]
		public void CheckIfTriangleIsRight()
		{
			var a = 3;
			var b = 4;
			var c = 5;
			
			var expected = true;
			var actual = false;
			
			var shape = new ShapeFactoryBuilder().Sides(a, b, c).Build();
			
			if (shape is Triangle)
			{
				actual = ((Triangle)shape).IsRight();
			}
			
			Assert.AreEqual(expected, actual);
		}
		
		/// <summary>
		/// Incorrect usage of the library - the shape can't have the sides and radius at the same time
		/// </summary>
		[Test]
		public void IncorrectLibraryUsageTest()
		{
			// Declare an init data
			var a = 3;
			var b = 4;
			var c = 5;
			var radius = 5;
			
			var expectedException = new NotSupportedException();
			
			// Action
			Exception actualException = null;
			
			try
			{
				var shape = new ShapeFactoryBuilder().Sides(a, b, c).Radius(radius).Build();
			}
			catch(Exception e)
			{
				actualException = e;
			}
			
			// Assert
			Assert.AreEqual(expectedException.GetType(), actualException.GetType());
		}
		
	}
}
