using System;




class Calculos
{
    public int v1;
    public int v2;
    public Calculos(int v1 , int v2)
    {
        //this referencia para o objeto 
        this.v1 = v1;
        this.v2 = v2;
    }

    public int Somar()
    {
        return v1+v2;
    }

}
class Aula23{

static void Main()
{
    Calculos c = new Calculos(10,12);
    Console.WriteLine(c.Somar());




}



}