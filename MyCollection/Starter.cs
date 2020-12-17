namespace MyCollection
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class when we will test our collection.
    /// </summary>
    public static class Starter
    {
        /// <summary>
        /// Run method.
        /// </summary>
        public static void Run()
        {
            var list = new MyLIst<int>();
            list.Add(4);
            list.Add(5);
            list.Add(1);
            list.Add(-18);
            list.Add(66);
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            list.Insert(2, 115);
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine(list.IndexOf(-18));
            list.Remove(1);
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            list.Sort();
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            list.RemoveAt(1);
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            var otherList = new List<int>();
            otherList.Add(12);
            otherList.Add(112);
            list.AddRange(otherList);
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
