namespace Adventday6_part1
{
    public class adventday6_part1
    {
        public static void day6p1(string[] args)
        {
            long grandTotal = 0;
            var input = File.ReadAllLines("/home/gorgol/RiderProjects/Advent_of_code_2025/Advent_of_code_2025/input.txt");
            
            string[][] changedInput = new string[input.Length][];
            for (int i = 0; i < input.Length; i++)
            {
                changedInput[i] = input[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            
            for (int col = 0; col < changedInput[0].Length; col++)
            {
                char op = char.Parse(changedInput[4][col]);
                long total = int.Parse(changedInput[3][col]);
                
                for (int row = 3; row >= 0; row--)
                {
                    var temp = "";
                    for (int picker = 0; picker < 3; picker++)
                    {
                        if (changedInput[row][col].Length != 4)
                        {
                            temp = changedInput[row][col].PadLeft(4);
                        }
                    }
                    int number = int.Parse(temp.Trim());
                    switch (op)
                    {
                        case '+':
                            total += number;
                            break;
                        case '*':
                            total *= number;
                            break;
                    }
                }

                Console.WriteLine(total);
                grandTotal += total;
            }
            Console.WriteLine(grandTotal);
        }
    }
}