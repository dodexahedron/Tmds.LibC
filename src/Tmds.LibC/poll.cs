namespace Tmds.Linux;

using System.Runtime.InteropServices;

public struct pollfd
{
  public short events  { get; set; }
  public int   fd      { get; set; }
  public short revents { get; set; }
}

public static unsafe partial class LibC
{
  [DllImport (libc)]
  public static extern int poll (pollfd* fds, ulong_t nfds, int timeout);

  public static short POLLERR   => 0x008;
  public static short POLLHUP   => 0x010;
  public static short POLLIN    => 0x001;
  public static short POLLMSG   => 0x400;
  public static short POLLNVAL  => 0x020;
  public static short POLLOUT   => 0x004;
  public static short POLLPRI   => 0x002;
  public static short POLLRDHUP => 0x2000;

  [DllImport (libc)]
  public static extern int ppoll (pollfd* fds, ulong_t nfds, timespec* timeout, sigset_t* sigmask);
}
