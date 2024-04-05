public class pessoa
{
    public string Cpf{get;set;}
    public string Nome{get;set;}
    public List<livro> livros = new List<livro>();

    // método na pessoa para receber livros
    public void adicionarLivros(livro L)
    {
        livros.Add(L);
    }

    public List<livro> GetLivros(){
        return this.livros;
    }

}