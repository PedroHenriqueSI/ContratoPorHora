using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP.Contract.Entidades
{
    class ContratoHora//classe contratto hora
    {
        //tipos da classe
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        //construtores
        public ContratoHora()
        {
        }
        public ContratoHora(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }
        //metodo que calcula o valor total das horas
        public double ValorTotal()
        {
            return ValorPorHora * Horas;
        }
    }
}

