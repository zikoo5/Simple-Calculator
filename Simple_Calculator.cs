namespace Kys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to Ziko's Calculator !, choose an operation by typing its number : \n 1.Addition(+) \n 2.Subtraction(-)  \n 3.Multiplication(x) \n 4.Division(/)");
            int operation;
            int.TryParse(Console.ReadLine(), out operation);
            int FirstNumber;
            Console.WriteLine("Please type the first number of the opperation: ");
            int.TryParse(Console.ReadLine(), out FirstNumber);
            int SecondNumber;
            Console.WriteLine("Please type the second number of the opperation :  ");
            int.TryParse(Console.ReadLine(), out SecondNumber);

            //operations
            int addition = FirstNumber + SecondNumber;
            int subtraction = FirstNumber - SecondNumber;
            int multiplication = FirstNumber * SecondNumber;
            int division = FirstNumber / SecondNumber;


            //printing operations
            if (operation == 1)
                Console.WriteLine(FirstNumber + " + " + SecondNumber + " = " + addition);
            if (operation == 2)
                Console.WriteLine(FirstNumber + " - " + SecondNumber +  " = " + subtraction);
            if (operation == 3)
                Console.WriteLine(FirstNumber + " x " + SecondNumber + " = " + multiplication);
            if (operation == 4)
                Console.WriteLine(FirstNumber +  " / " + SecondNumber + " = " + division);
            else
                Console.WriteLine("The number you wrote doesn't represent any process.");






            Console.ReadKey();
        }
