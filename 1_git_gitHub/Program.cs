System.Console.WriteLine("Hello Word");

Pessoa pessoa = new("Brian", 25, 2245234);

System.Console.WriteLine(pessoa.Nome);
System.Console.WriteLine(pessoa.Idade);
System.Console.WriteLine(pessoa.CPF);

Pessoa pessoa1 = new("João", 23, 155398);

System.Console.WriteLine(pessoa1.Nome);
System.Console.WriteLine(pessoa1.Idade);
System.Console.WriteLine(pessoa1.CPF);
public class Pessoa
{
    public string Nome;
    public int Idade;
    public int CPF;

    public Pessoa(string nome, int idade, int cpf)
    {
        Nome = nome;
        Idade = idade;
        CPF = cpf;
    }

}