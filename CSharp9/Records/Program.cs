using System;

namespace Records
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
        }
    }

    //O operador INIT obriga inicialzar a instância junto com o valor das propriedades
    public class Pessoa
    {
        public string Nome { get; init; }
        public string Sobrenome { get; init; }

        public Pessoa()
        {
            Pessoa pessoa = new Pessoa
            {
                Nome = "Lucas",
                Sobrenome = "Eschechola"
            };

            //Como ja foi inicializado, não posso fazer uma nova atribuição
            //Exemplo, essa atribuição não iria funcionar
            //pessoa.Nome = "Gabriel"
        }
    }


    public record PessoaRecord
    {
        public string Nome { get; init; }
        public string Sobrenome { get; init; }

        public PessoaRecord()
        {
            //pega os mesmos valores do objeto anterior 
            //mudando somente o informado
            PessoaRecord pessoa = new PessoaRecord
            {
                Nome = "Lucas",
                Sobrenome = "Eschechola"
            };

            PessoaRecord outraPessoa = pessoa with { Sobrenome = "Gabriel" };
        }
    }

    //classe com atributo init dentro das propriedades
    //de forma simplificada 
    public record PessoaInit(string Nome, string Sobrenome);


    //utilizando Record classes juntamente com herança
    public record PessoaHeranca(string Nome, string Sobrenome);

    public record PessoaJuridica(string Nome, string Sobrenome, string CNPJ) 
        : PessoaHeranca(Nome, Sobrenome);


    public class PessoaTeste
    {
        public PessoaTeste()
        {
            var pessoaJuridica = new PessoaJuridica(
                Nome: "Gabriel",
                Sobrenome: "Silva",
                CNPJ: "00.000.000/0001-00");

            //atribuindo a o objeto herdado
            var pessoa = pessoaJuridica with { CNPJ = "00.000.000/2222-33" };
        }
    }
}
