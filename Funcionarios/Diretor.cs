using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(5000,cpf)
        {

        }
        
        //override sobrescreve o comando GetBonificacao do funcionário por que o do funcionário é um metodo virtual
        //os metodos virtuais permitem que os filhos modifiquem os pais, assim como o diretor faz com o funcionario.
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }

        public override void AumentarSalario()
        {
            Salario += Salario * 0.15;
        }
    }
}
