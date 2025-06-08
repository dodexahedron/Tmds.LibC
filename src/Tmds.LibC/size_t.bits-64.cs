namespace Tmds.Linux;

public partial struct size_t
{
  internal size_t (ulong        arg) => Value = arg;
  internal size_t (uint         arg) => Value = arg;
  internal unsafe size_t (void* arg) => Value = (ulong)arg;
  internal size_t (ssize_t      arg) => Value = (ulong)arg.Value;

  internal uint  ToUInt32 () => (uint)Value;
  internal ulong ToUInt64 () => Value;
  internal ulong Value       { get; }
}

public partial struct ssize_t
{
  internal ssize_t (long arg) => Value = arg;
  internal ssize_t (int  arg) => Value = arg;

  internal int  ToInt32 () => (int)Value;
  internal long ToInt64 () => Value;
  internal long Value      { get; }
}
