// Quais as diferenças entre os tipos por valor e os tipos por referência ?

// Em C#, entender a diferença entre tipos por valor (value types) e tipos por referência (reference types) é fundamental para o gerenciamento eficiente da memória e para a criação de aplicações eficazes. Aqui estão as principais diferenças entre os dois:

// 1. **Armazenamento**:
//    - **Tipos por valor**: São armazenados na pilha (stack), o que significa que seus valores são armazenados diretamente na variável. Cada variável tem sua própria cópia dos dados, e não é possível que duas variáveis apontem para o mesmo dado na memória.
//    - **Tipos por referência**: São armazenados no heap, o que significa que a variável armazena um endereço (ou referência) para os dados, em vez dos próprios dados. Várias variáveis podem apontar para o mesmo objeto no heap, o que significa que alterações em um objeto através de uma variável serão refletidas em outra variável que referencia o mesmo objeto.

// 2. **Tipos**:
//    - **Tipos por valor**: Incluem todos os tipos de dados primitivos, como `int`, `double`, `bool`, e `structs` definidos pelo usuário.
//    - **Tipos por referência**: Incluem `string`, arrays, classes e delegates.

// 3. **Comportamento de Passagem de Parâmetros**:
//    - **Tipos por valor**: Quando passados para métodos, uma cópia do valor é passada. Isso significa que alterações feitas ao parâmetro dentro do método não afetarão o valor original fora do método.
//    - **Tipos por referência**: Quando passados para métodos, a referência é passada, então alterações feitas ao objeto dentro do método afetarão o objeto original. 

// 4. **Inicialização**:
//    - **Tipos por valor**: São inicializados com seus valores padrão se não forem explicitamente inicializados. Por exemplo, `int` é inicializado com `0`.
//    - **Tipos por referência**: São inicializados como `null` se não forem explicitamente inicializados, indicando que não estão apontando para nenhum objeto no heap.

// 5. **Cópia**:
//    - **Tipos por valor**: A atribuição de uma variável de tipo por valor a outra cria uma cópia independente do valor.
//    - **Tipos por referência**: A atribuição de uma variável de tipo por referência a outra copia a referência, não o objeto em si, portanto, ambas as variáveis apontam para o mesmo objeto.

// 6. **Coleta de lixo**:
//    - **Tipos por valor**: Como são armazenados na pilha, são removidos da memória assim que saem do escopo.
//    - **Tipos por referência**: São coletados pelo coletor de lixo do .NET quando não existem mais referências a eles, o que pode não ser imediatamente após saírem do escopo.

// Entender essas diferenças é crucial para o desenvolvimento de software em C#, especialmente quando se trata de desempenho e gerenciamento de memória.