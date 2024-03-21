// Quais as diferenças entre os tipos por valor e os tipos por referência ?
// **Sobre o C#
// C# é uma linguagem fortemente tipada. Isso significa que devemos declarar o tipo de uma variável que indica o valor que ela armazenará, como um número int, um float ou decimal, string etc.

// O exemplo de código a seguir declara e inicializa variáveis ​​de diferentes tipos de dados.

// string myString = "Olá, mundo";
// int myInt = 100;
// float myFloat = 10.2f;
// char myChar = 'J';
// bool myBool = true;

// O C# separou os tipos de dados em dois: tipos valor (value types) e tipos referência (reference types). Os tipos de valor incluem tipos simples (por exemplo, int, float, bool e char), enum, struct e Nullable. Os tipos de referência incluem class, interface, delegates e arrays.

// image.png

// Diferença entre um tipo de valor e um tipo de referência
// Um tipo de valor mantém os dados dentro de sua própria alocação de memória e um tipo de referência contém um ponteiro para outro local da memória que mantém os dados reais. As variáveis ​​de tipo de referência são armazenadas na heap, enquanto as variáveis ​​de tipo de valor são armazenadas na stack.

// 1_q-N-mxohDVyk5RK1-HOLHg.webp

// Tipo de valor
// Um tipo valor armazena seu conteúdo na memória alocada na stack. Quando você cria um tipo valor, um único espaço na memória é alocado para armazenar o valor e essa variável mantém diretamente um valor. Se você atribui-lo a outra variável, o valor é copiado diretamente e as duas variáveis ​​funcionam independentemente. datatypes, structs e enum também são tipo valor e funcionam da mesma maneira. Tipo valor podem ser criados em tempo de compilação e Armazenados na stack, por isso, o Garbage collector não pode acessar a pilha.

// por exemplo:
// int x = 5;
// Aqui o valor 5 é armazenado em uma área da memória stack.

// **Stack e Heap
// A stack é usada para alocação de memória estática e heap para alocação de memória dinâmica, ambas armazenadas na RAM do computador.

// As variáveis ​​alocadas na stack são armazenadas diretamente na memória e o acesso a essa memória é muito rápido, e sua alocação é tratada quando o programa é compilado. A stack é sempre reservada em uma ordem LIFO (last-in-first-out), o bloco reservado mais recente é sempre o próximo bloco a ser liberado. Isso torna muito simples acompanhar a stack, liberar um bloco da stack nada mais é do que ajustar um ponteiro.

// As variáveis ​​alocadas no heap têm sua memória alocada em tempo de execução e o acesso a essa memória é um pouco mais lento, mas o tamanho do heap é limitado apenas pelo tamanho da memória virtual. O elemento da heap não tem dependências entre si e sempre pode ser acessado aleatoriamente a qualquer momento. Você pode alocar um bloco a qualquer momento e liberá-lo a qualquer momento. Isso torna muito mais complexo acompanhar quais partes do heap estão alocadas ou livres a qualquer momento.

// 0_TnUKP6qzKR2anAnr.webp

// Você pode usar a stack se souber exatamente a quantidade de dados que precisa alocar antes do tempo de compilação e esse espaço não for muito grande. Você pode usar o heap se não souber exatamente quantos dados precisará no tempo de execução ou se precisar alocar muitos dados.

// Em uma situação multithread, cada thread terá sua própria stack completamente independente, mas eles compartilharão o heap.