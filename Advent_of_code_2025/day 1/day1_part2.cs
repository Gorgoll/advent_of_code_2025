public class Adventday1_part2;

public class day1_part2
{

    public static int current=50;
    public static int count=0;
    public static void day1_p2(string[] args)
    {
        var input = File.ReadAllLines("/home/gorgol/RiderProjects/Adventday1/Adventday1/text.txt");
        foreach (var line in input)
        {

            var changedline = int.Parse(line.Remove(0,1));
            if (line[0].ToString() == "R")
            {
                for (int i = 0; i < changedline; i++)
                {
                    current += 1;
                    Check();
                }
            }
            else
            {
                for (int i = 0; i < changedline; i++)
                {
                    current -= 1;
                    Check();
                }
            }
            
            
        }
        Console.WriteLine(count);

    }

    public static void Check()
    {
        current = (current % 100 + 100) % 100;
        if (current == 0)
        {
            count++;
        }
    }
}