# Avaliacao Sigma .NET e SQL Server
 
Este projeto tem como objetivo gerenciar e analisar dados do objeto/entidade Pessoa, com foco na performance, escalabilidade e boa arquitetura de software. 
O projeto se deu como um desafio proposto pela Vite Multisoftware/Sigma.

# Como iniciar o projeto?
O sistema conta com containerização, logo se faz necessário apenas subir para o docker com docker-compose.

# Princípios SOLID no Projeto
S - Single Responsibility Principle (Princípio da Responsabilidade Única)
Cada classe tem uma única responsabilidade, facilitando a manutenção e entendimento do código. Por exemplo, temos uma classe Utilitiess separada para a administração de validações

O - Open/Closed Principle (Princípio Aberto/Fechado)
O sistema foi desenhado para ser facilmente estendido sem a necessidade de modificar o código existente. 

L - Liskov Substitution Principle (Princípio da Substituição de Liskov)
As subclasses podem substituir suas classes base sem afetar a funcionalidade do sistema. 

I - Interface Segregation Principle (Princípio da Segregação de Interfaces)
Interfaces foram desenhadas de maneira específica para os diferentes tipos de operações, evitando que classes implementem métodos que não são necessários para a sua funcionalidade. Isso garante que as classes não sejam sobrecarregadas com métodos irrelevantes.

D - Dependency Inversion Principle (Princípio da Inversão de Dependência)
O projeto segue o padrão Injeção de Dependência (DI), garantindo que as dependências sejam passadas para as classes de forma externa. Isso permite maior flexibilidade e facilita os testes, já que podemos substituir implementações sem modificar a lógica principal.

# Foco em Performance
A performance é um dos pilares do projeto. Algumas das principais considerações para garantir eficiência incluem:

Uso de operações assíncronas: A solução utiliza métodos assíncronos para garantir que a aplicação não se torne bloqueante, especialmente ao recuperar dados ou gerar arquivos KML. Isso é crucial quando lidamos com grandes volumes de dados ou operações de I/O (como leitura/escrita de arquivos).

# Design/Layout
A ideia foi um layout clean apenas para demonstrar as funcionalidades com foco no código gerado.

# Testes 
O sistema foi projeto para suportar diferentes tipos de testes.


