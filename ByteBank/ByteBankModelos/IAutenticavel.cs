using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank1.Funcionarios;

namespace ByteBank1.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
       
}
