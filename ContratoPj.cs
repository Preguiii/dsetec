using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    class ContratoPj : Contrato
    {
        private int CNPJ { get; set; }
        private int InscricaoE { get; set; }

        public ContratoPj()
        {

        }

        public ContratoPj(int numero, string contratante, double valor, int prazo, int cnpj, int inscricaoe) : base (numero, contratante, valor, prazo)
        {
            CNPJ = cnpj;
            InscricaoE = inscricaoe;
        }

        public override double calcularPrestacao()
        {
            return base.calcularPrestacao() + 3;
        }
    }
}