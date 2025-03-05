using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polysimple01  /* Method overriding happens when a subclass provides a 
                          specific implementation of a method that is 
                           already defined in its base class
                        */
{ 
    class Animal
    {
      public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
}
     
class Dog: Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog Barks");
    }
}

    class Program
    {
        static void Main(string[] args)
        {

        Animal myAnimal = new Dog(); // Parent class reference holding a child class object
        myAnimal.MakeSound(); // Calls Dog's MakeSound() method 
        }
    }
}

