using System;

namespace _06_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();
            cliente.Nome = "Guilherme";
            cliente.CPF = "456.789.123.00";
            cliente.Profissao = "Desenvolvedor";

            conta.Saldo=-10;/**Não vai funcionar**/
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
