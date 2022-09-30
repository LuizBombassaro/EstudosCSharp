using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class GerenciadorBonificacao
    {
        private double _totalbonificacao;
        public void Registrar(Funcionario funcionario)
        {
            _totalbonificacao += funcionario.GetBonificacao();
        }
        public double GetTotalBonificacao()
        {
            return _totalbonificacao;
        }
    }
}
