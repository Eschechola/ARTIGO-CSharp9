using System;

namespace CSharp9.Classes
{
    public class IsNot
    {
        object obj = new object();

        public void ValidarObjeto()
        {
            // Antes no C# 8
            if(!(obj is null))
            {
                Console.WriteLine("Objeto Válido");
            }

            // Agora no C# 9 
            if(obj is not null)
            {
                Console.WriteLine("Objeto Válido");
            }
        }

        
               
    }
}