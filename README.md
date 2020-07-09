# Projeto Entra21 8-)

### Escrevendo e lendo do console
    //Escrever
    Console.WriteLine("Quantos anos você tem? ");

    //Ler e salvar o resultado
    var result = Console.ReadLine();

### Tipos básicos
Inline `code`

Indented code

    // Tipo numérico
    var number = 1

    // Tipo texto
    var text = "meu texto"

    // Tipo booleano/bool
    var boolean = true

    // Tipo numérico com ponto flutuante/double
    var price = 4.099

### Parsers / Transformadores
    // Transformar um texto/string em número/int
    var userAge = Int32.Parse(result);

### Operadores de comparação 
#### (toda comparação retorna um booleano/bool)
    // É igual?
    1 == 1;
    // vai retornar true

    //É diferente?
    !(1 == 1);
    // vai retornar false

    //É diferente?
     1 != 1;
    // vai retornar false

    // Booleano da esquerda é true e o da direita também?
     true && true;
    // vai retornar true

    // Booleano da esquerda ou o da direita é true?
     false || false || true;
    // vai retornar true

### Operadores de comparação para números
#### (toda comparação retorna um booleano/bool)
    // É maior?
    1 > 1;
    // vai retornar true

    //É menor?
    1 < 1;
    // vai retornar false

    // É menor ou igual?
    1 <= 1;
    // vai retornar true

### Operadores de matemática
    // Somar
    1 + 1;

    //Subtrair
    1 - 1;

    // Dividir
    2 / 1;

    // Multiplicar 
    1 * 2;

    // Resto
    3 % 2;
    // vai retornar 1