using static _42.Level30_GenericTypes_Exercises.Program.List2<T>;

namespace _42.Level30_GenericTypes_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating array method to adding items
            int[] numbers = new int[] { 1, 2, 3 };

            Console.WriteLine("Initial array:");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }

            numbers = AddToArray(numbers, 4);

            Console.WriteLine("Array after adding number");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }


            //Method letting arrays add numbers
            int[] AddToArray(int[] inputArray, int numberToAdd)
            {
                int[] output = new int[inputArray.Length + 1];

                for (int i = 0; i < inputArray.Length; i++)
                {
                    output[i] = inputArray[i];
                }

                output[^1] = numberToAdd;

                return output;
            }

            //********************************************************************************************************************************************************
            // This approach works, but it is not the most efficient way to add an item to an array. A better approach would be to use generics type that will allow us to use any type of a List<T> instead of an array,
            // as it allows for dynamic resizing and provides built-in methods for adding items.
            //
            // Here's an example of how to create a List<T> and add an item to it:

            List2<string> listOfNames = new();
            listOfNames.Add("Kamil");

            //listOfNames.Add(1); // Error as this is not string!

            //Multiple Generic Type Parameters
            Pair<string, double> pi = new Pair<string, double>("PI", 3.14); // something like tuples but our own


            //----- Generic Method call 
            List2<string> words = Repeat<string>("Alright", 3);
            List2<int> zeroes = Repeat<int>(0, 100);
        }


        //----------------------------------------------------------------------------------------------------
        //************************* Generic Class Definition *****************************************
        //----------------------------------------------------------------------------------------------------

        //-----------------Single Generic Type Parameters
        public class List2<T>
            // 'T' will be replaced with the type of the object that we want to store in the list when we create an instance of the List class.
            // Example : List<int> myList = new List<int>(); or List<string> myList = new List<string>();
        {
            // The List class creates an array of type T and initializes it to an empty array.
            private T[] _items = new T[0];
            private int _length;

            public int Lenght
            {
                get => _length = _items.Length;
            }

            public T GetItemAt(int index) => _items[index];
            public T SetItemAt(int index, T value) => _items[index] = value;

            public void Add(T value)
            {
                T[] update = new T[_items.Length + 1];
                for (int i = 0; i < _items.Length; i++)
                {
                    update[i] = _items[i];
                }

                update[^1] = value;
                _items = update;
            }


            //----------------------------------------------------------------------------------------------------
            //************************* Multiple Generic Type Parameters *****************************************
            //----------------------------------------------------------------------------------------------------

            // You can also have multiple generic type parameters by listing them in the angle brackets,
            // separated by commas.

            public class Pair<TFirst, TSecond>
            {
                public TFirst First { get; }
                public TSecond Second { get; }

                public Pair(TFirst first, TSecond second)
                {
                    First = first;
                    Second = second;
                }
            }

            //------------------- Generic Methods
            public static List2<T> Repeat<T>(T value, int times)
            {
                List2<T> collections = new List2<T>();
                for (int i = 0; i < times; i++)
                {
                    collections.Add(value);
                }

                return collections;
            }

        }
    }
}