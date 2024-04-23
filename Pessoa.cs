public class Pessoa {
    private String nome;
    private int idade;
    private String cpf;

    public Pessoa(String nome. int idade, String cpf){
        Nome = nome;
        Idade = idade;
        CPF = cpf;
    }

    public String Nome{
        get{return nome;}
        set{nome = value;}
    }
    public int Idade{
        get{return idade ;}
        set{idade = value ;}
    }
    public String CPF{
        get{return cpf;}
        set{cpf = value}
    }
}

public class Estudante : Pessoa{
    private String curso;

    public Estudante(string nome, int idade, string cpf, string curso):base(nome, idade, cpf){
        Curso = curso;
    }


    public string Curso{
        get{return curso;}
        set{curso = value;}
    }
}

public class Funcionario : Pessoa{
    private double salario;


    public double Bonus(){
        return salario * 0.1;
    }


    public string Salario {
        get{return salario;}
        set{salario = value;}
    }
}

public class Diretor : Funcionario{


    public Diretor(string nome, int idade, string cpf, double salario): base(nome, idade, cpf, salario){

    }


    public override double Bonus{
        return base.Bonus() + 1000;
    }
}