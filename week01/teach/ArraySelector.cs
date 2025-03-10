public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var newArray = new List<int>();
        var counter1 = 0;
        var counter2 = 0;
        foreach (var i in select)
        {
            if (i == 1) {
                newArray.Add(list1[counter1]);
                counter1 += 1;
            };
            if (i == 2) {
                newArray.Add(list2[counter2]);
                counter2 += 1;
            }
        }
        return newArray.ToArray();
    }
}