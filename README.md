# CodingAgent

CodingAgent is an experimental coding agent project. It's currently in an early prototype stage where the agent is focused on programming tasks and writing basic scripts. The longer-term aim is to evolve this agent into a full developer assistant that can help design, implement, test, and maintain software.

## Status

- **Stage:** Prototype — scripting & basic programming
- **Target:** Developer agent capable of end-to-end dev workflows

## Goals

- Grow from simple script automation to advanced developer assistance
- Provide tools for running tasks, invoking commands, and automating workflows
- Learn from usage and integrate testing, CI, and code generation capabilities

## Current Structure

- `Runner/` — agent runner and orchestration
- `Tools/` — helper utilities (DateTimeTools, FileTools, InvokeCommandTools, etc.)
- `Program.cs` and `CodingAgent.csproj` — entry and project file

## Getting Started

Prerequisites: install the .NET SDK matching `net10.0` (for example, .NET 10).

Build and run:

```powershell
dotnet build
dotnet run --project CodingAgent.csproj
```

Explore the `Tools` folder to see example utilities and simple scripts the agent uses while learning to program.

## Contributing

- Open issues for feature requests or bugs.
- Submit PRs that are small and focused; include tests where appropriate.

## Notes

This repository is intentionally lightweight while the agent learns capabilities. Expect rapid iteration and frequent changes.

## Acknowledgements

This project was kickstarted using the guidance from an article on Dev.to: ["Building your first AI Agent in C# with Microsoft Agent Framework" by Matteo Davena](https://dev.to/matteo_davena/building-your-first-ai-agent-in-c-with-microsoft-agent-framework-i33). The techniques and examples there were used to get this agent started.

## License

TBD
