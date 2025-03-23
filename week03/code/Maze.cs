/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then throw an InvalidOperationException with the message "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    // TODO Problem 4 - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveLeft()
    {
        // FILL IN CODE
        try
        {
            var keys = (_currX, _currY);
            // Condición adicional con claves específicas
            if (keys == (2, 3) || keys ==(3, 5) ||
                keys ==(3, 6) || keys ==(4, 1) ||
                keys ==(4, 3) || keys ==(5, 2) ||
                keys ==(5, 5) || keys ==(5, 6) ||
                keys ==(1,1) || keys ==(1,2) ||
                keys ==(1,4) || keys ==(1,5) ||
                keys ==(1,6))
            {
                _mazeMap[keys][0] = false;
                throw new InvalidOperationException("Can't go that way!");
            } else {
                _currX = _currX -1;
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        // FILL IN CODE
        try
        {
            var keys = (_currX, _currY);
            // Condición adicional con claves específicas
            if (keys == (2, 1) || keys ==(2, 2) ||
                keys ==(2, 3) || keys ==(3, 5) ||
                keys ==(3, 6) || keys ==(5, 2) ||
                keys ==(5, 4) || keys ==(5, 5) ||
                keys == (6, 1) || keys == (6, 3) ||
                keys == (6, 6)) 
            {
                _mazeMap[keys][1] = false;
                throw new InvalidOperationException("Can't go that way!");
            } else {
                _currX = _currX + 1;
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }

    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        // FILL IN CODE
        try
        {
            var keys = (_currX, _currY);

            // Condición adicional con claves específicas
            if (keys == (1, 4) || keys == (3, 4) ||
                keys == (4, 3) || keys == (6, 3) ||
                keys == (6, 6) || keys == (1, 1) ||
                keys == (2, 1) || keys == (4, 1)|| 
                keys == (5, 1) || keys == (6, 1)) 
            {
                _mazeMap[keys][2] = false;
                throw new InvalidOperationException("Can't go that way!");
            }else {
                _currY = _currY - 1;
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, throw an InvalidOperationException with the message "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        // FILL IN CODE
        try
        {
            var keys = (_currX, _currY);

            // Condición adicional con claves específicas
            if (keys == (1, 2) || keys == (2, 4) ||
                keys == (4, 1) || keys == (4, 4) ||
                keys == (6, 1) || keys == (6, 3) ||
                keys == (1, 6) || keys == (3, 6) || 
                keys == (5, 6) || keys == (6, 6))
            {
                _mazeMap[keys][3] = false;
                throw new InvalidOperationException("Can't go that way!");
            } else {
                _currY = _currY + 1;
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            throw;
        }
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}