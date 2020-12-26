# RestApiWithModelDDD

This application is a simple Web API REST based on Domain Driven Design modeling using the programming language C# with the library .Net Core 3.1 and the frameworks Entity Framework Core 5.1 amd Autofac 6.1.

## 🚀 Index
- ⚙ [Tecnologies and Techniques](#-tecnologies)
- 💻 [How to use](#-how-to-use)

## ⚙ Technologies and Techniques
  - Programming Language C#
  - Visual Studio Code
  - .Net Core 3.1
  - Object-Oriented Programming
  - Domain Driven Design
  - Json
  - Web API
  - SQL Server
  - Entity Framework Core
  - Swagger
  - Autofac
  - Autofac.Extensions.DependencyInjection
  - Model-View-Controller Design
  
## 💻 How to use

> Cloning repository
```bash
  #Cloning repository
  git clone git@github.com:pedrofreitaslima/RestApiWithModelDDD.git
```
> Running Service
```bash
  # Enter in directory Application
  cd '2 - Application'/RestApiModeloDDD.Application
  
  # Clean and Restore solution
  dotnet clean
  dotnet restore
  
  # Build solution
  dotnet build
  
  # Return directory main
  cd ../..
  
  # Enter in Domain
  cd '3 - Domain'
  
  ## Enter solution Domain
  cd RestApiModeloDDD.Domain
  
  ## Clean and Restore solution
  dotnet clean
  dotnet restore
  
  ## Build solution
  dotnet build
  
  ## Return directory Domain
  cd ..
  
  ## Enter solution Core
  cd RestApiModeloDDD.Domain.Core
  
  ## Clean and Restore solution
  dotnet clean
  dotnet restore
  
  ## Build solution
  dotnet build
  
  ## Return directory Domain
  cd ..
  
  ## Enter solution Services
  cd RestApiModeloDDD.Domain.Services
  
  ## Clean and Restore solution
  dotnet clean
  dotnet restore
  
  ## Build solution
  dotnet build
  
  # Return directory main
  cd ../..
  
  # Enter in directory Infrastructure
  cd '4 - Infrastructure'/RestApiModeloDDD.Infrastructure
  
  # Clean and Restore solution
  dotnet clean
  dotnet restore
  
  # Build solution
  dotnet build

  # Return directory main
  cd ../..

  # Enter in directory Services
  cd '1 - Services'/RestApiModeloDDD.Services
  
  # Clean and Restore solution
  dotnet clean
  dotnet restore
  
  # Build solution
  dotnet build
  
  # Running Application
  dotnet run
```
