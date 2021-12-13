using System;

class Aula12
{
    static void Main()
    {
        //if = SE(E_L){}
        // > < => <= == !=
        //else = SE Não / Caso contrário
        //else if  = Mas se / condição
        
        string resultado; //
        int n1,n2,n3,n4,res;
        res=n1=n2=n3=n4=0;
    
        string nome;
        int idade;
    
        //Informações do Aluno
        Console.Write("Digite o nome do Aluno: ");
        nome=Console.ReadLine();
        Console.Write("Digite a Idade: ");
        idade =int.Parse(Console.ReadLine());
        
        //Notas
        Console.Write("Digite nota 1: ");
        n1=int.Parse(Console.ReadLine());

        Console.Write("Digite nota 2: ");
        n2=int.Parse(Console.ReadLine());

        Console.Write("Digite nota 3: ");
        n3=int.Parse(Console.ReadLine());

        Console.Write("Digite nota 4: ");
        n4=int.Parse(Console.ReadLine());

            res = n1+n2+n3+n4;

        if(res >= 60){
            if(res >= 90)
            {
                if(res >=99)
                {
                    resultado = "ta de hack  ne fdp";
                }else{resultado = "Aprovado com louvor lek brabo d+";}

                
            }else{resultado = "Aprovado nice";}
            

        }else{
            
            if(res >= 40)
            {
                resultado = "Recuperação ainda tem chance";
            }else{resultado = "Reprovado SE FUDEU KKKKK";}
        
        }
        
        Console.WriteLine("Nome: {0}\nIdade:{3} \nResultado: {1} Nota: {2}",nome,resultado,res,idade);




    }




}