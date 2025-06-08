namespace Tmds.Linux;

using System.Runtime.InteropServices;

public static unsafe partial class LibC
{
  [DllImport (libc, SetLastError = true)]
  public static extern int fstatvfs (int fd, statvfs* buf);

  [DllImport (libc, SetLastError = true)]
  public static extern int statvfs (byte* path, statvfs* buf);
}
