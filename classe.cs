using System

public class Personagem
{
    private string nome;
    private int nivel;
    private double pontuacao;
    private double vida;
    private double forca;
    private double agilidade;
    private double inteligencia;
    private string[]armasEquipamento;

    public Personagem(string nome, int nivel, double pontuacao, double vida, double forca, double agilidade, double inteligencia, string[] armasEquipamentos)
    {
        this.nome = nome;
        this.nivel = nivel;
        this.pontuacao = pontuacao;
        this.vida = vida;
        this.forca = forca;
        this.agilidade = agilidade;
        this.inteligencia = inteligencia;
        this.armasEquipamento = armasEquipamento;
    }
}
    
    public string getNome(){
        return getNome;
    }
   
    public void SetNome(string nome ){
        this.nome = nome;
    }

    public interface GetNivel(){
        return GetNivel;
    }
   
    public void SetNivel(int nivel){
        this.nivel = nivel;
    }

    public double GetPontuacao(){
        return GetPontuacao;
    }
    
    public void SetPontuacao(double pontuacao){
        this.nivel = nivel;
    }

    public double GetVida(){
        return GetVida;
    }

    public void SetVida(double vida){
        this.vida = vida;
    }

    public double GetForca(){
        return forca;
    }

    public void SetForca(double forca){
        this.forca = forca;
    }

    public double GetAgilidade(){
        return agilidade;
    }

    public void SetAgilidade(double agilidade){
        this.agilidade = agilidade;
    }

    public double GetInteligencia(){
        return GetAgilidade;
    }

    public void SetInteligente(){
        this.inteligencia = inteligencia;
    }
    
    public string[] GetarmasEquipamento(){
        return armasEquipamentos;
    }

    public void armasEquipamento(string []){
        this.armasEquipamento = armasEquipamento
    }


    public void Mover(string direcao, double distancia){
        ConsolerWriteLine($"{GetNome()} esta se movendona direcao {direcao} por {distancia} passos.");
    }
    
    public void atacar(Personagem akivo){
        ConsolerWriteLine($"{GetNome()} esta atacando {alvo.GetNome}.");
    }

    public void ReceberDano(double dano){
        GetVida -= dano;
        if( GetVida <= 0){
            Morrer();
        }else{
            ConsoleWriteLine($"{GetNome()} recebeu {dano} de dano. vida restante: {GetVida()}");
        }
}


public void Usarhabilidade(string habilidade , Personagem alvo){
    Console.WriteLine($"{GetNome()} esta usando habilidade {habilidade} em {alvo.GetNome()}.");

}

public void SubirDeNivel(){
    nivel ++;
    Console.WhiteLine($"{GetNome()} subiu para o nivel {GetNivel()}!");
}

private void Morrer(){
    Console.WhiteLine($"{GetNome()} morreu.");

}

class Program{
    static void Main (string[] args){

        Personagem batman = new Personagem("Batman", 1, 0, 100, 90, 100, new string[]{
            "Multi-Batarangue","Lançador de Gel", "Bomba de fumaça", "Ultra Bat-Garra","Sintelizador de voz"});
            Console.WhiteLine("Personagem Heroi");
            Console.WhiteLine($"Nome: {batman.GetNome()}");
            Console.WhiteLine($"Nivel: {batman.GetNivel()}");
            Console.WhiteLine($"Pontuacao do Batman: {batman.GetPontuacao()}");
            Console.WhiteLine($"Vida: {batman.GetVida()}");
            Console.WhiteLine($"Forca: {batman.GetForca()}");
            Console.WhiteLine($"Agilidade: {batman.GetAgilidade()}");
            Console.WhiteLine($"Inteligencia: {batman.GetInteligencia()}");
            Console.WhiteLine($"Armas e Equipamentos: {string.Join(",", batman.GetArmasEquipamentos())}");
            Console.WhiteLine("");
    
    
        }
    }

Console.WhiteLine("----------------------------------")
Console.WhiteLine("");
        Personagem coringa = new Personagem("Coringa", 1, 0, 100, 70, 65, 85, new string[]{
            "Gas do Riso", "Flores que Esguicham Ácido", "Baralhas de Carta", "Luvas de Choque"});

            Console.WhiteLine("Personagem Inimigo");
            Console.WhiteLine($"Nome: {coringa.GetNome()}");
            Console.WhiteLine($"Nivel: {coringa.GetNivel()}");
            Console.WhiteLine($"Pontuacao do Batman: {coringa.GetPontuacao()}");
            Console.WhiteLine($"Vida: {coringa.GetVida()}");
            Console.WhiteLine($"Forca: {coringa.GetForca()}");
            Console.WhiteLine($"Agilidade: {coringa.GetAgilidade()}");
            Console.WhiteLine($"Inteligencia: {coringa.GetInteligencia()}");
            Console.WhiteLine($"Armas e Equipamentos: {string.Join(",", coringa.GetArmasEquipamentos())}");
            Console.WhiteLine("");
            Console.WhiteLine("----------------------------------");
            Console.WhiteLine("");



            batman.Mover("norte", 10);
            coringa.Mover("sul", 10);
            batman.Atacar(coringa);
            batman.Usarhabilidade("Multi-Batarangue", coringa);
            coringa.ReceberDano(50);
            batman.SetPontuacao(50);
            Console.WhiteLine($"Pontuacao do Batman: {batman.GetPontuacao()}");
            coringa.UsarHabilidade("Gas do Riso", batman);


            coringa.SetPontuacao(30);
            Console.WhiteLine($"Pontuacao do Coringa: {coringa.GetPontuacao()}");

            batman.UsarHabilidade9("Ultra Bat-Garra", coringa);

            coringa.ReceberDano(999);

            batman.SetPontuacao(100);
            Console.WhiteLine($"Pontuacao do Batman: {batman.GetPontuacao()}");

            batman.SubirDeNivel();
            Console.ReadLine();

    }
}

    













































