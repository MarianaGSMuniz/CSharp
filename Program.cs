using System;

class Program 
{
    static void Main(string[] args)
    {   //variavel tipo int
        Console.WriteLine("Criando Variavéis");

        int idade;
        idade = 31;

        Console.WriteLine(idade);

        idade = 2022 - 1991;

        idade = 10 * 3 + 1;

        idade = (10 - 40) * 1;

        
        // variavel tipo double

        double salario;
        salario = 3050.15;

        Console.WriteLine(salario);


        //Conversão e outros tipos numéricos

        double salario2;
        salario2 = 3000.15;

        int salarioInteior;
        salarioInteior = (int)salario2;

        Console.WriteLine(salarioInteior);


        //Utilizamos quando o numero é muito longo.

        long x;
        x = 20000000000000000000000;

        //Utilizamos quando o numero é menor.

        short y;
        y = 15000;

        //Utilizamo quando utlizamos numero com, mas precisa ser mais preciso nos 
        //números depois da vírgula.
        float altura;
        altura = 1.62f;


        Console.WriteLine("Tecle Enter para fechar");

    }



}






