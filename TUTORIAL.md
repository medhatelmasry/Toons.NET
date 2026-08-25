# Coding with AI Agent Skills in VS Code
Agent skills are folders of instructions, scripts, and resources that GitHub Copilot can load when relevant to perform specialized tasks.

You can think of agents skills as the micro-services of AI.

Agent skills are an open standard that work across multiple Al agents, including GitHub Copilot and VS Code, Copilot CLI, and Copilot Cloud Agent.

In this tutorail we will develop a very simple C# console application which will be used to reinforce some of the concepts pertaining to coding with AI in VS Code. 

Create a new console app and open it code in VS Code with the following terminal window commands:

```bash
dotnet new console -o Toons.Net
cd Toons.Net
code .
```

Replace contents of `Program.cs` with:

```C#
Toon[] toons = {
    new() {
        ID = 1,
        First = "Barney",
        Last = "Rubble",
        Gender = Gender.Male,
        Occupation = "Mining Assistant"
    },
    new() {
        ID = 2,
        First = "Betty",
        Last = "Rubble",
        Gender = Gender.Female,
        Occupation = "Nurse" },
    new() {
        ID = 3,
        First = "Fred",
        Last = "Flintstone",
        Gender = Gender.Male,
        Occupation = "Mining Manager" },
    new() {
        ID = 4,
        First = "Wilma",
        Last = "Flintstone",
        Gender = Gender.Female,
        Occupation = "Teacher" },
    new() {
        ID = 5,
        First = "Pebbles",
        Last = "Flintstone",
        Gender = Gender.Female,
        Occupation = "Toddler" },
};

foreach (var item in toons) {
    Console.Write($"ID: {item.ID}, ");
    Console.Write($"First: {item.First}, ");
    Console.Write($"Last: {item.Last}, ");
    Console.Write($"Gender: {item.Gender}, ");
    Console.WriteLine($"Occupation: {item.Occupation}");
}

public class Toon {
    public int ID { get; set; }
    public string? First { get; set; }
    public string? Last { get; set; }
    public Gender Gender { get; set; }
    public string? Occupation { get; set; }
}

public enum Gender {
    Male,
    Female
}
```

## Custom Instructions

Custom instructions enable you to define common guidelines and rules that automatically influence how AI generates code and handles other development tasks. Instead of manually including context in every chat prompt, specify custom instructions in a Markdown file to ensure consistent AI responses that align with your coding practices and project requirements.

In a `./github` folder, add a file named `copilot-instructions.md` with this text:

```md
# Please call me Sensei and speak with the calm discipline of a samurai.

## Naming Conventions
- Use PascalCase for component names, interfaces, and type aliases
- Use camelCase for variables, functions, and methods
- Prefix private class members with underscore (_)
- Use ALL_CAPS for constants

# Project-specific guidelines
- Use async/await for asynchronous operations
- When creating sample Toon data, ensure names are diverse and culturally inclusive
- When creating sample Toon data, use Occupations that represent a wide range of disciplines and regions
```

Note this interaction when you prompt the AI chat with “Hello”:

![Sensei](images/sensei.png)

You should put your team coding standards in the copilot-instructions.md file. You may also wish to put this file at a workspace level, rather than a project level.

In folder `./github/skills/hello-world`, add a file named `SKILL.md` with this text:

```md
---
name: hello-world
description: "Use when: you want a simple Hello World response in ASCII text."
---
# Hello World

When invoked, output exactly this line:

 _   _      _ _                             _     _ _
| | | | ___| | | ___    __      _____  _ __| | __| | |
| |_| |/ _ \ | |/ _ \   \ \ /\ / / _ \| '__| |/ _` | |
|  _  |  __/ | | (_) |   \ V  V / (_) | |  | | (_| |_|
|_| |_|\___|_|_|\___( )   \_/\_/ \___/|_|  |_|\__,_(_)
```

> [!NOTE]
> The `name` of the skill must exactly match the folder name.

> [!NOTE]
> It is mandatory to provide `name` and `description`.

Enter the prompt in the chat window:

```txt
add a simple Hello World response in ASCII text to Program.cs
```

It will add this code to `Program.cs`:

```C#
Console.WriteLine("""
 _   _      _ _                             _     _ _
| | | | ___| | | ___    __      _____  _ __| | __| | |
| |_| |/ _ \ | |/ _ \   \ \ /\ / / _ \| '__| |/ _` | |
|  _  |  __/ | | (_) |   \ V  V / (_) | |  | | (_| |_|
|_| |_|\___|_|_|\___( )   \_/\_/ \___/|_|  |_\__,_(_)
                    |/
""");
```

## Prompt files

Prompt files, also known as slash commands, let you simplify prompting for common tasks by encoding them as standalone Markdown files that you can invoke directly in chat. Each prompt file includes task-specific context and guidelines about how the task should be performed.

In folder `./github/prompts`, add a file named `code-review-analyzer.md` with this text:

```md
---
name: Researcher
description: Research codebase patterns and gather context
tools: ['read', 'search']
model: Claude Sonnet 4.5 (copilot)
user-invocable: true
---
Research the existing codebase for relevant files, functions, and patterns.
Return a concise summary of your findings, including links to relevant code sections.
Report on any insights that may help in implementing new features.
```

If you like, you get get AI to write these instructions for you.

Invoke the analyser instructions by entering the `/Researcher` prompt in the chat window.

![Researcher](images/researcher.png)

## Plugins

Agent plugins are prepackaged bundles of agent customizations that you can discover and install from plugin marketplaces in Visual Studio Code. Plugins work alongside your locally defined customizations. When you install a plugin, its supported customizations appear in chat.

A good site to visit to get skills, instructions, plugins, and agents for VS Code is `https://github.com/github/awesome-copilot`. 



