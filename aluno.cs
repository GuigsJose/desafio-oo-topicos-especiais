// ./aluno.cs exercicio 03

public class aluno
{
    public string Matricula{get;set;}
    public string Nome{get;set;}
    public int Idade{get;set;}

    public aluno(string matricula, string nome, int idade)
    {
        this.Matricula = matricula;
        this.Nome = nome;
        this.Idade = idade;
    }

    public string apresentaAluno()
    {
        return Matricula + " - " + Nome + " Idade:" + Idade;
    }
}