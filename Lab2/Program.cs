using ConsoleTables;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Question One:");
        Console.WriteLine("Please Enter a Number");
        int NumberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("PLease Enter a Second Number");
        int NumberTwo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{NumberOne} + {NumberTwo} = {NumberOne + NumberTwo}");

        Console.WriteLine("Question 2:");
        Console.WriteLine("Input a Number to Multiply");
        int Multiple = Convert.ToInt32(Console.ReadLine());
        int[] Multi = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        foreach (int i in Multi)
        {
            Console.WriteLine($"{Multiple} x {i} = {Multiple * i}");
        }

        Console.WriteLine("Question 3:");
        ConsoleTable table = new ConsoleTable("Type", "Bytes(s)", "Min", "Max");
        table.AddRow("sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal");

        Console.WriteLine("Question 4:");
        while (Console.ReadLine() != "esc")
        {
            Console.WriteLine("Please enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Select Function: Add, Subtract,Multiply,Divide,Mod");
            string ans = Console.ReadLine();
            if (ans == "Add")
            {
                Console.WriteLine("Please Enter a Number");
                int AddNum1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("PLease Enter a Second Number");
                int AddNum2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{AddNum1} + {AddNum2} = {AddNum1 + AddNum2}");
            }
            else if (ans == "Subtract")
            {
                Console.WriteLine("Please Enter a Number");
                double SubNum1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("PLease Enter a Second Number");
                double SubNum2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{SubNum1} - {SubNum2} = {SubNum1 - SubNum2}");
            }
            else if (ans == "Multiply")
            {
                Console.WriteLine("Please Enter a Number");
                double MulNum1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("PLease Enter a Second Number");
                double MulNum2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{MulNum1} - {MulNum2} = {MulNum1 * MulNum2}");
            }
            else if (ans == "Divide")
            {
                Console.WriteLine("Please Enter a Number");
                double DivNum1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("PLease Enter a Second Number");
                double DivNum2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{DivNum1} / {DivNum2} = {DivNum1 / DivNum2}");
            }
            else if (ans == "Mod")
            {
                Console.WriteLine("Please Enter a Number");
                int SubNum1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("PLease Enter a Second Number");
                int SubNum2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{SubNum1} % {SubNum2} = {SubNum1 % SubNum2}");
            }

        }
    }
}