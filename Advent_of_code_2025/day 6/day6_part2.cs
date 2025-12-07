namespace Adventday6_part2
{
    public class Program
    {
        public static void day6p2(string[] args)
        {
            var input = File.ReadAllLines(
                "/home/gorgol/RiderProjects/Advent_of_code_2025/Advent_of_code_2025/input.txt");
            int rows = input.Length;
            int cols = input[0].Length;

            long grandTotal = 0;
            long blockValue = 0;
            string op = " ";
            for (int col = 0; col < cols; col++)
            {
                string temp = "";
                
                for (int row = 0; row < rows; row++)
                {
                    string cell = input[row][col].ToString();

                    if (row == 4)
                    {
                        if (cell != " ")
                        {
                            op = cell;
                        }
                        continue;
                    }

                    temp += cell;
                }
                
                if (string.IsNullOrWhiteSpace(temp))
                {
                    if (blockValue != 0)
                    {
                        grandTotal += blockValue;
                    }
                    
                    blockValue = 0;
                    op = " ";
                    continue;
                }
                
                long number = long.Parse(temp);
                
                if (blockValue == 0)
                {
                    blockValue = number;
                }
                else
                {
                    switch (op)
                    {
                        case "+":
                            blockValue += number;
                            break;
                        case "*":
                            blockValue *= number;
                            break;
                    }
                }
            }
            grandTotal += blockValue;
            Console.WriteLine($"grand total: {grandTotal}");
        }
    }
}
