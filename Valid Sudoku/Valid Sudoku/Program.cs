namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] board =
            [
                ["1", "2", ".", ".", "3", ".", ".", ".", ""],
                ["4", ".", ".", "5", ".", ".", ".", ".", "."],
                [".", "9", "8", ".", ".", ".", ".", ".", "3"],
                ["5", ".", ".", ".", "6", ".", ".", ".", "4"],
                [".", ".", ".", "8", ".", "3", ".", ".", "5"],
                ["7", ".", ".", ".", "2", ".", ".", ".", "6"],
                [".", ".", ".", ".", ".", ".", "2", ".", "."],
                [".", ".", ".", "4", "1", "9", ".", ".", "8"],
                [".", ".", ".", ".", "8", ".", ".", "7", "9"]
            ];
            bool result = true;
            for (int i = 0; i < board.Length; i++)
            {
                bool res = true;
                for (int j = 0; j < board[i].Length; j++)
                {
                    for (int k = 0; k < board[i].Length; k++)
                    {
                        bool tryRes1 = int.TryParse(board[i][j].ToString(), out int result1);
                        bool tryRes2 = int.TryParse(board[i][k].ToString(), out int result2);
                        if (tryRes1 && tryRes2)
                        {
                            if (result1 == result2 && j != k)
                            {
                                res = false;
                                break;
                            }
                        }
                    }
                }
                if (!res)
                {
                    result = false;
                    break;
                }
                bool res2 = true;
                for (int j = 0; j < board[i].Length; j++)
                {
                    for (int k = 0; k < board[i].Length; k++)
                    {
                        bool tryRes1 = int.TryParse(board[j][i].ToString(), out int result1);
                        bool tryRes2 = int.TryParse(board[k][i].ToString(), out int result2);
                        if (tryRes1 && tryRes2)
                        {
                            if (result1 == result2 && j != k)
                            {
                                res2 = false;
                                break;
                            }
                        }
                    }
                }
                if (!res2)
                {
                    result = false;
                    break;
                }
            }
            if (result)
            {
                int startCol = 0, startRow = 0;
                while (startRow <= board.Length - 1)
                {
                    for (int i = startRow; i < startRow + 3; i++)
                    {
                        for (int j = startCol; j < startCol + 3; j++)
                        {
                            for (int k = startRow; k < startRow + 3; k++)
                            {
                                for (int l = startCol; l < startCol + 3; l++)
                                {
                                    bool tryRes1 = int.TryParse(board[i][j].ToString(), out int result1);
                                    bool tryRes2 = int.TryParse(board[k][l].ToString(), out int result2);
                                    if (tryRes1 && tryRes2)
                                    {
                                        if (result1 == result2 && i != k && j != l)
                                        {
                                            result = false;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    startRow += 3;
                }
                startCol = 3;
                startRow = 0;
                while (startCol <= board.Length - 1)
                {
                    for (int i = startRow; i < startRow + 3; i++)
                    {
                        for (int j = startCol; j < startCol + 3; j++)
                        {
                            for (int k = startRow; k < startRow + 3; k++)
                            {
                                for (int l = startCol; l < startCol + 3; l++)
                                {
                                    bool tryRes1 = int.TryParse(board[i][j].ToString(), out int result1);
                                    bool tryRes2 = int.TryParse(board[k][l].ToString(), out int result2);
                                    if (tryRes1 && tryRes2)
                                    {
                                        if (result1 == result2 && i != k && j != l)
                                        {
                                            result = false;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    startCol += 3;
                }
            }
            return result;
        }
    }
}