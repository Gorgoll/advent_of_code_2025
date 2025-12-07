using System.Diagnostics;

namespace Adventday7_part2
{
    public class Adventday7_part2
    {
        private static char[][] grid;
        private static int rows, cols;
        private static Dictionary<(int row, int col), long> memo = new();

        public static void day7p2(string[] args)
        {
            var stopwatch = Stopwatch.StartNew();
            var input = File.ReadAllLines(
                "/home/gorgol/RiderProjects/Advent_of_code_2025/Advent_of_code_2025/input.txt");

            rows = input.Length;
            cols = input[0].Length;
            grid = input.Select(line => line.ToCharArray()).ToArray();
            
            long totalTimelines = CountTimelines(0, Array.IndexOf(grid[0], 'S'));

            stopwatch.Stop();
            Console.WriteLine($"total timelines: {totalTimelines}");
            Console.WriteLine($"Execution time: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }

        private static long CountTimelines(int row, int col)
        {

            if (row == rows - 1)
            {
                return 1;
            }

            if (memo.ContainsKey((row, col)))
            {
                return memo[(row, col)];
            }

            long count = 0;
            int nextRow = row+1;
            char below = grid[nextRow][col];
            if (below == '.')
            {
                count = CountTimelines(nextRow, col);
            }
            else if (below == '^')
            {
                count = CountTimelines(nextRow, col - 1) + CountTimelines(nextRow, col + 1);
            }

            memo[(row, col)] = count;
            return count;
        }
    }
}