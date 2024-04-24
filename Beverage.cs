using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерн_Декоратор
{
    abstract class Beverage
    {
        protected string description;

        public virtual string GetDescription()
        {
            return description;
        }
        public abstract double Cost();
    }
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }
        public override double Cost()
        {
            return .89;
        }
    }
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }
        public override double Cost()
        {
            return .99;
        }
    }
    class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
    class Decaf : Beverage
    {
        public Decaf()
        {
            description = "House Blend Coffee";
        }
        public override double Cost()
        {
            return 1.05;
        }
    }
}
