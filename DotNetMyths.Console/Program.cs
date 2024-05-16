// See https://aka.ms/new-console-template for more information

using System.CommandLine;
using DotNetMyths.Console.Examples;

RootCommand root = new RootCommand();

Command rebuildCommand = new Command("stack-overflow", $"Break application with {nameof(StackOverflowException)}");
rebuildCommand.Handler = new StackOverflowCommandHandler();
root.Add(rebuildCommand);

Command explicitStructureCommand = new Command("explicit-structure", "Example for structure with explicit fields");
explicitStructureCommand.Handler = new ExplicitStructureCommandHandler();
root.Add(explicitStructureCommand);

return root.Invoke(args);