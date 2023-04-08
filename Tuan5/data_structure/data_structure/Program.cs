using System;


namespace data_structure
{
    class Program
    {
        public class CustomArrayList<T>
        {
            private T[] arr;
            private int count;
            /// <summary>Returns the actual list length</summary>
            public int Count
            {
                get
                {
                    return this.count;
                }
            }
            private const int INITIAL_CAPACITY = 4;
            /// <summary>
            /// Initializes the array-based list – allocate memory
            /// </summary>
            public CustomArrayList(int capacity = INITIAL_CAPACITY)
            {
                this.arr = new T[capacity];
                this.count = 0;
            }
            public void Add(T item)
            {
                GrowIfArrIsFull();
                this.arr[this.count] = item;
                this.count++;
            }
            /// <summary>
            /// Inserts the specified element at given position in this list
            /// </summary>
            /// <param name="index">
            /// Index, at which the specified element is to be inserted
            /// </param>
            /// <param name="item">Element to be inserted</param>
            /// <exception cref="System.IndexOutOfRangeException">Index is
            /// invalid</exception>
            public void Insert(int index, T item)
            {
                if (index > this.count || index < 0)
                {
                    throw new IndexOutOfRangeException(
                    "Invalid index: " + index);
                }
                GrowIfArrIsFull();
                Array.Copy(this.arr, index,
                this.arr, index + 1, this.count - index);
                this.arr[index] = item;
                this.count++;
            }
            /// <summary>
            /// Doubles the size of this.arr (grow) if it is full
            /// </summary>
            private void GrowIfArrIsFull()
            {
                if (this.count + 1 > this.arr.Length)
                {
                    T[] extendedArr = new T[this.arr.Length * 2];
                    Array.Copy(this.arr, extendedArr, this.count);
                    this.arr = extendedArr;
                }
            }
            /// <summary>Clears the list (remove everything)</summary>
            public void Clear()
            {
                this.arr = new T[INITIAL_CAPACITY];
                this.count = 0;
            }
            public int IndexOf(T item)
            {
                for (int i = 0; i < this.arr.Length; i++)
                {
                    if (object.Equals(item, this.arr[i]))
                    {
                        return i;
                    }
                }
                return -1;
            }
            public T this[int index]
            {
                get
                {
                    if (index >= this.count || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(
                        "Invalid index: " + index);
                    }
                    return this.arr[index];

                }
                set
                {
                    if (index >= this.count || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(
                        "Invalid index: " + index);
                    }
                    this.arr[index] = value;
                }
            }
            public T RemoveAt(int index)
            {
                if (index >= this.count || index < 0)
                {
                    throw new ArgumentOutOfRangeException(
                    "Invalid index: " + index);
                }
                T item = this.arr[index];
                Array.Copy(this.arr, index + 1,
                this.arr, index, this.count - index - 1);
                this.arr[this.count - 1] = default(T);
                this.count--;
                return item;
            }
            class CustomArrayListTest
            {
                static void Main()
                {
                    CustomArrayList<string> shoppingList =
                    new CustomArrayList<string>();
                    shoppingList.Add("Milk");
                    shoppingList.Add("Honey");
                    shoppingList.Add("Olives");
                    shoppingList.Add("Water");
                    shoppingList.Add("Beer");
                    shoppingList.Remove("Olives");
                    shoppingList.Insert(1, "Fruits");
                    shoppingList.Insert(0, "Cheese");
                    shoppingList.Insert(6, "Vegetables");
                    shoppingList.RemoveAt(0);
                    shoppingList[3] = "A lot of " + shoppingList[3];
                    Console.WriteLine("We need to buy:");
                    for (int i = 0; i < shoppingList.Count; i++)
                    {
                        Console.WriteLine(" - " + shoppingList[i]);
                    }
                    Console.WriteLine("Position of 'Beer' = {0}",
                    shoppingList.IndexOf("Beer"));
                    Console.WriteLine("Position of 'Water' = {0}",
                    shoppingList.IndexOf("Water"));
                    Console.WriteLine("Do we have to buy Bread? " + shoppingList.Contains("Bread"));
                }
            }
        }
    }
}