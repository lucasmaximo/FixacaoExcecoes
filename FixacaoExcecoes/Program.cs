// See https://aka.ms/new-console-template for more information

using FixacaoExcecoes.Entities;
using FixacaoExcecoes.Entities.Exceptions;
using System.Globalization;

Console.WriteLine("Entre os dados da conta");

Console.Write("Número: ");
int numero = int.Parse(Console.ReadLine());
Console.Write("Titular: ");
string titular = (Console.ReadLine());
Console.Write("Saldo inicial: ");
double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Limite de saque: ");
double limiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Conta conta = new Conta(numero, titular, saldo, limiteSaque);

try
{
    Console.WriteLine();
    Console.Write("Entre o valor para sacar: ");
    double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    conta.Sacar(quantia);
    Console.WriteLine("Novo saldo: " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));
}
catch (DomainException e)
{
    Console.WriteLine("Erro no saque: " + e.Message);
}
