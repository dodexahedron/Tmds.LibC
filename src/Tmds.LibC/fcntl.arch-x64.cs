namespace Tmds.Linux;

public static partial class LibC
{
  public const int F_DUPFD = 0;
  public const int F_GETFD = 1;
  public const int F_GETFL = 3;

  public const int F_GETLK     = 5;
  public const int F_GETOWN    = 9;
  public const int F_GETOWN_EX = 16;

  public const int F_GETOWNER_UIDS = 17;
  public const int F_GETSIG        = 11;
  public const int F_SETFD         = 2;
  public const int F_SETFL         = 4;
  public const int F_SETLK         = 6;
  public const int F_SETLKW        = 7;

  public const int F_SETOWN = 8;

  public const int F_SETOWN_EX = 15;
  public const int F_SETSIG    = 10;
  public const int O_APPEND    = 0x400;

  public const int O_ASYNC     = 0x2000;
  public const int O_CLOEXEC   = 0x80000;
  public const int O_CREAT     = 0x40;
  public const int O_DIRECT    = 0x4000;
  public const int O_DIRECTORY = 0x10000;
  public const int O_DSYNC     = 0x1000;
  public const int O_EXCL      = 0x80;
  public const int O_LARGEFILE = 0;
  public const int O_NDELAY    = O_NONBLOCK;
  public const int O_NOATIME   = 0x40000;
  public const int O_NOCTTY    = 0x100;
  public const int O_NOFOLLOW  = 0x20000;
  public const int O_NONBLOCK  = 0x800;
  public const int O_PATH      = 0x200000;
  public const int O_RSYNC     = 0x101000;
  public const int O_SYNC      = 0x101000;
  public const int O_TMPFILE   = 0x410000;
  public const int O_TRUNC     = 0x200;
}
