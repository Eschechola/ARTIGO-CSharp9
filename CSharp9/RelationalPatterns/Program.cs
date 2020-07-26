using System;

namespace RelationalPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AvaliarAluno(6));
        }

        public static string AvaliarAluno(double nota)
        {
           var resultado =  nota switch
            {
                < 0 => "Nota inválida",

                <= 5 => "Reprovado",

                <= 6 => "Recuperação",

                <= 9 => "Aprovado",

                10 => "Aprovado com êxito!",

                _ => throw new ArgumentException("Nota inválida!")
            };

            return resultado;
        }
    }
}
