using System;

namespace exercicio_19_02
{
    class Program
    {
        static void Main(string[] args)
        {
              // 1- Desenvolver uma aplicação de calculadora com as operações básicas: soma, subtração, multiplicação, divisão e resto da divisão.

                   Console.WriteLine("Digite o primeiro numero");
                   var num1 = double.Parse(Console.ReadLine());
                   Console.WriteLine("Digite o segundo numero");

                   var  num2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Soma");
                   var resultado = (num1 + num2 );
                   Console.WriteLine("resultado " + resultado);
                    Console.WriteLine("+++++++++++++++++++++++++++++++" );

                    Console.WriteLine("Subtração");
                   resultado = (num1 - num2 );
                   Console.WriteLine("resultado " + resultado );
                    Console.WriteLine("+++++++++++++++++++++++++++++++++ ");

                    Console.WriteLine("multiplicação");
                   resultado = (num1 * num2 );
                   Console.WriteLine("resultado " + resultado);
                    Console.WriteLine("++++++++++++++++++++++++++++++++" );

                    Console.WriteLine("Divisão");
                   resultado = (num1  / num2 );
                   Console.WriteLine("resultado " + resultado  );
                    Console.WriteLine("++++++++++++++++++++++++++++++++");

                    Console.WriteLine("Resto");
                   resultado = (num1  % num2 );
                   Console.WriteLine("resultado " + resultado  );
                    Console.WriteLine("+++++++++++++++++++++++++++++++++");



            // // 2- Desenvolver uma aplicação que leia uma string e informe a quantidade de vogais contidas nela.
            // Console.WriteLine("Digite o seu nome completo: ");
            // var nome = (Console.ReadLine());

            // int posicao = 0;
            // for (int i = 0; i < nome.Length; i++)
            // {
            //     string vogais = nome[i].ToString();

            //     if (vogais.Contains("a"))
            //     {
            //         posicao++;
            //     }

            //     if (vogais.Contains("e"))
            //     {
            //         posicao++;
            //     }

            //     if (vogais.Contains("i"))
            //     {
            //         posicao++;
            //     }

            //     if (vogais.Contains("o"))
            //     {
            //         posicao++;
            //     }

            //     if (vogais.Contains("u"))
            //     {
            //         posicao++;
            //     }
            // }

            // Console.WriteLine("A quantidade de vogais  que tem no seu nome é  " + posicao);

            //3- Desenvolver uma aplicação que leia uma string e imprima apenas as vogais.
            // string vogal;
            // Console.WriteLine("Digite o seu nome completo: ");
            // vogal = Console.ReadLine();

            // for (int i = 0; i < vogal .Length; i++)
            // {
            //     if (vogal[i] == 'a' ||
            //         vogal[i] == 'e' ||
            //         vogal[i] == 'i' ||
            //         vogal[i] == 'o' ||
            //         vogal[i] == 'u')
            //     {

            //         Console.WriteLine( "Vogal: " + vogal[i]);
            //     }
            // 


            //             4- Desenvolver uma aplicação que leia uma string e imprima apenas as consoantes.

            // string consoantes;
            // Console.WriteLine("Digite o seu nome completo: ");
            // consoantes = Console.ReadLine();

            // for (int i = 0; i <  consoantes.Length; i++)
            // {
            //     if (consoantes[i] != 'a' &&
            //         consoantes[i] != 'e' &&
            //         consoantes[i] != 'i' &&
            //         consoantes[i] != 'o' &&
            //         consoantes[i] != 'u')
            //     {

            //         Console.WriteLine("Vogal: " + consoantes[i]);
            //     }
            // }



            // 5- Desenvolver uma aplicação que leia a idade de uma pessoa e informe em qual faixa etária ela esta:
            // 	a)0-19 anos Jovem
            // 	b)20-59 anos Adulto
            // 	c) maior que 60 anos Idoso

            // Console.WriteLine("Informe a sua idade: ");
            // double idade = Double.Parse(Console.ReadLine());

            // if (idade == 0 || idade <= 19)
            // {
            //     Console.WriteLine( idade + " anos, " + "você  é Jovem!");
            // }
            // else if (idade == 20 || idade <= 59)
            // {
            //     Console.WriteLine( idade + " anos, " + "você é Adulto!");
            // }
            // else if (idade >= 60)
            // {
            //     Console.WriteLine(idade + " anos, " + "você é Idoso!");
            // }




            // 6- Utilizando struct, desenvolver efetuar o cadastro de um livro, com seu Titulo, Autor e Valor, e os imprima na tela.
            // Livro livro;
            // Console.WriteLine("Informe um titulo");
            // livro.Titulo = Console.ReadLine();

            // Console.WriteLine("Informe um Autor");
            // livro.Autor = Console.ReadLine();

            // Console.WriteLine("Digite um Valor ");
            // livro.Valor = double.Parse(Console.ReadLine());
            // Console.WriteLine("O livro esta  cadastrado com o " + "Titulo " + livro.Titulo + " ,com o Autor " + livro.Autor + " e com o Valor de " + livro.Valor + ",00 reais");



            // 7- Utilizando struct, efetuar o cadastro de um aluno, contendo nome, R.A., uma nota e frequência, 1 função para
            // média e outra para ver se passou ou não pelas faltas, a julgar que o limite de faltas é 40% de 25 aulas e a media é 7.
            // Aluno aluno;
            // Console.WriteLine("Informe o nome do aluno");
            // aluno.Nome = Console.ReadLine();

            // Console.WriteLine("Informe o RA do aluno");
            // aluno.RA = int.Parse(Console.ReadLine());

            // Console.WriteLine("Informe a nota do aluno ");
            // aluno.Nota = double.Parse(Console.ReadLine());


            // Console.WriteLine("Qual a frequencia do aluno?");
            // aluno.Frequencia = double.Parse(Console.ReadLine());


            // Console.WriteLine("O aluno foi cadastrado");
            // Console.WriteLine("Aluno: " + aluno.Nome);
            // Console.WriteLine("RA: " + aluno.RA);
            // Console.WriteLine("Nota: " + aluno.Nota);
            // Console.WriteLine("Média: " + aluno.Nota + "," + Media(aluno.Nota));
            // Console.WriteLine("Frequência: " + Frequencia(aluno.Frequencia));



            // string Media(double nota) => nota < 7 ? "Reprovado" : "Aprovado";
            // string Frequencia(double frequencia)

            // {


            //     double resultado = ((frequencia / 25) * 100);
            //     return resultado < 40 ? resultado + "% Reprovado por falta , a frequencia dele foi menor de 40% de 25 aulas " : resultado + "% Aprovado, a frequencia do aluno foi maior que 10% de 25 aulas";

            // }

        }
    }
    // 6- Utilizando struct, desenvolver efetuar o cadastro de um livro, com seu Titulo, Autor e Valor, e os imprima na tela.
    // struct Livro
    // {
    //     public String Titulo;
    //     public String Autor;
    //     public Double Valor;
    // }

    // 7- Utilizando struct, efetuar o cadastro de um aluno, contendo nome, R.A., uma nota e frequência, 1 função para
    // média e outra para ver se passou ou não pelas faltas, a julgar que o limite de faltas é 40% de 25 aulas e a media é 7.
    // struct Aluno
    // {
    //     public string Nome;
    //     public int RA;
    //     public double Nota;
    //     public double Frequencia;

    // }

}
