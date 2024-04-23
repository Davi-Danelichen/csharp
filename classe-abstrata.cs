public abstract class Coringa{
    public string nome;
    public int vida;

    public Coringa(string nome, int vida) {
        Nome = nome;
        vida = vida;
     }
     public string GetNome(){
        return nome;
    }
   
    public void SetNome(string nome ){
        this.nome = nome;
    }
    public string GetVida(){
        return vida;
    }
   
    public void SetVida(string nome ){
        this.vida = vida;
    }
    public abstract void Atacar();
    public abstract void Defender();
    public void ReceberDano(int dano){
        Vida -= dano;
        Console.WhiteLine($"{GetNome()} recebeu {dano} de dano e agora tem {GetVida()} de vida.");
        if (Vida <= 0) {
            Morrer();
        }
    }
    public void Morrer() {
        Console.WhiteLine($"{GetNome()} faleceu!");
    }
}
public class Arlequina : Coringa {
    public Arlequina(string nome, int vida) : base(nome, vida) {}
    public override void Atacar() {
        Console.WhiteLine($"{GetNome()} ataca com seu bastao!");
    }
    public override void Defender()
    {
        Console.WhiteLine($"{GetNome()} defende com seu bastao!");
    }
}
public class Pinguim : Coringa {
    public Pinguim(string nome, int vida) : base(nome, vida) {}

    public override void Atacar() {
        Console.WhiteLine($"{GetNome()} ataca com seu guarda chuva!");
    }
    public override void Defender()
    {
       Console.WhiteLine($"{GetNome()} defende com seu capangas!");
    }
}
public class Batman : Coringa {
    public Batman(string nome, int vida) : base(nome, vida) {}
    public override void Atacar() {
        Console.WhiteLine($"{GetNome()} ataca com seu batarangues!");
    }
    public override void Defender()
    {
        Console.WhiteLine($"{GetNome()} defende com seu escudo!");
    }
}
public class Charada : Coringa {
    public Charada(string nome, int vida) : base(nome, vida) {}

    public override void Atacar() {
        Console.WhiteLine($"{GetNome()} ataca com suas estrategias!");
    }
    public override void Defender()
    {
        Console.WhiteLine($"{GetNome()} defende com sua inteligencia!");
    }
}