using System;

namespace NullSimplify
{
    class Program
    {
        static void Main(string[] args)
        {
            Escrever(null);
        }


        // Antes no C# 8
        static void Escrever(string palavra)
        {
            if (palavra == null)
            {
                throw new ArgumentNullException(nameof(palavra));
            }

            Console.WriteLine(palavra);
        }

        // Agora no C# 9 
        void Escrever2(string palavra!)
        {
            Console.WriteLine(palavra);
        }
    }
}
