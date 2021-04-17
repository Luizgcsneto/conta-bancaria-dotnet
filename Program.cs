using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica,100,200,"Luiz");
            Console.WriteLine(minhaConta.ToString());
        }
    }
}
