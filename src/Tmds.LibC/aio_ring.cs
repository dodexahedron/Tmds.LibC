namespace Tmds.Linux;

public struct aio_ring
{
  public uint id;
  public uint nr;
  public uint head;
  public uint tail;
  public uint magic;
  public uint compat_features;
  public uint incompat_features;
  public uint header_length;

  public static unsafe io_event* io_events (aio_ring* ring, int idx)
  {
    io_event* ev = (io_event*)(ring + 1);

    return ev + idx;
  }
}
