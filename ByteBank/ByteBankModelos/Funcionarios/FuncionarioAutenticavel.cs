using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank1.Sistemas;

namespace ByteBank1.Funcionarios
{
    public abstract class FuncionarioAutenticavel: Funcionario, IAutenticavel
    { 
        public string Senha { get; set; }
        
        public bool Autenticar(string senha) {
            return this.Senha == senha;
        }

        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf) {
        }
    }
       
}
