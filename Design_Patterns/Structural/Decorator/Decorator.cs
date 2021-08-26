using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural.Decorator
{

    public abstract class Car
    {
        public abstract int getPrice();
    }

    public sealed class Indica : Car
    {
        public override int getPrice()
        {
            return 1000000;
        }
    }

    public class CarDecorator
    {
        public CarDecorator(Car car)
        {
            this.car = car;
        }
        public Car car { get; set; }

        public int getPrice()
        {
            return car.getPrice();
        }

        public decimal getDiscountedPrice()
        {
            return (decimal)(0.8 * car.getPrice());
        }
    }
}
