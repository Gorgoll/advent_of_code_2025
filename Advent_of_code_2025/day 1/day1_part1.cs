namespace Adventday1_part1;

public class day1_part1
{
    public static int current=50;
    public static int count=0;
    public static void day1_p1(string[] args)
    {
        var input = File.ReadAllLines("/home/gorgol/RiderProjects/Adventday1/Adventday1/text.txt");
        int count=0;
        int current=50;
        foreach (var line in input)
        {
            var changedline = int.Parse(line.Remove(0,1));
            if (line[0].ToString() == "R")
            {
                current += changedline;
            }
            else
            {
                current-=changedline;
            }
            
            current = (current % 100 + 100) % 100;
            if (current == 0)
            {
                count++;
            }
            
        }
        Console.WriteLine(count);

    }
}