namespace Tmds.Linux;

using System.Runtime.InteropServices;

public static partial class LibC
{
  [DllImport (libc, SetLastError = true)]
  public static extern int sigpause (int sig);
}
