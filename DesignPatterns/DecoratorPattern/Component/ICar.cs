using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DecoratorPattern.Component
{
    public interface ICar
    {
        string Make { get; }
        double Price();
    }
}
