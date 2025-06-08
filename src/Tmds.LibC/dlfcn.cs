namespace Tmds.Linux;

using System.Runtime.InteropServices;

public unsafe struct Dl_info
{
  public void* dli_fbase { get; set; }
  public byte* dli_fname { get; set; }
  public void* dli_saddr { get; set; }
  public byte* dli_sname { get; set; }
}

public static unsafe partial class LibC
{
  public const int RTLD_GLOBAL   = 256;
  public const int RTLD_LAZY     = 1;
  public const int RTLD_LOCAL    = 0;
  public const int RTLD_NODELETE = 4096;
  public const int RTLD_NOLOAD   = 4;
  public const int RTLD_NOW      = 2;

  public static readonly void* RTLD_DEFAULT = (void*)0;

  public static readonly void* RTLD_NEXT = (void*)-1;

  [DllImport (libdl)]
  public static extern int dladdr (void* addr, Dl_info* info);

  [DllImport (libdl)]
  public static extern int dlclose (void* handle);

  [DllImport (libdl)]
  public static extern byte* dlerror ();

  [DllImport (libdl)]
  public static extern int dlinfo (void* handle, int request, void* info);

  [DllImport (libdl)]
  public static extern void* dlopen (byte* filename, int flags);

  [DllImport (libdl)]
  public static extern void* dlsym (void* handle, byte* symbol);

  [DllImport (libdl)]
  public static extern void* dlvsym (void* handle, byte* symbol, byte* version);
}
