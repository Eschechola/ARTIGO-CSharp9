using System;

namespace IsNot
{
    class Program
    {
        static void ValidarObjeto(object obj)
        {
            // Antes no C# 8
            if (!(obj is null))
            {
                Console.WriteLine("Objeto Válido");
            }

            // Agora no C# 9 
            if (obj is not null)
            {
                Console.WriteLine("Objeto Válido");
            }
        }


        static void Main(string[] args)
        {
            object obj = new object();
            ValidarObjeto(obj);
            
        }
    }
}
