using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**Abertura da conta do Bruno**/
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";
            Console.WriteLine(contaDoBruno.saldo);
            
            /*Saque na conta do Bruno*/
            bool resultadoSaque = contaDoBruno.Sacar(50);

            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);

            /*Deposito na conta do Bruno*/
            contaDoBruno.Depositar(500);
            Console.WriteLine(contaDoBruno.saldo);

            /**Abertura da conta da Gabriela**/
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            Console.WriteLine("Saldo das Contas de Bruno e Gabriela:");
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(contaDaGabriela.saldo);

            Console.WriteLine("Transferencia de: " + contaDoBruno.titular + " para: " + contaDaGabriela.titular);
            contaDoBruno.Transferir(200, contaDaGabriela);
            Console.WriteLine(contaDoBruno.saldo);
            Console.WriteLine(contaDaGabriela.saldo);

            Console.WriteLine("Transferencia de: " + contaDaGabriela.titular + " para: " + contaDoBruno.titular);
            contaDaGabriela.Transferir(100, contaDoBruno);
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDoBruno.saldo);


            Console.ReadLine();
        }
    }
}
