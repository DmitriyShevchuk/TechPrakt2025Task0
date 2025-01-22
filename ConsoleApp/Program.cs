Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Enter first number: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Enter second number: ");
int b = int.Parse(Console.ReadLine());

Console.Write($"{a} + {b} = {a + b}");