using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SquareLibrary.Models;

namespace SquareLibrary
{
    /// <summary>
    /// Задание:
    ///  Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:
    ///  Юнит-тесты
    ///   Легкость добавления других фигур
    ///    Вычисление площади фигуры без знания типа фигуры
    ///     Проверку на то, является ли треугольник прямоугольным
    /// </summary>
    public class ShapeFactoryBuilder
    {
        private double[] sides;
        private double radius;
        
        public ShapeFactoryBuilder Sides(params double[] sides)
        {
            this.sides = sides;

            return this;
        }

        public ShapeFactoryBuilder Radius(double radius)
        {
            this.radius = radius;

            return this;
        }
        
        public IShape Create()
        {
            IShape shape = null;
            
            if (!radius.Equals(0))
            {
                shape = new Circle();
            }

            if (!sides.Equals(null))
            {
                if (sides.Length.Equals(2))
                {
                    shape = new Rectangle();
                }

                if (sides.Length.Equals(2))
                {
                    shape = new Triangle();
                }
            }

            throw new NotSupportedException();
        }
    }
}
