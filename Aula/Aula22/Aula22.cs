using System;

class Aula22
{
    static void Main()
    {
        soma(10,20,30,42,042,4,23,24,2,452,45,26,5465,7,87,8,9,0);
    }

        static void soma(params int[]n)
        {
            int res = 0;
            if(n.Length<1){
                Console.WriteLine("Não existe valores a serem somados");

            }else if(n.Length < 2){
                Console.WriteLine("Valores insuficientes para soma: {0}",n[0]);

            }else
            {
                for(int i=0;i<n.Length;i++)
                {
                    res+=n[i];
                }
                Console.WriteLine("A soma dos dois valores é: {0}",res);
            }


        }




    


}