using DesignPatterns.DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.ConcreteComponent
{
    public sealed class EconomyCar : ICar
    {
        public string Make => "Mazda";

        public double Price()
        {
            return 20000;
        }
    }
}
