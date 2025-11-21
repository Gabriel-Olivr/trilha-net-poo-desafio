# Sistema de abstração Smartphone - Programação orientada a objetos


## Desafio de projeto

Neste desafio foi implementado o conceito herança, deste modo evitando redundâncias de codigo para classes diferentes, permitindo uma melhor organização das funcionalidades comuns e eficientes.

### Smartphone.cs (Classe Pai/Abstrata)

- Novas Propriedades: Adicinado Modelo, IMEI e Memoria;

- Construtor Obrigatório: Implementei um construtor que exige os 4 parâmetros (numero, modelo, imei, memoria) na hora de criar o objeto.

### Iphone.cs e Nokia.cs (Classes Filhas)

- Herança: herdam de *: Smartphone*;

- Construtor Repassador: Adicionado construtores que recebem os dados e os repassam para a classe pai usando a palavra-chave : '*base(...)*';

- Sobrescrita (override): O método InstalarAplicativo de forma personalizada (um mostra "App Store", o outro apenas instala), tendo em vista a dispariedade entre um dispositivo antigo já outro atual, assim personalizando cada saída no terminal.


### Program.cs

- Utilizado no *Console.WriteLine* organizei os retornos do terminal para ficar mais agradavel e estruturado

- Implementado as operadores '*new Nokia*' e '*new Iphone*' para assegurar que o telefone so "exista" se todos os constructores estejam elencados.
