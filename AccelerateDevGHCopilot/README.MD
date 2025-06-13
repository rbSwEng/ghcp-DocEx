Collecting workspace information# Library App

## Description
A console-based library management system that handles patrons, books, and loan operations. Built using .NET Core with a layered architecture pattern.

## Project Structure
* AccelerateDevGHCopilot/
  * src/
    * Library.ApplicationCore/
      * Entities/
      * Enums/
      * Interfaces/
      * Services/
    * Library.Console/
      * Json/
      * appSettings.json
      * CommonActions.cs
      * ConsoleApp.cs
      * ConsoleState.cs
      * Program.cs
    * Library.Infrastructure/
      * Data/
  * tests/
    * UnitTests/

## Key Classes and Interfaces

### Application Core
- `Author` - Represents an author in the library system
- `ILoanService` - Manages book loan operations
- `IPatronService` - Handles patron-related operations

### Console Interface
- `ConsoleApp` - Main application class handling user interactions
- `ConsoleState` - Manages application state transitions

### Infrastructure
- Data persistence layer using JSON file storage
- Repository implementations for data access

## Usage

1. Clone the repository
2. Open the solution in Visual Studio Code
3. Restore NuGet packages:
```sh
dotnet restore
```
4. Build the solution:
```sh
dotnet build
```
5. Run the console application:
```sh
dotnet run --project AccelerateDevGHCopilot/src/Library.Console/Library.Console.csproj
```

## License

This project is licensed under the MIT License - see the LICENSE file for details.