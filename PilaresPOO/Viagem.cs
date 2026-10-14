using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    internal class Viagem
    {
        public string Destino;
        public int Dias;
        public decimal ValorDiaria;

        public Viagem (string destino, int dias, decimal valorDiaria)
        {
            Destino = destino;
            Dias = dias;
            ValorDiaria = valorDiaria;
        }
    }
}
