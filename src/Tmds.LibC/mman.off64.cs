namespace Tmds.Linux;

using System.Runtime.InteropServices;

public static unsafe partial class LibC
{
  [DllImport (libc, SetLastError = true)]
  public static extern void* mmap (void* addr, size_t length, int prot, int flags, int fd, off_t offset);
}
