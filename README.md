# Exercicios de OO

# Exercicio 01:

### Questão 1: Classe Simples

#### Crie uma classe simples chamada Carro com os seguintes atributos:

- Marca (string): a marca do carro.
- Modelo (string): o modelo do carro.
- Ano (int): o ano de fabricação do carro.
<br><br>

# Exercicio 02

### Questão 2: Classe com Coleção de Objetos

#### Crie uma classe chamada Pessoa que possua uma coleção de objetos da classe Livro. A classe 
#### Pessoa deve conter os seguintes atributos:

- Cpf (string): o cpf da pessoa.
- Nome (string): o nome da pessoa.

#### Livro deve ter os seguintes atributos:
- Titulo (string): o título do livro.
- Autor (string): o autor do livro.

#### A classe pessoa deve possuir um método para receber os livros.

#### No programa principal: Implemente uma rotina que imprima os dados dos livros da pessoa no console.

# Exercicio 03

### Questão 3: Alteração do Construtor da Classe

### Implemente uma classe Estudante com os seguintes atributos:


- Matricula (string):  número de matrícula no sistema de dados acadêmicos
- Nome (string) o nome do estudante
- Idade (int): idade em anos do estudante

### Altere o construtor da classe Estudante para receber a matrícula, o nome e a idade como argumentos

### Implemente um procedimento no programa principal que imprima os dados do objeto Estudante construído.

# Exercicio 04

### Questão 4: Recebendo um Objeto como dependência no Construtor

### Crie uma classe chamada Pedido que recebe um objeto Cliente no construtor e atribui esse objeto a uma propriedade Cliente da classe Pedido.

### Cliente deve conter os seguintes atributos:
- Cpf (string): o cpf da pessoa.
- Nome (string): o nome da pessoa.
Pedido deve conter os seguintes atributos;
- Data (string): data do pedido
- Cliente (Cliente): Cliente que realizou o pedido

## DESAFIO:

### Implemente a classe pedido de forma que os objetos construídos a partir dela contenham o Cliente, o Vendedor e os Produtos relativos a tal pedido.
