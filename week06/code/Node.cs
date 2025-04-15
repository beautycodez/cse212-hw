public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (!this.Contains(value))
        {
            if (value < Data)
            {
                // Insert to the left
                if (Left is null)
                    Left = new Node(value);
                else
                    Left.Insert(value);
            }
            else
            {
                // Insert to the right
                if (Right is null)
                    Right = new Node(value);
                else
                    Right.Insert(value);
            }
        }

    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2

        if (value == Data)

        {
            return true; 
        }
        else if (value < Data && Left != null)
        {
            return Left.Contains(value); 
        }
        else if (value > Data && Right != null)
        {
            return Right.Contains(value); 
        }

        return false;
    }

    public int GetHeight()
{
    // TODO start problem 4
    var leftHeight = 0;
    var rightHeight = 0;

    if (Left is not null) 
    {
        leftHeight = Left.GetHeight(); 
    }

    if (Right is not null) 
    {
        rightHeight = Right.GetHeight();
    }

    return 1 + Math.Max(leftHeight, rightHeight);
}
}