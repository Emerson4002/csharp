using System;

class Aula21{

    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        dobrar2(ref num);
        Console.Write(num);

    }
    //sem referencina 
    static void dobrar1 (int valor)
    {
        valor*=2;

    }
    //com referencia
    static void dobrar2 (ref int valor)
    {
        valor*=2;

    }
















}