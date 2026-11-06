using System.Diagnostics.Metrics;

namespace ExerciciosPOO
{
    public class Pessoa
    {
        //int Quantidade; => Campo: é uma forma simplificada de representar atributos
        public string? Nome { get; set; }
        public decimal Idade { get; set; }

        public string? Cidade { get; set; }
        
        public void Apresentar()
        {
            Console.WriteLine($"{Nome} - {Idade} - {Cidade}");
        }
    }
}