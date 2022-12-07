using System;
using System.Globalization;
using System.Collections.Generic;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contrato> list = new List<Contrato>();

            Console.WriteLine("Digite a quantia de contratos desejados: ");
            int resp = int.Parse(Console.ReadLine());

            for (int i = 1; i <= resp; i++)
            {
                Console.WriteLine($"Dados do {i}° contrato: ");
                
                Console.WriteLine("O contrato será de Pessoa Física ou Jurídica? (F / J) ");
                char rsp = char.Parse(Console.ReadLine());

                Console.WriteLine("Número do contrato: ");
                int numero = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome do contratante: ");
                string contratante = Console.ReadLine();

                Console.WriteLine("Valor do contrato: ");
                double valor = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

                Console.WriteLine("Prazo do contrato: ");
                int prazo = int.Parse(Console.ReadLine());

                if (rsp == 'f')
                {
                    Console.WriteLine("CPF da pessoa física: ");
                    int cpf = int.Parse(Console.ReadLine());

                    Console.WriteLine("Idade da pessoa física: ");
                    int idade = int.Parse(Console.ReadLine());

                    list.Add(new ContratoPf(numero, contratante, valor, prazo, cpf, idade));
                }
                else
                {
                    Console.WriteLine("CNPJ da pessoa jurídica: ");
                    int cnpj = int.Parse(Console.ReadLine());

                    Console.WriteLine("Inscrição Estadual: ");
                    int inscricaoe = int.Parse(Console.ReadLine());

                    list.Add(new ContratoPj(numero, contratante, valor, prazo, cnpj, inscricaoe));
                }

                Console.WriteLine();

            }
        }
    }
}