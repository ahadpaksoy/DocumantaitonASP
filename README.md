# asp.net-discover 🛰️🌌

A Simple Calculator App and A menu for a coffee shop.

## Overview

I prepared this project to learn asp.net, for now it is just a simple calculator application.\
[02/07/2024 20.35] I added a menu for a coffee shop that has simulated db. I'll add a real db soon.

## Prerequisites

- [.NET SDK 8](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) (optional, but recommended) or any text editor you love.

## Getting Started

1. **Clone the Repository:**

    ```bash
    git clone https://github.com/ahadpaksoy/asp.net-discover.git
    cd asp.net-discover
    ```

2. **Build and Run:**

    ```bash
    dotnet build
    dotnet run
    ```

3. Open the application in your web browser (you can check your port number in the launchSettings.json).

## Project Structure

├── README.md\
└── DocumantationApp\
    ├── appsettings.Development.json\
    ├── appsettings.json\
    ├── bin\
    │   └── Debug\
    ├── Controllers\
    │   ├── CalculatorController.cs\
    │   └── MenuController.cs\
    ├── Data\
    │   └── MenuData.cs\
    ├── DocumantationApp.csproj\
    ├── Models\
    │   ├── CalculatorModel.cs\
    │   ├── DessertModel.cs\
    │   ├── DrinkModel.cs\
    │   ├── ErrorViewModel.cs\
    │   └── SandwichModel.cs\
    ├── obj\
    │   ├── Debug\
    │   ├── DocumantationApp.csproj.nuget.dgspec.json\
    │   ├── DocumantationApp.csproj.nuget.g.props\
    │   ├── DocumantationApp.csproj.nuget.g.targets\
    │   └── ...\
    ├── Program.cs\
    ├── Properties\
    ├── Views\
    └── wwwroot

