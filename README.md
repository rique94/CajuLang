# 🥭 Caju

**Caju** é uma linguagem de programação compilada, estaticamente tipada e projetada para ser simples, rápida e agradável de usar.

A linguagem busca combinar a **simplicidade de linguagens como Lua** com a **tipagem estática de linguagens como C# e Java**, além de oferecer uma experiência simples para desenvolvimento de APIs e aplicações de backend.

> 🚧 **Caju está em desenvolvimento.**
> A linguagem ainda está em fase inicial e sua sintaxe e arquitetura podem mudar.

## 💡 Proposta

A Caju está sendo desenvolvida com alguns objetivos principais:

* ⚡ Ser rápida e compilada
* 🧠 Ter uma sintaxe simples e fácil de aprender
* 🔒 Possuir tipagem estática
* 🛠️ Facilitar o desenvolvimento de APIs
* 📦 Possuir um ecossistema de bibliotecas simples
* 🇧🇷 Ter uma identidade brasileira

Um exemplo de como a sintaxe poderá ser:

```caju
int idade = 15

if idade >= 18 then
    printL("Maior de idade")
else
    printL("Menor de idade")
end
```

A sintaxe ainda **não está definida definitivamente** e esse código serve apenas como exemplo da direção atual do projeto.

## 🏗️ Arquitetura

A implementação inicial da Caju está sendo desenvolvida em **C#**, que será utilizada como base para construir as primeiras versões da linguagem.

O objetivo final é que a Caju possua sua própria implementação e não dependa do C# ou do .NET para executar programas escritos na linguagem.

A arquitetura planejada inclui:

```text
Código Caju
     ↓
   Lexer
     ↓
   Parser
     ↓
 Compilador
     ↓
 Bytecode / código executável
     ↓
 Runtime da Caju
```

O projeto também pretende futuramente utilizar **bootstrapping**, permitindo que partes da própria Caju sejam implementadas em Caju.

## 🌐 Desenvolvimento Web

Um dos objetivos da Caju é oferecer uma experiência simples para criação de APIs.

A ideia é que exista uma biblioteca ou framework oficial para desenvolvimento web, permitindo algo semelhante à experiência proporcionada pelo Express no ecossistema Node.js.

Exemplo conceitual:

```caju
import web

app = web.create()

app.get("/", function(req, res)
    res.send("Olá, mundo!")
end)

app.listen(3000)
```

Essa API ainda não existe e a sintaxe acima é apenas uma representação da direção planejada para o projeto.

## 📁 Status

**Em desenvolvimento — versão inicial.**

Atualmente o projeto está começando pela implementação da infraestrutura básica da linguagem, incluindo:

* [ ] Leitura de arquivos `.caju`
* [ ] Lexer
* [ ] Tokens
* [ ] Parser
* [ ] AST
* [ ] Compilador
* [ ] Runtime / VM
* [ ] Sistema de tipos
* [ ] Funções
* [ ] Estruturas de controle
* [ ] Biblioteca padrão
* [ ] Suporte para desenvolvimento de APIs
* [ ] Gerenciador de pacotes

## 🎯 Objetivo

O objetivo da Caju não é substituir linguagens como C#, Java, C++ ou Go.

A proposta é criar uma linguagem que seja **simples de escrever, rápida para executar e agradável para desenvolver aplicações**, especialmente APIs e sistemas.

## 📜 Licença

Este projeto está disponível sob a licença **MIT**.

---

🇧🇷 **Caju — uma linguagem brasileira para programar sem complicação.** 🥭
