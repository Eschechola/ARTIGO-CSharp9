using System;

namespace CSharp9.Classes
{
    public class RelationalPatterns
    {

        public void AvaliarAluno(double nota){
            nota switch
            {
                < 5 => Console.WriteLine("Reprovado"),

                <= 6 => Console.WriteLine("Recuperação"),

                <= 9 => Console.WriteLine("Aprovado"),

                10 => Console.WriteLine("Aprovado com êxito!"),

                _ => throw new ArgumentException("Nota inválida!")
            };
        }
    }
}