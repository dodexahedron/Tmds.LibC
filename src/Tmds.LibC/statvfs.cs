namespace Tmds.Linux;

public static partial class LibC
{
  public static int ST_APPEND      => 256;
  public static int ST_IMMUTABLE   => 512;
  public static int ST_MANDLOCK    => 64;
  public static int ST_NOATIME     => 1024;
  public static int ST_NODEV       => 4;
  public static int ST_NODIRATIME  => 2048;
  public static int ST_NOEXEC      => 8;
  public static int ST_NOSUID      => 2;
  public static int ST_RDONLY      => 1;
  public static int ST_RELATIME    => 4096;
  public static int ST_SYNCHRONOUS => 16;
  public static int ST_WRITE       => 128;
}
