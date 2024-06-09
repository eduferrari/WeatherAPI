# Desafio .Net Senior Sistemas

Muito obrigado por reservar um tempo para fazer nosso teste técnico. Ele consiste em 2 partes:
- Um teste técnico (código)
- Algumas perguntas técnicas

Complete ambos e crie um arquivo zip com todo o conteúdo. Pegue este arquivo e dê upload para um local compartilhado como Google Drive, One Drive e nos forneça um link privado de acesso. Caso não seja possível, compartilhe o local com a pessoa responsável da Senior que lhe atribuiu o teste.

Por favor, não divulgue seu teste em outros canais.

O arquivo zip deve ser único, nomeado como `{seu nome}-{nome da vaga}.zip` e deve conter:
- Um arquivo único de markdown com as respostas para as perguntas técnicas
- Um único diretório contendo o teste técnico

## Teste Técnico

Para o teste técnico, deve-se criar uma API (Web App) com as seguintes premissas:
- Um agendamento interno deve acessar a API do OpenWeather (https://openweathermap.org/api) a cada 2 minutos.
- As informações a serem recuperadas da API do OpenWeather são os valores das temperaturas das seguintes capitais: Porto Alegre, Florianópolis e Curitiba.
- Uma vez que os dados forem lidos, estes devem ser armazenados (em memória ou no disco).
- Dentro do Web App, uma API em REST deve ser disponibilizada para a consulta dos dados de temperatura armazenados.
- A API deve permitir a consulta passando os seguintes parâmetros obrigatórios: Nome da(s) cidade(s), Data de Início e Data de Fim.

### Plataforma

- A API deve estar pronta para rodar em qualquer plataforma e em uma máquina com somente .Net instalado, com o comando `dotnet run` e nada mais.
- Pontos extras se entregar o projeto dentro de algum container!
- Pontos extras se entregar o projeto com uma interface para utilizar!

### Requisitos

- O código deve usar C# em um projeto ASP NET ou ASP NET Core.
- Você deve incluir testes de unidade. Tome cuidado com segurança, resiliência e velocidade.
- Tente não incluir artefatos de seu build local (se utilizar build), como por exemplo, as bin, debug ou similar.

### Critérios de Avaliação

- Legibilidade do código entregue, a Senior é aderente da cultura do Clean Code.
- Qualidade dos testes, consideramos esse item fundamental.
- Arquitetura da solução: isolamento das camadas, injeção de dependências etc.

### User Story

Como um usuário consumidor da API, eu posso chamar a API, passando a(s) cidade(s) e um range de datas, então receberei todos os registros de temperatura desse período e das cidades escolhidas.

### Aceite

Para as cidades de Curitiba, Florianópolis e Porto Alegre, as informações de temperatura, junto com a data/hora da coleta, são mostradas. O tempo entre cada coleta é de 2 minutos (aproximadamente).

## Perguntas Técnicas

Por favor, responda estas perguntas em um arquivo markdown chamado `PerguntasTecnicas.md` e coloque dentro do .zip entregue.

1. Quanto tempo você usou para completar a solução apresentada? O que você faria se tivesse mais tempo?
2. Se usou algum framework, qual foi o motivo de ter usado este? Caso contrário, por que não utilizou nenhum?
3. Descreva você mesmo utilizando JSON.

Muito obrigado e boa sorte!
