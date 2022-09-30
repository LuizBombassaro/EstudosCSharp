using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario Carlos = new Funcionario("049.461.150.21");

            Carlos.Nome = "Carlos";
            Carlos.Salario = 2000;

            gerenciador.Registrar(Carlos);

            Diretor Rogerio = new Diretor("049.461.1502-22");

            Rogerio.Nome = "Rogerio";
            Rogerio.Salario = 10000;

            gerenciador.Registrar(Rogerio);

            Console.WriteLine(Carlos.GetBonificacao());
            Console.WriteLine(Rogerio.GetBonificacao());
            Console.WriteLine("Total gasto com bonificações: "+gerenciador.GetTotalBonificacao());

            Console.WriteLine("Salário: "+Carlos.Salario);
            Carlos.AumentarSalario();
            Console.WriteLine("Salário depois do aumento: " + Carlos.Salario);
            Console.WriteLine("Rogerio salário Antes: " + Rogerio.Salario);
            Rogerio.AumentarSalario();
            Console.WriteLine("Rogerio salário Depois: " + Rogerio.Salario);
        }
    }
}
