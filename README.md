# 🧠 Chat Console com Semantic Kernel + Plugins + Ollama

Este projeto é um **chat console em .NET** integrado ao **Semantic Kernel** e ao provedor local **Ollama**, permitindo conversas com modelos como **Llama 3.1** diretamente no terminal.  
Além disso, o projeto utiliza **Plugins de IA**, que permitem ao modelo executar funções reais implementadas em C#.

---

## 🚀 Tecnologias Utilizadas

- **.NET 9**
- **C#**
- **Semantic Kernel (Microsoft.SemanticKernel)**
- **Connectors Ollama**
- **Microsoft.Extensions.Logging**
- **Microsoft.Extensions.DependencyInjection**
- **Ollama (modelo local: llama3.1:latest)**

---

## 💬 Funcionamento do Chat

O programa cria um **loop de conversa**, onde:

- o usuário envia uma mensagem pelo console  
- a mensagem é adicionada ao `ChatHistory`  
- o Semantic Kernel envia o histórico e o plugin para o modelo  
- o Ollama gera a resposta  
- o histórico é atualizado novamente

Isso cria uma experiência de chat **contextual**, onde o modelo entende toda a conversa anterior.

---

## 🔄 Uso de Histórico (ChatHistory)

O ChatHistory guarda:

- todas as mensagens do usuário  
- respostas do assistente  
- contexto passado ao modelo  
- chamadas internas do plugin

O modelo sempre recebe o histórico completo, permitindo respostas mais naturais e coerentes.

---

## 🔌 Plugins do Semantic Kernel

O projeto possui um **plugin chamado ProductPlugin, que expõe funções reais para o LLM:

### Funções incluídas:
- **get_product** → retorna todos os produtos  
- **get_state** → altera os dados de um produto específico  

Essas funções são marcadas com:
csharp
[KernelFunction]
Isso permite que o modelo:

descubra automaticamente quais funções existem
interprete parâmetros

execute ações reais dentro da aplicação

retorne resultados processados

Tudo isso usando Function Calling Automático.

🧩 Integração com Semantic Kernel

O Semantic Kernel é responsável por:

gerenciar serviços via DI
registrar plugins
coordenar chamadas do modelo
organizar o ciclo de execução do chat
unificar a experiência com IA no .NET

Ele funciona como o “orquestrador” da sua aplicação GenAI.

🤖 Integração com Ollama
O conector:

Microsoft.SemanticKernel.Connectors.Ollama

permite que o Semantic Kernel converse com modelos locais do Ollama.
Vantagens:

funciona offline
rápido e leve
custo zero
ideal para testes e desenvolvimento local

Modelo utilizado:
llama3.1:latest

✅ Finalidade do Projeto
Este projeto demonstra:

como integrar Semantic Kernel com Ollama
como criar um chat local com histórico
como expor funções reais (plugins) para serem chamadas por uma LLM
como usar Function Calling Automático
como estruturar um agente simples em .NET

Ótimo para estudos, portfólio e para entender a base da GenAI com .NET.
