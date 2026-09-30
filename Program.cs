namespace OOPAdvanced01
{
    public class Container<T>
    {
        private List<T> items = new List<T>();

        // Add this property to make the count public
        public int Count
        {
            get { return items.Count; }
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            return items[index];
        }
    }
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

            Container<int> numbers = new Container<int>();
            numbers.Add(10);
            numbers.Add(20);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers.Get(i));
            }
            #endregion
        }
    }
}
