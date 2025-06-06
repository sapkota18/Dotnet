using System;

namespace InheritanceTypes
{
    // Base class
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal eats");
        }
    }

    // Single Inheritance: Dog inherits from Animal
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog barks");
        }
    }

    // Multilevel Inheritance: Puppy inherits from Dog (which inherits from Animal)
    class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Puppy weeps");
        }
    }

    // Hierarchical Inheritance: Cat also inherits from Animal
    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Cat meows");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Single Inheritance:");
            Dog dog = new Dog();
            dog.Eat();   // From Animal
            dog.Bark();  // From Dog

            Console.WriteLine("\nMultilevel Inheritance:");
            Puppy puppy = new Puppy();
            puppy.Eat();   // From Animal
            puppy.Bark();  // From Dog
            puppy.Weep();  // From Puppy

            Console.WriteLine("\nHierarchical Inheritance:");
            Cat cat = new Cat();
            cat.Eat();    // From Animal
            cat.Meow();   // From Cat
        }
    }
}
