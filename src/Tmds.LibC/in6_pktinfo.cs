namespace Tmds.Linux;

public struct in6_pktinfo
{
  public in6_addr ipi6_addr;
  public uint     ipi6_ifindex { get; set; }
}