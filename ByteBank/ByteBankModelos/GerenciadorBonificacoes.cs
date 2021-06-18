using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank1.Funcionarios;

namespace ByteBank1
{
    class GerenciadorBonificacoes
    {
        private double _totalBonificacao;
        public void Registrar(Funcionario funcionario) {

            _totalBonificacao += funcionario.GetBonificacao();

        }
     
        public double GetTotalBonificacao() {
            return _totalBonificacao;
        }
    }
}
