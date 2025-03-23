
public class FindFirstDuplicateLetter
{
    public static void Run()
    {
        string message = "This is the first message";
        var duplicateIndex = FirstDuplicateLetter(message);
        Console.WriteLine($"The first duplicate letter is: <{message[duplicateIndex]}>");

    }
    private static int FirstDuplicateLetter(string message)
    {
        var uniqueLetters = new HashSet<string>();

        foreach (var letter in message)
        {
            if (letter != ' ')
            {
                if (!uniqueLetters.Contains(letter.ToString()))
                {
                    uniqueLetters.Add(letter.ToString());
                }
                else
                {
                    var indexAtDuplicate = message.IndexOf(letter);
                    return indexAtDuplicate;
                }

            }
        }
        ;
        return message[message.Count() - 1];
    }

}