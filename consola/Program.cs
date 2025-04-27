
Console.WriteLine("\nSuma de dos valores");

Console.WriteLine("\nDigite el valor de a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite el valor de b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("\nResultado: ");
Console.WriteLine(new Calculator().Sum(a,b));

Console.WriteLine("\nAplicacion finalizada");
