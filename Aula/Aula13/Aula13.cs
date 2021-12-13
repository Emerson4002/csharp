using System;

class Aula13
{
    static void Main()
    {
        int tempo;
        int idade;
        char escolhas;

        inicio:
        Console.Clear();

        Console.WriteLine("Belo Horizonte/MG para Vitória/SP");
        Console.WriteLine("Digite sua idade:");
        idade =int.Parse(Console.ReadLine());
        Console.WriteLine("Escola o transporte: [a] Avião [b] Carro [c] Onibus ");
        escolhas = char.Parse(Console.ReadLine());

        switch(escolhas)
        {
            case'a':
            case'A':
            tempo = 50;
                break;
            case 'b':
            case 'B':
             tempo = 400;
                break;
            case 'c':
            case 'C':
            tempo = 750;
                break;
            default:
            tempo =-1;
                break;
        }

        

        if(tempo < 0)
        {
            Console.WriteLine("\nTransporte Indisponivel\n ");
        }else
        {
            Console.WriteLine("\nPara o transporte escolhido o tempo é de {0} minutos\n",tempo);  
        }
        if(idade<18)
        {
            Console.WriteLine("como tem {0} anos necessario um acompanhante de maior idade",idade);
        }else{
            Console.WriteLine("Como tem {0} anos está apto a viajar",idade);
            }


            Console.Write("\nCalcular outro transporte: [s/n]? ");
            escolhas = char.Parse(Console.ReadLine());
            if(escolhas == 's' || escolhas == 'S')
            {
                goto inicio;
            }else{
                    Console.Clear();
                    Console.WriteLine("Encerrando o programa");
                 }






    }



}