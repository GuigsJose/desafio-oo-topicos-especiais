public class pedido
{
    public string data{get;set;}
    public cliente Cliente{get;set;}
    public vendedor Vendedor{get;set;}
    public List<produto> Produtos = new List<produto>();

    public pedido(cliente c, vendedor v,List<produto> p)
    {
        Cliente = c;
        Vendedor = v;
        Produtos = p;
    }

    public void AdicionaProd(produto p)
    {
        Produtos.Add(p);
    }

}