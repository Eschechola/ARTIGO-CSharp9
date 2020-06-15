namespace CSharp9.Classes
{
    public class Carro
    {
        public Carro(string modelo, string placa)
        {}
    
        //Antes no C# 8
        Carro carro = new Carro("Fiat Uno", "XYZ-0000");

        //Agora no C# 9
        Carro carro = new ("Fiat Uno", "XYZ-0000");

        
    }
}