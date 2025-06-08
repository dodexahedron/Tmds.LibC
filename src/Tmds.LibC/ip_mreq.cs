namespace Tmds.Linux;

public struct ip_mreq
{
  public in_addr imr_multiaddr;
  public in_addr imr_interface;
}