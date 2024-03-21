// O que é um nullable type e qual a sua utilidade ?

// Em C#, um *nullable type* (tipo anulável) é uma funcionalidade que permite a tipos de valor (como int, float, double, etc.), que normalmente não permitem valores nulos, serem atribuídos com um valor nulo. Os tipos de valor são aqueles que são armazenados diretamente na pilha e incluem os tipos primitivos como `int`, `double`, `bool`, etc. Por padrão, esses tipos não podem ser definidos como `null`.

// A utilidade dos nullable types é permitir representar de forma explícita a ausência de um valor para tipos que normalmente exigiriam um. Isso é particularmente útil em bancos de dados e manipulação de dados, onde um campo pode não ter um valor atribuído (por exemplo, uma data de nascimento que não é conhecida). Também é útil em lógicas de programação onde a distinção entre "zero" e "não definido" ou "não aplicável" é importante.

// Para declarar um tipo como nullable em C#, você utiliza o símbolo de interrogação `?` após o tipo de valor. Por exemplo, `int?` declara um tipo `int` que pode ser `null`.

// ```csharp
// int? a = null; // Aqui, a é um int nullable e pode ser atribuído a null
// int b = 5;
// a = b; // a agora tem o valor 5
// ```

// Os nullable types também oferecem propriedades úteis, como `HasValue` e `Value`. `HasValue` é um `bool` que indica se a variável tem algum valor além de `null`. `Value` contém o valor real se `HasValue` for `true`. Tentar acessar `Value` quando `HasValue` é `false` resultará em uma exceção.

// ```csharp
// int? c = null;
// if (c.HasValue)
// {
//     Console.WriteLine(c.Value); // Isso não será executado, pois c é null
// }
// else
// {
//     Console.WriteLine("c é null");
// }
// ```

// Em resumo, os nullable types são uma adição útil à linguagem C# que permite um maior controle e expressividade ao lidar com tipos de valor, especialmente em situações onde a ausência de um valor é uma condição válida e esperada.
