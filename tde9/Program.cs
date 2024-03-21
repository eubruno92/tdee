// O que é Pascal Case ? Dê um exemplo de sua aplicação

// Pascal Case é uma convenção de nomenclatura usada em programação em que a primeira letra de cada palavra é maiúscula e não há espaços entre as palavras. É comumente usada em várias linguagens de programação e contextos de desenvolvimento de software, especialmente para nomes de classes, métodos e, em alguns casos, variáveis.

// C# usando Pascal Case. Vou mostrar a definição de uma classe chamada Livro, com um construtor e algumas propriedades. Observe como todos os nomes de classes, propriedades e métodos começam com uma letra maiúscula, seguindo a convenção Pascal Case.

using System;

namespace Biblioteca
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }

        public Livro(string titulo, string autor, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacao = anoPublicacao;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Ano de Publicação: {AnoPublicacao}");
        }
    }
}

// Neste exemplo, a classe Livro tem três propriedades: Titulo, Autor, e AnoPublicacao, todas seguindo a convenção Pascal Case. Além disso, o método ExibirInformacoes também segue a mesma convenção. Ao usar Pascal Case consistentemente, o código fica mais organizado e segue um padrão claro, facilitando a leitura e manutenção.


//OBSERVAÇÃO COD TIRADO DO CHAT GPT MAS ANALISEI E VI QUE
//DEVE ESTAR TUDO CORRETO.