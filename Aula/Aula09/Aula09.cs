using System;

class Aula09{

    static void Main()
    {

        int num = 10;
        int num2 = 10;

        // para direita diminui pela metade
        num = num>>1;
        //dobra o valor
        num2 = num2<<1;

        Console.WriteLine("Bitwise para direita >> diminui o valor pela metade; 10 = {0} \nBitwise para esquerda << dobra o valor; 10 = {1}",num,num2);
        Console.ReadLine();






    }

    
















}