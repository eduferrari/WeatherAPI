# Desafio .Net Senior Sistemas

Muito obrigado por reservar um tempo para fazer nosso teste t�cnico. Ele consiste em 2 partes:
- Um teste t�cnico (c�digo)
- Algumas perguntas t�cnicas

Complete ambos e crie um arquivo zip com todo o conte�do. Pegue este arquivo e d� upload para um local compartilhado como Google Drive, One Drive e nos forne�a um link privado de acesso. Caso n�o seja poss�vel, compartilhe o local com a pessoa respons�vel da Senior que lhe atribuiu o teste.

Por favor, n�o divulgue seu teste em outros canais.

O arquivo zip deve ser �nico, nomeado como `{seu nome}-{nome da vaga}.zip` e deve conter:
- Um arquivo �nico de markdown com as respostas para as perguntas t�cnicas
- Um �nico diret�rio contendo o teste t�cnico

## Teste T�cnico

Para o teste t�cnico, deve-se criar uma API (Web App) com as seguintes premissas:
- Um agendamento interno deve acessar a API do OpenWeather (https://openweathermap.org/api) a cada 2 minutos.
- As informa��es a serem recuperadas da API do OpenWeather s�o os valores das temperaturas das seguintes capitais: Porto Alegre, Florian�polis e Curitiba.
- Uma vez que os dados forem lidos, estes devem ser armazenados (em mem�ria ou no disco).
- Dentro do Web App, uma API em REST deve ser disponibilizada para a consulta dos dados de temperatura armazenados.
- A API deve permitir a consulta passando os seguintes par�metros obrigat�rios: Nome da(s) cidade(s), Data de In�cio e Data de Fim.

### Plataforma

- A API deve estar pronta para rodar em qualquer plataforma e em uma m�quina com somente .Net instalado, com o comando `dotnet run` e nada mais.
- Pontos extras se entregar o projeto dentro de algum container!
- Pontos extras se entregar o projeto com uma interface para utilizar!

### Requisitos

- O c�digo deve usar C# em um projeto ASP NET ou ASP NET Core.
- Voc� deve incluir testes de unidade. Tome cuidado com seguran�a, resili�ncia e velocidade.
- Tente n�o incluir artefatos de seu build local (se utilizar build), como por exemplo, as bin, debug ou similar.

### Crit�rios de Avalia��o

- Legibilidade do c�digo entregue, a Senior � aderente da cultura do Clean Code.
- Qualidade dos testes, consideramos esse item fundamental.
- Arquitetura da solu��o: isolamento das camadas, inje��o de depend�ncias etc.

### User Story

Como um usu�rio consumidor da API, eu posso chamar a API, passando a(s) cidade(s) e um range de datas, ent�o receberei todos os registros de temperatura desse per�odo e das cidades escolhidas.

### Aceite

Para as cidades de Curitiba, Florian�polis e Porto Alegre, as informa��es de temperatura, junto com a data/hora da coleta, s�o mostradas. O tempo entre cada coleta � de 2 minutos (aproximadamente).

## Perguntas T�cnicas

Por favor, responda estas perguntas em um arquivo markdown chamado `PerguntasTecnicas.md` e coloque dentro do .zip entregue.

1. Quanto tempo voc� usou para completar a solu��o apresentada? O que voc� faria se tivesse mais tempo?
2. Se usou algum framework, qual foi o motivo de ter usado este? Caso contr�rio, por que n�o utilizou nenhum?
3. Descreva voc� mesmo utilizando JSON.

Muito obrigado e boa sorte!
