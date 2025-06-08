namespace Tmds.Linux;

using System.Runtime.InteropServices;

public static partial class LibC
{
  public static int errno => Marshal.GetLastWin32Error ();
}
