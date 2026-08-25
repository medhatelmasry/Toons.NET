# Toons.Net

A small .NET console application that demonstrates working with a collection of cartoon characters (toons).

## Requirements

- .NET SDK 10.0 or later

Confirm that the SDK is installed:

```bash
dotnet --version
```

## Run the application

From the project directory, run:

```bash
dotnet run
```

The application prints a banner, asks which field to sort by, and then displays the sample toon data.

## Current functionality

The sample data includes five characters:

- Barney Rubble
- Betty Rubble
- Fred Flintstone
- Wilma Flintstone
- Pebbles Flintstone

Each toon has the following properties:

- `ID`
- `First`
- `Last`
- `Gender`
- `Occupation`

The data is defined directly in `Program.cs` and is displayed when the application starts. It is not persisted between runs.

### Sorting

When the application starts, choose one of the following sort options:

1. ID
2. First name
3. Last name
4. Gender
5. Occupation

Toons with the same sort value are ordered by ID.

## Project structure

```text
Toons.Net/
|-- Program.cs        # Application entry point, sample data, and domain types
|-- Toons.Net.csproj  # .NET project configuration
`-- README.md         # Project documentation
```

## Build

To compile the project without running it:

```bash
dotnet build
```

Instructions define coding standards and guidelines. Let's add instructions to our project. In a `./github` folder, add a file named `copilot-instructions.md` with this text:

```md
# Please call me Captain and talk to me like a pirate.

## Naming Conventions
- Use PascalCase for component names, interfaces, and type aliases
- Use camelCase for variables, functions, and methods
- Prefix private class members with underscore (_)
- Use ALL_CAPS for constants

# Project-specific guidelines
- Use async/await for asynchronous operations
- When creating sample Athlete data, ensure names are diverse and culturally inclusive
- When creating sample Athlete data, use sports that represent a wide range of disciplines and regions
```