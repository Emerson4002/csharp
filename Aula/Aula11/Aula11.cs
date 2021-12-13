using System;

class Aula11
{

    static void Main()
    {

    //conversão implicita/segura    
            int n1 = 10;
            float n2 =n1;

    //conversão explicita
            float m1 =10.5f;
            int m2 = (int)m1;//typecast

            int vInt = 10;
            short vShort =(short)vInt;










            Console.WriteLine("\nTipo de conversão implicita:\n int n1 = 10; \n float n2 = n1; é igual a {0}",n2);
            Console.WriteLine("\nTipo de conversão explicita:\nfloat m1 = 10.5f\n int m2 = (int)m1; é igual a {0}\noutro exemplo:\nint vInt = 10;\nshort vShort = (short)vInt; igual a {1}",m2,vInt);
            

    }



}