namespace Tmds.Linux;

using System.Runtime.InteropServices;

[StructLayout (LayoutKind.Explicit, Size = 8)]
public unsafe struct epoll_data_t
{
  [FieldOffset (0)]
  public void* ptr;

  [FieldOffset (0)]
  public int fd;

  [FieldOffset (0)]
  public uint u32;

  [FieldOffset (0)]
  public ulong u64;
}
