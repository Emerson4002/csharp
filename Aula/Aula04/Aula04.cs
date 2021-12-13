using System;

class Aula04
{
    static int num1 =30;
    static int num2 = 40;
    static int num3 = 20;

    static int resposta;
    static void Main()
    {
        resposta = num1 + num2 * num3;
        Console.WriteLine("Resultado de " + num1 + " + " + num2 + " * " + num3 + " é igual a " + resposta );
        Console.ReadLine();
    }


}