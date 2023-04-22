using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Create a new Hashtable
        Hashtable myHashtable = new Hashtable();

        // Add some key-value pairs to the Hashtable
        myHashtable.Add("key1", "value1");
        myHashtable.Add("key2", "value2");
        myHashtable.Add("key3", "value3");

        // Retrieve a value from the Hashtable using the indexer with the key
        string value = (string)myHashtable["key1"];
        Console.WriteLine("Value for key1: " + value);

        // Check if a key exists in the Hashtable using the ContainsKey method
        bool keyExists = myHashtable.ContainsKey("key2");
        Console.WriteLine("Does key2 exist? " + keyExists);

        // Check if a value exists in the Hashtable using the ContainsValue method
        bool valueExists = myHashtable.ContainsValue("value4");
        Console.WriteLine("Does value4 exist? " + valueExists);

        // Remove a key-value pair from the Hashtable using the Remove method
        myHashtable.Remove("key3");

        // Clear all key-value pairs from the Hashtable using the Clear method
        myHashtable.Clear();

        // Check if the Hashtable is empty using the Count property
        Console.WriteLine("Is the Hashtable empty? " + (myHashtable.Count == 0));
    }
}

