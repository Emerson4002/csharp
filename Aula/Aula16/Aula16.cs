using System;

class Aula16{

    static void Main()
    {      
        int[] num = new int[9];   

        int i=num.Length-1;

        while(i>0){
            num[i]=0;
            Console.WriteLine(num[i]);
            i--;
        }
        Console.WriteLine("Fim de Loop");







    }



}