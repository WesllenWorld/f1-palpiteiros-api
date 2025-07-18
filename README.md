# F1Palpiteiros

## Resumo geral
F1 Palpiteiros é um projeto pessoal de palpites de um campeonato com várias etapas. A dinâmica utilizada é baseada no molde atual da contagem de pontos de uma temporada de Formula 1.

Nesta API, os serviços são:

- Login e cadastramento;
- Inserir e alterar palpites, sendo disponível até o prazo limite para cada sessão durante um fim de semana de corrida;
- [Somente ADMIN] Cadastrar etapas e sessões (incluindo Corrida Principal, Corrida Sprint e Classificação);
- [Somente ADMIN] Alterar resultados conforme a necessidade (no caso de uma etapa cancelada, pontuações totais não serem validadas ou pilotos serem desclassificados)
- Visualizar situação atual de campeonato (_standings_);

## História dos palpiteiros

A ideia do projeto saiu de uma brincadeira entre alguns participantes e membros de uma mesma familia que ama Formula 1. Em 2024, foi feita a primeira edição dos palpiteiros, sendo realizada e contabilizada por meio de um grupo de Whatsapp e de planilhas de Excel

## Tecnologias utilizadas

- ASP.NET WEB API;
- SQL SERVER (ou PostgreSQL. Se os parênteses estiverem aqui ainda, eu esqueci de editar);
- Docker (em desenvolvimento);
- React.js para a interface web (repositório em: [url]);
- Hospedagem em: [hospedagem]

