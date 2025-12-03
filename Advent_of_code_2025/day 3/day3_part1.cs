namespace Adventday3_part1;

public class Adventday3_part1
{
    public static long joltageSum;
    public static void day3p1(string[] args)
    {
        string[] input = File.ReadAllLines("C:\\Users\\Klasa5P\\RiderProjects\\ConsoleApp1\\ConsoleApp1\\input.txt");
        
        foreach (var line in input)
        {
            int biggestNumber = 0;
            for (int i = 0; i < line.Length-1; i++)
            {
                int firstDigit = 0;
                int lineFirstDigitInt = int.Parse(line.Substring(i, 1));
                if (lineFirstDigitInt > firstDigit)
                {
                    firstDigit = lineFirstDigitInt;
                    int secondDigit = 0;
                    for (int secDigitIndex = i + 1; secDigitIndex < line.Length; secDigitIndex++)
                    {
                        
                        var lineSecDigitInt = int.Parse(line.Substring(secDigitIndex, 1));
                        if (lineSecDigitInt > secondDigit)
                        {
                            secondDigit = lineSecDigitInt;
                        }
                    }
                    int temp = firstDigit * 10 + secondDigit;
                    if (temp > biggestNumber)
                    {
                        biggestNumber = temp;
                    }
                }
            }
            Console.WriteLine($"line: {line} {biggestNumber}");
            joltageSum += biggestNumber;
        }
        Console.WriteLine(joltageSum);
    }
}