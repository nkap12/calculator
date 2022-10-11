namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

        
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Hello, welcome to this very basic calculator app");
Console.WriteLine("--------------------------------------------------");

do {

    double result = 0;
    double num1;
    double num2;


    Console.WriteLine("1st number: ");
    var firstNumber = Console.ReadLine();
   

    //firstValue = Convert.ToDouble(firstNumber);

    while(!double.TryParse(firstNumber, out num1))

    {
        Console.WriteLine("Not a valid number try entering 1st number again: ");
        firstNumber = Console.ReadLine();
    }


    Console.WriteLine("Enter one math operator + - * /");
    string mathOp = Console.ReadLine();
    

    Console.WriteLine("2nd number: ");
    var secondNumber = Console.ReadLine();
    
    

    while (!double.TryParse(secondNumber, out num2))

    {
        Console.WriteLine("Not a valid number try entering 2nd number again: ");
        secondNumber = Console.ReadLine();
    }

//statement to execute correct math operator based on input

    switch (mathOp)
    {
        case "+":
            result = Calculation.Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = " + result);
            break;
        case "-":
            result = Calculation.Subtract(num1, num2);
            Console.WriteLine($"{num1} - {num2} = " + result);
            break;
        case "*":
            result = Calculation.Multiply(num1, num2);
            Console.WriteLine($"{num1} * {num2} = " + result);
            break;
        case "/":
            result = Calculation.Divide(num1,num2);
            Console.WriteLine($"{num1} / {num2} = " + result);
            break;
        default:
            Console.WriteLine("Not a valid maths option");
            break;
    }

    Console.WriteLine("more maths? y/n");

} while (Console.ReadLine() == "y");


Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Thanks for using the calculator app. Bye!");
Console.WriteLine("--------------------------------------------------");

Console.Read();

        }
    }
}
