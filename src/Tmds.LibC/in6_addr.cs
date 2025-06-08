namespace Tmds.Linux;

using System.Runtime.InteropServices;

[StructLayout (LayoutKind.Explicit)]
public unsafe struct in6_addr
{
  [FieldOffset (0)]
  public fixed byte s6_addr [16];

  [FieldOffset (0)]
  private uint __align;
}