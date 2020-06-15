namespace CSharp9.Classes
{
    //O operador INIT obriga inicialzar a instância junto com o valor das propriedades
    public class Pessoa
    {   
        public string Nome { get; init; }
        public string Sobrenome { get; init; }
    }

    var pessoa = new Pessoa
    {
        Nome = "Lucas",
        Sobrenome = "Eschechola"
    };

    //Como ja foi inicializado, não posso fazer uma nova atribuição
    //Exemplo, essa atribuição não iria funcionar
    //pessoa.Nome = "Gabriel"



    
    public data class Pessoa
    {
        public string Nome { get; init; }
        public string Sobrenome { get; init; }
    }
    
    
    //pega os mesmos valores do objeto anterior 
    //mudando somente o informado
    var pessoa = new Pessoa
    {
        Nome = "Lucas",
        Sobrenome = "Eschechola"
    };

    var outraPessoa = pessoa with { Sobrenome = "Gabriel" }


    //classe com atributo init dentro das propriedades
    //de forma simplificada 
     public data class Pessoa { string Nome, string Sobrenome }


    //utilizando Record classes juntamente com herança
    public data class Pessoa { string Nome, string Sobrenome }
    public data class Emprego : Pessoa { double Salario }


    //atribuindo a o objeto herdado
    var pessoaEmpregada = new Emprego
    {
        Nome = "Gabriel",
        Sobrenome = "Silva",
        Salario = "1200"
    } 

    var pessoa = pessoaEmpregada with { Salario = "2000" }
    
}