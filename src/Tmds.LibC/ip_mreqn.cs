namespace Tmds.Linux;

public struct ip_mreqn
{
  public in_addr imr_multiaddr;
  public in_addr imr_address;
  public int     imr_ifindex { get; set; }
}