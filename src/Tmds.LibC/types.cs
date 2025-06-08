namespace Tmds.Linux;

public partial struct size_t : IEquatable<size_t>
{
  public bool Equals (size_t v) => this == v;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is size_t v)
    {
      return this == v;
    }

    return false;
  }

  public override                 int GetHashCode ()                        => Value.GetHashCode ();
  public static                   size_t operator + (size_t  v1, size_t v2) => new (v1.Value + v2.Value);
  public static                   size_t operator & (size_t  v1, size_t v2) => new (v1.Value & v2.Value);
  public static                   size_t operator | (size_t  v1, size_t v2) => new (v1.Value | v2.Value);
  public static                   size_t operator -- (size_t v)             => new (v.Value - 1);
  public static                   size_t operator / (size_t  v1, size_t v2) => new (v1.Value / v2.Value);
  public static                   bool operator == (size_t   v1, size_t v2) => v1.Value == v2.Value;
  public static                   size_t operator ^ (size_t  v1, size_t v2) => new (v1.Value ^ v2.Value);
  public static explicit operator uint (size_t               arg)           => arg.ToUInt32 ();
  public static explicit operator int (size_t                arg)           => (int)arg.Value;
  public static explicit operator size_t (ulong              arg)           => new (arg);
  public static                   bool operator > (size_t    v1, size_t v2) => v1.Value > v2.Value;
  public static                   bool operator >= (size_t   v1, size_t v2) => v1.Value >= v2.Value;
  public static implicit operator ulong (size_t              arg) => arg.ToUInt64 ();

  public static implicit operator size_t (uint arg) => new (arg);

  // .NET uses 'int' mostly to for lengths.
  public static implicit operator size_t (int arg) => new ((uint)arg);

  // disambiguate between uint and int overloads
  public static implicit operator size_t (ushort             arg)           => new ((uint)arg);
  public static                   size_t operator ++ (size_t v)             => new (v.Value + 1);
  public static                   bool operator != (size_t   v1, size_t v2) => v1.Value != v2.Value;
  public static                   size_t operator << (size_t v,  int    i)  => new (v.Value << i);
  public static                   bool operator < (size_t    v1, size_t v2) => v1.Value < v2.Value;
  public static                   bool operator <= (size_t   v1, size_t v2) => v1.Value <= v2.Value;
  public static                   size_t operator % (size_t  v1, size_t v2) => new (v1.Value % v2.Value);
  public static                   size_t operator * (size_t  v1, size_t v2) => new (v1.Value * v2.Value);
  public static                   size_t operator ~ (size_t  v)             => new (~v.Value);
  public static                   size_t operator >> (size_t v,  int    i)  => new (v.Value >> i);
  public static                   size_t operator - (size_t  v1, size_t v2) => new (v1.Value - v2.Value);

  public static size_t operator + (size_t v) => new (v.Value);

  public override string ToString () => Value.ToString ();
}

public partial struct ssize_t : IEquatable<ssize_t>
{
  public bool Equals (ssize_t v) => this == v;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is ssize_t v)
    {
      return this == v;
    }

    return false;
  }

  public override                 int GetHashCode ()                           => Value.GetHashCode ();
  public static                   ssize_t operator + (ssize_t  v1, ssize_t v2) => new (v1.Value + v2.Value);
  public static                   ssize_t operator & (ssize_t  v1, ssize_t v2) => new (v1.Value & v2.Value);
  public static                   ssize_t operator | (ssize_t  v1, ssize_t v2) => new (v1.Value | v2.Value);
  public static                   ssize_t operator -- (ssize_t v)              => new (v.Value - 1);
  public static                   ssize_t operator / (ssize_t  v1, ssize_t v2) => new (v1.Value / v2.Value);
  public static                   bool operator == (ssize_t    v1, ssize_t v2) => v1.Value == v2.Value;
  public static                   ssize_t operator ^ (ssize_t  v1, ssize_t v2) => new (v1.Value ^ v2.Value);
  public static explicit operator int (ssize_t                 arg)            => arg.ToInt32 ();
  public static explicit operator size_t (ssize_t              arg)            => new (arg);
  public static explicit operator ssize_t (long                arg)            => new (arg);
  public static                   bool operator > (ssize_t     v1, ssize_t v2) => v1.Value > v2.Value;
  public static                   bool operator >= (ssize_t    v1, ssize_t v2) => v1.Value >= v2.Value;
  public static implicit operator long (ssize_t                arg) => arg.ToInt64 ();

  public static implicit operator ssize_t (int                 arg)            => new (arg);
  public static                   ssize_t operator ++ (ssize_t v)              => new (v.Value + 1);
  public static                   bool operator != (ssize_t    v1, ssize_t v2) => v1.Value != v2.Value;
  public static                   ssize_t operator << (ssize_t v,  int     i)  => new (v.Value << i);
  public static                   bool operator < (ssize_t     v1, ssize_t v2) => v1.Value < v2.Value;
  public static                   bool operator <= (ssize_t    v1, ssize_t v2) => v1.Value <= v2.Value;
  public static                   ssize_t operator % (ssize_t  v1, ssize_t v2) => new (v1.Value % v2.Value);
  public static                   ssize_t operator * (ssize_t  v1, ssize_t v2) => new (v1.Value * v2.Value);
  public static                   ssize_t operator ~ (ssize_t  v)              => new (~v.Value);
  public static                   ssize_t operator >> (ssize_t v,  int     i)  => new (v.Value >> i);
  public static                   ssize_t operator - (ssize_t  v1, ssize_t v2) => new (v1.Value - v2.Value);
  public static                   ssize_t operator - (ssize_t  v) => new (-v.Value);

  public static ssize_t operator + (ssize_t v) => new (v.Value);

  public override string ToString () => Value.ToString ();
}

public struct syscall_arg
{
  private unsafe syscall_arg (size_t               value) => Value = *(ssize_t*)&value;
  private syscall_arg (ssize_t                     value) => Value = value;
  public static explicit operator int (syscall_arg arg) => (int)arg.Value;

  public static implicit operator syscall_arg (size_t  arg) => new (arg);
  public static implicit operator syscall_arg (ssize_t arg) => new (arg);
  public static implicit operator syscall_arg (long_t  arg) => new (arg.Value);

  public static implicit operator syscall_arg (uint arg) => new (new size_t (arg));
  public static implicit operator syscall_arg (int  arg) => new (new ssize_t (arg));

  public static unsafe implicit operator syscall_arg (void* arg) => new (new size_t (arg));

  public static implicit operator ssize_t (syscall_arg arg) => arg.Value;

  public override string  ToString () => Value.ToString ();
  internal        ssize_t Value       { get; }
}

public struct sa_family_t : IEquatable<sa_family_t>
{
  private sa_family_t (int value) => Value = (ushort)value;

  public bool Equals (sa_family_t v) => this == v;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is sa_family_t v)
    {
      return this == v;
    }

    return false;
  }

  public override int GetHashCode () => Value.GetHashCode ();

  public static bool operator == (sa_family_t v1, sa_family_t v2) => v1.Value == v2.Value;

  public static implicit operator int (sa_family_t              arg)                => arg.Value;
  public static implicit operator sa_family_t (int              arg)                => new (arg);
  public static                   bool operator != (sa_family_t v1, sa_family_t v2) => v1.Value != v2.Value;

  public override string ToString () => Value.ToString ();
  internal        ushort Value       { get; }
}

public struct pid_t : IEquatable<pid_t>
{
  private pid_t (int value) => Value = value;

  public bool Equals (pid_t v) => this == v;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is pid_t v)
    {
      return this == v;
    }

    return false;
  }

  public override int GetHashCode ()                    => Value.GetHashCode ();
  public static   bool operator == (pid_t v1, pid_t v2) => v1.Value == v2.Value;

  public static implicit operator int (pid_t              arg)          => arg.Value;
  public static implicit operator pid_t (int              arg)          => new (arg);
  public static                   bool operator != (pid_t v1, pid_t v2) => v1.Value != v2.Value;

  public static pid_t operator - (pid_t v) => new (-v.Value);

  public override string ToString () => Value.ToString ();
  internal        int    Value       { get; }
}

public struct uid_t : IEquatable<uid_t>
{
  private uid_t (uint value) => Value = value;

  public bool Equals (uid_t v) => this == v;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is uid_t v)
    {
      return this == v;
    }

    return false;
  }

  public override int GetHashCode () => Value.GetHashCode ();

  public static bool operator == (uid_t v1, uid_t v2) => v1.Value == v2.Value;

  public static implicit operator uint (uid_t             arg)          => arg.Value;
  public static implicit operator uid_t (uint             arg)          => new (arg);
  public static                   bool operator != (uid_t v1, uid_t v2) => v1.Value != v2.Value;

  public override string ToString () => Value.ToString ();
  internal        uint   Value       { get; }
}

public struct gid_t : IEquatable<gid_t>
{
  private gid_t (uint value) => Value = value;

  public bool Equals (gid_t v) => this == v;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is gid_t v)
    {
      return this == v;
    }

    return false;
  }

  public override int GetHashCode () => Value.GetHashCode ();

  public static bool operator == (gid_t v1, gid_t v2) => v1.Value == v2.Value;

  public static implicit operator uint (gid_t             arg)          => arg.Value;
  public static implicit operator gid_t (uint             arg)          => new (arg);
  public static                   bool operator != (gid_t v1, gid_t v2) => v1.Value != v2.Value;

  public override string ToString () => Value.ToString ();
  internal        uint   Value       { get; }
}

public struct socklen_t : IEquatable<socklen_t>
{
  private socklen_t (uint value) => Value = value;

  public bool Equals (socklen_t v) => this == v;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is socklen_t v)
    {
      return this == v;
    }

    return false;
  }

  public override                 int GetHashCode ()                                 => Value.GetHashCode ();
  public static                   socklen_t operator + (socklen_t  v1, socklen_t v2) => new (v1.Value + v2.Value);
  public static                   socklen_t operator & (socklen_t  v1, socklen_t v2) => new (v1.Value & v2.Value);
  public static                   socklen_t operator | (socklen_t  v1, socklen_t v2) => new (v1.Value | v2.Value);
  public static                   socklen_t operator -- (socklen_t v)                => new (v.Value - 1);
  public static                   socklen_t operator / (socklen_t  v1, socklen_t v2) => new (v1.Value / v2.Value);
  public static                   bool operator == (socklen_t      v1, socklen_t v2) => v1.Value == v2.Value;
  public static                   socklen_t operator ^ (socklen_t  v1, socklen_t v2) => new (v1.Value ^ v2.Value);
  public static explicit operator int (socklen_t                   arg)              => (int)arg.Value;
  public static                   bool operator > (socklen_t       v1, socklen_t v2) => v1.Value > v2.Value;
  public static                   bool operator >= (socklen_t      v1, socklen_t v2) => v1.Value >= v2.Value;

  public static implicit operator uint (socklen_t arg) => arg.Value;

  public static implicit operator socklen_t (uint arg) => new (arg);

  // .NET uses 'int' mostly to for lengths.
  public static implicit operator socklen_t (int arg) => new ((uint)arg);

  // Make unambiguous implicit int vs uint
  public static implicit operator socklen_t (ushort                arg)              => new (arg);
  public static                   socklen_t operator ++ (socklen_t v)                => new (v.Value + 1);
  public static                   bool operator != (socklen_t      v1, socklen_t v2) => v1.Value != v2.Value;
  public static                   socklen_t operator << (socklen_t v,  int       i)  => new (v.Value << i);
  public static                   bool operator < (socklen_t       v1, socklen_t v2) => v1.Value < v2.Value;
  public static                   bool operator <= (socklen_t      v1, socklen_t v2) => v1.Value <= v2.Value;
  public static                   socklen_t operator % (socklen_t  v1, socklen_t v2) => new (v1.Value % v2.Value);
  public static                   socklen_t operator * (socklen_t  v1, socklen_t v2) => new (v1.Value * v2.Value);
  public static                   socklen_t operator ~ (socklen_t  v)                => new (~v.Value);
  public static                   socklen_t operator >> (socklen_t v,  int       i)  => new (v.Value >> i);
  public static                   socklen_t operator - (socklen_t  v1, socklen_t v2) => new (v1.Value - v2.Value);

  public static socklen_t operator + (socklen_t v) => new (v.Value);

  public override string ToString () => Value.ToString ();
  internal        uint   Value       { get; }
}

public struct time_t : IEquatable<time_t>
{
  internal time_t (long arg) => Value = new (arg);

  // 32-bit values overflow in 2038: https://sourceware.org/glibc/wiki/Y2038ProofnessDesign

  public bool Equals (time_t v) => this == v;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is time_t v)
    {
      return this == v;
    }

    return false;
  }

  public override int GetHashCode ()                        => Value.GetHashCode ();
  public static   time_t operator + (time_t  v1, time_t v2) => new (v1.Value + v2.Value);
  public static   time_t operator & (time_t  v1, time_t v2) => new (v1.Value & v2.Value);
  public static   time_t operator | (time_t  v1, time_t v2) => new (v1.Value | v2.Value);
  public static   time_t operator -- (time_t v)             => new (v.Value - 1);
  public static   time_t operator / (time_t  v1, time_t v2) => new (v1.Value / v2.Value);
  public static   bool operator == (time_t   v1, time_t v2) => v1.Value == v2.Value;
  public static   time_t operator ^ (time_t  v1, time_t v2) => new (v1.Value ^ v2.Value);
  public static   bool operator > (time_t    v1, time_t v2) => v1.Value > v2.Value;
  public static   bool operator >= (time_t   v1, time_t v2) => v1.Value >= v2.Value;

  public static implicit operator long (time_t               arg)           => arg.Value;
  public static implicit operator time_t (long               arg)           => new (arg);
  public static                   time_t operator ++ (time_t v)             => new (v.Value + 1);
  public static                   bool operator != (time_t   v1, time_t v2) => v1.Value != v2.Value;
  public static                   time_t operator << (time_t v,  int    i)  => new (v.Value << i);
  public static                   bool operator < (time_t    v1, time_t v2) => v1.Value < v2.Value;
  public static                   bool operator <= (time_t   v1, time_t v2) => v1.Value <= v2.Value;
  public static                   time_t operator % (time_t  v1, time_t v2) => new (v1.Value % v2.Value);
  public static                   time_t operator * (time_t  v1, time_t v2) => new (v1.Value * v2.Value);
  public static                   time_t operator ~ (time_t  v)             => new (~v.Value);
  public static                   time_t operator >> (time_t v,  int    i)  => new (v.Value >> i);
  public static                   time_t operator - (time_t  v1, time_t v2) => new (v1.Value - v2.Value);
  public static                   time_t operator - (time_t  v) => new (-v.Value);

  public static time_t operator + (time_t v) => new (v.Value);

  public override string  ToString () => Value.ToString ();
  internal        ssize_t Value       { get; }
}

public struct timespec : IEquatable<timespec>
{
  public time_t tv_sec;
  public long_t tv_nsec;

  public bool Equals (timespec v) => this == v;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is timespec v)
    {
      return this == v;
    }

    return false;
  }

  public override int GetHashCode () => tv_sec.GetHashCode () ^ tv_nsec.GetHashCode ();

  public static bool operator == (timespec v1, timespec v2) => v1.tv_sec == v2.tv_sec && v1.tv_nsec == v2.tv_nsec;
  public static bool operator != (timespec v1, timespec v2) => !(v1 == v2);
}

public struct long_t : IEquatable<long_t>
{
  private long_t (ssize_t value) => __value = value;
  internal ssize_t __value;

  public bool Equals (long_t v) => this == v;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is long_t v)
    {
      return this == v;
    }

    return false;
  }

  public override                 int GetHashCode ()                        => Value.GetHashCode ();
  public static                   long_t operator + (long_t  v1, long_t v2) => new (v1.Value + v2.Value);
  public static                   long_t operator & (long_t  v1, long_t v2) => new (v1.Value & v2.Value);
  public static                   long_t operator | (long_t  v1, long_t v2) => new (v1.Value | v2.Value);
  public static                   long_t operator -- (long_t v)             => new (v.Value - 1);
  public static                   long_t operator / (long_t  v1, long_t v2) => new (v1.Value / v2.Value);
  public static                   bool operator == (long_t   v1, long_t v2) => v1.Value == v2.Value;
  public static                   long_t operator ^ (long_t  v1, long_t v2) => new (v1.Value ^ v2.Value);
  public static explicit operator int (long_t                arg) => (int)arg.Value;

  public static explicit operator long_t (long             arg)           => new (new (arg));
  public static                   bool operator > (long_t  v1, long_t v2) => v1.Value > v2.Value;
  public static                   bool operator >= (long_t v1, long_t v2) => v1.Value >= v2.Value;

  public static implicit operator long (long_t               arg)           => arg.Value;
  public static implicit operator long_t (int                arg)           => new (arg);
  public static                   long_t operator ++ (long_t v)             => new (v.Value + 1);
  public static                   bool operator != (long_t   v1, long_t v2) => v1.Value != v2.Value;
  public static                   long_t operator << (long_t v,  int    i)  => new (v.Value << i);
  public static                   bool operator < (long_t    v1, long_t v2) => v1.Value < v2.Value;
  public static                   bool operator <= (long_t   v1, long_t v2) => v1.Value <= v2.Value;
  public static                   long_t operator % (long_t  v1, long_t v2) => new (v1.Value % v2.Value);
  public static                   long_t operator * (long_t  v1, long_t v2) => new (v1.Value * v2.Value);
  public static                   long_t operator ~ (long_t  v)             => new (~v.Value);
  public static                   long_t operator >> (long_t v,  int    i)  => new (v.Value >> i);
  public static                   long_t operator - (long_t  v1, long_t v2) => new (v1.Value - v2.Value);
  public static                   long_t operator - (long_t  v) => new (-v.Value);

  public static long_t operator + (long_t v) => new (v.Value);

  public override string  ToString () => Value.ToString ();
  internal        ssize_t Value       => __value;
}

public struct clock_t : IEquatable<clock_t>
{
  internal clock_t (long arg) => Value = new (arg);

  // 32-bit systems: values could overflow

  public bool Equals (clock_t v) => this == v;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is clock_t v)
    {
      return this == v;
    }

    return false;
  }

  public override int GetHashCode ()                           => Value.GetHashCode ();
  public static   clock_t operator + (clock_t  v1, clock_t v2) => new (v1.Value + v2.Value);
  public static   clock_t operator & (clock_t  v1, clock_t v2) => new (v1.Value & v2.Value);
  public static   clock_t operator | (clock_t  v1, clock_t v2) => new (v1.Value | v2.Value);
  public static   clock_t operator -- (clock_t v)              => new (v.Value - 1);
  public static   clock_t operator / (clock_t  v1, clock_t v2) => new (v1.Value / v2.Value);
  public static   bool operator == (clock_t    v1, clock_t v2) => v1.Value == v2.Value;
  public static   clock_t operator ^ (clock_t  v1, clock_t v2) => new (v1.Value ^ v2.Value);
  public static   bool operator > (clock_t     v1, clock_t v2) => v1.Value > v2.Value;
  public static   bool operator >= (clock_t    v1, clock_t v2) => v1.Value >= v2.Value;

  public static implicit operator long (clock_t                arg)            => arg.Value;
  public static implicit operator clock_t (long                arg)            => new (arg);
  public static                   clock_t operator ++ (clock_t v)              => new (v.Value + 1);
  public static                   bool operator != (clock_t    v1, clock_t v2) => v1.Value != v2.Value;
  public static                   clock_t operator << (clock_t v,  int     i)  => new (v.Value << i);
  public static                   bool operator < (clock_t     v1, clock_t v2) => v1.Value < v2.Value;
  public static                   bool operator <= (clock_t    v1, clock_t v2) => v1.Value <= v2.Value;
  public static                   clock_t operator % (clock_t  v1, clock_t v2) => new (v1.Value % v2.Value);
  public static                   clock_t operator * (clock_t  v1, clock_t v2) => new (v1.Value * v2.Value);
  public static                   clock_t operator ~ (clock_t  v)              => new (~v.Value);
  public static                   clock_t operator >> (clock_t v,  int     i)  => new (v.Value >> i);
  public static                   clock_t operator - (clock_t  v1, clock_t v2) => new (v1.Value - v2.Value);
  public static                   clock_t operator - (clock_t  v) => new (-v.Value);

  public static clock_t operator + (clock_t v) => new (v.Value);

  public override string  ToString () => Value.ToString ();
  internal        ssize_t Value       { get; }
}

public unsafe struct pthread_t : IEquatable<pthread_t>
{
  internal pthread_t (void* arg) => Value = arg;

  public bool Equals (pthread_t v) => this == v;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is pthread_t v)
    {
      return this == v;
    }

    return false;
  }

  public override int GetHashCode () => ((ulong)Value).GetHashCode ();

  public static bool operator == (pthread_t v1, pthread_t v2) => v1.Value == v2.Value;
  public static bool operator != (pthread_t v1, pthread_t v2) => v1.Value != v2.Value;

  public override string ToString () => ((ulong)Value).ToString ();
  internal        void*  Value       { get; }
}

public struct dev_t
{
  private dev_t (ulong value) => Value = value;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is dev_t v)
    {
      return this == v;
    }

    return false;
  }

  public bool Equals (dev_t v) => this == v;

  public override int GetHashCode () => Value.GetHashCode ();

  public static bool operator == (dev_t v1, dev_t v2) => v1.Value == v2.Value;

  public static implicit operator ulong (dev_t            arg)          => arg.Value;
  public static implicit operator dev_t (ulong            arg)          => new (arg);
  public static                   bool operator != (dev_t v1, dev_t v2) => v1.Value != v2.Value;

  public override string ToString () => Value.ToString ();
  internal        ulong  Value       { get; }
}

public struct ino_t
{
  private ino_t (ulong value) => Value = value;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is ino_t v)
    {
      return this == v;
    }

    return false;
  }

  public bool Equals (ino_t v) => this == v;

  public override int GetHashCode () => Value.GetHashCode ();

  public static bool operator == (ino_t v1, ino_t v2) => v1.Value == v2.Value;

  public static implicit operator ulong (ino_t            arg)          => arg.Value;
  public static implicit operator ino_t (ulong            arg)          => new (arg);
  public static                   bool operator != (ino_t v1, ino_t v2) => v1.Value != v2.Value;

  public override string ToString () => Value.ToString ();
  internal        ulong  Value       { get; }
}

public struct blkcnt_t
{
  private blkcnt_t (long value) => Value = value;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is blkcnt_t v)
    {
      return this == v;
    }

    return false;
  }

  public bool Equals (blkcnt_t v) => this == v;

  public override int GetHashCode ()                              => Value.GetHashCode ();
  public static   blkcnt_t operator + (blkcnt_t  v1, blkcnt_t v2) => new (v1.Value + v2.Value);
  public static   blkcnt_t operator & (blkcnt_t  v1, blkcnt_t v2) => new (v1.Value & v2.Value);
  public static   blkcnt_t operator | (blkcnt_t  v1, blkcnt_t v2) => new (v1.Value | v2.Value);
  public static   blkcnt_t operator -- (blkcnt_t v)               => new (v.Value - 1);
  public static   blkcnt_t operator / (blkcnt_t  v1, blkcnt_t v2) => new (v1.Value / v2.Value);
  public static   bool operator == (blkcnt_t     v1, blkcnt_t v2) => v1.Value == v2.Value;
  public static   blkcnt_t operator ^ (blkcnt_t  v1, blkcnt_t v2) => new (v1.Value ^ v2.Value);
  public static   bool operator > (blkcnt_t      v1, blkcnt_t v2) => v1.Value > v2.Value;
  public static   bool operator >= (blkcnt_t     v1, blkcnt_t v2) => v1.Value >= v2.Value;

  public static implicit operator long (blkcnt_t                 arg)             => arg.Value;
  public static implicit operator blkcnt_t (long                 arg)             => new (arg);
  public static                   blkcnt_t operator ++ (blkcnt_t v)               => new (v.Value + 1);
  public static                   bool operator != (blkcnt_t     v1, blkcnt_t v2) => v1.Value != v2.Value;
  public static                   blkcnt_t operator << (blkcnt_t v,  int      i)  => new (v.Value << i);
  public static                   bool operator < (blkcnt_t      v1, blkcnt_t v2) => v1.Value < v2.Value;
  public static                   bool operator <= (blkcnt_t     v1, blkcnt_t v2) => v1.Value <= v2.Value;
  public static                   blkcnt_t operator % (blkcnt_t  v1, blkcnt_t v2) => new (v1.Value % v2.Value);
  public static                   blkcnt_t operator * (blkcnt_t  v1, blkcnt_t v2) => new (v1.Value * v2.Value);
  public static                   blkcnt_t operator ~ (blkcnt_t  v)               => new (~v.Value);
  public static                   blkcnt_t operator >> (blkcnt_t v,  int      i)  => new (v.Value >> i);
  public static                   blkcnt_t operator - (blkcnt_t  v1, blkcnt_t v2) => new (v1.Value - v2.Value);
  public static                   blkcnt_t operator - (blkcnt_t  v) => new (-v.Value);

  public static blkcnt_t operator + (blkcnt_t v) => new (v.Value);

  public override string ToString () => Value.ToString ();
  internal        long   Value       { get; }
}

public partial struct nlink_t
{
  public override bool Equals (object obj)
  {
    if (obj != null && obj is nlink_t v)
    {
      return this == v;
    }

    return false;
  }

  public bool Equals (nlink_t v) => this == v;

  public override                 int GetHashCode ()                           => Value.GetHashCode ();
  public static                   nlink_t operator + (nlink_t  v1, nlink_t v2) => new (v1.Value + v2.Value);
  public static                   nlink_t operator & (nlink_t  v1, nlink_t v2) => new (v1.Value & v2.Value);
  public static                   nlink_t operator | (nlink_t  v1, nlink_t v2) => new (v1.Value | v2.Value);
  public static                   nlink_t operator -- (nlink_t v)              => new (v.Value - 1);
  public static                   nlink_t operator / (nlink_t  v1, nlink_t v2) => new (v1.Value / v2.Value);
  public static                   bool operator == (nlink_t    v1, nlink_t v2) => v1.Value == v2.Value;
  public static                   nlink_t operator ^ (nlink_t  v1, nlink_t v2) => new (v1.Value ^ v2.Value);
  public static                   bool operator > (nlink_t     v1, nlink_t v2) => v1.Value > v2.Value;
  public static                   bool operator >= (nlink_t    v1, nlink_t v2) => v1.Value >= v2.Value;
  public static implicit operator ulong (nlink_t               arg)            => arg.Value;
  public static implicit operator nlink_t (ulong               arg)            => new (arg);
  public static                   nlink_t operator ++ (nlink_t v)              => new (v.Value + 1);
  public static                   bool operator != (nlink_t    v1, nlink_t v2) => v1.Value != v2.Value;
  public static                   nlink_t operator << (nlink_t v,  int     i)  => new (v.Value << i);
  public static                   bool operator < (nlink_t     v1, nlink_t v2) => v1.Value < v2.Value;
  public static                   bool operator <= (nlink_t    v1, nlink_t v2) => v1.Value <= v2.Value;
  public static                   nlink_t operator % (nlink_t  v1, nlink_t v2) => new (v1.Value % v2.Value);
  public static                   nlink_t operator * (nlink_t  v1, nlink_t v2) => new (v1.Value * v2.Value);
  public static                   nlink_t operator ~ (nlink_t  v)              => new (~v.Value);
  public static                   nlink_t operator >> (nlink_t v,  int     i)  => new (v.Value >> i);
  public static                   nlink_t operator - (nlink_t  v1, nlink_t v2) => new (v1.Value - v2.Value);

  public static nlink_t operator + (nlink_t v) => new (v.Value);

  public override string ToString () => Value.ToString ();
}

public partial struct blksize_t
{
  public override bool Equals (object obj)
  {
    if (obj != null && obj is blksize_t v)
    {
      return this == v;
    }

    return false;
  }

  public bool Equals (blksize_t v) => this == v;

  public override                 int GetHashCode ()                                 => Value.GetHashCode ();
  public static                   blksize_t operator + (blksize_t  v1, blksize_t v2) => new (v1.Value + v2.Value);
  public static                   blksize_t operator & (blksize_t  v1, blksize_t v2) => new (v1.Value & v2.Value);
  public static                   blksize_t operator | (blksize_t  v1, blksize_t v2) => new (v1.Value | v2.Value);
  public static                   blksize_t operator -- (blksize_t v)                => new (v.Value - 1);
  public static                   blksize_t operator / (blksize_t  v1, blksize_t v2) => new (v1.Value / v2.Value);
  public static                   bool operator == (blksize_t      v1, blksize_t v2) => v1.Value == v2.Value;
  public static                   blksize_t operator ^ (blksize_t  v1, blksize_t v2) => new (v1.Value ^ v2.Value);
  public static                   bool operator > (blksize_t       v1, blksize_t v2) => v1.Value > v2.Value;
  public static                   bool operator >= (blksize_t      v1, blksize_t v2) => v1.Value >= v2.Value;
  public static implicit operator long (blksize_t                  arg)              => arg.Value;
  public static implicit operator blksize_t (long                  arg)              => new (arg);
  public static                   blksize_t operator ++ (blksize_t v)                => new (v.Value + 1);
  public static                   bool operator != (blksize_t      v1, blksize_t v2) => v1.Value != v2.Value;
  public static                   blksize_t operator << (blksize_t v,  int       i)  => new (v.Value << i);
  public static                   bool operator < (blksize_t       v1, blksize_t v2) => v1.Value < v2.Value;
  public static                   bool operator <= (blksize_t      v1, blksize_t v2) => v1.Value <= v2.Value;
  public static                   blksize_t operator % (blksize_t  v1, blksize_t v2) => new (v1.Value % v2.Value);
  public static                   blksize_t operator * (blksize_t  v1, blksize_t v2) => new (v1.Value * v2.Value);
  public static                   blksize_t operator ~ (blksize_t  v)                => new (~v.Value);
  public static                   blksize_t operator >> (blksize_t v,  int       i)  => new (v.Value >> i);
  public static                   blksize_t operator - (blksize_t  v1, blksize_t v2) => new (v1.Value - v2.Value);
  public static                   blksize_t operator - (blksize_t  v) => new (-v.Value);

  public static blksize_t operator + (blksize_t v) => new (v.Value);

  public override string ToString () => Value.ToString ();
}

public struct ulong_t : IEquatable<ulong_t>
{
  private ulong_t (size_t value) => __value = value;
  internal size_t __value;

  public bool Equals (ulong_t v) => this == v;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is ulong_t v)
    {
      return this == v;
    }

    return false;
  }

  public override                 int GetHashCode ()                           => Value.GetHashCode ();
  public static                   ulong_t operator + (ulong_t  v1, ulong_t v2) => new (v1.Value + v2.Value);
  public static                   ulong_t operator & (ulong_t  v1, ulong_t v2) => new (v1.Value & v2.Value);
  public static                   ulong_t operator | (ulong_t  v1, ulong_t v2) => new (v1.Value | v2.Value);
  public static                   ulong_t operator -- (ulong_t v)              => new (v.Value - 1);
  public static                   ulong_t operator / (ulong_t  v1, ulong_t v2) => new (v1.Value / v2.Value);
  public static                   bool operator == (ulong_t    v1, ulong_t v2) => v1.Value == v2.Value;
  public static                   ulong_t operator ^ (ulong_t  v1, ulong_t v2) => new (v1.Value ^ v2.Value);
  public static explicit operator uint (ulong_t                arg) => (uint)arg.Value;

  public static explicit operator ulong_t (ulong            arg)            => new (new (arg));
  public static                   bool operator > (ulong_t  v1, ulong_t v2) => v1.Value > v2.Value;
  public static                   bool operator >= (ulong_t v1, ulong_t v2) => v1.Value >= v2.Value;

  public static implicit operator ulong (ulong_t               arg)            => arg.Value;
  public static implicit operator ulong_t (uint                arg)            => new (arg);
  public static                   ulong_t operator ++ (ulong_t v)              => new (v.Value + 1);
  public static                   bool operator != (ulong_t    v1, ulong_t v2) => v1.Value != v2.Value;
  public static                   ulong_t operator << (ulong_t v,  int     i)  => new (v.Value << i);
  public static                   bool operator < (ulong_t     v1, ulong_t v2) => v1.Value < v2.Value;
  public static                   bool operator <= (ulong_t    v1, ulong_t v2) => v1.Value <= v2.Value;
  public static                   ulong_t operator % (ulong_t  v1, ulong_t v2) => new (v1.Value % v2.Value);
  public static                   ulong_t operator * (ulong_t  v1, ulong_t v2) => new (v1.Value * v2.Value);
  public static                   ulong_t operator ~ (ulong_t  v)              => new (~v.Value);
  public static                   ulong_t operator >> (ulong_t v,  int     i)  => new (v.Value >> i);
  public static                   ulong_t operator - (ulong_t  v1, ulong_t v2) => new (v1.Value - v2.Value);

  public static ulong_t operator + (ulong_t v) => new (v.Value);

  public override string ToString () => Value.ToString ();
  internal        size_t Value       => __value;
}

public struct fsblkcnt_t
{
  private fsblkcnt_t (ulong value) => Value = value;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is fsblkcnt_t v)
    {
      return this == v;
    }

    return false;
  }

  public bool Equals (fsblkcnt_t v) => this == v;

  public override int GetHashCode ()                                    => Value.GetHashCode ();
  public static   fsblkcnt_t operator + (fsblkcnt_t  v1, fsblkcnt_t v2) => new (v1.Value + v2.Value);
  public static   fsblkcnt_t operator & (fsblkcnt_t  v1, fsblkcnt_t v2) => new (v1.Value & v2.Value);
  public static   fsblkcnt_t operator | (fsblkcnt_t  v1, fsblkcnt_t v2) => new (v1.Value | v2.Value);
  public static   fsblkcnt_t operator -- (fsblkcnt_t v)                 => new (v.Value - 1);
  public static   fsblkcnt_t operator / (fsblkcnt_t  v1, fsblkcnt_t v2) => new (v1.Value / v2.Value);
  public static   bool operator == (fsblkcnt_t       v1, fsblkcnt_t v2) => v1.Value == v2.Value;
  public static   fsblkcnt_t operator ^ (fsblkcnt_t  v1, fsblkcnt_t v2) => new (v1.Value ^ v2.Value);
  public static   bool operator > (fsblkcnt_t        v1, fsblkcnt_t v2) => v1.Value > v2.Value;
  public static   bool operator >= (fsblkcnt_t       v1, fsblkcnt_t v2) => v1.Value >= v2.Value;

  public static implicit operator ulong (fsblkcnt_t                  arg)               => arg.Value;
  public static implicit operator fsblkcnt_t (ulong                  arg)               => new (arg);
  public static                   fsblkcnt_t operator ++ (fsblkcnt_t v)                 => new (v.Value + 1);
  public static                   bool operator != (fsblkcnt_t       v1, fsblkcnt_t v2) => v1.Value != v2.Value;
  public static                   fsblkcnt_t operator << (fsblkcnt_t v,  int        i)  => new (v.Value << i);
  public static                   bool operator < (fsblkcnt_t        v1, fsblkcnt_t v2) => v1.Value < v2.Value;
  public static                   bool operator <= (fsblkcnt_t       v1, fsblkcnt_t v2) => v1.Value <= v2.Value;
  public static                   fsblkcnt_t operator % (fsblkcnt_t  v1, fsblkcnt_t v2) => new (v1.Value % v2.Value);
  public static                   fsblkcnt_t operator * (fsblkcnt_t  v1, fsblkcnt_t v2) => new (v1.Value * v2.Value);
  public static                   fsblkcnt_t operator ~ (fsblkcnt_t  v)                 => new (~v.Value);
  public static                   fsblkcnt_t operator >> (fsblkcnt_t v,  int        i)  => new (v.Value >> i);
  public static                   fsblkcnt_t operator - (fsblkcnt_t  v1, fsblkcnt_t v2) => new (v1.Value - v2.Value);

  public static fsblkcnt_t operator + (fsblkcnt_t v) => new (v.Value);

  public override string ToString () => Value.ToString ();
  internal        ulong  Value       { get; }
}

public struct fsfilcnt_t
{
  private fsfilcnt_t (ulong value) => Value = value;

  public override bool Equals (object obj)
  {
    if (obj != null && obj is fsfilcnt_t v)
    {
      return this == v;
    }

    return false;
  }

  public bool Equals (fsfilcnt_t v) => this == v;

  public override int GetHashCode ()                                    => Value.GetHashCode ();
  public static   fsfilcnt_t operator + (fsfilcnt_t  v1, fsfilcnt_t v2) => new (v1.Value + v2.Value);
  public static   fsfilcnt_t operator & (fsfilcnt_t  v1, fsfilcnt_t v2) => new (v1.Value & v2.Value);
  public static   fsfilcnt_t operator | (fsfilcnt_t  v1, fsfilcnt_t v2) => new (v1.Value | v2.Value);
  public static   fsfilcnt_t operator -- (fsfilcnt_t v)                 => new (v.Value - 1);
  public static   fsfilcnt_t operator / (fsfilcnt_t  v1, fsfilcnt_t v2) => new (v1.Value / v2.Value);
  public static   bool operator == (fsfilcnt_t       v1, fsfilcnt_t v2) => v1.Value == v2.Value;
  public static   fsfilcnt_t operator ^ (fsfilcnt_t  v1, fsfilcnt_t v2) => new (v1.Value ^ v2.Value);
  public static   bool operator > (fsfilcnt_t        v1, fsfilcnt_t v2) => v1.Value > v2.Value;
  public static   bool operator >= (fsfilcnt_t       v1, fsfilcnt_t v2) => v1.Value >= v2.Value;

  public static implicit operator ulong (fsfilcnt_t                  arg)               => arg.Value;
  public static implicit operator fsfilcnt_t (ulong                  arg)               => new (arg);
  public static                   fsfilcnt_t operator ++ (fsfilcnt_t v)                 => new (v.Value + 1);
  public static                   bool operator != (fsfilcnt_t       v1, fsfilcnt_t v2) => v1.Value != v2.Value;
  public static                   fsfilcnt_t operator << (fsfilcnt_t v,  int        i)  => new (v.Value << i);
  public static                   bool operator < (fsfilcnt_t        v1, fsfilcnt_t v2) => v1.Value < v2.Value;
  public static                   bool operator <= (fsfilcnt_t       v1, fsfilcnt_t v2) => v1.Value <= v2.Value;
  public static                   fsfilcnt_t operator % (fsfilcnt_t  v1, fsfilcnt_t v2) => new (v1.Value % v2.Value);
  public static                   fsfilcnt_t operator * (fsfilcnt_t  v1, fsfilcnt_t v2) => new (v1.Value * v2.Value);
  public static                   fsfilcnt_t operator ~ (fsfilcnt_t  v)                 => new (~v.Value);
  public static                   fsfilcnt_t operator >> (fsfilcnt_t v,  int        i)  => new (v.Value >> i);
  public static                   fsfilcnt_t operator - (fsfilcnt_t  v1, fsfilcnt_t v2) => new (v1.Value - v2.Value);

  public static fsfilcnt_t operator + (fsfilcnt_t v) => new (v.Value);

  public override string ToString () => Value.ToString ();
  internal        ulong  Value       { get; }
}
