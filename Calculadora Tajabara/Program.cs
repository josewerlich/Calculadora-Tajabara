﻿using System.ComponentModel.Design;

namespace Calculadora.ConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
         
            string[] historicoOperacoes = new string[100];
            int contadorHistorico = 0;

            while (true)
            {

                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Calculadora Tajabara 2025");
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Tabuada");
                Console.WriteLine("6 - Histórico");
                Console.WriteLine("S - Sair");
                Console.WriteLine("-------------------------------------");

                string opcao = Console.ReadLine();

                if (opcao == "S")
                {
                    break;
                }

                else if (opcao == "5")
                {

                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Calculadora Tajabara 2025");
                    Console.WriteLine("-------------------------------------");

                    Console.WriteLine("Digite o número desejado:");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    for (int contador = 1; contador <= 10; contador++)
                    {
                        string linhaDaTabuada = $"{numeroTabuada} x {contador} =  {numeroTabuada * contador}";
                        Console.WriteLine(linhaDaTabuada);
                    }
                    Console.WriteLine("-------------------------------------");
                    Console.ReadLine();
                    continue;
                }

                else if (opcao == "6")
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine("Calculadora Tajabara 2025");
                    Console.WriteLine("-------------------------------------");

                    for (int contador = 0; contador < contadorHistorico; contador++)
                        Console.WriteLine(historicoOperacoes[contador]);

                    Console.ReadLine();
                    continue;
                }
                
                Console.Write("Digite o primeiro número: ");
                string strPrimeiroNumero = Console.ReadLine();

                decimal primeiroNumero = Convert.ToDecimal(strPrimeiroNumero);

                Console.Write("Digite o segundo: ");
                string strSegundoNumero = Console.ReadLine();

                decimal segundoNumero = Convert.ToDecimal(strSegundoNumero);

                decimal resultado = 0.0m;


                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
                }
                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
                }
                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundoNumero} = {resultado}";
                }
                else
                {
                    while (segundoNumero == 0)
                    {
                        Console.WriteLine("> Digite o número novamente: ");
                        segundoNumero = Convert.ToDecimal(Console.ReadLine());
                    }

                    resultado = primeiroNumero / segundoNumero;
                    historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundoNumero} = {resultado}";
                }

                contadorHistorico++;

                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Resultado: " + resultado.ToString("F2"));
                Console.WriteLine("-------------------------------------");
                Console.ReadLine();

            }



        }
    }
}

