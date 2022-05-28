using Aula02_Shift_FIAP_POO_Parte2.Exceptions;
using Aula02_Shift_FIAP_POO_Parte2.Models;
using System;

namespace Aula02_Shift_FIAP_POO_Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler os dados inputados pelo usuário
            Console.WriteLine("Digite seu nome completo:");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite seu CPF:");
            var cpf = Console.ReadLine();

            Console.WriteLine("Digite o telefone do cliente: ");
            var tel = Console.ReadLine();

            // TODO: Finalizar insert de dados da conta e métdodos para transações

            Console.WriteLine("Didite o número da conta");
            int numeroConta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("É uma conta especial. ");
            bool especial = bool.Parse(Console.ReadLine());

            decimal limite = 0;
            double juros = 0;

            if (especial)
            {
                // Caso a conta seja especial, o usuário deve realizar o input
                Console.WriteLine("Digite o limite da conta: ");
                limite = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite o juros da conta: ");
                juros = double.Parse(Console.ReadLine());

            }

            //Ler os dados da conta poupança

            Console.WriteLine("Digite o numero da conta poupança");
            double numeroPoupanca = double.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(nome, tel, cpf);
            cliente.Nome = nome;
            cliente.Cpf = cpf;
            cliente.Telefone = tel;

            double contaPoupanca = double.Parse(Console.ReadLine());
            // Instanciar Conta Poupancaa
            ContaPoupanca cntPoupanca = new ContaPoupanca(numeroPoupanca);

            cntPoupanca.Numero = numeroPoupanca;

            //Instanciar Conta Poupanca
            ContaCorrente contaCorrente = new ContaCorrente(numero: numeroConta,
                cliente: cliente, juros: juros, especial: especial, limite: limite, contaPoupanca: cntPoupanca);


            int opcao;

            do
            {
                Console.WriteLine("Escolha uma opcao: \n 1- Depositar \n 2-Retirar \n 3-Transferir \n 4-Calcular \n 0-Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o valor para o deposito: ");
                        try
                        {
                            // Ler o valor para deposito
                            var valor = decimal.Parse(Console.ReadLine());
                            contaCorrente.Depositar(valor);
                            Console.WriteLine($"O saldo da conta é:  {contaCorrente.Saldo} e o total {contaCorrente.RetornarSaldoTotal()}");
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Digite um valor para retirar: ");
                        try
                        {
                            // Ler o valor para deposito
                            var valor = decimal.Parse(Console.ReadLine());
                            contaCorrente.Retirar(valor);
                            Console.WriteLine($"O saldo da conta é:  {contaCorrente.Saldo} e o total {contaCorrente.RetornarSaldoTotal()}");
                        }
                        catch (SaldoInsuficienteException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:

                        Console.WriteLine("Digite um valor para transferir ");
                        try
                        {
                            // Ler o valor para deposito
                            var valor2 = decimal.Parse(Console.ReadLine());
                            contaCorrente.TrasferirParaPoupanca(valor2);
                            Console.WriteLine($"O saldo da conta corrente é:  {contaCorrente.Saldo} e o total {contaCorrente.RetornarSaldoTotal()}");
                            Console.WriteLine($"O saldo da poupançã:  {contaCorrente.Saldo}");

                        }
                        catch (SaldoInsuficienteException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 4:
                        if (contaCorrente.Saldo < 0)
                        {
                            Console.WriteLine("Digite a quantidade de dias: ");

                            // Ler o valor para deposito
                            int valor3 = int.Parse(Console.ReadLine());
                            decimal valorJuros = contaCorrente.CalcularValorTaxaJuros(valor3);
                            Console.WriteLine($"O valor do juros:  {valorJuros}");
                        }
                        else
                        {
                            Console.WriteLine("Não há calculo de juros");
                        }

                        break;
                    case 0:
                        Console.WriteLine("Finalizando o sistema... ");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
