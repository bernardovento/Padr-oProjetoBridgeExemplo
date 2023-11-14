using System;

// Criação da classe abstrata Forma, para servir como pai(abstrata = serve como 
//base para suas subclasses) 
public abstract class Forma
{
    // Criação da variavel protegida Cor(protegida = só pode ser acessada por 
    //codigo na classe ou subclasse)
    protected Cor cor;
    
    // Função de inicialização da classe Forma.
    public Forma(Cor cor)
    {
        // Esta pegando a cor que a classe Forma recebe na criação e colocando 
        //como a cor da classe forma:
        this.cor = cor;
    }
    // Criação da função abstrata Imprimir.
    public abstract void Imprimir();
}

// Criação da subclasse Circulo 
public class Circulo : Forma
{
    // Função de inicialização da subclasse circulo(Apenas iniciamos o que 
    //declaramos na inicialização da classe pai):
    public Circulo(Cor cor) : base(cor)
    {
    }

    // Fazendo overrride na função imprimir(Escrevendo por cima da função abstrata)
    public override void Imprimir()
    {
        // Escrevendo a Forma no console:
        Console.WriteLine("Forma: "+ this.GetType().Name +", Cor: " + cor.Nome);
    }
}

// Repetimos o mesmo processo da forma Circulo, só que no Quadrado:
public class Quadrado : Forma
{
    public Quadrado(Cor cor) : base(cor)
    {
    }

    public override void Imprimir()
    {
        Console.WriteLine("Forma: "+ this.GetType().Name +", Cor: " + cor.Nome);
    }
}

// Criação da classe abstrata Cor:
public abstract class Cor
{
    // Criação da função abstrata Nome:
    public abstract string Nome { get; }
}

// Criação da subclasse Vermelho:
public class Vermelho : Cor
{
    // Dando um override na função Nome e adcionando um get que retornará 
    //o nome Vermelho:
    public override string Nome
    {
        get { return "Vermelho"; }
    }
}
// Repetimos o mesmo processo da cor Vermelha, só que com a Azul:
public class Azul : Cor
{
    public override string Nome
    {
        get { return "Azul"; }
    }
}

// Classe controladora do codigo:
class Programa
{
    // O ponto de entrada de todo codigo em C#, função Main:
    static void Main(string[] args)
    {
        // Estamos criando um circulo vermelho:
        Forma forma = new Circulo(new Vermelho());
        forma.Imprimir();
        
         // Estamos criando um circulo azul:
        forma = new Circulo(new Azul());
        forma.Imprimir();

        // Estamos criando um quadrado vermelho:
        forma = new Quadrado(new Vermelho());
        forma.Imprimir();
        
        // Estamos criando um quadrado azul:
        forma = new Quadrado(new Azul());
        forma.Imprimir();
        
    }
}
