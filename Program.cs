using System;
using System.Collections;

public class Calculator<T> where T : struct
{
    public T Add(T a, T b) => (dynamic)a + b;
    public T Subtract(T a, T b) => (dynamic)a - b;
    public T Multiply(T a, T b) => (dynamic)a * b;
    public T Divide(T a, T b) => (dynamic)a / b;
}
public class SwapUtil
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
public class Product
{
    public string Name { get; set; }
    public double Cost { get; set; }
    public int Quantity { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Cost: {Cost}, Quantity: {Quantity}";
    }
}

public class Program
{
    public static void Main()
    {
    
        main2();
        main3();

        
    }
    public static void main2(){
        ArrayList products = new ArrayList
        {
            new Product { Name = "Product1", Cost = 10.0, Quantity = 1 },
            new Product { Name = "Product2", Cost = 20.0, Quantity = 2 },
            new Product { Name = "Product3", Cost = 30.0, Quantity = 3 },
            new Product { Name = "Product4", Cost = 40.0, Quantity = 4 },
            new Product { Name = "Product5", Cost = 50.0, Quantity = 5 }
        };

        foreach (Product product in products)
        {
            Console.WriteLine(product);
        }
    }
    public static void main3(){
        Console.WriteLine("Enter value to search: ");
        String find = Console.ReadLine();
        Hashtable daysOfWeek = new Hashtable
        {
            { 1, "Sunday" },
            { 2, "Monday" },
            { 3, "Tuesday" },
            { 4, "Wednesday" },
            { 5, "Thursday" },
            { 6, "Friday" },
            { 7, "Saturday" }
        };

        if (daysOfWeek.ContainsValue(find))
        {
            Console.WriteLine("Tuesday is found.");
        }
        else
        {
            Console.WriteLine("Tuesday is not found.");
        }
        Console.WriteLine("List: ");
        foreach (DictionaryEntry entry in daysOfWeek)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}