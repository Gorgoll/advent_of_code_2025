namespace Adventday7_part1
{
    public class Adventday7_part1
    {
        private static int amountOfSplits = 0;

        public static void day7p1(string[] args)
        {
            var input = File.ReadAllLines(
                "/home/gorgol/RiderProjects/Advent_of_code_2025/Advent_of_code_2025/input.txt");

            int rows = input.Length;
            int cols = input[0].Length;

            var grid = input.Select(line => line.ToCharArray()).ToArray();

            var activeS = new List<(int row, int col)>();
            activeS.Add((row: 0, col: input[0].IndexOf("S")));


            for (int i = 0; i < rows; i++)
            {
                var newActiveS = new List<(int row, int col)>();

                foreach (var (row, col) in activeS)
                {
                    var nextRow = row + 1;
                    if (nextRow >= rows)
                    {
                        continue;
                    }

                    char below = grid[nextRow][col];

                    if (below == '.')
                    {
                        grid[nextRow][col] = 'S';
                        newActiveS.Add((nextRow, col));
                    }
                    else if (below == '^')
                    {
                        grid[nextRow][col] = '.';
                        
                        if (col - 1 >= 0 && grid[nextRow][col - 1] == '.')
                        {
                            grid[nextRow][col - 1] = 'S';
                            newActiveS.Add((nextRow, col - 1));
                        }
                        if (col + 1 < cols && grid[nextRow][col + 1] == '.')
                        {
                            grid[nextRow][col + 1] = 'S';
                            newActiveS.Add((nextRow, col + 1));
                        }

                        amountOfSplits++;
                    }
                }

                activeS = newActiveS;

            }
            Console.WriteLine($"Total splits: {amountOfSplits}");
        }
    }
}
