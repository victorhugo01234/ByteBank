using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ContaCorrente contaDaGariela = new ContaCorrente();
            contaDaGariela.titular = "Gabriela";
            contaDaGariela.agencia = 863;
            contaDaGariela.numero = 863452;
            contaDaGariela.saldo = 100;

            Console.WriteLine("Titular da conta: "+contaDaGariela.titular);
            Console.WriteLine("Agência: "+contaDaGariela.agencia);
            Console.WriteLine("Número: "+contaDaGariela.numero);
            Console.WriteLine("Saldo: "+contaDaGariela.saldo);

            contaDaGariela.saldo += 200;
            Console.WriteLine("Saldo: " + contaDaGariela.saldo);

            Console.ReadLine();
        }
    }
}
