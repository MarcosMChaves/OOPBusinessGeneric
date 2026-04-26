# OOPBusinessGeneric

## Structures

### Abstract Classes

`APerson` : allows creation of different classes to represent different persons, e.g. Employee or Student 

`ARegister` *extends* `OOPFoundation.AText` : allows creation of different identification numbers, e.g. Employee Number or Student Number

### Interfaces
**NONE**

### Classes

`CNPJ` *extends* `OOPFoundation.AText` : Brazilian **business identification number** for taxes purposes

`CPF` *extends* `OOPFoundation.AText` : Brazilian **individual (person) identification number** for taxes purposes

`Address` : encompasses all address data

- [x] `PublicWay` *extends* `OOPFoundation.AText` : identifies Street, Avenue...

- [x] `AddressNumber` *extends* `OOPFoundation.AText` : specific Public Way number

- [x] `Complement` *extends* `OOPFoundation.AText` : address complement information, e.g. Apt ou Block info

- [x] `Neighborhood` *extends* `OOPFoundation.AText` : identifies the neighborhood of residence for example

- [x] `County` *extends* `OOPFoundation.AText`, *uses* `State` : identifies the city of residence for example

- [x] `ZIPCode` *extends* `OOPFoundation.AText` : identifies the ZIP Code of residence for example

`Country` *extends* `OOPFoundation.AText`, *uses* `OOPFoundation.Acronym` : identifies the country of residence for example

`State` *extends* `OOPFoundation.AText`, *uses* `OOPFoundation.Acronym`, `Country` : identifies the state of residence for example

## UML

![OOPBusinessGeneric UML](UML-OOPBusinessGeneric.png "OOPBusinessGeneric UML")

---
## NOTICE! 

This is a **NuGet** package aimed at teaching Object-Oriented Paradigm **concepts** to a specific group of students. 


Best regards,

Prof. Marcos M. Chaves

CST | TADS