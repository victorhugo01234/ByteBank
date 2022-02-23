using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta = new ContaCorrente(867, 86712540);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            //conta.Numero = 86712540;
            //conta.Agencia = 867;

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
            Console.WriteLine();

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745820);
            Cliente Gabriela = new Cliente();
            Gabriela.Nome = "Gabriela";
            Gabriela.Profissao = "Desenvolvedora";
            Gabriela.CPF = "123.456.789-00";
            contaDaGabriela.Titular = Gabriela;
            
            Console.WriteLine("Titular: " + contaDaGabriela.Titular.Nome);
            Console.WriteLine("Agência: " + contaDaGabriela.Agencia);
            Console.WriteLine("Número: " + contaDaGabriela.Numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.Saldo);
            Console.WriteLine();

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
