using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    class ContratoPf : Contrato
    {
        private int CPF { get; set; }
        private int Idade { get; set; }

        public ContratoPf()
        {

        }

        public ContratoPf(int numero, string contratante, double valor, int prazo, int cpf, int idade) : base (numero, contratante, valor, prazo)
        {
            CPF = cpf;
            Idade = idade;
        }

        public override double calcularPrestacao()
        {
            if (Idade <= 30)
            {
                return base.calcularPrestacao() + 1;
            }
            else if (Idade <= 40)
            {
                return base.calcularPrestacao() + 2;
            }
            else if (Idade <= 50)
            {
                return base.calcularPrestacao() + 3;
            }
            else
            {
                return base.calcularPrestacao() + 4;
            }
        }
    }
}