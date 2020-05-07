using DesignPatterns.DecoratorPattern.Component;
using DesignPatterns.DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.ConcreteDecorator
{
    public class FinalOffer : CarDecorator
    {
        public FinalOffer(ICar car) : base(car)
        {

        }
        public override double GetDiscount()
        {
            return .8 * Price();
        }
    }
}
