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

            int maxNumber = Utility.FindMax(50, 100);
            Console.WriteLine("Q5 Result:");
            Console.WriteLine("The max number is: " + maxNumber);

            // It works with strings too because strings are IComparable
            string maxWord = Utility.FindMax("Apple", "Banana");
            Console.WriteLine("The max word is: " + maxWord);
            #endregion

            #region Q6
            //Q6: What is a generic interface? Write IRepository<T>.
            /*
            A generic interface is a blueprint that uses a placeholder type. 
            Any class that implements it will decide what the exact data type is.
            */
            #endregion

        }
    }
}
