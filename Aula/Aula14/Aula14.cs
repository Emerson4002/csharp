using Internal;
using System;

class Aula14
{

    static void Main()
    {
       // int n1,n2,n3,n4,n5;
       // int[] n = new int[5];
       // n[0] = 23;
       // n[1] = 32;
       // n[2] = 43;
       // n[3] = 54;
       // n[4] = 65;
        // segunda maneira de fazer um array
        //string[] num = new string[3]{23,34,65};
        //veiculo[0] = "Avião";
        //veiculo[1] = "Carro";
        //veiculo[2] = "Onibus";
        //terceira forma
        //int[] num2 ={23,34,45};

        //forma bidimensionais

        int[,] n = new int[2,2];
        
        n[0,0] = 10;
        n[0,1] = 20;

        n[0,0] = 40;
        n[1,1] = 30;

        //ou ja pode colocar o valor

       int[,] num = new int[2,2]{{10,20},{40,30}};

        Console.WriteLine();

        

    }




}