---
name: update-readme-on-feature
description: 'Keep README.md current when adding or changing project features. Use after implementing a user-visible capability, command, workflow, data model, dependency, configuration option, or setup requirement.'
argument-hint: 'Describe the feature that was added or changed.'
---

# Update README on Feature Changes

## Purpose

Keep this project's `README.md` accurate whenever a feature changes how users run, understand, configure, or use the application.

## When to Use

Use this skill after:

- Adding or changing user-visible behavior
- Adding commands, menu options, endpoints, or workflows
- Changing the data model or the way data is created, edited, deleted, or stored
- Adding dependencies, configuration, environment variables, or setup requirements
- Changing project structure or the documented build and run process

Do not update the README for formatting-only changes, internal refactors with no user-visible effect, or generated build output.

## Procedure

1. Identify the feature's user-facing behavior, prerequisites, commands, configuration, and limitations.
2. Read the current `README.md` and locate sections affected by the change.
3. Update the smallest relevant sections. Keep examples executable and descriptions consistent with the implementation.
4. Add a section only when the feature introduces a distinct workflow that users need to discover.
5. Remove or revise statements made obsolete by the feature. Do not leave contradictory descriptions of the application.
6. Preserve the README's existing style and avoid documenting implementation details that users do not need.
7. Run the project's focused validation command, normally `dotnet build --no-restore`, and correct any documentation examples or project issues exposed by the change.

## Quality Checklist

- The README describes the current behavior, not the previous behavior.
- Setup and run instructions work from a clean checkout.
- New commands or menu options include their expected inputs and outcomes.
- Persistence, reset, authentication, and other important limitations are explicit.
- No secrets, machine-specific paths, or generated artifacts are documented.
- The README remains concise and scannable.