using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_BancoVirtualReferencias
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaFulano = new ContaCorrente();
            contaFulano.titular = new Cliente();
            contaFulano.titular.nome = "Fulano";
            contaFulano.titular.cpf = "123.456.789-10";
            contaFulano.titular.profissao = "Professor";
            contaFulano.saldo = 500;
            contaFulano.agencia = 123;
            contaFulano.numConta = 1234567;

            Console.WriteLine("Banco Virtual - Referências: \r\n");
            Console.WriteLine("O nome de titular é " + contaFulano.titular.nome + ".");
            Console.WriteLine("O CPF do titular é " + contaFulano.titular.cpf + ".");
            Console.WriteLine("A profissão do titular é " + contaFulano.titular.profissao + ".");
            Console.WriteLine("O saldo do titular é de R$ " + contaFulano.saldo + ".");
            Console.WriteLine("O número da agência é " + contaFulano.agencia + ".");
            Console.WriteLine("O número da conta é " + contaFulano.numConta + ".");

            Console.ReadLine();
        }
    }
