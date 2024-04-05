public class pedido
{
    public string data{get;set;}
    public cliente Cliente{get;set;}
    public vendedor Vendedor{get;set;}
    // public List<produto> Produtos = new List<produto>();
    public produto Produto{get;set;}

    public pedido(cliente c, vendedor v,produto p)
    {
        Cliente = c;
        Vendedor = v;
        Produto = p;
    }


    // metodo 1 utilizando uma lista de produtos
    // public void AdicionaProd(produto p)
    // {
    //     Produtos.Add(p);
    // }

}