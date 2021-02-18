using System;
using System.Text.RegularExpressions;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int Provas;
            float notas = 0;
            string pattern = @"[a-zA-Z]+";
            string msgError = "Comando só pode conter numeros!";

            Console.WriteLine("Programa Teste 1.");
            Console.WriteLine("Programa para tirar a media de nota!");
            Console.WriteLine("Quanto de media você precisa para passar");

            string media = Console.ReadLine();
            while (Regex.IsMatch(media, pattern))
            {
                Console.WriteLine(msgError);
                media = Console.ReadLine();
            }

            Console.WriteLine("Quantas provas a no ano?");
            string quantidade_de_provas = Console.ReadLine();
            while (Regex.IsMatch(quantidade_de_provas, pattern))
            { 
                Console.WriteLine(msgError);
                quantidade_de_provas = Console.ReadLine();
            }

            for (int i = 0; i < float.Parse(quantidade_de_provas); i++)
            {
                Console.WriteLine("Digite a nota da " + (i + 1) + "° prova.");
                string nota = Console.ReadLine();
                while (Regex.IsMatch(nota, pattern))
                { 
                    Console.WriteLine(msgError);
                    nota = Console.ReadLine();
                }
                notas = notas + float.Parse(nota);
            }


            float mediax = notas / float.Parse(quantidade_de_provas);

            Console.WriteLine("Sua Media ficou em " + mediax + ".");
            if (mediax >= float.Parse(media))
            {
                Console.WriteLine("Você foi aprovado.");
            }
            else
            {
                Console.WriteLine("faltou " + (float.Parse(media) - mediax) + " para você passar, você está na recuperação.");
            }
        }
    }
}

