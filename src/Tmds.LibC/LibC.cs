namespace Tmds.Linux;

public static unsafe partial class LibC
{
  public static int io_destroy (aio_context_t ctx)
  {
    int rv = (int)syscall (SYS_io_destroy, ctx.ring);

    return rv;
  }

  public static int io_getevents (aio_context_t ctx, long_t min_nr, long_t nr, io_event* events, timespec* timeout)
  {
    int rv = (int)syscall (SYS_io_getevents, ctx.ring, min_nr, nr, events, timeout);

    return rv;
  }

  public static int io_setup (uint nr_events, aio_context_t* ctx)
  {
    int rv = (int)syscall (SYS_io_setup, nr_events, ctx);

    return rv;
  }

  public static int io_submit (aio_context_t ctx, long_t nr, iocb** iocbpp)
  {
    int rv = (int)syscall (SYS_io_submit, ctx.ring, nr, iocbpp);

    return rv;
  }

  public static ushort IOCB_CMD_FDSYNC  => 3;
  public static ushort IOCB_CMD_FSYNC   => 2;
  public static ushort IOCB_CMD_NOOP    => 6;
  public static ushort IOCB_CMD_PREAD   => 0;
  public static ushort IOCB_CMD_PREADV  => 7;
  public static ushort IOCB_CMD_PWRITE  => 1;
  public static ushort IOCB_CMD_PWRITEV => 8;
}
