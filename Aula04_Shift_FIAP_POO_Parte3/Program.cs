using Aula04_Shift_FIAP_POO_Parte3.Models;
using System;

namespace Aula04_Shift_FIAP_POO_Parte3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ler a informação cadastrar
            Console.WriteLine("Digite a formação 1 - Tecnologo ou 2 - Bacharelado");
            int tipo = Convert.ToInt32(Console.ReadLine());

            // Ler dados da formação
            Console.WriteLine("Digite o nome da Intituição: ");
            var instituicao = Console.ReadLine();

            // Ler informações sobre o curso completo 
            Console.WriteLine("Digite o nome da formação: ");
            var nome = Console.ReadLine();

            Formacao formacao;

            if (tipo == 1)
            {
                Console.WriteLine("Plano estendido? ");
                var plano = bool.Parse(Console.ReadLine());


                formacao = new Tecnologos(nome)
                {
                    PlanoEstendido = plano,
                    Instituicao = new Instituicao(instituicao)
                };

            }
            else
            {
                Console.WriteLine("Projeto TCC");
                var projeto = Console.ReadLine();


                Console.WriteLine("Carga horaria de estagio");
                int estagio = int.Parse(Console.ReadLine());


                formacao = new Bacharelado(nome, estagio)
                {
                    ProjetoConclusao = projeto,
                    Instituicao = new Instituicao(instituicao)
                };
            }

            Console.WriteLine(formacao);

            // Apresentar um menu de opçõe
            int op;


            do
            {
                Console.WriteLine("Escolha uma opção: \n 1-Calcular média \n 2-Calcular Mensalidae \n 3- Sair");
                op = Convert.ToInt32(Console.ReadLine());   

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite a nota 1: ");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a nota 2: ");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a nota 3: ");
                        int n3 = int.Parse(Console.ReadLine());
                        //Calcular e exibe a média
                        Console.WriteLine($"A média é {formacao.CalcularMedia(n1, n2, n3)}");
                        break;
                    case 2:
                        Console.WriteLine($"A mensalidade é {formacao.CalcularMensalidade()}");
                        break;
                    case 3:
                        Console.WriteLine("Finalizando o sitema....");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (op != 3);

        }

    }
}
