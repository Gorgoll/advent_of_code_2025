namespace Adventday5_part1;

public class Adventday5_part1
{
    public static int amountOfFreshIngredients = 0;
    public static void day5p1(string[] args)
    {
        List<string> inputRanges = new ();
        List<string> inputNumbers = new ();
        bool emptySpacePresent=false;
        foreach (var line in File.ReadAllLines("C:\\Users\\admin\\RiderProjects\\ConsoleApp1\\ConsoleApp1\\input.txt"))
        {
            if (line == "")
            {
                emptySpacePresent = true;
                continue;
            }
            if (!emptySpacePresent)
            {
                inputRanges.Add(line);
            }
            else
            {
                inputNumbers.Add(line);
            }
        }
        
        foreach (string numbers in inputNumbers)
        {
            long number= long.Parse(numbers);
            foreach (string ranges in inputRanges)
            {
                long[] range = ranges.Split('-').Select(x => long.Parse(x)).ToArray();
                if (number > range[0] && number < range[1])
                {
                    amountOfFreshIngredients++;
                    break;
                }
            }
        }
        Console.WriteLine(amountOfFreshIngredients);
    }
}