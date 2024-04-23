using System:

class Palhaco {
//atributos
    private string nome;
    private string cor;
    private int idade;
    private double altura;
    private char genero;

    //constrututor
    public Palhaco(string nome, string cor, int idade, double altura, char genero){
        this.nome = nome;
        this.cor = cor;
        this.idade = idade;
        this.altura = altura;
        this.genero = genero;
    }

    //metodos
    public void infoPalhaco(){
        Console.WriteLine($"NOME:{nome},idade:{idade},altura:{altura},genero:{genero}");
    }
    private void correr(){
        Console.WriteLine("Correndo.");
    }
    private void pular(){
        Console.WriteLine("Pulando");
    }
}

public class Coringa:Palhaco{
    public Coringa(){
        this.nome = "Coringa";
        this.cor = "verde";
        this.idade = "48";
        this.altura = "1,83";
        this.genero = "M";
        
    public void risada(){
Console.WriteLane("Coringa ativou a risada")
        }
    }
}
    public class Coringa:Palhaco{
        public Coringa(){
        this.nome = "Coringa";
        this.cor = "verde";
        this.idade = "48";
        this.altura = "1,83";
        this.genero = "M";

        public void main risada(){
            Console.writelane("Coringa ativou a risada")
         }
     }
 }

 class Programa{
    static void maim(string[]args){
         Palhaco = new Palhaco();
        Coringa coringa = new Coringa();

console.writelane($"Nome:{Palhaco.Nome}")
   
        }
    }