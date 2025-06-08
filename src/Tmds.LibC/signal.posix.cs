using System.Runtime.InteropServices;

namespace Tmds.Linux;

public static partial class LibC
{
  [DllImport(libc, SetLastError = true)]
  public static extern int sigpause(int sig);
}
