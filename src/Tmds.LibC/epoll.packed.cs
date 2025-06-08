namespace Tmds.Linux;

using System.Runtime.InteropServices;

[StructLayout (LayoutKind.Explicit, Size = 12)]
public struct epoll_event
{
  [FieldOffset (0)]
  public uint events;

  [FieldOffset (4)]
  public epoll_data_t data;
}
