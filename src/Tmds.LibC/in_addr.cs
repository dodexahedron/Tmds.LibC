namespace Tmds.Linux;

using System.Runtime.InteropServices;

[StructLayout (LayoutKind.Explicit)]
public unsafe struct in_addr
{
  [FieldOffset (0)]
  public fixed byte s_addr [4];

  [FieldOffset (0)]
  private UInt32 __align;
}