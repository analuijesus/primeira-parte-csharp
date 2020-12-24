using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrmeiraParteCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeiroProjeto();

            CriandoVariaveis();

            VariaveisPontosFlutuantes();

            ConversoesEOutrosTiposNumericos();

            CaracteresETextos();

            AtribuicoesDeVariaveis();

            Condicionais();

            Escopo();

            LacoDeRepeticaoWhile();

            LacoDeRepeticaoFor();

            LacoDeRepeticaoFor();
        }

        public static void PrimeiroProjeto()
        {
            Console.WriteLine("Olá, mundo. Projeto no Visual Studio!");

            Console.WriteLine("A execução acabou. Tecle enter para finalizar. . . ");
            Console.ReadLine();
        }

        public static void CriandoVariaveis()
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;
            idade = 32;

            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua idade é " + idade + "!");

            Console.WriteLine("Execução finalizada. Tecle enter para sair. . . ");
            Console.ReadLine();
        }

        public static void VariaveisPontosFlutuantes()
        {
            Console.WriteLine("Executando projeto 3 Criando variaveis ponto flutuante");

            double salario;
            salario = 1200.70;

            Console.WriteLine(salario);

            double idade;
            idade = 15 / 2.0;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);

            Console.WriteLine("A execução acabou. Tecle enter para sair . . . ");
            Console.ReadLine();
        }

        public static void ConversoesEOutrosTiposNumericos()
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            // O int é um tipo de variável que suporta valores ate 32 bits
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // O long é uma variavel de 64 bits
            long idade = 130000000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variavel de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }

        public static void CaracteresETextos()
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            // character
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia " + 2020;
            string cursosProgramacao =
@" - .NET
 - Java
 - Javascript";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);


            Console.ReadLine();
        }

        public static void AtribuicoesDeVariaveis()
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            Console.ReadLine();
        }

        public static void Condicionais()
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado. Pode entrar");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos, não pode entrar");
                }
            }

            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idadeAna = 18;
            // int quantidadePessoas = 2;
            // bool acompanhado = quantidadePessoas >= 2;
            bool acompanhado = false;

            if (idadeAna >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            Console.ReadLine();
        }

        public static void Escopo()
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado!";
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                mensagemAdicional = "João NÃO está acompanhado";
                Console.WriteLine(mensagemAdicional);
            }


            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            Console.ReadLine();
        }

        public static void LacoDeRepeticaoWhile()
        {
            int contador = 1;
            int total = 0;

            while (contador <= 10)
            {
                total += contador;

                // contador = contador + 1;
                // contador += 1;
                contador++;
            }

            Console.WriteLine(total);

            Console.ReadLine();
        }

        public static void LacoDeRepeticaoFor()
        {
            int total = 0;

            for (int contador = 0; contador <= 10; contador++)
            {
                total += contador;
            }

            Console.WriteLine(total);

            for (int numero = 0; numero <= 10; numero++)
            {
                Console.Write("Tabuada do " + numero + " : ");

                for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
                {
                    Console.Write(numero * multiplicador);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********
            // **********

            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********
            // **********
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    if (coluna > linha)
                        break;

                    Console.Write("*");
                }
                Console.WriteLine();
            }


            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }    
}
