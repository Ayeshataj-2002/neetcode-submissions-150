public class Solution 
{
    public bool IsValidSudoku(char[][] board) 
    {
        HashSet<string> set = new HashSet<string>();

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char num = board[i][j];

                // Skip empty cells
                if (num == '.')
                    continue;

                // Create unique keys
                string row = num + " in row " + i;
                string col = num + " in col " + j;
                string box = num + " in box " + (i / 3) + "-" + (j / 3);

                // If already exists => invalid
                if (set.Contains(row) || set.Contains(col) || set.Contains(box))
                    return false;

                // Add to set
                set.Add(row);
                set.Add(col);
                set.Add(box);
            }
        }

        return true;
    }
}