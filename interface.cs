using System;

interface IAtaque {
    void Atacar();
}

public abstract class Heroi {
    public string nome;
    public int vida;

    public Heroi(string nome, int vida) {
        this.nome = nome;
        this.vida = vida;
    }

    public string GetNome() {
        return nome;
    }

    public void SetNome(string nome) {
        this.nome = nome;
    }

    public int GetVida() {
        return vida;
    }

    public void SetVida(int vida) {
        this.vida = vida;
    }

    public abstract void Especial();
}

public class Arlequina : Heroi, IAtaque {
    public Arlequina(string nome, int vida) : base(nome, vida) {}

    public void Atacar() {
        Console.WriteLine($"{GetNome()} ataca com seu bastão!");
    }

    public override void Especial() {
        Console.WriteLine($"{GetNome()} joga sua granada de fumaça!");
    }
}

public class Pinguim : Heroi, IAtaque {
    public Pinguim(string nome, int vida) : base(nome, vida) {}

    public void Atacar() {
        Console.WriteLine($"{GetNome()} ataca com seu guarda-chuva!");
    }

    public override void Especial() {
        Console.WriteLine($"{GetNome()} ataca com seu guarda-chuva!");
    }
}

public class Batman : Heroi, IAtaque {
    public Batman(string nome, int vida) : base(nome, vida) {}

    public void Atacar() {
        Console.WriteLine($"{GetNome()} defende com seu traje!");
    }

    public override void Especial() {
        Console.WriteLine($"{GetNome()} lança o batarangue explosivo!");
    }
}

public class Program {
    public static void Main(string[] args) {
        Arlequina arlequina = new Arlequina("Arlequina", 100);
        arlequina.Atacar();
        arlequina.Especial();

        Pinguim pinguim = new Pinguim("Pinguim", 120);
        pinguim.Atacar();
        pinguim.Especial();

        Batman batman = new Batman("Batman", 150);
        batman.Atacar();
        batman.Especial();
    }
}


