using System;


class veiculo
{
    public int veloMax;
    public bool ligado;
    public bool desligado;

    public void ligar()
    {
        ligado = true;
    }
    public void desligar()
    {   
        desligado = false;

    }

    public string getLigado()
    {
        if(ligado)
        {
            return "Sim";
        }else
        {
            return "Não";
        }
    }
}
class carro:veiculo
{
    public string nome;
    public string cor;
    public int rodas;

    public carro(string nome , string cor)
    {
        desligar();
        rodas = 4;
        veloMax = 130;
        this.nome = nome;
        this.cor = cor;   
    }

}
class Aula23
{
    static void Main()
    {
        carro c1= new carro("Rapidão","Vermelho");
        Console.WriteLine("Cor: {0}",c1.cor);
        Console.WriteLine("Nome: {0}",c1.nome);
        Console.WriteLine("Rodas: {0}",c1.rodas);
        Console.WriteLine("Vel.Maxima: {0}",c1.veloMax);
        Console.WriteLine("Ligado: {0}",c1.getLigado());


        
    }


}