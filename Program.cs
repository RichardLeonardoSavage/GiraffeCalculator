namespace GiraffeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //converting a string to an int
            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 6);

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("These two numbers added together = " + (num1 + num2));

            Console.Write("Enter a number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("These 2 numbers multiplied by each other = " + (num3 * num4));

            Console.Write("Enter a number for division ");
            double num5 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a number for division ");
            double num6 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num5 + " divided by " + num6 + " = " + (num5 / num6));

            Console.WriteLine("Finally, let's do a subtraction");
            Console.Write("Enter a number here: ");
            double num7 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter a number here: ");
            double num8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Here is the answer, " + (num7 - num8));




            Console.ReadLine();
        }
    }
}
