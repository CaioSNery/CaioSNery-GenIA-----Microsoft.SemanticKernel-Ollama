🧠 Console Chatbot com Semantic Kernel + Ollama

Projeto em .NET usando Semantic Kernel com o provedor local Ollama, permitindo conversar com modelos como Llama 3.1 diretamente no terminal.

🚀 Tecnologias usadas
.NET 9
Semantic Kernel (Microsoft.SemanticKernel)
Ollama como provedor de LLM local
C#
Console Application
Logging com ConsoleLogger

📌 Pré-requisitos
1. Instalar o Ollama

Baixe e instale em:
https://ollama.com/download

2. Baixar o modelo que deseja usar

Exemplo com Llama 3.1:
ollama pull llama3.1
Ou o que você preferir, como mistral, phi3, etc.

3. Pacotes NuGet necessários
dotnet add package Microsoft.SemanticKernel
dotnet add package Microsoft.SemanticKernel.Connectors.Ollama

▶️ Rodando o projeto

Clone o repositório
Instale os pacotes
Garanta que o Ollama está rodando (ollama serve)

Execute:
dotnet run

💬 Como funciona o chatbot

O app inicia um loop no console
Você digita uma mensagem
A mensagem entra no histórico (ChatHistory)
O Semantic Kernel envia tudo para o modelo Ollama
A resposta é mostrada na tela
O histórico é atualizado e a conversa continua
