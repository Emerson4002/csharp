using System;

class Aula18{

    static void Main()
    {   

        int[] num=new int[5]{23,34,56,58,11};

        /*
        for(int i=0;i<num.Length;i++)
        {
            Console.WriteLine(num[i]);

        }
        */
        
        foreach(int n in num)
        {
            Console.WriteLine(n);
        }






    }



}