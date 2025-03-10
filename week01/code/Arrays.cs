public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Steps:
        // 1. I need to declare an empty array
        // 2. I should create a for Loop to calculate the multiples
        // 3. Store the multiples in the empty array 


        var multiplesArray = new double[length];

        for (var i = 0; i < length; i++)
        {
            multiplesArray[i] = number * (i + 1);
        }
        return multiplesArray; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // steps:
        // 1. Create a for loop and an index counter that starts at the amount value
        // 2.  select the array I want to enter 
        // 3. Enter the first value in the right position
        // 4.  When the module is equal to 0, reset the index counter to 0
        // var list = new List <int> ();
        var indexCounter = amount;
        var newList = data.ToList();
        for (var i = 0; i < data.Count; i++)
        {

            if (indexCounter >= data.Count)
            {
                indexCounter = 0;
            }

            newList[indexCounter] = data[i];
            indexCounter += 1;
            if (i == data.Count) {
                data = newList;
            }
        }
        data = newList;
        Console.WriteLine(string.Join(", ", newList));

        
    }
}
