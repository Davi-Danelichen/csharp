public class Produto{
    private String nome;
    private Decimal preco;
    private String descricao;
    private String categoria;

    public Produto(String nome. decimal preco, string descricao, string categoria){
        Nome = nome;
        Preco = preco;
        Descricao = descricao;
        Categoria = categoria;
    }

    public String Nome{
        get{return nome;}
        set{nome = value;}
    }
    public Decimal preco{
        get{return preco}
        set{preco = value}
    }
    public String descricao{
        get{return descricao}
        set{descricao = value}
    }
    public String categoria{
        get{return categoria}
        set{categoria = value}
    }
    public virtual void Promocao(){
        Console.WriteLine("Promoção");
    }
}

public class ConsoleGame : Produto{
    private int armazenamento;
    
    public ConsoleGame(string nome, decimal preco, string descricao, string categoria, int armazenamento):base(nome, preco, descricao, categoria){
        Armazenamento = armazenamento;
    }
    public string armazenamento{
        get{return armazenamento;}
        set{armazenamento = value}
    }
    public override void Promocao(){
        Console.WriteLine("Promoção PlayStation 5 com 10% de desconto");
    }
}

public class Jogo : Produto{
    private string genero;

    public Jogo(string nome, decimal preco, string descricao, string categoria, string genero): base(nome, preco, descricao, categoria){
        Genero = genero 
    }

    public string Genero {
        get{return enero;}
        set{genero = value;}
    }
    public override void Promocao(){
        Console.WriteLine("Promoção Marvel´s Spider-Man 2 PREMIUM com 30% de desconto");
    }
}

public class Acessorio : Produto{
    private string tipo;

    public Acessorio(string nome, decimal preco, string descricao, string categoria, string tipo): base(nome, preco, descricao, categoria){
        Tipo = tipo 
    }
    
    public string Tipo {
        get{return Tipo;}
        set{Tipo = value;}
    }
    public override void Promocao(){
        Console.WriteLine("Luvas de teia com 25% de desconto");
    }
 }

  public class Colecionavel : Produto{
    private bool edicao;

    public Colecionavel(string nome, decimal preco, string descricao, string categoria, bool edicao): base(nome, preco, descricao, categoria){
        Edicao = edicao
    }
    
    public bool Edicao {
        get{return Edicao;}
        set{Edicao = value;}    
    }
    
    public override void Promocao(){
        Console.WriteLine("Bonecos do homem com 15% de desconto");
    }
}

public class Program {

    public static void main (String[] args){

        Produto produto;
        produto = new ConsoleGame("PlayStation 5", 5.900,"console de Video Game PlayStation 5 Slim com 1 Tera de armazenamento" , "Console", 1024000);
        produto.Promocao();

        Jogo jogo = new Jogo("Marvel´s Spider-Man 2 PREMIUM", 299,9,"Jogo completo Marvel´s Spider-Man 2 para PS5." , "jogoPS5","Ação e Aventura");
        jogo.Promocao();

        Acessorio acessorio = new Acessorio("Luvas de teia",300.0,"Cor vermelha e bastante flexivel","Luva","Luva de borracha" );
        acessorio.Promocao();

        Colecionavel colecionavel = new Colecionavel("Bonecos do homem ", 150.0,"Um boneco para colecionador","boneco",true);
        colecionavel.Promocao();

    }
}