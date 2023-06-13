Console.WriteLine("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine());

Console.Write("Введите математическую операцию: ");
string symbol = Console.ReadLine();

switch (symbol)
{
    case "+":
        Console.WriteLine(number_1 + number_2);
        break;
	case "-":
		Console.WriteLine(number_1 - number_2);
        break;
	case "*":
		Console.WriteLine(number_1 * number_2);
        break;
	case "/":
		Console.WriteLine(number_1 / number_2);
        break;
}
