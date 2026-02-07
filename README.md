# 🔐 HashGenerator

Ei, pessoal! O **HashGenerator** é uma aplicação simples de console que criei em C# para gerar **hashes seguros** de senhas. O foco aqui foi aprender na prática, aplicando conceitos de segurança, organização de código e boas práticas de backend. Nada de armazenar senhas em texto puro – tudo gira em torno de gerar hashes e registrar essas ações em um log básico, tipo uma memória da aplicação.

---

## 🎯 O que o projeto faz

- Gerar hashes de senha de forma segura
- Aplicar boas práticas de segurança com credenciais
- Simular um fluxo de autenticação real
- Organizar o código com Models, Services, Providers e Helpers

---

## 🧠 Conceitos que usei

- Hash de senhas
- Segurança da informação
- Separação de responsabilidades
- Arquitetura em camadas
- Persistência simples em arquivo

---

## ⚙️ Tecnologias

Usei **C# (.NET)** e **BCrypt** para gerar os hashes. Escolhi o BCrypt porque é seguro, usado no mercado e resistente a ataques de força bruta. Configurei o custo de processamento para deixar o hash ainda mais forte.

---

## 🚀 Como funciona

Quando você roda a aplicação, aparece um menu interativo. Daí, você escolhe o que fazer: gerar um novo hash, ver os hashes já criados ou sair.

### Opções do menu

- **Criar hash**: Digite uma senha, e ela vira um hash com BCrypt
- **Visualizar logs**: Mostra todos os hashes gerados, com data e ID
- **Encerrar**: Fecha o programa

---

## 🔐 Como gero o hash

A senha que você informa vai para um objeto `Password`. O `PasswordService` cuida da validação e geração, enquanto o `PasswordProvider` isola a parte criptográfica. No final, você vê um hash seguro. A senha em texto puro só fica na memória durante o processo.

---

## 📝 Sistema de log

Cada hash novo é salvo automaticamente em um log, que é como uma memória da aplicação. Os logs ficam em um arquivo (`Data/log.txt`) e incluem só:

- ID do registro
- Data de criação
- Hash gerado

Nada de senhas em texto puro. Você pode ver esse histórico direto no menu.

---

## 🧱 Estrutura do projeto

Organizei assim:

- **Views**: Para interagir com o usuário (menu e fluxos)
- **Models**: As entidades principais (`Password`, `Log`)
- **Services**: As regras de negócio (`PasswordService`, `LogService`)
- **Providers**: Coisas específicas, como o BCrypt
- **Helpers**: Para ler e validar entradas do usuário

---

## 📚 Ideias para melhorar

- Adicionar validação de senha com hash (tipo login)
- Melhorar o controle dos logs
- Integrar com banco de dados
- Fazer uma interface gráfica ou API
- Tratar erros de forma mais avançada

---

## 👨‍💻 Sobre mim

Desenvolvi isso para estudar C#, segurança e autenticação. É um projeto de aprendizado.

---

## 📄 Licença

Livre para uso educacional e aprendizado.
