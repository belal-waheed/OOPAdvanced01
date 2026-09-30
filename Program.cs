namespace OOPAdvanced01
{

    internal class Program
    {
       
        static void Main(string[] args)
        {

            #region Q1
            //Q: What is a generic class?
            /*
            A generic class is a class that can work with any data type.

            //Why use generics?
            - type safety "notice while working not at runtime"
            - code reuseablilty "in the impelementation you define the type safely"
            - performance "no boxing/unboxing"
            - clean code "no duplicate code"
            */
            #endregion

            #region Q2
            //Q2: Write a generic class Container<T> with Add and Get methods.

            //Container<int> numbers = new Container<int>();
            //numbers.Add(10);
            //numbers.Add(20);

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers.Get(i));
            //}
            #endregion

            #region Q3
            //Q3: What are multiple type parameters? Write Pair<TKey, TValue>.
            /*
            Multiple type parameters allow a generic class to work with more than one data type at the same time.
            */
            //Pair<int, string> student = new Pair<int, string>();
            //student.Key = 1;
            //student.Value = "Ahmed";
            //Console.WriteLine(student.Key + " - " + student.Value);
            #endregion

            #region Q4
            //Q4: What is a generic method? Write Swap<T> method.
            /*
            A generic method is a method that has its own type parameter, allowing it to work with any data type.
            */
            //int x = 10;
            //int y = 20;
            //Console.WriteLine("x is now: " + x);
            //Console.WriteLine("y is now: " + y);
            //// Now we call it cleanly from Utility!
            //Utility.Swap(ref x, ref y);

            //Console.WriteLine("\nAfter Swap:");
            //Console.WriteLine("x is now: " + x);
            //Console.WriteLine("y is now: " + y);
            #endregion

            #region Q5
            //Q5: Write a generic method FindMax<T> that finds maximum value

            //int maxNumber = Utility.FindMax(50, 100);
            //Console.WriteLine("Q5 Result:");
            //Console.WriteLine("The max number is: " + maxNumber);

            //// It works with strings too because strings are IComparable
            //string maxWord = Utility.FindMax("Apple", "Banana");
            //Console.WriteLine("The max word is: " + maxWord);
            #endregion

            #region Q6
            //Q6: What is a generic interface? Write IRepository<T>.
            /*
            A generic interface is a blueprint that uses a placeholder type. 
            Any class that implements it will decide what the exact data type is.
            */
            #endregion

            #region Q7
            //Q7: What is the 'struct' constraint? Write an example.
            /*
            The 'struct' constraint forces the generic type parameter to be a value type.
            */
            //ValueStore<int> numberStore = new ValueStore<int>();
            //numberStore.Data = 99;
            //Console.WriteLine("Q7 Result: ValueStore contains " + numberStore.Data);

            // the line below would cause an error because string is not a struct"not value type"
            // ValueStore<string> badStore = new ValueStore<string>();
            #endregion

            #region Q8
            //Q8: What is the 'class' constraint? Write an example.
            /*
            The 'class' constraint forces the generic type parameter to be a reference type.
            */
            //ReferenceStore<string> textStore = new ReferenceStore<string>();
            //textStore.Data = "Hello Reference!";
            //Console.WriteLine("Q8 Result: ReferenceStore contains " + textStore.Data);

            // the line below would cause an error because int is not a class"not reference type"
            // ReferenceStore<int> badStore2 = new ReferenceStore<int>();
            #endregion

            #region Q9
            //Q9: What is the 'new()' constraint? Write an example.
            /*
            The 'new()' constraint ensures the type has an empty constructor, 
            so you can create new objects of that type inside your generic class.
            */
            //Factory<Document> docFactory = new Factory<Document>();
            //Document myDoc = docFactory.CreateInstance();

            //Console.WriteLine("Q9 Result: Factory created a " + myDoc.Title);
            #endregion

            #region Q10
            //Q10: What is the interface constraint? Write an example.
            /*
            The interface constraint forces the generic type to implement a specific interface.
            */
            //Console.WriteLine("\nQ10 Result:");
            //Printer<Document> docPrinter = new Printer<Document>();

            // This works because Document implements IPrintable
            //docPrinter.PrintItem(myDoc);
            #endregion


            #region Q11
            //Q11: What is the base class constraint? Write an example.
            /*
            The base class constraint forces the generic type to inherit from a specific class.
            */
            //Console.WriteLine("Q11 Result:");
            //Dog myDog = new Dog();
            //AnimalShelter<Dog> shelter = new AnimalShelter<Dog>();
            //shelter.Adopt(myDog);
            #endregion

            #region Q12
            //Q12: How do you apply multiple constraints? Write an example.
            /*
            You combine them with commas: where T : BaseClass, IInterface, new()
            */
            //Console.WriteLine("\nQ12 Result:");
            //AdvancedShelter<SmartDog> advancedShelter = new AdvancedShelter<SmartDog>();

            // This will create the SmartDog AND call its Print method automatically
            //advancedShelter.CreateAndPrint();
            #endregion


            #region Q13
            //Q13: What does the 'default' keyword do in generics?
            /*
            It returns the default value of a type (0 for value types, null for reference types) 
            because you can't assume 'T' can accept a null value.
            */
            //Console.WriteLine("Q13 Result:");
            //Console.WriteLine("Default int is: " + default(int));
            //Console.WriteLine("Default bool is: " + default(bool));
            #endregion

            #region Q14
            //Q14: Write a SafeList<T> that returns default when the index is invalid.
            //Console.WriteLine("\nQ14 Result:");
            //SafeList<int> safeNumbers = new SafeList<int>();
            //safeNumbers.Add(50); // This is at index 0

            //Console.WriteLine("Valid index (0): " + safeNumbers.Get(0));

            // Index 99 doesn't exist! A normal list would crash.
            // Our SafeList will just safely return the default int (which is 0).
            //Console.WriteLine("Invalid index (99): " + safeNumbers.Get(99));
            #endregion

            #region Q15
            //Q15: What is covariance? Explain the 'out' keyword.
            /*
            Covariance (out) allows you to use a more specific type than requested, as long as it's only being returned.
            Example: A Dog Producer can be stored inside an Animal Producer variable.
            */
            Console.WriteLine("Q15 Result:");
            IProducer<Dog> myDogProducer = new DogProducer();

            IProducer<Animal> myAnimalProducer = myDogProducer;

            Animal newPet = myAnimalProducer.Produce();
            Console.WriteLine("Produced: " + newPet.Name);
            #endregion

            #region Q16
            //Q16: What is contravariance? Explain the 'in' keyword.
            /*
            Contravariance (in) allows you to use a less specific (base) type than requested, as long as it's only an input.
            Example: An Animal Consumer can be stored inside a Dog Consumer variable.
            */
            Console.WriteLine("\nQ16 Result:");
            IConsumer<Animal> generalAnimalConsumer = new AnimalConsumer();

            // MAGIC HERE: Storing IConsumer<Animal> inside IConsumer<Dog>
            IConsumer<Dog> specificDogConsumer = generalAnimalConsumer;

            specificDogConsumer.Consume(new Dog());
            #endregion
        }
    }
}
