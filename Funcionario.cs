using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO
{

class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; private set; }

    public Funcionario(double salario)
    {
        Salario = salario;
    }

    public void AumentarSalario(double percentual)
    {
        Salario += Salario * percentual / 100;
    }

    public void ConsultarSalario()
    {
        Console.WriteLine("Salário atual: R$ " + Salario);
    }
}


}