# ATIVIDADE DA DISCIPLINA DE ALGORÍTMOS E ESTRUTURA DE DADOS

## Descrição

Este projeto foi desenvolvido como atividade acadêmica com base nos requisitos propostos em sala de aula, que incluem:

* Separação do código em arquivo principal (`Program.cs`) e bibliotecas
* Criação de métodos com e sem retorno
* Implementação de pelo menos um método com sobrecarga

O sistema simula um pedido de lanchonete, permitindo ao usuário informar seus dados e visualizar o valor total da compra.

---

## Funcionalidades

O programa permite:

* Informar o nome do cliente
* Inserir o valor do pedido
* Escolher se deseja entrega
* Calcular o valor total (com ou sem taxa de entrega)
* Exibir um resumo do pedido

---

## Estrutura do Projeto

```id="9l2zq1"
/ProjetoLanchonete
 ├── Program.cs
 └── Classes
      └── Pedido.cs
```

* **Program.cs**: responsável pela execução principal do sistema (entrada de dados e controle do fluxo)
* **Pedido.cs**: contém os métodos utilizados no sistema

---

## Implementação dos Requisitos

### ✔ Método com retorno

* `CalcularTotal()` → responsável por retornar o valor total do pedido

### ✔ Método sem retorno (void)

* `ExibirResumo()` → responsável por exibir as informações no console

### ✔ Sobrecarga

* Implementada nos construtores da classe `Pedido`, permitindo criar pedidos:

  * Sem taxa de entrega
  * Com taxa de entrega

---

## Como Executar

1. Abra o projeto em uma IDE compatível com C#
2. Execute o arquivo `Program.cs`
3. Siga as instruções no console

---

## Exemplo de Execução

```id="x3o9o7"
Digite seu nome: Ana
Digite o valor do pedido: 50
Deseja entrega? (s/n): s
Digite a taxa de entrega: 10
```

Saída:

```id="e2k1pz"
===== RESUMO DO PEDIDO =====
Cliente: Ana
Valor do pedido: R$ 50
Taxa de entrega: R$ 10
Total: R$ 60
```

---

## Observação

Além dos requisitos solicitados, o projeto foi organizado de forma estruturada, separando responsabilidades entre os arquivos e mantendo a lógica do sistema isolada da execução principal.

---

## 👩‍💻 Autora

Ana Maria Brito Souza
Estudante de Sistemas de Informação
