namespace Tmds.Linux;

public struct ip6_mtuinfo
{
  public sockaddr_in6 ip6m_addr;
  public uint         ip6m_mtu;
}