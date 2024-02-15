using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Program to display the capacity and count of ArrayList when it contains one element
        ArrayList arrayList = new ArrayList();
        arrayList.Add(10);
        Console.WriteLine($"ArrayList capacity: {arrayList.Capacity}, count: {arrayList.Count}");

        // 2. Program to create an ArrayList with different types of elements and display
        ArrayList mixedArrayList = new ArrayList();
        mixedArrayList.Add("Hello");
        mixedArrayList.Add(10);
        mixedArrayList.Add(true);
        Console.WriteLine("\nMixed ArrayList elements:");
        foreach (var item in mixedArrayList)
        {
            Console.WriteLine(item);
        }

        // 3. Display ArrayList elements with their types
        Console.WriteLine("\nArrayList elements with their types:");
        foreach (var item in mixedArrayList)
        {
            Console.WriteLine($"{item} : {item.GetType()}");
        }

        // 4. Sort elements in ArrayList in descending order
        ArrayList mixedArrayList1 = new ArrayList();
        mixedArrayList1.Add("Hello");
        mixedArrayList1.Add("rabins");
        mixedArrayList1.Add("how are You");
        mixedArrayList1.Sort();
        mixedArrayList1.Reverse();
        Console.WriteLine("\nSorted elements in descending order:");
        foreach (var item in mixedArrayList)
        {
            Console.WriteLine(item);
        }

        // 5. Display hash table elements with their key
        Hashtable hashtable = new Hashtable();
        hashtable.Add("Name", "John");
        hashtable.Add("Age", 30);
        hashtable.Add("IsEmployed", true);
        Console.WriteLine("\nHashtable elements with their key:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        // 6. Compare 2 employee objects
        Employee emp1 = new Employee { Id = 1, Name = "John" };
        Employee emp2 = new Employee { Id = 2, Name = "Jane" };
        Console.WriteLine($"\nAre emp1 and emp2 equal? {emp1.Equals(emp2)}");

        // 7. Create a list collection to store 5 numbers and display
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("\nList of numbers:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }

        // 8. Create a list collection to store 5 strings and display
        List<string> strings = new List<string> { "apple", "banana", "cherry", "date", "fig" };
        Console.WriteLine("\nList of strings:");
        foreach (var str in strings)
        {
            Console.WriteLine(str);
        }

        // 9. Display elements using IEnumerator
        Console.WriteLine("\nDisplaying elements using IEnumerator:");
        IEnumerator enumerator = strings.GetEnumerator();
        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }

        // 10. Display Person records using IEnumerator
        List<Person> persons = new List<Person>
        {
            new Person { Id = 1, Name = "Alice", Age = 30 },
            new Person { Id = 2, Name = "Bob", Age = 35 }
        };
        Console.WriteLine("\nDisplaying Person records using IEnumerator:");
        IEnumerator<Person> personEnumerator = persons.GetEnumerator();
        while (personEnumerator.MoveNext())
        {
            Console.WriteLine($"Id: {personEnumerator.Current.Id}, Name: {personEnumerator.Current.Name}, Age: {personEnumerator.Current.Age}");
        }

        // Sample data - list of products
        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 999.99 },
            new Product { Id = 2, Name = "Smartphone", Price = 599.99 },
            new Product { Id = 3, Name = "Tablet", Price = 299.99 },
            new Product { Id = 4, Name = "Headphones", Price = 99.99 },
            new Product { Id = 5, Name = "Mouse", Price = 29.99 }
        };

        // Display UI screen
        Console.WriteLine("=====================================");
        Console.WriteLine("          Product Information         ");
        Console.WriteLine("=====================================");
        Console.WriteLine("ID\tName\t\tPrice");
        Console.WriteLine("-------------------------------------");

        foreach (var product in products)
        {
            Console.WriteLine($"{product.Id}\t{product.Name}\t\t${product.Price:F2}");
        }

        Console.WriteLine("=====================================");

        Console.ReadKey();
    }
}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Employee other = (Employee)obj;
        return Id == other.Id && Name == other.Name;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode() ^ Name.GetHashCode();
    }
}

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}
