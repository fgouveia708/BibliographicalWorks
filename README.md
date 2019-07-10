
# Obras Bibliográficas

Chef's Snacks é uma aplicação demonstrativa que visa mostrar técnicas de arquitetura, desenvolvimento e distribuição de software utilizando ferramentas como .NET Core, Angular 7, Bootstrap, Docker, Nginx e Jenkins.

- [Chef's Snacks](https://github.com/fgouveia708/BibliographicalWorks#chefs-snacks)
    - [Introdução](https://github.com/fgouveia708/BibliographicalWorks#introdu%C3%A7%C3%A3o)
    - [Briefing](https://github.com/fgouveia708/BibliographicalWorks#briefing)
    - [Requisitos técnicos](https://github.com/fgouveia708/BibliographicalWorks#requisitos-t%C3%A9cnicos)

### Introdução

A ideia é criar uma aplicação console que possibilite catalogar e organizar nomes de autores.

### Briefing
                
Quando se lista o nome de autores de livros, artigos e outras publicações é comum que se apresente o nome do autor ou dos autores da seguinte forma: sobrenome do autor em letras maiúsculas, seguido de uma vírgula e da primeira parte do nome apenas com as iniciais maiúsculas.

Por exemplo:
* SILVA, Joao
* COELHO, Paulo
* ARAUJO, Celso de

Seu desafio é fazer um programa que leia um número inteiro correspondendo ao número de nomes que será fornecido, e, a seguir, leia estes nomes (que podem estar em qualquer tipo de letra) e imprima a versão formatada no estilo exemplificado acima.

As seguintes regras devem ser seguidas nesta formatação:
* o sobrenome será igual a última parte do nome e deve ser apresentado em letras maiúsculas;
* se houver apenas uma parte no nome, ela deve ser apresentada em letras maiúsculas (sem vírgula): se a entrada for “ Guimaraes” , a saída deve ser “ GUIMARAES”;
* se a última parte do nome for igual a "FILHO", "FILHA", "NETO", "NETA", "SOBRINHO", "SOBRINHA" ou "JUNIOR" e houver duas ou mais partes antes, a penúltima parte fará parte do sobrenome. Assim: se a entrada for "Joao Silva Neto", a saída deve ser "SILVA NETO, Joao" ; se a entrada for "Joao Neto" , a saída deve ser "NETO, Joao";
* as partes do nome que não fazem parte do sobrenome devem ser impressas com a inicial maiúscula e com as demais letras minúsculas;
* "da", "de", "do", "das", "dos" não fazem parte do sobrenome e não iniciam por letra maiúscula.

### Requisitos técnicos
                
- Visual Studio Code;
- .NET Core;
- xUnit.


