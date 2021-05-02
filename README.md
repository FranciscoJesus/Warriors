# Warriors

This is the socialicity technical test done by Francisco Jesus Dominguez Ruiz.

This project implements State, Factory and Smart Enum patterns to resolve the problem of the warriors.

It also implements CI/CD with github Actions in which the project is built, tested and it creates the docker image and push it into dockerhub repository.

# How to run

To run this application you can open the .sln file into Visual Studio 2019 and then execute it.

Also you can pull the docker image and then run it.

``
    docker pull fjdominguez/warrior
    docker run fjdominguez/warrior
``

To run the tests you can execute them in the Visual Studio 2019 or in a cmd in the same path of the .sln file:

``
    dotnet test --verbosity normal
``
