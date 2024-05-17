using System.CommandLine.Invocation;
using DotNetMyths.Common;

namespace DotNetMyths.Console.Handlers;

public sealed class ExplicitStructureCommandHandler : ICommandHandler
{
    public int Invoke(InvocationContext context)
    {
        StructWithOverlapping overlapping = new StructWithOverlapping();
        
        System.Console.WriteLine("Clear structure");
        Print(overlapping);
        
        overlapping.b = long.MaxValue;
        
        System.Console.WriteLine("After b = long.MaxValue");
        Print(overlapping);
        
        return 0;
    }

    public async Task<int> InvokeAsync(InvocationContext context)
    {
        throw new NotSupportedException();
    }

    private void Print(StructWithOverlapping overlapping)
    {
        System.Console.WriteLine($"A: {overlapping.a}");
        System.Console.WriteLine($"B: {overlapping.b}");
        System.Console.WriteLine($"C: {overlapping.c}");
    }
}