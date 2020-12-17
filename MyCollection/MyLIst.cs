namespace MyCollection
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Class with custom collection.
    /// </summary>
    /// <typeparam name="T">template type.</typeparam>
    public class MyLIst<T> : IEnumerable
        where T : IComparable<T>
    {
        /// <summary>
        /// #nullable.
        /// </summary>
        private T[] array = new T[1];
        private int count = 0;

        /// <summary>
        /// Gets count of item in collection.
        /// </summary>
        public int Count => this.count;

        /// <summary>
        /// Add new item to collection.
        /// </summary>
        /// <param name="item">item witch we wanna add.</param>
        public void Add(T item)
        {
            if (this.count == this.array.Length)
            {
                Array.Resize(ref this.array, this.array.Length + 1);
            }

            this.array[this.count] = item;
            this.count++;
        }

        /// <summary>
        /// This method add a collection to our.
        /// </summary>
        /// <param name="collection">name of collection >witch we wanna add.</param>
        public void AddRange(ICollection<T> collection)
        {
            foreach (var item in collection)
            {
                this.Add(item);
            }
        }

        /// <summary>
        /// Return index of first occurrence of an element or -1  if item wasn't found.
        /// </summary>
        /// <param name="item">item witch we try find.</param>
        /// <returns>index.</returns>
        public int IndexOf(T item)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.array[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// This function add new item in collection at index.
        /// </summary>
        /// <param name="index">index where we paste item.</param>
        /// <param name="item">item wtch we wanna paste.</param>
        public void Insert(int index, T item)
        {
            if (index < 0 || index >= this.array.Length)
            {
                return;
            }

            var arr = new T[this.array.Length + 1];
            Array.Copy(this.array, arr, index - 1);
            arr[index] = item;

            for (int i = index; i < this.array.Length; i++)
            {
                arr[i + 1] = this.array[i];
            }
        }

        /// <summary>
        /// WE try to remove item from collection.
        /// </summary>
        /// <param name="item">item to remove.</param>
        /// <returns>if item removed: true ,else: false.</returns>
        public bool Remove(T item)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.array[i].Equals(item))
                {
                    var arr = new T[this.array.Length - 1];
                    Array.Copy(this.array, arr, i);
                    for (int j = i; i < arr.Length; i++)
                    {
                        arr[i] = this.array[i + 1];
                    }

                    this.array = arr;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Remove all items from index.
        /// </summary>
        /// <param name="index">index where we start delet items.</param>
        public void RemoveAt(int index)
        {
            if (index <= this.count && index > -1)
            {
                var arr = new T[index];
                Array.Copy(this.array, arr, index);
                this.array = arr;
                this.count = arr.Length;
            }
        }

        /// <summary>
        /// Sort our collection.
        /// </summary>
        public void Sort()
        {
            Array.Sort(this.array);
        }

        /// <summary>
        /// for foreach cicle.
        /// </summary>
        /// <returns>enumerator.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.array.GetEnumerator();
        }
    }
}
