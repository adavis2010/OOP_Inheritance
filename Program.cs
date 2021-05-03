using System;

namespace OOP_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create object
            Car myCar = new Car();

            // Calling honk method 
            myCar.honk();

            // Display the value of the car brand field and car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);





        }
    }
}
