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

//Exercicio 4... implementando cliente e vendedor 
cliente C = new cliente();
C.cpf = "12345678910";
C.nome = "Joao";
vendedor V = new vendedor();
V.id = 1;
V.nome = "marcos";

// lista de criação de produtos (criando objeto produto por uma lista) metodo 1
// List<produto> P = new List<produto>
// {
//     new produto {id = 1, nome = "molde", preco = 50.00},
//     new produto {id = 2, nome = "repelente", preco = 23.90}
// };
produto P =  new produto();
P.id = 1;
P.nome = "repelente";
P.preco = 23.90;


pedido Pedido = new pedido(C,V,P);
Pedido.data = "20/12/2023";
Console.WriteLine("Pedido:");
Console.WriteLine("Data: " + Pedido.data);
Console.WriteLine("Cliente:" + Pedido.Cliente.nome);
Console.WriteLine("Vendedor:" + Pedido.Vendedor.nome);
Console.WriteLine("Produtos: ");
Console.WriteLine(Pedido.Produto.nome + " R$" + Pedido.Produto.preco.ToString("F2"));



// print dos produtos metodo 1
// foreach(var produto in Pedido.Produtos)
// {
//     Console.WriteLine(produto.nome + " Preço: R$"+ produto.preco);
// }

