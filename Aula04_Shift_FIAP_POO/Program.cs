using Aula04_Shift_FIAP_POO.Models;
using System;

namespace Aula04_Shift_FIAP_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fabricante honda = new Fabricante() { Nome = "Honda" };

            Carro carro = new Carro();

            carro.Motor = "2.0 Motor";
            carro.Cor = "Preto";
            carro.Ano = 2021;
            carro.Arcondicionado = true;
            carro.QuantidadePortas = 4;
            carro.Fabricante = honda;


            Moto moto = new Moto();

            moto.PartidaEletrica = true;
            moto.Ano = 2022;
            moto.Cor = "Preta";
            moto.Motor = "120";
            moto.Fabricante = honda;


            Veiculo veiculo = new Veiculo();

            veiculo.Ano = 2015;
            veiculo.Motor = "70HP";
            veiculo.Cor = "Vermelho";

            Veiculo veiculo2 = new Veiculo("Amerelo", "100c", 2022);

            //Versoes herdadas do método acelerar
            carro.Acelerar();
            moto.Acelerar();
            veiculo.Acelerar();

            carro.Acelerar(20);
            carro.Acelerar(true, 20);


            //Instanciado carros e motos com utilização de construtore 
            Veiculo v1 = new Carro("Branco", "1.0", 2007, true, 4);
            Veiculo v2 = new Carro(3);
            Veiculo v3 = new Carro();

            Veiculo v4 = new Moto();
            Veiculo v5 = new Moto("Preto13", "300c", 2020, true);

            //Carro v13 = new Veiculo();


            //chamando o métdo acelar do veiculo e da moto
            v1.Acelerar();
            v4.Acelerar();


            veiculo.Frear(100, false, 10);  //veiculo
            carro.Frear(100, false, 10); //Carro

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Carro: {carro}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Moto: {moto}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Veiculo: {veiculo}");

        }
    }
}
