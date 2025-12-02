namespace Adventday2_part2;

public class day2_part2
{
    public static long invalidIdsSum;
    
    public static void day2p2(string[] args)
    {
        // took me wayyyyy too long
        var input = File.ReadAllLines("/home/gorgol/RiderProjects/Advent_of_code_2025/Advent_of_code_2025/input.txt");
        input = input[0].Split(',');

        foreach (var line in input)
        {
            var parts = line.Split('-');
            long min = long.Parse(parts[0]);
            long max = long.Parse(parts[1]);
            
            for (long i = min; i <= max; i++)
            {
                string s = i.ToString();
                int sL = s.Length;
                bool isInvalid = false;

                for (int y = 1; y <= sL / 2; y++)
                {
                    if (sL % y != 0)
                        continue;

                    string pattern = s.Substring(0, y);
                    int repeats = sL / y;
                    bool matches = true;

                    for (int z = 1; z < repeats; z++)
                    {
                        if (s.Substring(z * y, y) != pattern)
                        {
                            matches = false;
                            break;
                        }
                    }

                    if (matches)
                    {
                        isInvalid = true;
                        break;
                    }
                }
                
                if (isInvalid)
                {
                    invalidIdsSum += i;
                }
            }

        }
        Console.WriteLine(invalidIdsSum);
    }
}