using System; // Importing the System namespace to use Console class

class Program
{
    // The Main method is the entry point of the program
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my Calculator please Choose a Function");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
            Console.WriteLine("Addition");
            Console.Write("Enter first number: ");
            double numadd1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double numadd2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result: " + (numadd1 + numadd2));
            break;

            case 2:
            Console.WriteLine("Subtraction");
            Console.Write("Enter first number: ");
            double numsub1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double numsub2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result: " + (numsub1 - numsub2));
            break;

            case 3:
            Console.WriteLine("Multiplication");
            Console.Write("Enter first number: ");
            double nummul1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double nummul2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result: " + (nummul1 * nummul2));
            break;

            case 4:
            Console.WriteLine("Division");
            Console.Write("Enter first number: ");
            double numdiv1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double numdiv2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result: " + (numdiv1 / numdiv2));
            break;

            default:
            Console.WriteLine("Error Wrong Choice");
            break;
        }
    }
}