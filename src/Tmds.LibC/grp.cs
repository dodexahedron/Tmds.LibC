namespace Tmds.Linux;

using System.Runtime.InteropServices;

#pragma warning disable CS8981

public static unsafe partial class LibC
{
  [DllImport (libc)]
  [SuppressMessage ("ReSharper", "IdentifierTypo")]
  public static extern int getgrnam_r (byte* name, group* grp, byte* buffer, size_t buflen, group** result);
}
