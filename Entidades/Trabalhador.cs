using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP.Contract.Entidades.Enums
{
    class Trabalhador
    {
        //tipos da classe
        public string Nome { get; set; }
        public LevelTrabalhador Level { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<ContratoHora> Contrato { get; private set; } = new List<ContratoHora>();
       
        //Construtores
        public Trabalhador()
        {
        }

        public Trabalhador(string nome, LevelTrabalhador level, double salarioBase)
        {
            Nome = nome;
            Level = level;
            SalarioBase = salarioBase;
        }
        //Metodo para adicionar o contrato
        public void AddContrato (ContratoHora contrato)
        {
            Contrato.Add(contrato);
        }
        //Metódo para remover o contratado.
        public void RemoverContrato(ContratoHora contrato)
        {
            Contrato.Remove(contrato);
        }
        //metodo para calcular a base conforme o mes/ano
        public double Renda (int ano, int mes)
        {
            double SomaRenda = SalarioBase;


        }
    }
}
