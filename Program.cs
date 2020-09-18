using System;
using System.Globalization;

namespace CSHARP.Contract.Entidades.Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando as váriaveis
            Console.Write("Entre com o nome do departamente: ");
            string dptNome = Console.ReadLine();
            Console.WriteLine("Dados do trabalhador");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            LevelTrabalhador level = Enum.Parse<LevelTrabalhador>(Console.ReadLine());//conversão do tipo enum
            Console.Write("Salario base: ");
            double salarioBase = double.Parse(Console.ReadLine());
            
            //Instanciando a classe 
            Departamento departamento = new Departamento(dptNome);
            Trabalhador trabalhador = new Trabalhador(nome, level, salarioBase, departamento);

            Console.WriteLine();

            Console.Write("Quantos contratos esse trabalhador possui? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Entre com a data do " +i+ " contrato");
                Console.Write("Data (dd/mm/aaaa): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração: ");
                double horas = double.Parse(Console.ReadLine());

                ContratoHora contrato = new ContratoHora(data, valorPorHora, horas);
                trabalhador.AddContrato(contrato);
            }
            Console.Write("Entre com o mês e ano para ser calculado a renda (mm/aaaa): ");
            string mesEAno = Console.ReadLine();
            int mes = int.Parse(mesEAno.Substring(0, 2));
            int ano = int.Parse(mesEAno.Substring(3));
            
            
            Console.WriteLine();
            Console.WriteLine("Nome: " + trabalhador.Nome);
            Console.WriteLine("Departamento: "+trabalhador.Departamento.Nome);
            Console.WriteLine("Renda do " +mesEAno+": " +trabalhador.Renda(ano, mes));

        }
    }
}
