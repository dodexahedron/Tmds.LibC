namespace Tmds.Linux;

public struct in_pktinfo
{
  public in_addr ipi_spec_dst;
  public in_addr ipi_addr;
  public int     ipi_ifindex { get; set; }
}