using System.Text;

namespace DotNetMyths.Common;

public static class PotentiallyDangerousOnStackOperations
{
    public static void DoSomethingDirty(StringBuilder output)
    {
        Span<byte> buffer = stackalloc byte[10_000_000];
        
        output.AppendLine($"Buffer length {buffer.Length}");
        output.AppendLine($"Buffer items sum {Sum(in buffer)}");
        
        AddRandomData(buffer);
        output.AppendLine("Added some random values");
        output.AppendLine($"Buffer items sum {Sum(in buffer)}");
    }
    
    private static long Sum(in Span<byte> buffer)
    {
        long value = 0;
        for (int i = 0; i < buffer.Length; i++)
        {
            value += buffer[i];
        }

        return value;
    }

    private static void AddRandomData(in Span<byte> buffer)
    {
        int iterations = Random.Shared.Next(100);
        for (int i = 0; i < iterations; i++)
        {
            int position = Random.Shared.Next(0, buffer.Length - 1);
            byte value = (byte)Random.Shared.Next(0, 255);

            buffer[position] = value;
        }
    }
}