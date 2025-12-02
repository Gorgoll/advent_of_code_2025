namespace Adventday2_part1;

public class Adventday2_part1
{
    public static long invalidIdsSum;
    public static void day2_p1(string[] args)
    {
        var input = File.ReadAllLines("/home/gorgol/RiderProjects/Advent_of_code_2025/Advent_of_code_2025/input.txt");
        input = input[0].Split(',');
        
        foreach (var line in input)
        {
            var parts = line.Split('-');
            long min = long.Parse(parts[0]);
            long max = long.Parse(parts[1]);

            for (long i = min; i <= max; i++)
            {
                if (i.ToString().Length % 2 != 0)
                {
                    continue;
                }
                
                string s=i.ToString();
                
                string firstHalf = s.Substring(0, i.ToString().Length / 2);
                string secondHalf = s.Substring(i.ToString().Length / 2);
                
                if (firstHalf == secondHalf)
                {
                    invalidIdsSum += i;
                }
            }
            
        }
        Console.WriteLine(invalidIdsSum);
    }
}