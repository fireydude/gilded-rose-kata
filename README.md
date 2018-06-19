# Gilded Rose Kata

## Development Tools
 * [.NET Core 2.0](https://www.microsoft.com/net/learn/get-started) is required to build this project
 * The [dotnet CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/?tabs=netcore2x) was used in combination with VS Code for development so it is compatible with Windows, OSX and Linux based systems.

## Build
Run this command from the route of this repository.

> dotnet build GuildedRose.Inventory/GuildedRose.Inventory.csproj

This will produce a .dll file in the `bin` folder which should be executed with the following command.

> dotnet GuildedRose.Inventory/bin/Debug/netcoreapp2.0/GuildedRose.Inventory.dll input.txt

## Unit Tests / Specs
Run this command from the route of this repository.

> dotnet test GuildedRose.Inventory.Spec/GuildedRose.Inventory.Spec.csproj

You may also need to install the C# extension for [Visual Studio Code](https://code.visualstudio.com/download) in order to run the tests.

## Test Coverage
Produce a coverage report but executing `run-tests.cmd`.  For a better development experience, you can watch for changes by running `run-tests-watcher.cmd`. [This is only](https://www.hanselman.com/blog/AutomaticUnitTestingInNETCorePlusCodeCoverageInVisualStudioCode.aspx) available with the new dotnet SDK (2.1).
### VS Code Extension - Coverage Gutters
This plugin can be used to view coverage, right-click on the file and select Display Coverage from the context menu.