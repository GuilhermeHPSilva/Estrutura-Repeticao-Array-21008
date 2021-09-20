using System;

namespace ArrayColection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5]{
                "Dani",
                "Maju",
                "Bruno",
                "Ramon",
                "Sofi"
            };
            Console.WriteLine(nomes[2]);

            //nomes[2] = "Antonio Junior";

            Console.WriteLine("------");

            Console.WriteLine($"Novo valor na index > {nomes[2]}");

            Console.WriteLine("------ Iteração do Array pelo foreach");

            foreach (string aluno in nomes)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("------ Iteração do Array pelo for");

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }
        }
    }
}
