using DesignPatterns.DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.Decorator
{
    // This is more like a wrapper over concretecomponent
    public abstract class CarDecorator : ICar
    {
        private ICar Car;
        public CarDecorator(ICar car)
        {
            Car = car;
        }
        public string Make => Car.Make;

        public double Price()
        {
            return Car.Price();
        }
        public abstract double GetDiscount();
    }
}
