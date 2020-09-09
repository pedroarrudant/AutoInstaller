# Auto Installer Versão 1.0.0
> Esse software tem a proposta de facilitar a instalação de outros softwares de forma silenciosa, sendo necessário somente informar o link de download, o nome e os argumentos a serem passados para o mesmo.

[![Build Status][travis-image]][travis-url]

Ao selecionar um ou mais softwares da lista o programa automaticamente vai efetuar o download do mesmo e colocar na pasta /Downloads de seu sistema, após isso ele executará o mesmo com a instrução de silence. (comum /s)

![](../header.png)

## Instalação

Windows:

Somente execute o arquivo setup.exe e siga os passos informados.

## Configuração para Desenvolvimento

Todas as depencias se encontram no arquivo de projetos, sendo somente necessario um restore no VS de sua escolha.

## Histórico de lançamentos

* 0.0.1
    * Trabalho em andamento - Criação do MVP

## Meta

Pedro Arruda – [@pedroarrudant](https://twitter.com/pedroarrudant) – pedro.arruda@outlook.com.br

Distribuído sob a licença GNU GPLv3. Veja [LICENSE](./LICENSE.md) para mais informações.

[https://github.com/pedroarrudant](https://github.com/pedroarrudant)

## Contributing

1. Faça o _fork_ do projeto (https://github.com/pedroarrudant/AutoInstaller/fork)
2. Crie uma _branch_ para sua modificação (`git checkout -b feature/fooBar`)
3. Faça o _commit_ (`git commit -am 'Add some fooBar'`)
4. _Push_ (`git push origin feature/fooBar`)
5. Crie um novo _Pull Request_

[travis-image]: https://img.shields.io/travis/dbader/node-datadog-metrics/master.svg?style=flat-square
[travis-url]: https://travis-ci.org/dbader/node-datadog-metrics
[wiki]: https://github.com/seunome/seuprojeto/wiki