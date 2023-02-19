using System;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collection = new Collection<int>();

            Console.WriteLine("Current Collection: " + collection.ToString());

            Console.WriteLine("Collection count: " + collection.Count);
            Console.WriteLine("Collection capacity: " + collection.Capacity);

            collection.Add(4);
            Console.WriteLine("Current Collection: " + collection.ToString());

            collection.AddRange(7, 12, 23, 45, 6);
            Console.WriteLine("Current Collection: " + collection.ToString());

            Console.WriteLine("Collection first 2 elements: " + collection[0] + " " + collection[1]);

            collection[0] = 900;
            Console.WriteLine("Current Collection: " + collection.ToString());

            collection.InsertAt(3, 55);
            Console.WriteLine("Current Collection: " + collection.ToString());

            collection.Exchange(1, 4);
            Console.WriteLine("Current Collection: " + collection.ToString());

            collection.RemoveAt(2);
            Console.WriteLine("Current Collection: " + collection.ToString());

            collection.Clear();
            Console.WriteLine("Current Collection: " + collection.ToString());

        }
    }
}