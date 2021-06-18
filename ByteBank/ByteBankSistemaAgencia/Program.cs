using System;
using ByteBank.ByteBankModelos;

namespace ByteBank.ByteBankSistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(123, 456789);
            Console.WriteLine(conta.Conta);
            Console.ReadLine();
        }
    }
}
