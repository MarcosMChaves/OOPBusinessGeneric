# OOPBusinessGeneric

## Structures

### Abstract Classes

`ARegister` *extends* `OOPFoundation.AText` : allows creation of different identification numbers, e.g. Employee Number or Student Number

### Interfaces
**NONE**

### Classes

`Address` *uses* `PublicWay`, `AddressNumber`, `Complement`, `Neighborhood`, `County`, `ZIPCode` : encompasses all address data

`AddressNumber` *extends* `OOPFoundation.AText` : specific Public Way number

`Complement` *extends* `OOPFoundation.AText` : address complement information, e.g. Apt ou Block info

`Country` *extends* `OOPFoundation.AText`, *uses* `OOPFoundation.Acronym` : 

`County` *extends* `OOPFoundation.AText`, *uses* `State` : identifies the city of residence for instance

`CNPJ` *extends* `OOPFoundation.AText` : Brazilian business identification number for taxes purposes

`CPF` *extends* `OOPFoundation.AText` : Brazilian individual (person) identification number for taxes purposes

`Neighborhood` *extends* `OOPFoundation.AText` : identifies the neighborhood

`PublicWay` *extends* `OOPFoundation.AText` : identifies Street, Avenue...

`State` *extends* `OOPFoundation.AText`, *uses* `OOPFoundation.Acronym`, `Country` : identifies the state of residence

`ZIPCode` *extends* `OOPFoundation.AText` : identifies the ZIP Code

## UML

![OOPBusinessGeneric UML](UML-OOPBusinessGeneric.png "OOPBusinessGeneric UML")

---
## NOTICE! 

This is a **NuGet** package aimed at teaching Object-Oriented Paradigm **concepts** to a specific group of students. 


Best regards,

Prof. Marcos M. Chaves

CST | TADS