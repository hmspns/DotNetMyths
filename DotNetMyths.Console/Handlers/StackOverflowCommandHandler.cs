using System.CommandLine.Invocation;
using System.Text;
using DotNetMyths.Common;

namespace DotNetMyths.Console.Handlers;

public sealed class StackOverflowCommandHandler : ICommandHandler
{
    public int Invoke(InvocationContext context)
    {
        StringBuilder sb = new StringBuilder();
        
        // the line below will throw StackOverflowException 
        PotentiallyDangerousOnStackOperations.DoSomethingDirty(sb);
        
        // this line will be never executed
        System.Console.WriteLine(sb.ToString());
        return 0;
    }

    public async Task<int> InvokeAsync(InvocationContext context)
    {
        throw new NotSupportedException();
    }
}