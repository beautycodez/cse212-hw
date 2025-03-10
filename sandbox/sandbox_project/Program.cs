using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("Hello Sandbox World!");

        var numbers = new int[3];

        numbers [0] = 1;
        numbers [1] = 2;
        numbers [2] = 3;

        Console.WriteLine(numbers[0]);

        var numbers1 = new[] {1,2,3};
        Console.WriteLine(numbers1[2]);

        var numbersList = new List<int>();
        numbersList.Add(1);
        numbersList.Add(2);
        numbersList.Add(3);

        Console.WriteLine(numbersList[0]);

        var numbersList1 = new List<int> {1,2,3};
        Console.WriteLine(numbersList1[2]);
        Console.WriteLine(numbersList1.Capacity);

        foreach (var item in numbersList1)
        {
            Console.WriteLine("This is my list Item number " + item);
        }

        for (var index = 0; index < numbers.Length; ++index)
        {
            Console.WriteLine("This is an array item:" + numbers[index]);
        }
        for (var index = 0; index < numbersList.Count; ++index)
        {
            Console.WriteLine("This is a List item:" + numbers[index]);
        }     
        
    }
    
}