# 🔐 HashGenerator

O **HashGenerator** é um projeto simples, criado com o objetivo de gerar **hashes seguros** a partir de uma senha informada pelo usuário. A ideia do projeto é estudar, na prática, como funciona a proteção de senhas e como elas devem ser tratadas em sistemas reais.

Nada de armazenar senha em texto puro 😉 — aqui o foco é segurança, boas práticas e aprendizado.

---

## 🎯 Objetivo do Projeto

* Gerar um **hash criptográfico** a partir de uma senha
* Entender como funciona o processo de proteção de senhas
* Servir como base para sistemas de **login e autenticação**
* Aplicar conceitos reais usados no mercado

---

## 🧠 Conceitos Trabalhados

* Hash de senhas
* Segurança da informação
* Autenticação de usuários
* Diferença entre senha pura e hash
* Boas práticas no backend

---

## ⚙️ Tecnologias Utilizadas

* **C# (.NET)**
* **BCrypt** para geração de hash de senha

O BCrypt foi escolhido por ser um algoritmo seguro, amplamente utilizado e resistente a ataques de força bruta.

---

## 🚀 Como Funciona

1. O usuário informa uma senha
2. A senha é processada pelo BCrypt
3. O sistema gera e retorna o **hash da senha**
4. Esse hash pode ser armazenado com segurança (ex: banco de dados)

> ⚠️ A senha em texto puro é usada apenas durante a execução e não deve ser armazenada.

---

## 📌 Exemplo de Uso

Senha informada pelo usuário:

```
MinhaSenha123
```

Hash gerado:

```
$2a$11$k8ZyUqzE...
```

---

## 🔒 Boas Práticas

* Nunca armazenar senha em texto puro
* Utilizar algoritmos seguros, como o BCrypt
* Trabalhar sempre com hash + salt
* Evitar algoritmos ultrapassados (MD5, SHA1, etc.)

---

## 📚 Possíveis Evoluções

* Validação de senha (comparar senha digitada com hash)
* Integração com banco de dados
* Implementação de sistema de login
* Criação de API ou interface gráfica
* Registro de logs de autenticação

---

## 👨‍💻 Autor

Projeto desenvolvido para fins de estudo e prática em segurança, autenticação e backend.

---

## 📄 Licença

Uso livre para fins educacionais e aprendizado.
