using System;
using System.Globalization;

namespace ExercisesResolution1
{
    class Program
    {
        private class Elevador
        {
            private double PesoMaximo;
            private int QuantidadeDePessoasDentro;
            private int QuantidadeMaxima;
            private int QuantidadeDeAndares;
            private int AndarAtual;
        
            public Elevador(double pesoMaximo, int quantidadeDePessoas, int quantidadeDeAndares, int andarAtual, int quantidadeMaxima)
            {
                PesoMaximo = pesoMaximo;
                QuantidadeDePessoasDentro = quantidadeDePessoas;
                QuantidadeMaxima = quantidadeMaxima;
                QuantidadeDeAndares = quantidadeDeAndares;
                AndarAtual = andarAtual;
            }
            public void Subir()
            {
                if (AndarAtual == QuantidadeDeAndares)
                {
                    Console.WriteLine("Último andar!!!");

                }
                else
                {
                    AndarAtual = AndarAtual + 1;
                }
            }

            public void Descer()
            {
                if (AndarAtual == 0)
                {
                    Console.WriteLine("Térreo!");
                }
                else
                {
                    AndarAtual = AndarAtual - 1;
                }
            }

            public void EntrarPessoas(int quantidadeDePessoas)
            {
                if (QuantidadeDePessoasDentro == QuantidadeMaxima || QuantidadeDePessoasDentro + quantidadeDePessoas > QuantidadeMaxima)
                {
                    Console.WriteLine("Ta cheio!!!");
                }
                else
                {
                    QuantidadeDePessoasDentro = QuantidadeDePessoasDentro + quantidadeDePessoas;
                }

            }
            public void SairPessoas(int quantidadeDePessoas)
            {
                if (QuantidadeDePessoasDentro == 0 || QuantidadeDePessoasDentro - quantidadeDePessoas < 0)
                {
                    Console.WriteLine("Hein???");
                }
                else
                {
                    QuantidadeDePessoasDentro = QuantidadeDePessoasDentro - quantidadeDePessoas;
                }
            }
            public void ConsultarAndarAtual()
            {
                Console.WriteLine(AndarAtual);
            }

            public void ConsultarQuantidadeDePessoas()
            {
                Console.WriteLine(QuantidadeDePessoasDentro);
            }
        }
        static void Main(string[] args)
        {
            int andarAtual, quantidadeDeAndares, quantidadeDePessoasDentro, quantidadeMaxima;
            double pesoMaximo;

            quantidadeDeAndares = int.Parse(Console.ReadLine());
            andarAtual = int.Parse(Console.ReadLine());
            quantidadeDePessoasDentro = int.Parse(Console.ReadLine());
            quantidadeMaxima = int.Parse(Console.ReadLine());
            pesoMaximo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Elevador elevadorBrabo = new Elevador(pesoMaximo, quantidadeDePessoasDentro, quantidadeDeAndares, andarAtual, quantidadeMaxima);

            elevadorBrabo.Subir();
            elevadorBrabo.Descer();
            elevadorBrabo.ConsultarAndarAtual();
            elevadorBrabo.ConsultarQuantidadeDePessoas();
            int quantidadeDePessoasQueVaoEntrar = int.Parse(Console.ReadLine());
            elevadorBrabo.EntrarPessoas(quantidadeDePessoasQueVaoEntrar);
            elevadorBrabo.ConsultarQuantidadeDePessoas();
            int quantidadeDePessoasQueVaoSair = int.Parse(Console.ReadLine());
            elevadorBrabo.SairPessoas(quantidadeDePessoasQueVaoSair);
            elevadorBrabo.ConsultarQuantidadeDePessoas();


        }

    }

}
