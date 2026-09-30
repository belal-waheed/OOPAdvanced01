using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAdvanced01
{
    // Q7: Only accepts Value Types (like int, float, bool)
    public class ValueStore<T> where T : struct
    {
        public T Data { get; set; }
    }
    // Q8: Only accepts Reference Types (like string, or your own classes)
    public class ReferenceStore<T> where T : class
    {
        public T Data { get; set; }
    }

    // Q9 
    public class Factory<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T(); // We can do this safely because of the new() constraint
        }
    }
    // Q10 
    public interface IPrintable
    {
        void Print();
    }
    public class Printer<T> where T : IPrintable
    {
        public void PrintItem(T item)
        {
            item.Print(); // We can call this safely because of the IPrintable constraint
        }
    }
    // Q10: A class that implements IPrintable
    public class Document : IPrintable
    {
        public string Title { get; set; } = "Blank Document";
        
        // Fulfills the IPrintable requirement
        public void Print()
        {
            Console.WriteLine("Printing: " + Title);
        }
    }
    //  Q11  
    public class Animal
    {
        public string Name { get; set; } = "Unknown Animal";
    }

    public class Dog : Animal
    {
        public Dog() { Name = "holaoo the Dog"; }
    }

    // This generic class only accepts Animals (or classes that inherit from Animal)
    public class AnimalShelter<T> where T : Animal
    {
        public void Adopt(T animal)
        {
            // We can safely access .Name because we know it's an Animal
            Console.WriteLine("Adopted: " + animal.Name);
        }
    }

    //  Q12  
    // SmartDog inherits from Animal AND implements IPrintable (from Q10)
    public class SmartDog : Animal, IPrintable
    {
        public SmartDog() { Name = "Smart Dog"; }
        public void Print()
        {
            Console.WriteLine("Printing animal profile: " + Name);
        }
    }

    // Multiple Constraints: Must be an Animal, MUST implement IPrintable, MUST have an empty constructor!
    public class AdvancedShelter<T> where T : Animal, IPrintable, new()
    {
        public T CreateAndPrint()
        {
            T newAnimal = new T(); 
            newAnimal.Print();     
            return newAnimal;
        }
    }
    //  Q18  
    public class Tracker<T>
    {
        // This static variable is UNIQUE for every different data type 'T'
        public static int InstanceCount = 0;
        public Tracker()
        {
            InstanceCount++;
        }
    }
}
