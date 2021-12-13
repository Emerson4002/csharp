using System;

class Aula20{

    static void Main()
    {   
        int v1, v2;
        Console.Write("Digite o primeiro valor: ");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        soma(v1,v2);    

    }

    static void soma(int n1 , int n2)
    {   int res = n1+n2;
        Console.WriteLine("\nA soma de {0} mais {1} é igual a: {2}",n1,n2,res);




    }



}