using System;

namespace CSharp9.Classes
{
    public class NullSimplify
    {
        // Antes no C# 8
        void Escrever(string palavra)
        {
            if(palavra == null){
                throw new ArgumentNullException(nameof(palavra));
            }

            Console.WriteLine(palavra);
        }

        // Agora no C# 9 
        void Escrever(string palavra!)
        {
            Console.WriteLine(palavra);
        }

        
    }
}