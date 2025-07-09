# Desafio Backend - LEDS

Candidato: Luiz Henrique Oliveira da Hora

## Tecnologias Utilizadas
- C# 11  
- .NET 9.0

## Como Rodar o Projeto

### Requisitos
- .NET 9.0 SDK instalado

### Executando
1. Clone o repositório:
   ```bash
   git clone https://github.com/LuizHenriqueOlv/Luiz-Henrique-Oliveira-da-Hora---Desafio-Backend-LEDS.git
   
   dotnet build
   dotnet run

2. O programa irá solicitar entrada via console para pegar o:

CPF do candidato, para buscar os concursos relacionados às suas profissões.

Código do concurso, para listar os candidatos compatíveis com as vagas.

# Funcionamento

## Busca de concursos por CPF

Ao informar o CPF, o sistema lista os concursos cujas vagas coincidem com as profissões do candidato.

## Busca de candidatos por concurso

Ao informar o código do concurso, o sistema lista todos os candidatos que possuem as profissões compatíveis com as vagas daquele concurso.

# Estrutura dos arquivos de dados

1. candidatos.txt: arquivo texto contendo os dados dos candidatos no formato:

Nome,Data de Nascimento,CPF,Profissões

2. concursos.txt: arquivo texto contendo os dados dos concursos no formato:

Órgão,Edital,Código do Concurso,Lista de vagas


# Observações
Os arquivos candidatos.txt e concursos.txt devem estar no mesmo diretório da aplicação.