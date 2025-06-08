namespace Tmds.Linux;

public struct sockaddr_in6
{
  public in6_addr    sin6_addr;
  public sa_family_t sin6_family   { get; set; }
  public uint        sin6_flowinfo { get; set; }
  public UInt16   sin6_port     { get; set; }
  public uint        sin6_scope_id { get; set; }
}