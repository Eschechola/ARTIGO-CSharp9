namespace CSharp9.Classes
{
    public class Computador
    {
        public string Modelo { get; init; }
        public string Processador { get; init; }
        public string PlacaDeVídeo { get; init; }    


        Computador computador = new Computador
        {
            Modelo = "Samsung Odyssey 2",
            Processador = "Intel Core i5 8500F",
            PlacaDeVídeo = "GTX 1050 TI"
        };

        //com o atributo init
        // atribuições além do construtor são inviaveis
        //computador.Modelo = "Mac Book Pro 2019"

    }
}