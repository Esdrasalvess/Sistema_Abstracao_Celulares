# Sistema de Abstração de Celulares (Desafio DIO)

Este projeto é uma solução para o **Desafio de Orientação a Objetos** da **DIO - Digital Innovation One**. O objetivo é criar um sistema que modele diferentes tipos de celulares (no caso, `iPhone` e `Nokia`) utilizando conceitos de Orientação a Objetos, como herança, polimorfismo e abstração.

O desafio propõe a criação de uma classe abstrata `Smartphone` e classes filhas para representar diferentes marcas de celulares, como `Iphone` e `Nokia`. Cada modelo de celular tem um comportamento específico, como a instalação de aplicativos, que deve ser sobrescrito nas classes filhas.

## Tecnologias Utilizadas

- **C#** (C Sharp)
- **.NET Core**

## Estrutura do Projeto

O projeto contém as seguintes classes:

- **Smartphone**: Classe abstrata que serve como base para os outros tipos de celular. Define os métodos comuns (`Ligar`, `ReceberLigacao`) e um método abstrato `InstalarAplicativo`.
- **Iphone**: Classe que herda de `Smartphone` e implementa o método `InstalarAplicativo` de acordo com o comportamento do iPhone.
- **Nokia**: Classe que herda de `Smartphone` e implementa o método `InstalarAplicativo` de acordo com o comportamento do Nokia.
- **Program**: Classe principal, onde são feitos os testes criando instâncias de `Iphone` e `Nokia` e chamando seus métodos.
