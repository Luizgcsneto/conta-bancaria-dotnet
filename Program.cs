using System;
using System.Collections.Generic;

namespace DIO.Bank
{
    class Program
    {
        static List<Conta> listaContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                    ListarContas();
                    break;
                    case "2":
                    InserirNovaConta();
                    break;
                    case "3":
                  //  Transferir();
                    break;
                    case "4":
                   // Sacar();
                    break;
                    case "5":
                  //  Depositar();
                    break;
                    case "C":
                    Console.Clear();
                    break;
                    case "X":

                    default:
                    throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
             Console.WriteLine("Obrigado por usar nossos serviços");
             Console.WriteLine();

        }

        private static void ListarContas()
        {
          Console.WriteLine("Listar Contas");
          if(listaContas.Count == 0)
          {
              Console.WriteLine("nenhuma conta cadastrada");
              return;
          }

          for(int i = 0; i < listaContas.Count; i++)
          {
              Conta conta = listaContas[i];
              Console.WriteLine("#{0}", i);
              Console.WriteLine(conta);
          }
        }

        private static void InserirNovaConta()
        {
           Console.WriteLine("Digite 1 pessoa física e 2 para pessoa jurídica");
           int entradaTipoConta = int.Parse(Console.ReadLine());

           Console.WriteLine("Diga o nome do cliente");
           string entradaNome = Console.ReadLine();

           Console.WriteLine("Informe o saldo da conta");
           double entradaSaldo = double.Parse(Console.ReadLine());

           Console.WriteLine("Informe o  crédito");
           double entradaCredito = double.Parse(Console.ReadLine());

           Conta novaConta = new Conta(
           tipoConta : (TipoConta)entradaTipoConta, 
           saldo: entradaSaldo,
           credito: entradaCredito, 
           nome: entradaNome);

            listaContas.Add(novaConta);
        }

        private static string ObterOpcaoUsuario()
        {
             Console.WriteLine();
             Console.WriteLine("DIO Bank ao seu dispor");
             Console.WriteLine("Informe a opção desejada");

             Console.WriteLine("1 - Listar Contas");
             Console.WriteLine("2 - Inserir Nova Conta");
             Console.WriteLine("3 - Transferir");
             Console.WriteLine("4 - Sacar");
             Console.WriteLine("5 - Depositar");
             Console.WriteLine("C - Limpar Tela");
             Console.WriteLine("X - Sair");
             Console.WriteLine();

             string opcaoUsuario = Console.ReadLine().ToUpper();
             Console.WriteLine();
             return opcaoUsuario;


        }
    }
}
