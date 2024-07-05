using System;

namespace AnimalSoundApp
{
    // Base class
    class Animal
    {
        // Virtual method to be overridden
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    class Dog : Animal
    {
        // Overriding the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    class Cat : Animal
    {
        // Overriding the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Animal, Dog, and Cat
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call the MakeSound method on each instance
            genericAnimal.MakeSound(); // Output: Some generic sound
            dog.MakeSound(); // Output: Bark
            cat.MakeSound(); // Output: Meow

            // Explanation
            Console.WriteLine("\nExplanation:");
            Console.WriteLine("The Animal class has a virtual method MakeSound which is overridden by the Dog and Cat classes.");
            Console.WriteLine("When the MakeSound method is called on an instance of Dog, it prints 'Bark'.");
            Console.WriteLine("When called on an instance of Cat, it prints 'Meow'.");
            Console.WriteLine("This demonstrates the concept of method overriding in inheritance.");
        }
    }
}
