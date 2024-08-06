do
{
    double num1 = 0;
    double num2 = 0;
    double res = 0;

    Console.WriteLine("-----------");
    Console.WriteLine("CALCULADORA");
    Console.WriteLine("-----------");

    Console.Write("Digite o primeiro número:");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite um operador: ");
    Console.WriteLine("\t+ : Adicionar");
    Console.WriteLine("\t- : Subtrair");
    Console.WriteLine("\t* : Multiplicar");
    Console.WriteLine("\t/ : Dividir");
    Console.Write("Selecione uma opção: ");

    switch (Console.ReadLine())
    {
        case "+":
            res = num1 + num2;
            Console.WriteLine($"Resultado: {num1} + {num2} = {res}");
            break;
        case "-":
            res = num1 - num2;
            Console.WriteLine($"Resultado: {num1} - {num2} = {res}");
            break;
        case "*":
            res = num1 * num2;
            Console.WriteLine($"Resultado: {num1} * {num2} = {res}");
            break;
        case "/":
            res = num1 / num2;
            Console.WriteLine($"Resultado: {num1} / {num2} = {res}");
            break;
        default:
            Console.WriteLine("Isso não é um operador válido.");
            break;
    }
    Console.Write("Gostaria de usar novamente? (Y/N): ");

} while (Console.ReadLine().ToUpper() == "Y");

Console.WriteLine("Obrigado por usar meu programa!");

Console.ReadKey();