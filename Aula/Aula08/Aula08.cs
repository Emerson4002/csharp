using System;

class Aula08{


    static void Main()
    {
        int n1, n2, soma;
        
        Console.Write("Digite o primeiro valor: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        n2 = int.Parse(Console.ReadLine());
        soma = n1 + n2;

        Console.WriteLine("A soma de {0} mais {1} é igual {2}",n1,n2,soma);
        
        string nome, nome2, nome3;
        int dia,mes,ano;
        //Nome
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Digite segundo nome: ");
        nome2 = Console.ReadLine();
        Console.Write("Digite terceiro nome: ");
        nome3 = Console.ReadLine();
        //data de nascimento
        Console.Write("Digite o dia de nascimento: ");
        dia = int.Parse(Console.ReadLine());
        Console.Write("Digite o mês de nascimento: ");
        mes = int.Parse(Console.ReadLine());
        Console.Write("Digite o ano de seu nascimento: ");
        ano = int.Parse(Console.ReadLine());
        

        Console.WriteLine("Seu nome {0} {1} {2} e vc nasceu no dia {3} do mes {4} no {5}  ", nome, nome2, nome3, dia, mes, ano);



        








    }








}