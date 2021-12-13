using System;

class Aula15
{

    static void Main()
    {  
           //variavel//N de execuções//Encremento/Declemento

        for(int num=0;num<2;num++)  //num++, num=num+1,num+=1;
        {
            Console.WriteLine("XABLAU ");
        }  

        int[] num2 = new int[10]; 

        for (int i=0;num2.Length;i++)
        {
            num2[i] = 0;
            


        }
        for(int i=0;num2.Length;i++)
        {
            Console.WriteLine("valor de num na posi{0}: {1}",i,num2[i]);
        }








    }



}