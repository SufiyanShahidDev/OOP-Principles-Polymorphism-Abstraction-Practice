namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car = new Car();
           car.start();

           Bike bike = new Bike();
           bike.start();
        }
    }
}
