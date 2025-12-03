namespace Adventday3_part2;

public class Adventday3_part2
{
    public static long joltageSum;
    public static void day3p2(string[] args)
    {
        string[] input = File.ReadAllLines("C:\\Users\\Klasa5P\\RiderProjects\\ConsoleApp1\\ConsoleApp1\\input.txt");
        foreach (var line in input)
        {
            string AmountOfJoltageInLine = "";
            var firstDigit = 0;
            var firstDigitIndex = 0;
            var skipThisIndex = 0;
            for (int i=0;i<line.Length-12;i++)
            {
                var digit = int.Parse(line.Substring(i, 1));
                if (digit > firstDigit)
                {
                    firstDigit = digit;
                    firstDigitIndex = i;
                    skipThisIndex = i;
                    AmountOfJoltageInLine+=firstDigit.ToString();
                }
            }

            for (int i = 0; i < 11; i++)
            {
                var temp = 0;
                for (int y = input.Length-firstDigitIndex+1; y > line.Length; y--)
                {
                    if (y > skipThisIndex) { continue; }
                    var digit = int.Parse(line.Substring(y, 1));
                    
                    if (temp < digit)
                    {
                        temp=digit;
                        skipThisIndex=i;
                    }
                    
                }
                AmountOfJoltageInLine += temp;
            }
            
            Console.WriteLine($"line: {line} {AmountOfJoltageInLine}");
            joltageSum += long.Parse(AmountOfJoltageInLine);
        }
        Console.WriteLine(joltageSum);
    }
}