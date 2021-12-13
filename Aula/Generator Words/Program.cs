using System;

namespace Generator_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
string[] Palavra1 = {" É "};
string[] Palavra2 = { "Otario", "Fresco", "Trouxa", "Garena" };

// aqui gera os bagulho aleatorio.
int mIndex = rnd.Next(0, Palavra1.Length);
int fIndex = rnd.Next(0, Palavra2.Length);

//Resultado na tela fi.
Console.Write("Lukas\0 {0} {1}", Palavra1[mIndex], Palavra2[fIndex]);
//Console.Write("{0}\0", Palavra1[mIndex]);
//Console.Write("{0}\0", Palavra2[fIndex]);

Console.ReadLine();


        }
    }
}
