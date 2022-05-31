using System;
using Aula03_Shift_FIAP_POO.Models;

namespace Aula03_Shift_FIAP_POO_Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de comodos");         
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Tem piscina");
            bool piscina = bool.Parse(Console.ReadLine());

            Console.WriteLine("Digite a área da casa: ");
            var area = double.Parse(Console.ReadLine());

            //Utilizandi atributos informados no construtor, com input do usuário
            var casa = new Casa(quantidade, piscina, area);

            //Construtor recebendo parametros pre definidos
            var casa2 = new Casa(6, true, 123);

            //Construtor sem parametros
            var casa3 = new Casa()
            {
                Comodos = 5,
                AreaTotal = 50
            };

            //Construtor com 1 parametro
            var casa4 = new Casa(70)
            {
                Piscina = true
            };

            Console.WriteLine($"{ casa.Comodos}, {casa.Piscina },  {casa.AreaTotal}" );
            Console.WriteLine($"{ casa2.Comodos}, {casa2.Piscina },  {casa2.AreaTotal}" );
            Console.WriteLine($"{ casa3.Comodos}, {casa3.Piscina },  {casa3.AreaTotal}" );
            Console.WriteLine($"{ casa4.Comodos}, {casa4.Piscina },  {casa4.AreaTotal}" );
        }
    }
}
