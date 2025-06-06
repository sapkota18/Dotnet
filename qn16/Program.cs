using System;

namespace PolymorphismDemo
{
    // Static Polymorphism (Method Overloading)
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    // Runtime Polymorphism (Method Overriding)
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows");
        }
    }

    class Program
    {
        static void Main()
        {
            // Static Polymorphism Example
            Calculator calc = new Calculator();
            Console.WriteLine("Addition (int): " + calc.Add(5, 3));
            Console.WriteLine("Addition (double): " + calc.Add(2.5, 4.7));

            // Runtime Polymorphism Example
            Animal myAnimal;

            myAnimal = new Dog();  // Dog version of Speak()
            myAnimal.Speak();

            myAnimal = new Cat();  // Cat version of Speak()
            myAnimal.Speak();
        }
    }
}
