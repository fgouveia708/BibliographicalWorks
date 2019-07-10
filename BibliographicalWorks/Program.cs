using System;
using System.Collections.Generic;

namespace BibliographicalWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("######################################");
            Console.WriteLine("######## OBRAS BIBLIOGRÁFICAS ########");
            Console.WriteLine("######################################\n\n");

            int amout = GetInteger();
            var names = new List<string>();

            for (int i = 0; i < amout; i++)
            {
                Console.WriteLine("\nInforme o nome do Autor:");
                string input = Console.ReadLine();

                names.Add(new Author().GetName(input));
            }

            Console.WriteLine("\nLISTA DE AUTORES:\n");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        public static int GetInteger()
        {
            Console.WriteLine("Informe a quantidade de Autores que você deseja cadastrar:");
            string input = Console.ReadLine();

            int amount = 0;
            if (int.TryParse(input, out amount) && amount > 0)
            {
                return amount;
            }
            else
            {
                Console.WriteLine("\n### VALOR DIGITADO INVÁLIDO! ###\n");
                return GetInteger();
            }
        }
    }
}
