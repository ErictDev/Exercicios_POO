using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosPOO
{
 
class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int NumeroPaginas { get; set; }

    public Livro()
    {
        Titulo = "Sem título";
        Autor = "Desconhecido";
        NumeroPaginas = 0;
    }

    public Livro(string titulo) : this()
    {
        Titulo = titulo;
    }

    public Livro(string titulo, string autor) : this(titulo)
    {
        Autor = autor;
    }

    public Livro(string titulo, string autor, int paginas) : this(titulo, autor)
    {
        NumeroPaginas = paginas;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"{Titulo} - {Autor} - {NumeroPaginas} páginas");
    }
}
}