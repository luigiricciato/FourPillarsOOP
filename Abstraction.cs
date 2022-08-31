using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPillarsOOP.Abstraction
{
    internal class CoffeeMachine
    {
        private double _coffeeBeansQuantity;
        private double _waterQuantity;

        private readonly Func<CoffeeSelection, Coffee> _coffeeFactory = (s) =>
        {
            switch (s)
            {
                case CoffeeSelection.Espresso:
                    return new Espresso();
                case CoffeeSelection.FilterCoffee:
                    return new FilterCoffee();
                case CoffeeSelection.Americano:
                    return new Americano();
                default:
                    throw new ArgumentOutOfRangeException($"This machine cannot brew this selection of coffee ('{s.ToString()}')");
            }
        };

        private void useCoffeeBeans(Coffee coffee)
        {
            if (_coffeeBeansQuantity < coffee.CoffeeBeansQuantity)
            {
                throw new InvalidOperationException("Not enough coffee beans");
            }
            _coffeeBeansQuantity -= coffee.CoffeeBeansQuantity;
        }
        private void useWater(Coffee coffee)
        {
            if (_waterQuantity < coffee.WaterQuantity)
            {
                throw new InvalidOperationException("Not enough water");
            }
            _waterQuantity -= coffee.WaterQuantity;
        }

        public Coffee BrewCoffee(CoffeeSelection coffeeSelection)
        {
            Coffee coffee = _coffeeFactory(coffeeSelection);

            useCoffeeBeans(coffee);
            useWater(coffee);

            // ... making coffee

            return coffee;
        }
        public void RefillCoffee(double quantity)
        {
            _coffeeBeansQuantity += quantity;
        }
        public void RefillWater(double quantity)
        {
            _waterQuantity += quantity;
        }
    }

    internal abstract class Coffee 
    {
        public abstract double WaterQuantity { get; }
        public abstract double CoffeeBeansQuantity { get; }
    }
    internal class Espresso : Coffee
    {
        public Espresso()
        {
            WaterQuantity = 15.0;
            CoffeeBeansQuantity = 7.0;
        }

        public override double WaterQuantity { get; }
        public override double CoffeeBeansQuantity { get; }
    }
    internal class Americano : Coffee
    {
        public Americano()
        {
            WaterQuantity = 100.0;
            CoffeeBeansQuantity = 20.0;
        }

        public override double WaterQuantity { get; }
        public override double CoffeeBeansQuantity { get; }
    }
    internal class FilterCoffee : Coffee
    {
        public FilterCoffee()
        {
            WaterQuantity = 50.0;
            CoffeeBeansQuantity = 10.0;
        }

        public override double WaterQuantity { get; }
        public override double CoffeeBeansQuantity { get; }
    }

    internal enum CoffeeSelection
    {
        Espresso,
        FilterCoffee,
        Americano
    }
}
