using System.Runtime.InteropServices;

namespace Tmds.Linux;

public static partial class LibC
{
  public static int errno => Marshal.GetLastWin32Error();
}
