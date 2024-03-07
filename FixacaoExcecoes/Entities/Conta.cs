using FixacaoExcecoes.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoExcecoes.Entities
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double LimiteSaque { get; set; }

        public Conta() { }

        public Conta(int numero, string titular, double saldo, double limiteSaque)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
            LimiteSaque = limiteSaque;
        }

        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }
        public void Sacar(double quantia)
        {
            if (quantia > LimiteSaque)
            {
                throw new DomainException("Esse valor excede o limite de saque");
            }
            if (quantia > Saldo)
            {
                throw new DomainException("Saldo insuficiente para realizar o saque");
            }

            Saldo -= quantia;
        }
    }
}
