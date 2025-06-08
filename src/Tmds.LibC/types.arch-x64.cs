namespace Tmds.Linux;

public partial struct nlink_t
{
  private nlink_t (ulong value) => Value = value;
  internal ulong Value { get; }
}

public partial struct blksize_t
{
  public blksize_t (long value) => Value = value;
  internal long Value { get; }
}
