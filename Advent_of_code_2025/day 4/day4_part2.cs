using System.Runtime.InteropServices.JavaScript;

namespace Adventday4_part2;

public class Adventday4_part2
{
    public static int rollsAccessed = 0;
    public static int rollsAccessedLastTime = 0;
    public static char[][] input = File.ReadAllLines("/home/gorgol/RiderProjects/Advent_of_code_2025/Advent_of_code_2025/input.txt")
        .Select(line => line.ToCharArray())
        .ToArray();
    public static void day4p2(string[] args)
    {
        do
        {
            solve();
            if (rollsAccessedLastTime == rollsAccessed)
            {
                break;
            }
            rollsAccessedLastTime = rollsAccessed;
            
        } while (true);
    }

    public static void solve()
    {
        for (int y = 0; y < input.Length; y++)
        {
            var line = input[y];
            for (int i = 0; i < line.Length; i++)
            {
                int amountOfRollsAround = 0;
                if (line[i] == '@')
                {
                    List<char> arrayWithRolls =
                    [
                        getValueAt(y-1,i-1),
                        getValueAt(y-1,i),
                        getValueAt(y-1,i + 1),
                        getValueAt(y,i - 1),
                        getValueAt(y,i + 1),
                        getValueAt(y+1,i - 1),
                        getValueAt(y+1,i),
                        getValueAt(y+1,i + 1),
                    ];
                    foreach (var space in arrayWithRolls)
                    {
                        if (space == '@')
                        {
                            amountOfRollsAround++;
                        }
                    }

                    if (amountOfRollsAround < 4)
                    {
                        line[i] = '.'; 
                        rollsAccessed++;
                    }
                }

            }
        }
        Console.WriteLine(rollsAccessed);
    }
    public static char getValueAt(int col, int row)
    {
        if (col >= 0 && col < input.Length && row >= 0 && row < input[col].Length)
        {
            return input[col][row];
        }
        return '.';
    }
}