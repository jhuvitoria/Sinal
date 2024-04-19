﻿int numero;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
 Console.Write("Digite um número: ");
 Console.ResetColor();

numero = Convert.ToInt32(Console.ReadLine());

if (numero < 0)
{
 Console.WriteLine("Negativo");
}
else if (numero > 0)
{
 Console.WriteLine("Positivo");
}
else
{
 Console.WriteLine("Numero zero");
}