using System.Runtime.InteropServices;

namespace Tmds.Linux;

public static unsafe partial class LibC
{
  [DllImport(libc, SetLastError = true)]
  public static extern int statvfs(byte* path, statvfs* buf);
  [DllImport(libc, SetLastError = true)]
  public static extern int fstatvfs(int fd, statvfs* buf);
}
