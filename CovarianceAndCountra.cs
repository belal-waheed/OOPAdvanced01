using System;

namespace OOPAdvanced01
{
    //  Q15 Code (Covariance / out) 
    // 'out T' means T is only used as a return type
    public interface IProducer<out T>
    {
        T Produce();
    }

    public class DogProducer : IProducer<Dog>
    {
        public Dog Produce()
        {
            return new Dog();
        }
    }

    //  Q16  (Contravariance / in) 
    // 'in T' means T is only used as a method parameter
    public interface IConsumer<in T>
    {
        void Consume(T item);
    }

    public class AnimalConsumer : IConsumer<Animal>
    {
        public void Consume(Animal item)
        {
            Console.WriteLine("Consuming: " + item.Name);
        }
    }
}