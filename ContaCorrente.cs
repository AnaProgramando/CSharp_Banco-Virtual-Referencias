using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_BancoVirtualReferencias
{
    class ContaCorrente
    {
        public Cliente titular;
        public double saldo;
        public int agencia;
        public int numConta;        
    }
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string profissao;
    }
}
