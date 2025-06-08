namespace Tmds.Linux;

public struct iocb
{
  public ulong aio_data;

  // TODO: these fields swap for big endian
  public uint aio_key;
  public int  aio_rw_flags;

  public ushort aio_lio_opcode;
  public short  aio_reqprio;
  public int    aio_fildes;
  public ulong  aio_buf;
  public ulong  aio_nbytes;
  public long   aio_offset;
  public ulong  aio_reserved2;
  public uint   aio_flags;
  public uint   aio_resfd;
}
