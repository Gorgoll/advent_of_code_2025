namespace Adventday5_part2;

public class Adventday5_part2
{
    public static long amountOfFreshIngredients = 0;
    public static long[,] mergedRanges;

    public static void day5p2(string[] args)
    {
        List<(long min, long max)> ranges = new();
        foreach (var line in File.ReadAllLines("/home/gorgol/RiderProjects/Advent_of_code_2025/Advent_of_code_2025/input.txt"))
        {
            if (line == "")
            {
                break;
            }

            var parts = line.Split('-');

            long min = long.Parse(parts[0]);
            long max = long.Parse(parts[1]);

            ranges.Add((min, max));
        }
        
        ranges = ranges.OrderBy(x => x.min).ToList();

        mergedRanges = new long[ranges.Count, 2];

        foreach (var range in ranges)
        {
            long min = range.min;
            long max = range.max;

            for (int i = 0; i < mergedRanges.GetLength(0); i++)
            {
                long existingMin = mergedRanges[i, 0];
                long existingMax = mergedRanges[i, 1];
                
                if (existingMin == 0 && existingMax == 0)
                {
                    mergedRanges[i, 0] = min;
                    mergedRanges[i, 1] = max;
                    break;
                }
                
                if (min <= existingMax + 1)
                {
                    mergedRanges[i, 0] = Math.Min(existingMin, min);
                    mergedRanges[i, 1] = Math.Max(existingMax, max);
                    break;
                }
            }
        }
        
        for (int y = 0; y < mergedRanges.GetLength(0); y++)
        {
            long min = mergedRanges[y, 0];
            long max = mergedRanges[y, 1];

            if (min == 0 && max == 0) continue;

            amountOfFreshIngredients += (max - min + 1);
        }

        Console.WriteLine(amountOfFreshIngredients);
    }
}