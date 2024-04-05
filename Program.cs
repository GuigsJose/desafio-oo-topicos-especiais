// instânciando exercicio 01:
carro Marea = new carro();
Marea.Marca = "fiat";
Marea.Modelo = "turbo";
Marea.Ano = 2005;

// Console.WriteLine(Marea.Marca);
// Console.WriteLine(Marea.Modelo);
// Console.WriteLine(Marea.Ano);

//instânciando exercicio 02:

pessoa Humano = new pessoa();
Humano.Nome = "Guilherme";
Humano.Cpf = "12345678910";
livro Livro = new livro();
Livro.Titulo = "sociedade do cansaço";
Livro.Autor = "Byung-Chul han";
Humano.adicionarLivros(Livro);
Livro = new livro();
Livro.Titulo = "Bersek";
Livro.Autor = "Kentaro Miura";
Humano.adicionarLivros(Livro);

// Laço para apresentar na tela os livros.
foreach(var livro in Humano.livros)
{
    Console.WriteLine(livro.Titulo + " - " + livro.Autor);
}

//Exercicio 3.. implementando um procedimento imprimindo os dados do estudante

aluno Aluno = new aluno("34145443","Guilherme",20);
Console.WriteLine(Aluno.apresentaAluno());