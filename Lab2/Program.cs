using ConsoleTables;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Question One:");
        Console.WriteLine("Please Enter a Number");
        int NumberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please Enter a Second Number");
        int NumberTwo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{NumberOne} + {NumberTwo} = {NumberOne + NumberTwo}");
        //Question 2:
        Console.WriteLine("Question 2:");
        Console.WriteLine("Input a Number to Multiply");
        int Multiple = Convert.ToInt32(Console.ReadLine());
        int[] Multi = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        foreach (int i in Multi)
        {
            Console.WriteLine($"{Multiple} x {i} = {Multiple * i}");
        }

        //Question 3 : min and max bit table

        Console.WriteLine("Question 3:");
        var table = new ConsoleTable("Type", "Bytes(s) of Memory", "Min", "Max");
        table.AddRow("sbyte", 1,$"{ sbyte.MinValue}",$"{ sbyte.MaxValue}")
        .AddRow("byte", 1, $"{byte.MinValue}",$"{byte.MaxValue}")
        .AddRow("short", 2, $"{short.MinValue}",$"{short.MaxValue}")
        .AddRow("ushort", 2, $"{ushort.MinValue}",$"{ushort.MaxValue}")
        .AddRow("int", 4, $"{int.MinValue}",$"{int.MaxValue}")
        .AddRow("uint", 4, $"{uint.MinValue}",$"{uint.MaxValue}")
        .AddRow("long", 8, $"{long.MinValue}",$"{long.MaxValue}")
        .AddRow("ulong", 8, $"{ulong.MinValue}",$"{ulong.MaxValue}")
        .AddRow("float", 4, $"{float.MinValue}","${float.MaxValue}")
        .AddRow("double", 8, $"{double.MinValue}",$"{double.MaxValue}")
        .AddRow("decimal", 16, $"{decimal.MinValue}",$"{decimal.MaxValue}");
         table.Write();
         Console.WriteLine();



        //"sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal"

        //Question 4:calculator
        Console.WriteLine("Question 4:");
        Console.WriteLine("Please Press Enter");
        string ans = Console.ReadLine();
        do
        {
            Console.WriteLine("Select Function: Add, Subtract,Multiply,Divide,Mod");
            if (ans == "Add")
            {
                Console.WriteLine("Please Enter a Number");
                int AddNum1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter a Second Number");
                int AddNum2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{AddNum1} + {AddNum2} = {AddNum1 + AddNum2}");
                Console.WriteLine("Please Press Enter");
            }
            else if (ans == "Subtract")
            {
                Console.WriteLine("Please Enter a Number");
                double SubNum1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter a Second Number");
                double SubNum2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{SubNum1} - {SubNum2} = {SubNum1 - SubNum2}");
                Console.WriteLine("Please Press Enter");
            }
            else if (ans == "Multiply")
            {
                Console.WriteLine("Please Enter a Number");
                double MulNum1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter a Second Number");
                double MulNum2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{MulNum1} x {MulNum2} = {MulNum1 * MulNum2}");
                Console.WriteLine("Please Press Enter");
            }
            else if (ans == "Divide")
            {
                Console.WriteLine("Please Enter a Number");
                double DivNum1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter a Second Number");
                double DivNum2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{DivNum1} / {DivNum2} = {DivNum1 / DivNum2}");
                Console.WriteLine("Please Press Enter");
            }
            
            else if (ans == "Mod")
            {
                Console.WriteLine("Please Enter a Number");
                int SubNum1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter a Second Number");
                int SubNum2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{SubNum1} % {SubNum2} = {SubNum1 % SubNum2}");
                Console.WriteLine("Please Press Enter");
            }
        } 
        while (Console.ReadLine() != ans);
    }
}
