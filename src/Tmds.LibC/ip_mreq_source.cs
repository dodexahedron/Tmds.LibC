namespace Tmds.Linux;

public struct ip_mreq_source
{
  public in_addr imr_multiaddr;
  public in_addr imr_interface;
  public in_addr imr_sourceaddr;
}