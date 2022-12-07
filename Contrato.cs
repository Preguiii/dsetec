using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp30
{
    class Contrato
    {
        private int Numero { get; set; }
        private string Contratante { get; set; }
        private double Valor { get; set; }
        private int Prazo { get; set; }

        public Contrato()
        {

        }

        public Contrato(int numero, string contratante, double valor, int prazo)
        {
            Numero = numero;
            Contratante = contratante;
            Valor = valor;
            Prazo = prazo;
        }

        public virtual double calcularPrestacao()
        {
            return Valor / Prazo;
        }
    }
}