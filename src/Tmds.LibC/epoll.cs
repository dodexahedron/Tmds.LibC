namespace Tmds.Linux;

using System.Runtime.InteropServices;

public static unsafe partial class LibC
{
  public const int EPOLL_CLOEXEC = O_CLOEXEC;

  public const int EPOLL_CTL_ADD  = 0x1;
  public const int EPOLL_CTL_DEL  = 0x2;
  public const int EPOLL_CTL_MOD  = 0x3;
  public const int EPOLLERR       = 0x008;
  public const int EPOLLET        = -0x80000000;
  public const int EPOLLEXCLUSIVE = 0x10000000;
  public const int EPOLLHUP       = 0x010;

  public const int EPOLLIN      = 0x001;
  public const int EPOLLMSG     = 0x400;
  public const int EPOLLONESHOT = 0x40000000;
  public const int EPOLLOUT     = 0x004;
  public const int EPOLLPRI     = 0x002;
  public const int EPOLLRDBAND  = 0x080;
  public const int EPOLLRDHUP   = 0x2000;
  public const int EPOLLRDNORM  = 0x040;
  public const int EPOLLWAKEUP  = 0x20000000;
  public const int EPOLLWRBAND  = 0x200;
  public const int EPOLLWRNORM  = 0x100;

  [DllImport (libc, SetLastError = true)]
  public static extern int epoll_create (int size);

  [DllImport (libc, SetLastError = true)]
  public static extern int epoll_create1 (int flags);

  [DllImport (libc, SetLastError = true)]
  public static extern int epoll_ctl (int epfd, int op, int fd, epoll_event* ev);

  [DllImport (libc, SetLastError = true)]
  public static extern int epoll_pwait (int epfd, epoll_event* events, int maxevents, int timeout, sigset_t* sigmask);

  [DllImport (libc, SetLastError = true)]
  public static extern int epoll_wait (int epfd, epoll_event* events, int maxevents, int timeout);
}
