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
    ### Comandos do editor
Selecionando o texto:
Segurar a tela SHIFT e utilizar as SETAS

Comando para comentar:
CTRL + K + C

Comando para desfazer:
CTRL + Z

Comando para refazer:
CTRL + Y

Comando para descomentar:
CTRL + K + U

Comando para abrir o terminal
CTRL + '

### Depurando a aplicação

Ordered

1. Clicar na baratinha e depois no botão engrenagem
2. Selecionar texto '.Net Core'
3. Alterar a opção "console" para "integratedTerminal"
4. Adicionar um breakpoint (clicar na esquerda do número da linha)
5. Adicionar quantos breakpoints quiser (clicar na esquerda do número da linha)
6. Selecionar o Terminal (Sair na tab "Debug Console")
7. F10 vai para a próxima linha
8. F5 para o próximo breakpoint
9. Shift + F5 para "matar" a aplicação
10. CTRl + Shift + F5 para reiniciar o debug

### Blocos condicionais
    // Escrevendo olá SOMENTE quando 1 > 0
    if (1 > 2){
        Console.WriteLine("Olá");
    }
    // Caso 1 NÃO for maior que 0, escreva Boa tarde!
    else if{
        Console.WriteLine("Boa tarde!");
    }
    // Caso NENHUMA das condições anteriores forem verdadeiras, escreva Xau!
    else{
        Console.WriteLine("Xau");
    }

    //Subtrair
    1 - 1;

    // Dividir
    2 / 1;

    // Multiplicar 
    1 * 2;

    // Resto
    3 % 2;
    // vai retornar 1