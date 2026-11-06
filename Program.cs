using ExerciciosPOO;

// ! Exercicio 1

/*
class Program
{
    static void Main(string[] args)
    {

        Pessoa p1 = new Pessoa();
        Pessoa p2 = new Pessoa();

     
        p1.Nome = "Ana";
        p1.Idade = 25;
        p1.Cidade = "São Paulo";

        p2.Nome = "Carlos";
        p2.Idade = 30;
        p2.Cidade = "Rio de Janeiro";

    
        p1.Apresentar();
        p2.Apresentar();
    }
}
*/


// ! Exercicio 2

/*
 class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            double resultadoSoma = calc.Somar(11, 5);
            double resultadoSubtracao = calc.Subtrair(7, 5);
            double resultadoMultiplicacao = calc.Multiplicar(10, 28);

            
            Console.WriteLine($"Soma: {resultadoSoma}");
            Console.WriteLine($"Subtração: {resultadoSubtracao}");
            Console.WriteLine($"Multiplicação: {resultadoMultiplicacao}");

  
            double resultadoDivisao = Calculadora.Dividir(60, 2);

            Console.WriteLine($"Divisão: {resultadoDivisao}");
        }
    }
*/

// ! Exercicio 3

/*

class Program
{
    static void Main()
    {
        Veiculo carro = new Veiculo();

        carro.Velocidade = 80;
        Console.WriteLine($"Velocidade: {carro.Velocidade} km/h");

        carro.Velocidade = 259;
        Console.WriteLine($"Velocidade: {carro.Velocidade} km/h");

        carro.Velocidade = 150;
        Console.WriteLine($"Velocidade: {carro.Velocidade} km/h");

        carro.Velocidade = -34;
        Console.WriteLine($"Velocidade: {carro.Velocidade} km/h");
    }
}

*/

// ! Exercicio 4

/*
class Program
{
    static void Main()
    {
        Funcionario funcionario = new Funcionario(3000);

        funcionario.Nome = "João";
        funcionario.Cargo = "Desenvolvedor";

        double percentual = 10;

        funcionario.ConsultarSalario();

        funcionario.AumentarSalario(percentual);

        funcionario.ConsultarSalario();

        // Não da pra alterar o salário diretamente, porque o set é privado e só pode ser acessado dentro da classe Funcionario.

    }
}

*/

// ! Exercicio 5

/*
class Program
{
    static void Main()
    {
        Livro livro1 = new Livro();

        Livro livro2 = new Livro("Como Fazer Amigos e Influenciar Pessoas");

        Livro livro3 = new Livro("O Hobbit", "J.R.R. Tolkien");

        Livro livro4 = new Livro("Harry Potter", "J.K. Rowling", 223);

        livro1.ExibirDados();
        livro2.ExibirDados();
        livro3.ExibirDados();
        livro4.ExibirDados();
    }
}

*/