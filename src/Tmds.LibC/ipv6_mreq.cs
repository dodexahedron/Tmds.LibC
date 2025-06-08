namespace Tmds.Linux;

public struct ipv6_mreq
{
  public in6_addr ipv6mr_multiaddr;
  public uint     ipv6mr_interface { get; set; }
}