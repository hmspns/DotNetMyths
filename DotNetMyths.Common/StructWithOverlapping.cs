using System.Runtime.InteropServices;

namespace DotNetMyths.Common;

[StructLayout(LayoutKind.Explicit)]
public struct StructWithOverlapping
{
    [FieldOffset(0)]
    public long a;

    [FieldOffset(4)]
    public long b;

    [FieldOffset(8)]
    public long c;
}