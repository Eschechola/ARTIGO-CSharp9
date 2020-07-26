namespace TargetTyped
{
    class Program
    {
        public class Carro
        {
            public Carro(string modelo, string placa)
            { }
        }


        static void Main(string[] args)
        {
            //Antes no C# 8
            Carro carro = new Carro("Fiat Uno", "XYZ-0000");

            //Agora no C# 9
            Carro carro2 = new("Fiat Uno", "XYZ-0000");

        }
    }
}
