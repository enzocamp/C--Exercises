# Resolvendo problema de composição

Este exercício precisava que a apenas a classe Cicle tivesse o atributo Color, e implementasse a função Area(). Enquanto na classe Retangle, implementasse apenas o método Area().

#Resolução

Criação da interface IShape, com o contrato do método Area();

Criação de uma classe abstrata com atributo Color color, e implementando a interface IShape, para que as suas classe filhas possam ter o atributo disponível.

Retangle apenas havia a necessidade da funcao Area, implementando apenas a interace.

#Considerações

A situação de uma classe abstrata implementar uma interface, se por acaso alguma outra classe queira implementar a interface e não utilizar os atributos da classe abstrata, nesse caso apenas implementaria a interface.
